using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormMain : Form {
        private const string EmbeddedBinariesNamespace = "Maxstupo.YdlUi.Resources";
        private const string EmbeddedYdlName = "youtube-dl.exe";
        private const string EmbeddedFfmpegName = "ffmpeg.exe";

        private const string UrlWiki = "https://github.com/Maxstupo/ydl-ui/wiki";

        private readonly PreferencesManager<Preferences> preferencesManager;
        private readonly DownloadManager downloadManager;


        public FormMain() {
            InitializeComponent();

            // Set the title of the application.
            Text = $"{Application.ProductName} v{Application.ProductVersion.RemoveAfterLast('.')}";

            // Create a new preferences manager with multiple preference file locations. (Multiple filepaths are used to make YDL portable).
            preferencesManager = new PreferencesManager<Preferences>(new string[] {
              "ydl-ui.json", // ~\ydl-ui.json
              Path.Combine(Util.GetAppDataPath(),".ydl-ui", "ydl-ui.json") // %appdata%\.ydl-ui\ydl-ui.json
            });

            // The filepath to the download list, it's within the same folder as the preferences file.
            string downloadListFilepath = Path.Combine(preferencesManager.PrefDirectory, "download-list.json");

            // XXX: DownloadManager doesn't create or check if the download list directory exists.
            downloadManager = new DownloadManager(preferencesManager.Preferences, downloadListFilepath);
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

            // Attempt to load preferences if file exists, else create a new preferences file.
            preferencesManager.Load(true);

            UpdateResources();

            downloadManager.Load(true);
        }

        // Check if we are closing YDL-UI when we are downloading or haven't saved our changes.
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (downloadManager.ConcurrentDownloads > 0 && preferencesManager.Preferences.PromptDownloadingOnClose) {
                if (MessageBox.Show(this, "There are still items downloading! Do you want to quit?", "Are you sure you want to quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    e.Cancel = true;
            }
            if (!e.Cancel)
                downloadManager.Save();
        }


        private void UpdateResources() {

            string ydlPath = preferencesManager.Preferences.Binaries.YoutubeDl;
            string ffmpegPath = preferencesManager.Preferences.Binaries.Ffmpeg;

            bool ydlCustomExists = File.Exists(ydlPath);
            bool ffmpegCustomExists = File.Exists(ffmpegPath);


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


            downloadManager.YdlPath = ydlPath;
            downloadManager.FfmpegPath = ffmpegPath;

            Logger.Instance.Debug("Resources", "youtube-dl path: '{0}'", ydlPath);
            Logger.Instance.Debug("Resources", "ffmpeg path: '{0}'", ffmpegPath);
        }

        private void AddDownload(Download download) {
            if (!downloadManager.AddDownload(download)) {
                MessageBox.Show(this, "The video URL is already added to the download list!", "Failed to queue download!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #region Dialog Methods

        private void ShowPreferencesDialog() {
            using (FormPreferences dialog = new FormPreferences(downloadManager, preferencesManager.Preferences, preferencesManager.PrefPath)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    preferencesManager.Save();

                    if (dialog.RequiresRestart) {
                        if (MessageBox.Show(this, $"{Application.ProductName} requires a restart for changes to take effect.\n\nWould you like to restart {Application.ProductName} now?", "Restart required", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            Application.Restart();
                    }

                } else {
                    preferencesManager.Load();
                }
            }
        }

        private void ShowAddDownloadDialog(string url = null) {
            using (FormAddDownload dialog = new FormAddDownload(preferencesManager.Preferences, url)) {
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

        #region Options Menu

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowPreferencesDialog();
        }

        #endregion

        #region Help Menu 

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(UrlWiki);
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

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
            startToolStripMenuItem.Enabled = downloads?.All(d => downloadManager.CanQueueDownload(d)) ?? false;

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
            if (download != null)
                Clipboard.SetText(download.Url);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            Download[] downloads = dgvDownloads.SelectedRows<Download>();
            if (downloads != null) {
                foreach (Download download in downloads)
                    downloadManager.Queue(download);
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


    }
}
