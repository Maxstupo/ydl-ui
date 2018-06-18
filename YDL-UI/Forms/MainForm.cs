using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maxstupo.YdlUi.Util;
using Maxstupo.CommandBuilder;
using Maxstupo.YdlUi.YoutubeDL;
using System.Xml.Serialization;

namespace Maxstupo.YdlUi.Forms {

    public partial class MainForm : Form {
        private static readonly Color LightRed = ControlPaint.LightLight(Color.Red);

        private static readonly string BIN_FOLDER_NAME = "bin";
        private static readonly string ROOT_DIRECTORY = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        private bool isYoutube;
        private string saveLocation = null;
        private bool needsSave = false;

        private string ffmpegPath;
        private string defaultTitle;

        private ControlListenGroup clg;
        private YoutubeDLApi api;


        public MainForm() {
            InitializeComponent();

        }


        private void CheckVersion() {
            YoutubeDLArguments temp = new YoutubeDLArguments();
            temp.General.Version = true;

            api.ExecuteWithTempArguments(temp, (data, type) => {
                if (type == ProcType.EXITED) {
                    Console.WriteLine("youtube-dl version: '{0}'", data);

                    if (!api.IsCompatibleVersion(data)) {
                        DialogResult dr = MessageBox.Show(this, "Version mismatch between YDL-UI and youtube-dl.\n\nPlease be aware that using YDL-UI with any other version of youtube-dl other than '" + api.Version + "' could result in bugs or broken functionality!", "WARNING: Version Mismatch!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Abort) {
                            Application.Exit();
                        } else if (dr == DialogResult.Retry) {
                            CheckVersion();
                        }
                    }
                }
                return false;
            });
        }



        private void MainForm_Load(object sender, EventArgs e) {
            defaultTitle = Text;
            Application.Idle += Application_Idle;
            this.ResizeBegin += (s, ee) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, ee) => { this.ResumeLayout(true); };
            saveToolStripMenuItem.Enabled = false;

            ffmpegPath = Path.Combine(ROOT_DIRECTORY, BIN_FOLDER_NAME, "ffmpeg.exe");
            api = new YoutubeDLApi(Path.Combine(ROOT_DIRECTORY, BIN_FOLDER_NAME, "youtube-dl.exe"), new YoutubeDLArguments());


            CheckVersion();

            cbxFilesizeMaxUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxFilesizeMaxUnits.SelectedItem = FilesizeUnit.MB;

            cbxFilesizeMinUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxFilesizeMinUnits.SelectedItem = FilesizeUnit.MB;

            cbxLimitRateUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxLimitRateUnits.SelectedItem = FilesizeUnit.MB;

            cbxOutputFormat.DataSource = Enum.GetValues(typeof(MergeVideoFormat));
            cbxOutputFormat.SelectedItem = MergeVideoFormat.MP4;

            cbxRecodeFormat.DataSource = Enum.GetValues(typeof(VideoFormatRecode));
            cbxRecodeFormat.SelectedItem = VideoFormatRecode.MP4;


            clg = ControlListenGroup.New();
            clg.OnChanged += () => {
                needsSave = true;

                string exe = api.Executable;
                string urls = api.Arguments.Url;
                if (urls != null && urls.Split(new string[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
                    api.Arguments.Url = "...urls(s)...";
                api.Executable = "youtube-dl";


                txtCommand.Text = api.BuildCommandString();
                api.Executable = exe;
                api.Arguments.Url = urls;
            };
            CreateBindings(clg);


            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DefaultPresetLocation)) {
                OpenPreset(Properties.Settings.Default.DefaultPresetLocation);
            }
        }

