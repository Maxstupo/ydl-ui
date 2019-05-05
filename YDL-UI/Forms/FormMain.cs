using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormMain : Form {
        private const string EmbeddedBinariesNamespace = "Maxstupo.YdlUi.Resources";
        private const string EmbeddedYdlName = "youtube-dl.exe";
        private const string EmbeddedFfmpegName = "ffmpeg.exe";

        private const string UrlWiki = @"https://github.com/Maxstupo/ydl-ui/wiki";
        private const string UpdateUrl = @"https://api.github.com/repos/Maxstupo/ydl-ui/releases/latest";

        public PreferencesManager<Preferences> PreferencesManager { get; }
        private readonly DownloadManager downloadManager;

        public string ApplicationVersion { get => Application.ProductVersion.RemoveAfterLast('.'); }

        public FormMain() {
            InitializeComponent();

            // Set the title of the application.
            Text = $"{Application.ProductName}";
#if PORTABLE
            Text += " Portable";
#endif
            Text += $" v{ ApplicationVersion}";
#if DEBUG
            Text += "  -  Debug Build";
#endif

            // Ensure portable build always has a preference file in the same directory as the executable.
#if PORTABLE
            if (!File.Exists("ydl-ui.json"))
                PreferencesManager<Preferences>.Save("ydl-ui.json", new Preferences());
#endif

            // Create a new preferences manager with multiple preference file locations. (Multiple filepaths are used to make YDL portable).
            PreferencesManager = new PreferencesManager<Preferences>(new string[] {
              "ydl-ui.json", // ~\ydl-ui.json
              Path.Combine(Util.GetAppDataPath(),".ydl-ui", "ydl-ui.json") // %appdata%\.ydl-ui\ydl-ui.json
            });

            // The filepath to the download list, it's within the same folder as the preferences file.
            string downloadListFilepath = Path.Combine(PreferencesManager.PrefDirectory, "download-list.json");

            // XXX: DownloadManager doesn't create or check if the download list directory exists.
            downloadManager = new DownloadManager(PreferencesManager, downloadListFilepath);
            downloadManager.PropertyChanged += DownloadManager_PropertyChanged;
        }

        private void DownloadManager_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            tsslStatusLeft.Text = $"Downloaded {downloadManager.CompletedDownloads} of {downloadManager.TotalDownloads}, {downloadManager.ConcurrentDownloads} running.";
        }

        private void FormMain_Load(object sender, EventArgs e) {
            // Bind our downloads from the download manager to the datagridview.
            dgvDownloads.AutoGenerateColumns = false;
            dgvDownloads.OpenCellLinkOnClick();
            dgvDownloads.SelectRowOnRightClick();
            dgvDownloads.DataSource = downloadManager.Downloads;

            completedDownloadsToolStripMenuItem.Tag = DownloadStatus.Completed;
            waitingDownloadsToolStripMenuItem.Tag = DownloadStatus.Waiting;
            queuedDownloadsToolStripMenuItem.Tag = DownloadStatus.Queued;
            failedDownloadsToolStripMenuItem.Tag = DownloadStatus.Failed;

            PreferencesManager.OnUpdate += (sdr, p) => {
                TopMost = p.StayOnTop;
            };

            // Attempt to load preferences if file exists, else create a new preferences file.
            PreferencesManager.Load(true);

            UpdateResources();

            downloadManager.Load(true);

#if !DEBUG
            if (PreferencesManager.Preferences.CheckForUpdates)
                CheckForUpdates(true);
#endif
        }


        // Check if we are closing YDL-UI when we are downloading or haven't saved our changes.
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (downloadManager.ConcurrentDownloads > 0 && PreferencesManager.Preferences.PromptDownloadingOnClose) {
                if (MessageBox.Show(this, "There are still items downloading! Do you want to quit?", "Are you sure you want to quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    e.Cancel = true;
            }
            if (!e.Cancel)
                downloadManager.Save();
        }

        // Updates resource filepaths, based on preferences. If a binary filepath is defined in preferences and exists use that, otherwise auto-extract
        // the resource to a temp directory and update the filepath to this temp resource instead.
        private void UpdateResources() {

            string ydlPath = PreferencesManager.Preferences.Binaries.YoutubeDl;
            string ffmpegPath = PreferencesManager.Preferences.Binaries.Ffmpeg;

            bool ydlCustomExists = File.Exists(ydlPath);
            bool ffmpegCustomExists = File.Exists(ffmpegPath);

            // If this is a portable build, disable auto-extraction as we don't have the binaries embedded within the application.
#if !PORTABLE
            TempDirectory tempDirectory = null;

            // Create temp directory only if needed, and mark it for deletion on application exit.
            if (!ydlCustomExists || !ffmpegCustomExists)
                tempDirectory = new TempDirectory("YDL-UI", true).DeleteOnExit();


            // Only extract youtube-dl if we need it.
            if (!ydlCustomExists) {
                ResourceDescriptor[] descriptors = ResourceExtractor.ExtractTo(tempDirectory, EmbeddedBinariesNamespace, EmbeddedYdlName);

                ydlPath = ResourceExtractor.GetFullPath(descriptors, EmbeddedYdlName); // Get the full filepath of our extracted binary.
            }

            // Only extract ffmpeg if we need it.
            if (!ffmpegCustomExists) {
                ResourceDescriptor[] descriptors = ResourceExtractor.ExtractTo(tempDirectory, EmbeddedBinariesNamespace, $"|{EmbeddedYdlName}"); // Pipe used to negate name (extract everything but this name).

                ffmpegPath = ResourceExtractor.GetFullPath(descriptors, EmbeddedFfmpegName); // Get the full filepath of our extracted binary.
            }
#else
            // If this is a portable build and our custom binary paths don't exist, ask for their location in a dialog.
            if (!ydlCustomExists || !ffmpegCustomExists) {
                ShowUpdateBinaryLocationsDialog(true);
                ydlPath = PreferencesManager.Preferences.Binaries.YoutubeDl;
                ffmpegPath = PreferencesManager.Preferences.Binaries.Ffmpeg;
            }
#endif

            // Apply the ydl and ffmpeg paths to our download manager.
            downloadManager.YdlPath = Util.GetAbsolutePath(ydlPath);
            downloadManager.FfmpegPath = Util.GetAbsolutePath(ffmpegPath);

            Logger.Instance.Debug("Resources", "youtube-dl path: '{0}'", ydlPath);
            Logger.Instance.Debug("Resources", "ffmpeg path: '{0}'", ffmpegPath);
        }

        private void AddDownload(Download download) {
            if (!downloadManager.AddDownload(download)) {
                MessageBox.Show(this, "The video URL is already added to the download list!", "Failed to queue download!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #region Dialog Methods

        private void ShowUpdateBinaryLocationsDialog(bool exitOnCancel = true) {
            using (FormUpdateBinaryLocations dialog = new FormUpdateBinaryLocations(PreferencesManager.Preferences)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PreferencesManager.Save();
                } else {
                    PreferencesManager.Load();

                    if (exitOnCancel)
                        Application.Exit();
                }
            }
        }

        private void ShowPreferencesDialog() {
            using (FormPreferences dialog = new FormPreferences(downloadManager, PreferencesManager.Preferences, PreferencesManager.PrefPath)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PreferencesManager.Save();

                    if (dialog.RequiresRestart) {
                        if (MessageBox.Show(this, $"{Application.ProductName} requires a restart for changes to take effect.\n\nWould you like to restart {Application.ProductName} now?", "Restart required", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            Application.Restart();
                    }

                } else {
                    PreferencesManager.Load();
                }
            }
        }

        private void ShowAddDownloadDialog(string url = null) {
            using (FormAddDownload dialog = new FormAddDownload(PreferencesManager.Preferences, url, null, false)) {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    AddDownload(dialog.Download);
            }
        }

        #endregion

        #region Menustrip Events

        #region File Menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion

        #region Download Menu

        private void addURLToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowAddDownloadDialog();
        }

        private void selectToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem.Tag is DownloadStatus status)
                dgvDownloads.SelectRows<Download>(download => status.HasFlag(download.Status));
        }

        #endregion

        #region Settings Menu

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowPreferencesDialog();
        }

        #endregion

        #region Help Menu 

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(UrlWiki);
        }

        private void checkForUpdatesToolStripMenuItem_Click_1(object sender, EventArgs e) {
            CheckForUpdates(false);
        }

        #endregion

        #endregion

        #region Drag & Drop Events

        private void FormMain_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e) {
            string url = (string)e.Data.GetData(DataFormats.Text);
            if (!string.IsNullOrWhiteSpace(url) && Uri.IsWellFormedUriString(url, UriKind.Absolute))
                ShowAddDownloadDialog(url);
        }


        #endregion

        #region Download Context Menu Strip

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {

            //YdlDownload download = dgvDownloads.SelectedRow<YdlDownload>();

            bool singleRowSelected = dgvDownloads.HasSingleSelectedRow();

            // download will be null if multiple rows are selected.
            copyDownloadLinkToolStripMenuItem.Enabled = singleRowSelected;
            openDownloadDirectoryToolStripMenuItem.Enabled = singleRowSelected;
            viewLogToolStripMenuItem.Enabled = singleRowSelected;

            Download[] downloads = dgvDownloads.SelectedRows<Download>();

            removeDownloadToolStripMenuItem.Enabled = downloads?.All(d => downloadManager.CanRemoveDownload(d)) ?? false;
            startToolStripMenuItem.Visible = downloads?.All(d => downloadManager.CanQueueDownload(d)) ?? false;
            stopToolStripMenuItem.Visible = downloads?.All(d => downloadManager.CanStopDownload(d)) ?? false;

            if (!dgvDownloads.HasSelectedRows())
                e.Cancel = true;
        }

        private void removeDownloadToolStripMenuItem_Click(object sender, EventArgs e) {
            Download[] downloads = dgvDownloads.SelectedRows<Download>();
            if (downloads != null && downloads.Length > 0) {

                if (MessageBox.Show(this, $"Are you sure you want to remove {downloads.Length} download(s)?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                foreach (Download download in downloads)
                    downloadManager.RemoveDownload(download);

            }
        }

        private void openDownloadDirectoryToolStripMenuItem_Click(object sender, EventArgs e) {
            Download download = dgvDownloads.SelectedRow<Download>();
            if (download != null)
                Process.Start(download.DownloadDirectory);
        }

        private void copyDownloadLinkToolStripMenuItem_Click(object sender, EventArgs e) {
            Download download = dgvDownloads.SelectedRow<Download>();
            if (download != null && download.Url != null) {
                try {
                    Clipboard.SetDataObject(download.Url, true, 5, 200); // Attempt to set clipboard 5 times, every 200ms.

                } catch (ExternalException ex) { // Clipboard is being used by another process.

                    MessageBox.Show(this, "Failed to copy URL to clipboard.\n\nClipboard is being used by another process. Please try again later...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            Download[] downloads = dgvDownloads.SelectedRows<Download>();
            if (downloads != null) {
                foreach (Download download in downloads)
                    downloadManager.Queue(download);
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e) {
            Download[] downloads = dgvDownloads.SelectedRows<Download>();
            if (downloads != null) {
                foreach (Download download in downloads)
                    downloadManager.Stop(download);
            }
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Download download = dgvDownloads.SelectedRow<Download>();
            if (download != null) {
                using (FormDownloadLog dialog = new FormDownloadLog(download))
                    dialog.ShowDialog(this);
            }
        }


        #endregion

        private void dgvDownloads_SelectionChanged(object sender, EventArgs e) {
            // Set LinkCells to have white text when selected.
            foreach (DataGridViewRow row in dgvDownloads.Rows) {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["colUrl"] is DataGridViewLinkCell cell)
                    cell.LinkColor = cell.VisitedLinkColor = cell.Selected ? Color.White : Color.Blue;
            }
        }

        /// <summary>
        /// Check for a new release of the application by accessing the github API for the YDL-UI repo.
        /// </summary>
        /// <param name="silent">If true the update checker will run sliently in the background and only notify the user if a new update is found, used for update check on startup.</param>
        public async void CheckForUpdates(bool silent) {
            Logger.Instance.Info("Updater", "Checking for updates...");
            try {
                string response = await NetUtil.HttpGetAsync(UpdateUrl, Text);

                if (string.IsNullOrWhiteSpace(response))
                    return;

                JObject json = JObject.Parse(response);

                string releasePageUrl = json["html_url"].Value<string>();
                string releaseTagName = json["tag_name"].Value<string>();
                // DateTime releasePublishedAt = json["published_at"].Value<DateTime>();
                //string changelog = Regex.Replace(json["body"].Value<string>(), @"(\[.+\])\(.+\)", string.Empty); 

                if (releaseTagName.StartsWith("v"))
                    releaseTagName = releaseTagName.Substring(1);

                Version currentVersion = new Version(ApplicationVersion);
                Version releaseVersion = new Version(releaseTagName);

                int delta = releaseVersion.CompareTo(currentVersion);
                if (delta > 0) {
                    Logger.Instance.Info("Updater", "New version available: {0} -> {1} ({2})", currentVersion, releaseVersion, delta);
                    if (MessageBox.Show(this, $"{Application.ProductName} v{releaseTagName} is available! Do you want to go to the download page?", "An Update is Available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        Process.Start(releasePageUrl);
                    }
                } else {
                    Logger.Instance.Info("Updater", "Up to date.");

                    if (!silent)
                        MessageBox.Show(this, "No new updates found.", "Check For Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception e) {
                Logger.Instance.Error("Updater", "Failed to check for updates!\n{0}", e.ToString());

                if (!silent)
                    MessageBox.Show(this, "Failed to check for updates!", "Check For Updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
