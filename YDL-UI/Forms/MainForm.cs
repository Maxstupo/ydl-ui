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
using Maxstupo.YdlUi.Util.UiStore;
using Maxstupo.YdlUi.Controls;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Maxstupo.YdlUi.Forms {

    public partial class MainForm : Form {
        public string Version { get; } = "v1.4.2";
        public string Title { get { return "YDL-UI " + Version; } }

        private static readonly Color LightRed = ControlPaint.LightLight(Color.Red);

        private static readonly string BIN_FOLDER_NAME = "bin";
        private static readonly string ROOT_DIRECTORY = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        private readonly Type[] presetSavableTypes = {
            typeof(TextBox),
            typeof(CheckBox),
            typeof(RadioButton),
            typeof(ComboBox),
            typeof(NumericUpDown),
            typeof(DateTimePicker),
            typeof(DataGridView),
            typeof(KeywordTextBox)
        };
        private UiState uiState = new UiState();
        private UiState defaultUiState;

        public string DefaultDownloadDirectory {
            get {
                try {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                } catch (PlatformNotSupportedException ex) {
                    return string.Empty;
                }
            }
        }

        private bool isYoutube;
        private string saveLocation = null;

        private bool needsSave;
        private bool NeedsSave {
            get { return needsSave; }
            set {
                Text = Title + " - " + (saveLocation ?? "<untitled>");
                if (value)
                    Text += "*";

                needsSave = value;
            }
        }

        private string ffmpegPath;

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
            Application.Idle += Application_Idle;
            Text = Title;

            this.ResizeBegin += (s, ee) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, ee) => { this.ResumeLayout(true); };
            saveToolStripMenuItem.Enabled = false;

            ffmpegPath = Path.Combine(ROOT_DIRECTORY, BIN_FOLDER_NAME, "ffmpeg.exe");
            api = new YoutubeDLApi(Path.Combine(ROOT_DIRECTORY, BIN_FOLDER_NAME, "youtube-dl.exe"), new YoutubeDLArguments());

            Func<Control, SerializedValue> kTextboxSeralizer = control => {
                return new SerializedValue(((KeywordTextBox)control).Text);
            };
            Action<Control, SerializedValue> kTextboxDeseralizer = (c, val) => {
                ((KeywordTextBox)c).Text = val.Value;
            };


            uiState.Serializers.Add(typeof(KeywordTextBox), kTextboxSeralizer);
            uiState.Deserializers.Add(typeof(KeywordTextBox), kTextboxDeseralizer);


            CheckVersion();

            if (Properties.Settings.Default.CheckForUpdates) {
                Timer updateTimer = new Timer();
                updateTimer.Tick += (s, ee) => {
                    updateTimer.Stop();
                    CheckForUpdates(false);
                };
                updateTimer.Interval = 250;
                updateTimer.Start();
            }

            cbxFilesizeMaxUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxFilesizeMaxUnits.SelectedItem = FilesizeUnit.MB;

            cbxFilesizeMinUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxFilesizeMinUnits.SelectedItem = FilesizeUnit.MB;

            cbxLimitRateUnits.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxLimitRateUnits.SelectedItem = FilesizeUnit.MB;

            cbxRecodeFormat.DataSource = Enum.GetValues(typeof(VideoFormatRecode));
            cbxRecodeFormat.SelectedItem = VideoFormatRecode.MP4;

            txtDownloadDirectory.Text = DefaultDownloadDirectory;
            txtDownloadDirectory.TextChanged += (ss, ee) => { NeedsSave = true; };

            clg = ControlListenGroup.New();
            clg.OnChanged += () => {
                NeedsSave = true;

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

            defaultUiState = new UiState(uiState);
            defaultUiState.CreateFrom(tabControl, presetSavableTypes); // Create a default ui state for making "New" presets.


            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DefaultPresetLocation)) {
                OpenPreset(Properties.Settings.Default.DefaultPresetLocation);
            } else {
                NeedsSave = false;
            }
        }

        private void CreateBindings(ControlListenGroup clg) {
            txtUrl.BindValueTo(v => {
                isYoutube = txtUrl.IsValidUrl() && new Uri(v).Host.Contains("youtube.com");
            });

            txtUrl.BindValueTo(v => api.Arguments.Url = v).Listen(clg);

            nudVideoQualityWidth.BindEnableTo(rbVqCustom);
            nudVideoQualityHeight.BindEnableTo(rbVqCustom);
            nudFpsCustom.BindEnableTo(rbFpsCustom);

            gbVideoQuality.BindEnableTo(cbs => !cbs[0].Checked, cbCustomFormatSelector);
            gbFrameRate.BindEnableTo(cbs => !cbs[0].Checked, cbCustomFormatSelector);

            #region General

            cbIgnoreErrors.BindValueTo(v => api.Arguments.General.IgnoreErrors = v).Listen(clg);
            cbAbortOnErrors.BindValueTo(v => api.Arguments.General.AbortOnError = v).Listen(clg);

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
                api.Arguments.VideoSelection.MinFilesize = (v == null || v == 0) ? (ByteSize?)null : ByteSize.From(v.Value, (FilesizeUnit)cbxFilesizeMinUnits.SelectedItem);
            }
            cbxFilesizeMinUnits.BindEnableTo(cbFilesizeMin).BindValueTo(obj => filesizeMinEvt(nudFilesizeMin.GetValueFloat(cbFilesizeMin))).Listen(clg);
            nudFilesizeMin.BindEnableTo(cbFilesizeMin).BindValueTo(filesizeMinEvt, cbFilesizeMin, clg);

            void filesizeMaxEvt(float? v) {
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

            formatGroup.Listen(rbVq2160p, rbVq1440p, rbVq1080p, rbVq720p, rbVq480p, rbVq360p, rbVq240p, rbVqCustom, rbFps144, rbFps120, rbFps60, rbFps30, rbFps25, rbFpsCustom);
            formatGroup.Listen(cbVqPreferred, cbFpsPreferred, cbVqFallback, cbFpsFallback);
            formatGroup.Listen(nudFpsCustom, nudVideoQualityWidth, nudVideoQualityHeight);

            formatGroup.OnChanged += () => {
                if (!cbCustomFormatSelector.Checked)
                    api.Arguments.VideoFormat.Format = GetVideoQuality().FormatSelector;

                VideoQuality vq = GetVideoQuality();
                if (!rbVqCustom.Checked && vq.Width > 0 && vq.Height > 0) {
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
            return new VideoQuality(width, height, fps, resPreferred, resFallback, fpsPreferred, fpsFallback);
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

            string downloadDirectory = DefaultDownloadDirectory;
            if (string.IsNullOrWhiteSpace(downloadDirectory) || !string.IsNullOrWhiteSpace(txtDownloadDirectory.Text))
                downloadDirectory = txtDownloadDirectory.Text;

            string[] urls = txtUrl.Text.Split(new string[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string url in urls) {
                if (!Utils.IsValidUrl(url))
                    continue;
                api.Arguments.Url = url;

                api.Execute(downloadDirectory);
            }

            if (saveLocation == null) {
                ResetUiState();
            } else if (Properties.Settings.Default.ClosePresetOnDownloadStart) {
                ClosePreset();
            }
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
                dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dialog.OverwritePrompt = false;
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


        private void SavePreset(string location) {
            saveLocation = location;
            saveToolStripMenuItem.Enabled = true;
            NeedsSave = false;

            uiState.CreateFrom(tabControl, presetSavableTypes).Save(location);
        }

        private void OpenPreset(string location) {
            if (!File.Exists(location)) {
                MessageBox.Show(this, "Failed to load preset.. \nNo file found at: " + location, "Failed to find preset!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uiState.Load(location).Apply(tabControl, presetSavableTypes);

            saveLocation = location;
            saveToolStripMenuItem.Enabled = true;
            NeedsSave = false;
        }

        private void ClosePreset() {
            saveLocation = null;
            saveToolStripMenuItem.Enabled = false;

            ResetUiState();
        }

        private void ResetUiState() {
            defaultUiState.Apply(tabControl, presetSavableTypes);
            NeedsSave = false;
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

                if (dialog.ShowDialog(this) == DialogResult.OK)
                    SavePreset(dialog.FileName);

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

                if (dialog.ShowDialog(this) == DialogResult.OK)
                    OpenPreset(dialog.FileName);

            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            if (NeedsSave) {
                if (MessageBox.Show(this, "Do you want to save your configuration, before opening a new one?", "Save Preset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (saveLocation != null) {
                        saveToolStripMenuItem.PerformClick();
                    } else {
                        saveAsToolStripMenuItem.PerformClick();
                    }
                }
            }
            ClosePreset();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (Properties.Settings.Default.PromptSaveOnClose && NeedsSave) {

                if (MessageBox.Show(this, "You are exiting without saving, do you want to save?", "Are you sure you want to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (saveLocation == null) {
                        saveAsToolStripMenuItem.PerformClick();
                    } else {
                        saveToolStripMenuItem.PerformClick();
                    }
                }

            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e) {
            CheckForUpdates(true);
        }

        private void CheckForUpdates(bool alertForNoUpdatesFound = true) {
            try {

                string url = @"https://api.github.com/repos/Maxstupo/ydl-ui/releases/latest";
                string html = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Maxstupo/" + Title;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                    using (Stream stream = response.GetResponseStream()) {
                        using (StreamReader sr = new StreamReader(stream)) {
                            html = sr.ReadToEnd();
                        }
                    }
                }

                if (string.IsNullOrWhiteSpace(html)) return;

                JObject obj = JsonConvert.DeserializeObject<JObject>(html);

                string ver = obj.Value<string>("tag_name");
                Util.Version repo_version = Util.Version.Parse(ver);
                Util.Version our_version = Util.Version.Parse(this.Version);

                string updateUrl = obj.Value<string>("html_url");

                if (repo_version.IsNewerThan(our_version)) {
                    if (MessageBox.Show(this, "YDL-UI " + repo_version.ToString() + " is available! Do you want to go to the download page?", "An update is available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        Process.Start(updateUrl);
                    }
                } else if (alertForNoUpdatesFound) {
                    MessageBox.Show(this, "No new updates found.", "Check for Updates");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