        private void CreateBindings(ControlListenGroup clg) {
            txtUrl.BindValueTo(v => {
                isYoutube = txtUrl.IsValidUrl() && new Uri(v).Host.Contains("youtube.com");
            });

            txtUrl.BindValueTo(v => api.Arguments.Url = v).Listen(clg);
            txtDownloadDirectory.BindValueTo(v => api.Arguments.DownloadDirectory = v);

            cbVqPreferred.BindValueTo(v => api.Arguments.Vq.ResPreferred = v);
            cbVqFallback.BindValueTo(v => api.Arguments.Vq.ResFallback = v);

            cbFpsPreferred.BindValueTo(v => api.Arguments.Vq.FpsPreferred = v);
            cbFpsFallback.BindValueTo(v => api.Arguments.Vq.FpsFallback = v);

            cbCustomFormatSelector.BindValueTo(v => api.Arguments.CustomFormat = v);

            nudVideoQualityWidth.BindEnableTo(rbVqCustom);
            nudVideoQualityHeight.BindEnableTo(rbVqCustom);
            nudFpsCustom.BindEnableTo(rbFpsCustom);

            gbVideoQuality.BindEnableTo(cbs => !cbs[0].Checked, cbCustomFormatSelector);
            gbFrameRate.BindEnableTo(cbs => !cbs[0].Checked, cbCustomFormatSelector);

            #region General

            cbIgnoreErrors.BindValueTo(v => api.Arguments.General.IgnoreErrors = v).Listen(clg);
            cbAbortOnErrors.BindValueTo(v => api.Arguments.General.AbortOnError = v).Listen(clg);
            cbMarkWatched.BindValueTo(v => api.Arguments.General.MarkWatched = isYoutube ? v : false, cbUsernamePassword, clg);

            #endregion

            #region Video Selection
            nudPlaylistStart.BindEnableTo(cbPlaylistStart).BindValueTo(v => api.Arguments.VideoSelection.PlaylistStart = (int?)v, cbPlaylistStart, clg);
            nudPlaylistEnd.BindEnableTo(cbPlaylistEnd).BindValueTo(v => api.Arguments.VideoSelection.PlaylistEnd = (int?)v, cbPlaylistEnd, clg);
            txtPlaylistRange.BindEnableTo(cbPlaylistRange).BindValueTo(v => api.Arguments.VideoSelection.PlaylistItems = v, cbPlaylistRange, clg);
            txtMatchTitle.BindEnableTo(cbMatchTitle).BindValueTo(v => api.Arguments.VideoSelection.MatchTitle = v, cbMatchTitle, clg);
            txtRejectTitle.BindEnableTo(cbRejectTitle).BindValueTo(v => api.Arguments.VideoSelection.RejectTitle = v, cbRejectTitle, clg);
            nudMaxDownloads.BindEnableTo(cbMaxDownloads).BindValueTo(v => api.Arguments.VideoSelection.MaxDownloads = (int?)v, cbMaxDownloads, clg);

            txtMatchFilter.BindEnableTo(cbMatchFilter).BindValueTo(v => api.Arguments.VideoSelection.MatchFilter = v, cbMatchFilter, clg);

            void filesizeMinEvt(float? v) {
                api.Arguments.FilesizeMinUnit = (FilesizeUnit)cbxFilesizeMinUnits.SelectedItem;
                api.Arguments.VideoSelection.MinFilesize = (v == null || v == 0) ? (ByteSize?)null : ByteSize.From(v.Value, (FilesizeUnit)cbxFilesizeMinUnits.SelectedItem);
            }
            cbxFilesizeMinUnits.BindEnableTo(cbFilesizeMin).BindValueTo(obj => filesizeMinEvt(nudFilesizeMin.GetValueFloat(cbFilesizeMin))).Listen(clg);
            nudFilesizeMin.BindEnableTo(cbFilesizeMin).BindValueTo(filesizeMinEvt, cbFilesizeMin, clg);

            void filesizeMaxEvt(float? v) {
                api.Arguments.FilesizeMaxUnit = (FilesizeUnit)cbxFilesizeMaxUnits.SelectedItem;
                api.Arguments.VideoSelection.MaxFilesize = (v == null || v == 0) ? (ByteSize?)null : ByteSize.From(v.Value, (FilesizeUnit)cbxFilesizeMaxUnits.SelectedItem);
            }
            cbxFilesizeMaxUnits.BindEnableTo(cbFilesizeMax).BindValueTo(obj => filesizeMaxEvt(nudFilesizeMax.GetValueFloat(cbFilesizeMax))).Listen(clg);
            nudFilesizeMax.BindEnableTo(cbFilesizeMax).BindValueTo(filesizeMaxEvt, cbFilesizeMax, clg);

            dtpDate.BindEnableTo(cbDate).BindValueTo(v => api.Arguments.VideoSelection.Date = v, cbDate, clg);
            dtpDateAfter.BindEnableTo(cbDateAfter).BindValueTo(v => api.Arguments.VideoSelection.DateAfter = v, cbDateAfter, clg);
            dtpDateBefore.BindEnableTo(cbDateBefore).BindValueTo(v => api.Arguments.VideoSelection.DateBefore = v, cbDateBefore, clg);

            nudViewRangeMin.BindEnableTo(cbMinViews).BindValueTo(v => api.Arguments.VideoSelection.MinViews = (int?)v, cbMinViews, clg);
            nudViewRangeMax.BindEnableTo(cbMaxViews).BindValueTo(v => api.Arguments.VideoSelection.MaxViews = (int?)v, cbMaxViews, clg);

            ////    api.Arguments.VideoSelection.MatchFilter =

            rbPlaylistOnly.BindValueTo(v => api.Arguments.VideoSelection.YesPlaylist = v).Listen(clg);
            rbVideoOnly.BindValueTo(v => api.Arguments.VideoSelection.NoPlaylist = v).Listen(clg);

            nudAgeLimit.BindEnableTo(cbAgeLimit).BindValueTo(v => api.Arguments.VideoSelection.AgeLimit = (int?)v, cbAgeLimit, clg);
            btnBrowseDownloadArchive.BindEnableTo(cbDownloadArchive);
            txtDownloadArchive.BindEnableTo(cbDownloadArchive).BindValueTo(v => {
                api.Arguments.VideoSelection.DownloadArchive = v;
            }, cbDownloadArchive, clg);

            #endregion

            #region Filesystem

            txtFileTemplate.BindEnableTo(cbFileTemplate).BindValueTo(v => { api.Arguments.FileSystem.OutputTemplate = v; }, cbFileTemplate, clg);
            cbRestrictFilenames.BindValueTo(v => api.Arguments.FileSystem.RestrictFilenames = v).Listen(clg);
            cbNoOverwrites.BindValueTo(v => api.Arguments.FileSystem.NoOverwrites = v).Listen(clg);
            cbWriteDescription.BindValueTo(v => api.Arguments.FileSystem.WriteDescription = v).Listen(clg);
            cbWriteAnnotations.BindValueTo(v => api.Arguments.FileSystem.WriteAnnotations = v).Listen(clg);

            #endregion

            #region Network

            txtProxy.BindEnableTo(cbProxy).BindValueTo(v => api.Arguments.Network.Proxy = v, cbProxy, clg);
            txtSourceAddress.BindEnableTo(cbSourceAddress).BindValueTo(v => api.Arguments.Network.SourceAddress = v, cbSourceAddress, clg);
            nudSocketTimeout.BindEnableTo(cbSocketTimeout).BindValueTo(v => api.Arguments.Network.SocketTimeout = (int?)v, cbSocketTimeout, clg);
            rbForceIpv4.BindValueTo(v => api.Arguments.Network.ForceIpv4 = v).Listen(clg);
            rbForceIpv6.BindValueTo(v => api.Arguments.Network.ForceIpv6 = v).Listen(clg);

            #endregion

            #region Download

            void limitRateEvt(float? v) {
                api.Arguments.Download.LimitRate = (v == null || v == 0) ? (ByteSize?)null : ByteSize.From(v.Value, (FilesizeUnit)cbxLimitRateUnits.SelectedItem);
                api.Arguments.LimitRateUnit = (FilesizeUnit)cbxLimitRateUnits.SelectedItem;
            }
            cbxLimitRateUnits.BindEnableTo(cbLimitRate).BindValueTo(obj => limitRateEvt(nudLimitRate.GetValueFloat(cbLimitRate))).Listen(clg);
            nudLimitRate.BindEnableTo(cbLimitRate).BindValueTo(limitRateEvt, cbLimitRate, clg);

            cbRetriesInf.BindEnableTo(cbRetries);
            nudRetries.BindEnableTo(cbs => {
                return cbs[0].Checked && !cbs[1].Checked;
            }, cbRetries, cbRetriesInf).BindValueTo(v => api.Arguments.Download.Retries = (v == null) ? null : v >= 0 ? v.ToString() : "infinite", cbRetries, clg);

            cbFragmentRetriesInf.BindEnableTo(cbFragmentRetries);
            nudFragmentRetries.BindEnableTo(cbs => {
                return cbs[0].Checked && !cbs[1].Checked;
            }, cbFragmentRetries, cbFragmentRetriesInf).BindValueTo(v => api.Arguments.Download.FragmentRetries = (v == null) ? null : v >= 0 ? v.ToString() : "infinite", cbFragmentRetries, clg);

            cbPlaylistRandom.BindValueTo(v => api.Arguments.Download.PlaylistRandom = v).Listen(clg);
            cbPlaylistReversed.BindValueTo(v => api.Arguments.Download.PlaylistReverse = v).Listen(clg);

            #endregion

            cbWriteThumbnail.BindValueTo(v => api.Arguments.Thumbnail.WriteThumbnail = v).Listen(clg);

            #region Workarounds

            txtReferer.BindEnableTo(cbReferer).BindValueTo(v => api.Arguments.Workarounds.Referer = v, cbReferer, clg);
            txtUserAgent.BindEnableTo(cbUserAgent).BindValueTo(v => api.Arguments.Workarounds.UserAgent = v, cbUserAgent, clg);

            dgvHeaders.BindValueTo(v => {
                api.Arguments.Workarounds.Headers.Clear();
                foreach (DataGridViewRow row in v) {
                    string key = row.Cells["cKey"].Value as string;
                    string value = row.Cells["cValue"].Value as string;
                    if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
                        api.Arguments.Workarounds.Headers.Add(key, value);
                }
            }).Listen(clg);

            nudSleepValue.BindEnableTo(rbSleepValue).BindValueTo(v => api.Arguments.Workarounds.SleepInterval = (int?)v, rbSleepValue, clg);
            nudSleepRangeMin.BindEnableTo(rbSleepRange).BindValueTo(v => api.Arguments.Workarounds.MinSleepInterval = (int?)v, rbSleepRange, clg);
            nudSleepRangeMax.BindEnableTo(rbSleepRange).BindValueTo(v => api.Arguments.Workarounds.MaxSleepInterval = (int?)v, rbSleepRange, clg);

            #endregion

            #region Auth

            string user = null, pass = null;
            txtPassword.BindEnableTo(cbUsernamePassword).BindValueTo(v => api.Arguments.Authentication.Password = v, cbUsernamePassword, clg);
            txtPassword.BindValueTo(v => {
                pass = v;
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass)) {
                    api.Arguments.Authentication.Username = null;
                    api.Arguments.Authentication.Password = null;
                } else {
                    api.Arguments.Authentication.Username = user;
                    api.Arguments.Authentication.Password = pass;
                }
                clg.Trigger();
            }, cbUsernamePassword);
            txtUsername.BindEnableTo(cbUsernamePassword).BindValueTo(v => {
                user = v;
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass)) {
                    api.Arguments.Authentication.Username = null;
                    api.Arguments.Authentication.Password = null;
                } else {
                    api.Arguments.Authentication.Username = user;
                    api.Arguments.Authentication.Password = pass;
                }
                clg.Trigger();
            }, cbUsernamePassword, clg);
            txtTwoFactor.BindEnableTo(cbTwoFactor).BindValueTo(v => api.Arguments.Authentication.TwoFactor = v, cbTwoFactor, clg);
            txtVideoPassword.BindEnableTo(cbVideoPassword).BindValueTo(v => api.Arguments.Authentication.VideoPassword = v, cbVideoPassword, clg);

            #endregion

            #region Post Processing

            cbxRecodeFormat.BindEnableTo(cbRecodeFormat).BindValueTo(v => api.Arguments.PostProcessing.RecodeVideo = (VideoFormatRecode?)v, cbRecodeFormat, clg);

            #endregion

            #region Video Format

            ControlListenGroup formatGroup = ControlListenGroup.New();
            txtCustomFormatSelector.BindEnableTo(cbCustomFormatSelector).BindValueTo(v => api.Arguments.VideoFormat.Format = v, cbCustomFormatSelector, formatGroup);

            cbxOutputFormat.BindEnableTo(cbOutputFormat).BindValueTo(v => api.Arguments.VideoFormat.MergeOutputFormat = (v == null) ? null : (MergeVideoFormat?)v, cbOutputFormat, clg);

            formatGroup.Listen(rbVq2160p, rbVq1440p, rbVq1080p, rbVq720p, rbVq480p, rbVq360p, rbVq240p, rbVqCustom, rbFps144, rbFps120, rbFps60, rbFps30, rbFps25, rbFpsCustom);
            formatGroup.Listen(cbVqPreferred, cbFpsPreferred, cbVqFallback, cbFpsFallback);
            formatGroup.Listen(nudFpsCustom, nudVideoQualityWidth, nudVideoQualityHeight);

            formatGroup.OnChanged += () => {
                if (!cbCustomFormatSelector.Checked)
                    api.Arguments.VideoFormat.Format = GetVideoQuality().FormatSelector;

                VideoQuality vq = GetVideoQuality();
                if (!rbVqCustom.Checked) {
                    nudVideoQualityWidth.Value = vq.Width;
                    nudVideoQualityHeight.Value = vq.Height;
                }
                if (!rbFpsCustom.Checked)
                    nudFpsCustom.Value = vq.Fps;

                if (!cbCustomFormatSelector.Checked)
                    txtCustomFormatSelector.Text = vq.FormatSelector;

                clg.Trigger();
            };
            formatGroup.Trigger();


            #endregion



        }
        
        private void Application_Idle(object sender, EventArgs e) {
            txtUrl.BackColor = txtUrl.IsValidUrl() ? Color.LightGreen : LightRed;
            txtDownloadDirectory.BackColor = txtDownloadDirectory.ExistsDirectory() ? Color.LightGreen : LightRed;
            btnStartDownload.Enabled = txtUrl.IsValidUrl();

            if (cbRetriesInf.Checked) {
                nudRetries.Minimum = -1;
                nudRetries.Value = -1;
            } else {
                nudRetries.Minimum = 0;
            }

            if (cbFragmentRetriesInf.Checked) {
                nudFragmentRetries.Minimum = -1;
                nudFragmentRetries.Value = -1;
            } else {
                nudFragmentRetries.Minimum = 0;
            }

            cbMarkWatched.Enabled = isYoutube && cbUsernamePassword.Checked;

        }

        private VideoQuality GetVideoQuality() {
            int width = 0, height = 0, fps = 0;
            bool resPreferred = cbVqPreferred.Checked;
            bool resFallback = cbVqFallback.Checked;
            bool fpsPreferred = cbFpsPreferred.Checked;
            bool fpsFallback = cbFpsFallback.Checked;

            if (rbVq2160p.Checked) {
                width = 3840; height = 2160;
            } else if (rbVq1440p.Checked) {
                width = 2560; height = 1440;
            } else if (rbVq1080p.Checked) {
                width = 1920; height = 1080;
            } else if (rbVq720p.Checked) {
                width = 1280; height = 720;
            } else if (rbVq480p.Checked) {
                width = 854; height = 480;
            } else if (rbVq360p.Checked) {
                width = 640; height = 360;
            } else if (rbVq240p.Checked) {
                width = 426; height = 240;
            } else if (rbVqCustom.Checked) {
                width = nudVideoQualityWidth.GetValueInt(null).Value;
                height = nudVideoQualityHeight.GetValueInt(null).Value;
            }

            if (rbFps144.Checked) {
                fps = 144;
            } else if (rbFps120.Checked) {
                fps = 120;
            } else if (rbFps60.Checked) {
                fps = 60;
            } else if (rbFps30.Checked) {
                fps = 30;
            } else if (rbFps25.Checked) {
                fps = 25;
            } else if (rbFpsCustom.Checked) {
                fps = nudFpsCustom.GetValueInt(null).Value;
            }
            VideoQuality vq = new VideoQuality(width, height, fps, resPreferred, resFallback, fpsPreferred, fpsFallback);
            api.Arguments.Vq = vq;
            return vq;
        }

        #region Drag & Drop

        private void MainForm_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Link;

        }

        private void MainForm_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                string url = (string)e.Data.GetData(DataFormats.StringFormat);

                if (Utils.IsValidUrl(url)) {
                    txtUrl.Text = url;

                }

            }
        }

        #endregion

        private void btnBrowseDownloadDirectory_Click_1(object sender, EventArgs e) {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select download directory..")) {
                dialog.IsFolderPicker = true;
                dialog.InitialDirectory = txtDownloadDirectory.Text;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    txtDownloadDirectory.Text = dialog.FileName;
            }
        }



        private void StartDownload() {
            if (!txtUrl.IsValidUrl())
                return;

            api.Arguments.PostProcessing.FFmpegLocation = ffmpegPath;
            api.Arguments.PostProcessing.PreferFFmpeg = true;

            string[] urls = txtUrl.Text.Split(new string[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string url in urls) {
                if (!Utils.IsValidUrl(url))
                    continue;
                api.Arguments.Url = url;

                api.Execute(txtDownloadDirectory.Text);
            }
            txtUrl.Text = string.Empty;
        }


        private void btnStartDownload_Click_1(object sender, EventArgs e) {
            StartDownload();
        }



        private void btnOpenPlaylistItemsEditor_Click(object sender, EventArgs e) {
            using (FormPlaylistItemsEditor dialog = new FormPlaylistItemsEditor(txtPlaylistRange.Text)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    txtPlaylistRange.Text = dialog.PlaylistItemSelector;
                }
            }
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e) {
            using (FormOptions dialog = new FormOptions())
                dialog.ShowDialog(this);
        }


        private void btnOpenUrlEditor_Click(object sender, EventArgs e) {
            using (FormUrlsEditor dialog = new FormUrlsEditor(txtUrl.Text)) {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    txtUrl.Text = dialog.UrlList;
            }
        }

        private void txtCommand_Enter(object sender, EventArgs e) {
            txtCommand.SelectAll();
        }

        private void txtCommand_MouseClick(object sender, MouseEventArgs e) {
            txtCommand.SelectAll();
        }

        private void btnBrowseDownloadArchive_Click_1(object sender, EventArgs e) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.Title = "Select download archive file...";
                dialog.OverwritePrompt = true;
                dialog.InitialDirectory = txtDownloadArchive.Text;
                if (dialog.ShowDialog() == DialogResult.OK)
                    txtDownloadArchive.Text = dialog.FileName;
            }
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://github.com/Maxstupo/ydl-ui/wiki");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


        private void UpdateControls(YoutubeDLArguments args) {
            txtUrl.Text = args.Url ?? string.Empty;
            txtDownloadDirectory.Text = args.DownloadDirectory ?? string.Empty;

            cbDownloadArchive.Checked = args.VideoSelection.DownloadArchive != null;
            txtDownloadArchive.Text = args.VideoSelection.DownloadArchive ?? string.Empty;

            cbFileTemplate.Checked = args.FileSystem.OutputTemplate != null;
            txtFileTemplate.Text = args.FileSystem.OutputTemplate ?? string.Empty;

            cbWriteDescription.Checked = args.FileSystem.WriteDescription;
            cbWriteAnnotations.Checked = args.FileSystem.WriteAnnotations;
            cbWriteThumbnail.Checked = args.Thumbnail.WriteThumbnail;
            cbRestrictFilenames.Checked = args.FileSystem.RestrictFilenames;
            cbNoOverwrites.Checked = args.FileSystem.NoOverwrites;

            cbIgnoreErrors.Checked = args.General.IgnoreErrors;
            cbAbortOnErrors.Checked = args.General.AbortOnError;
            cbMarkWatched.Checked = args.General.MarkWatched;

            cbRecodeFormat.Checked = args.PostProcessing.RecodeVideo.HasValue;
            if (args.PostProcessing.RecodeVideo.HasValue) cbxRecodeFormat.SelectedItem = args.PostProcessing.RecodeVideo.Value;

            cbDate.Checked = args.VideoSelection.Date.HasValue;
            if (args.VideoSelection.Date.HasValue) dtpDate.Value = args.VideoSelection.Date.Value;

            cbDateAfter.Checked = args.VideoSelection.DateAfter.HasValue;
            if (args.VideoSelection.DateAfter.HasValue) dtpDateAfter.Value = args.VideoSelection.DateAfter.Value;

            cbDateBefore.Checked = args.VideoSelection.DateBefore.HasValue;
            if (args.VideoSelection.DateBefore.HasValue) dtpDateBefore.Value = args.VideoSelection.DateBefore.Value;



            cbFilesizeMin.Checked = args.VideoSelection.MinFilesize.HasValue;
            if (args.VideoSelection.MinFilesize.HasValue) {
                double bytes = args.VideoSelection.MinFilesize.Value.Bytes;
                nudFilesizeMin.Value = (decimal)ByteSize.FromBytes(bytes).ToUnit(args.FilesizeMinUnit);
                cbxFilesizeMinUnits.SelectedItem = args.FilesizeMinUnit;
            }

            cbFilesizeMax.Checked = args.VideoSelection.MaxFilesize.HasValue;
            if (args.VideoSelection.MaxFilesize.HasValue) {
                double bytes = args.VideoSelection.MaxFilesize.Value.Bytes;
                nudFilesizeMax.Value = (decimal)ByteSize.FromBytes(bytes).ToUnit(args.FilesizeMaxUnit);
                cbxFilesizeMaxUnits.SelectedItem = args.FilesizeMaxUnit;
            }

            cbMinViews.Checked = args.VideoSelection.MinViews.HasValue;
            if (args.VideoSelection.MinViews.HasValue) nudViewRangeMin.Value = args.VideoSelection.MinViews.Value;

            cbMaxViews.Checked = args.VideoSelection.MaxViews.HasValue;
            if (args.VideoSelection.MaxViews.HasValue) nudViewRangeMax.Value = args.VideoSelection.MaxViews.Value;

            cbAgeLimit.Checked = args.VideoSelection.AgeLimit.HasValue;
            if (args.VideoSelection.AgeLimit.HasValue) nudAgeLimit.Value = args.VideoSelection.AgeLimit.Value;

            cbMatchTitle.Checked = args.VideoSelection.MatchTitle != null;
            txtMatchTitle.Text = args.VideoSelection.MatchTitle ?? string.Empty;

            cbRejectTitle.Checked = args.VideoSelection.RejectTitle != null;
            txtRejectTitle.Text = args.VideoSelection.RejectTitle ?? string.Empty;

            cbMaxDownloads.Checked = args.VideoSelection.MaxDownloads.HasValue;
            if (args.VideoSelection.MaxDownloads.HasValue) nudMaxDownloads.Value = args.VideoSelection.MaxDownloads.Value;

            cbMatchFilter.Checked = args.VideoSelection.MatchFilter != null;
            txtMatchFilter.Text = args.VideoSelection.MatchFilter ?? string.Empty;

            cbPlaylistStart.Checked = args.VideoSelection.PlaylistStart.HasValue;
            if (args.VideoSelection.PlaylistStart.HasValue) nudPlaylistStart.Value = args.VideoSelection.PlaylistStart.Value;

            cbPlaylistEnd.Checked = args.VideoSelection.PlaylistEnd.HasValue;
            if (args.VideoSelection.PlaylistEnd.HasValue) nudPlaylistEnd.Value = args.VideoSelection.PlaylistEnd.Value;

            cbPlaylistRange.Checked = args.VideoSelection.PlaylistItems != null;
            txtPlaylistRange.Text = args.VideoSelection.PlaylistItems ?? string.Empty;

            cbPlaylistReversed.Checked = args.Download.PlaylistReverse;
            cbPlaylistRandom.Checked = args.Download.PlaylistRandom;

            if (args.VideoSelection.YesPlaylist) {
                rbVideoOnly.Checked = true;
            } else if (args.VideoSelection.NoPlaylist) {
                rbPlaylistOnly.Checked = true;
            } else {
                rbPlaylistAndVideo.Checked = true;
            }

            cbVqPreferred.Checked = args.Vq.ResPreferred;
            cbVqFallback.Checked = args.Vq.ResFallback;
            cbFpsPreferred.Checked = args.Vq.FpsPreferred;
            cbFpsFallback.Checked = args.Vq.FpsFallback;

            if (args.Vq.Width == 3840 && args.Vq.Height == 2160) {
                rbVq2160p.Checked = true;
            } else if (args.Vq.Width == 2560 && args.Vq.Height == 1440) {
                rbVq1440p.Checked = true;
            } else if (args.Vq.Width == 1920 && args.Vq.Height == 1080) {
                rbVq1080p.Checked = true;
            } else if (args.Vq.Width == 1280 && args.Vq.Height == 720) {
                rbVq720p.Checked = true;
            } else if (args.Vq.Width == 854 && args.Vq.Height == 480) {
                rbVq480p.Checked = true;
            } else if (args.Vq.Width == 640 && args.Vq.Height == 360) {
                rbVq360p.Checked = true;
            } else if (args.Vq.Width == 426 && args.Vq.Height == 240) {
                rbVq240p.Checked = true;
            } else {
                rbVqCustom.Checked = true;
                nudVideoQualityWidth.Value = args.Vq.Width;
                nudVideoQualityHeight.Value = args.Vq.Height;
            }

            if (args.Vq.Fps == 144) {
                rbFps144.Checked = true;
            } else if (args.Vq.Fps == 120) {
                rbFps120.Checked = true;
            } else if (args.Vq.Fps == 60) {
                rbFps60.Checked = true;
            } else if (args.Vq.Fps == 30) {
                rbFps30.Checked = true;
            } else if (args.Vq.Fps == 25) {
                rbFps25.Checked = true;
            } else {
                rbFpsCustom.Checked = true;
                nudFpsCustom.Value = args.Vq.Fps;
            }

            cbReferer.Checked = args.Workarounds.Referer != null;
            txtReferer.Text = args.Workarounds.Referer ?? string.Empty;

            cbUserAgent.Checked = args.Workarounds.UserAgent != null;
            txtUserAgent.Text = args.Workarounds.UserAgent ?? string.Empty;

            cbProxy.Checked = args.Network.Proxy != null;
            txtProxy.Text = args.Network.Proxy ?? string.Empty;

            cbSocketTimeout.Checked = args.Network.SocketTimeout.HasValue;
            if (args.Network.SocketTimeout.HasValue) nudSocketTimeout.Value = args.Network.SocketTimeout.Value;

            cbSourceAddress.Checked = args.Network.SourceAddress != null;
            txtSourceAddress.Text = args.Network.SourceAddress ?? string.Empty;

            if (args.Network.ForceIpv4) {
                rbForceIpv4.Checked = true;
            } else if (args.Network.ForceIpv6) {
                rbForceIpv6.Checked = true;
            } else {
                rbAny.Checked = true;
            }

            cbLimitRate.Checked = args.Download.LimitRate.HasValue;
            if (args.Download.LimitRate.HasValue) {
                double bytes = args.Download.LimitRate.Value.Bytes;
                nudLimitRate.Value = (decimal)ByteSize.FromBytes(bytes).ToUnit(args.LimitRateUnit);
                cbxLimitRateUnits.SelectedItem = args.LimitRateUnit;
            }

            cbRetries.Checked = args.Download.Retries != null;
            cbRetriesInf.Checked = args.Download.Retries == "infinite";
            nudRetries.Minimum = cbRetriesInf.Checked ? -1 : 0;
            nudRetries.Value = cbRetries.Checked ? (cbRetriesInf.Checked ? -1 : int.Parse(args.Download.Retries)) : 0;

            cbFragmentRetries.Checked = args.Download.FragmentRetries != null;
            cbFragmentRetriesInf.Checked = args.Download.FragmentRetries == "infinite";
            nudFragmentRetries.Minimum = cbFragmentRetriesInf.Checked ? -1 : 0;
            nudFragmentRetries.Value = cbFragmentRetries.Checked ? (cbFragmentRetriesInf.Checked ? -1 : int.Parse(args.Download.FragmentRetries)) : 0;

            rbSleepDefault.Checked = !args.Workarounds.SleepInterval.HasValue;
            if (args.Workarounds.MaxSleepInterval.HasValue && args.Workarounds.MinSleepInterval.HasValue) {
                rbSleepRange.Checked = true;
                nudSleepRangeMin.Value = args.Workarounds.MinSleepInterval.Value;
                nudSleepRangeMax.Value = args.Workarounds.MaxSleepInterval.Value;
            } else if (args.Workarounds.SleepInterval.HasValue) {
                rbSleepValue.Checked = true;
                nudSleepValue.Value = args.Workarounds.SleepInterval.Value;
            }

            cbCustomFormatSelector.Checked = args.CustomFormat;
            txtCustomFormatSelector.Text = args.VideoFormat.Format;

            dgvHeaders.Rows.Clear();
            foreach (KeyValuePair<string, string> entry in args.Workarounds.Headers) {
                if (string.IsNullOrWhiteSpace(entry.Key) || string.IsNullOrWhiteSpace(entry.Value))
                    continue;
                dgvHeaders.Rows.Add(new object[] { entry.Key, entry.Value });
            }

            // Note: Authentication not saved in preset.

            api.Arguments = args;
            clg.Trigger();
            needsSave = false;
        }

        private void SavePreset(string location) {
            XmlSerializer serializer = new XmlSerializer(typeof(YoutubeDLArguments));
            using (StreamWriter sw = new StreamWriter(location, false, Encoding.UTF8)) {
                serializer.Serialize(sw, api.Arguments);
                saveLocation = location;
                saveToolStripMenuItem.Enabled = true;

            }
        }

        private void OpenPreset(string location) {
            if (!File.Exists(location)) {
                MessageBox.Show(this, "Failed to load preset.. \nNo file found at: " + location, "Failed to find preset!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(YoutubeDLArguments));
            using (StreamReader sr = new StreamReader(location)) {
                YoutubeDLArguments args = serializer.Deserialize(sr) as YoutubeDLArguments;
                UpdateControls(args);

                saveLocation = location;
                saveToolStripMenuItem.Enabled = true;

                Text = defaultTitle + "  -  " + location;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveLocation != null)
                SavePreset(saveLocation);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.Title = "Save preset as...";
                dialog.OverwritePrompt = true;
                dialog.DefaultExt = "xml";
                dialog.FileName = "ydl-ui";
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    SavePreset(dialog.FileName);

                    Text = defaultTitle + "  -  " + saveLocation;
                }
            }
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Title = "Open preset...";
                dialog.Multiselect = false;
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                dialog.DefaultExt = "xml";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;

                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    OpenPreset(dialog.FileName);
                }
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {

            saveLocation = null;
            saveToolStripMenuItem.Enabled = false;

            Text = defaultTitle;
            rbVq2160p.Checked = true;

            YoutubeDLArguments args = new YoutubeDLArguments();
            args.Vq = GetVideoQuality();
            UpdateControls(args);
            api.Arguments = args;

            needsSave = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (Properties.Settings.Default.PromptSaveOnClose && needsSave) {

                if (MessageBox.Show(this, "You are exiting without saving, do you want to save?", "Are you sure you want to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (saveLocation == null) {
                        saveAsToolStripMenuItem.PerformClick();
                    } else {
                        saveToolStripMenuItem.PerformClick();
                    }
                }

            }
        }
    }

}
