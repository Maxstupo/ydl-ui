namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.IO.Pipes;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public partial class FormMain : Form {
        public const string PipeName = "YDL_UI_IO";

        private const string UrlWiki = @"https://github.com/Maxstupo/ydl-ui/wiki";
        private const string UpdateUrl = @"https://api.github.com/repos/Maxstupo/ydl-ui/releases/latest";

        public PreferencesManager<Preferences> PreferencesManager { get; }
        private readonly DownloadManager downloadManager;

        public string ApplicationVersion => Application.ProductVersion.RemoveAfterLast('.');

        private Thread pipeThread;
        private NamedPipeServerStream pipeServer;

        private readonly string urlToAdd;
        private readonly bool isSilent;
        private bool isInitLanguageChange = true;

        private readonly string localesDirectory;

        public FormMain(string urlToAdd, bool silent) {
            InitializeComponent();
            this.urlToAdd = urlToAdd;
            this.isSilent = silent;

            // Set the title of the application.
            Text = $"{Application.ProductName} Portable v{ApplicationVersion}";

#if DEBUG
            Text += "  -  Debug Build";
#endif
            string prefFilepath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ydl-ui.json");

            // Create a new preferences manager.
            PreferencesManager = new PreferencesManager<Preferences>(prefFilepath);

            // The directory path to locale files.
            localesDirectory = Path.Combine(PreferencesManager.PrefDirectory, "locales");

            // The filepath to the download list, it's within the same folder as the preferences file.
            string downloadListFilepath = Path.Combine(PreferencesManager.PrefDirectory, "download-list.json");

            downloadManager = new DownloadManager(PreferencesManager, downloadListFilepath);
            downloadManager.PropertyChanged += DownloadManager_PropertyChanged;

            Listen();
        }


        private void DownloadManager_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            string template = Localization.GetString("status", "Downloading {CompletedDownloads} of {TotalDownloads}, {ConcurrentDownloads} running.");

            tsslStatusLeft.Text = template.Replace("{CompletedDownloads}", downloadManager.CompletedDownloads.ToString())
                                          .Replace("{TotalDownloads}", downloadManager.TotalDownloads.ToString())
                                          .Replace("{ConcurrentDownloads}", downloadManager.ConcurrentDownloads.ToString());
        }

        private void FormMain_Load(object sender, EventArgs e) {

            // Bind our downloads from the download manager to the datagridview.
            dgvDownloads.AutoGenerateColumns = false;
            dgvDownloads.OpenCellLinkOnClick();
            dgvDownloads.SelectRowOnRightClick();
            dgvDownloads.DataSource = downloadManager.Downloads;

            dgvDownloads.Columns[0].Tag = "url";
            dgvDownloads.Columns[1].Tag = "progress";
            dgvDownloads.Columns[2].Tag = "size";
            dgvDownloads.Columns[3].Tag = "speed";
            dgvDownloads.Columns[4].Tag = "eta";
            dgvDownloads.Columns[5].Tag = "status";
            dgvDownloads.Columns[6].Tag = "download_directory";
            dgvDownloads.Columns[7].Tag = "title";
            dgvDownloads.Columns[8].Tag = "playlist";

            completedDownloadsToolStripMenuItem.Tag = DownloadStatus.Completed;
            waitingDownloadsToolStripMenuItem.Tag = DownloadStatus.Waiting;
            queuedDownloadsToolStripMenuItem.Tag = DownloadStatus.Queued;
            failedDownloadsToolStripMenuItem.Tag = DownloadStatus.Failed;

            PreferencesManager.OnUpdate += (sdr, p) => TopMost = p.StayOnTop;
            PreferencesManager.OnLoad += (sdr, p) => {
                Localization.Language = p.Language;
                p.Language = Localization.Language;

                foreach (DataGridViewColumn column in dgvDownloads.Columns) {
                    if (p.Columns.TryGetValue(column.Name, out ColumnDef def)) {
                        column.DisplayIndex = Math.Min(Math.Max(def.Index, 0), dgvDownloads.ColumnCount - 1);
                        column.Visible = (column.Name == "colUrl") || def.Visible;
                    }
                }
            };

            PreferencesManager.OnPreSave += (sdr, p) => {
                p.Columns.Clear();
                foreach (DataGridViewColumn column in dgvDownloads.Columns)
                    p.Columns.Add(column.Name, new ColumnDef(column.DisplayIndex, column.Visible));
            };

            Localization.OnLanguageChanged += OnLanguageChanged;
            Localization.Load(localesDirectory);

            // Attempt to load preferences if file exists, else create a new preferences file.
            PreferencesManager.Load(true);

            UpdateResources();

            downloadManager.Load(true);

            if (urlToAdd != null) {
                BeginInvoke((Action<string, bool>) ((url, silent) => ShowAddDownloadDialogIfValidUrl(url, silent)), urlToAdd, isSilent);
            }

#if !DEBUG
            if (ShouldCheckForUpdates())
                CheckForUpdates(true);
#endif

        }



        private void OnLanguageChanged(object sender, EventArgs args) {
            // Update preferences manually instead of using data binding, as the language property can change from what you set it to.
            // (e.g. Language = 'en-US', resolves to 'en' if 'en-US' locale doesnt exist)
            PreferencesManager.Preferences.Language = Localization.Language;

            Localization.ApplyLocaleText(this);
            Localization.ApplyLocaleText(contextMenuStripView, null, (string) dgvDownloads.Tag, 1);

            // Status text at the bottom left.
            DownloadManager_PropertyChanged(null, null);

            if (!isInitLanguageChange)
                dgvDownloads.AutoResizeColumns();
            isInitLanguageChange = false;
        }

        #region Named Pipe Server

        // Start a thread to listen for connections from Pipe Clients.
        private void Listen() {
            Logger.Instance.Debug("Background", "Starting named pipe server thread...");
            pipeThread = new Thread(ServerPipeThread) {
                IsBackground = true
            };
            pipeThread.Start();
        }

        private void ServerPipeThread() {
            try {
                pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.In, 1);

                using (StreamReader sr = new StreamReader(pipeServer, new UTF8Encoding(false))) {

                    while (true) { // XXX: Infinite loop, as you can't cancel WaitForConnection, without using BeginWaitForConnection. 
                                   // The pipe thread will terminate when the main application thread exits, as it's a background thread.
                        Logger.Instance.Debug("Background", "Waiting for connection...");
                        pipeServer.WaitForConnection();

                        Logger.Instance.Debug("Background", "Connection Successful!");

                        string data = sr.ReadToEnd();
                        if (data != null) {
                            Logger.Instance.Debug("Background", "Received: {0}", data);

                            bool silent = data[0] == '1';
                            string urlToAdd = data.Substring(2);


                            BeginInvoke((Action<string, bool>) ((url, isSilent) => ShowAddDownloadDialogIfValidUrl(url, isSilent)), urlToAdd, silent);
                        }

                        pipeServer.Disconnect();

                    }
                }

            } catch (Exception e) {
                Logger.Instance.Error("Background", "Failed to create named pipe server!\n{0}", e);
            } finally {
                if (pipeServer != null)
                    pipeServer.Dispose();
            }
        }

        #endregion

        // Check if we are closing YDL-UI when we are downloading or haven't saved our changes.
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (downloadManager.ConcurrentDownloads > 0 && PreferencesManager.Preferences.PromptDownloadingOnClose) {
                if (MessageBox.Show(this, Localization.GetString("msg.prompt_on_close", "There are still items downloading! Do you want to quit?"), Localization.GetString("msg.prompt_on_close.title", "Are you sure you want to quit?"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    e.Cancel = true;
            }
            if (!e.Cancel) {
                downloadManager.Save();
                PreferencesManager.Save();

                if (pipeServer != null)
                    pipeServer.Dispose();
            }
        }

        // Updates resource filepaths, based on preferences. If a binary filepath is defined in preferences and exists use that, otherwise prompt for locations.
        private void UpdateResources() {

            string ydlPath = Util.GetAbsolutePath(PreferencesManager.Preferences.Binaries.YoutubeDl);
            string ffmpegPath = Util.GetAbsolutePath(PreferencesManager.Preferences.Binaries.Ffmpeg);

            bool ydlCustomExists = File.Exists(ydlPath);
            bool ffmpegCustomExists = File.Exists(ffmpegPath);

            // If our custom binary paths don't exist, ask for their location in a dialog.
            if (!ydlCustomExists || !ffmpegCustomExists) {
                ShowUpdateBinaryLocationsDialog(true);
                ydlPath = PreferencesManager.Preferences.Binaries.YoutubeDl;
                ffmpegPath = PreferencesManager.Preferences.Binaries.Ffmpeg;
            }

            // Apply the ydl and ffmpeg paths to our download manager.
            downloadManager.YdlPath = Util.GetAbsolutePath(ydlPath);
            downloadManager.FfmpegPath = Util.GetAbsolutePath(ffmpegPath);

            Logger.Instance.Debug("Resources", "youtube-dl path: '{0}'", ydlPath);
            Logger.Instance.Debug("Resources", "ffmpeg path: '{0}'", ffmpegPath);
        }

        private void AddDownload(Download download) {
            if (!downloadManager.AddDownload(download))
                MessageBox.Show(this, Localization.GetString("msg.url_already_added", "The video URL is already added to the download list!"), Localization.GetString("msg.url_already_added.title", "Failed to queue download!"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            using (FormPreferences dialog = new FormPreferences(downloadManager, PreferencesManager.Preferences)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PreferencesManager.Save();

                    if (dialog.RequiresRestart) {
                        if (MessageBox.Show(this, Localization.GetString("msg.restart_required", "{ProductName} requires a restart for changes to take effect.\n\nWould you like to restart {ProductName} now?").Replace("{ProductName}", Application.ProductName), Localization.GetString("msg.restart_required.title", "Restart Required"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            Application.Restart();
                    }

                } else {
                    PreferencesManager.Load();
                }
            }
        }

        private void ShowAddDownloadDialog(string url = null, bool silent = false) {
            using (FormAddDownload dialog = new FormAddDownload(PreferencesManager.Preferences, downloadManager, url, null, false, silent)) {
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

            string url = (string) e.Data.GetData(DataFormats.Text);
            if (url != null && Util.IsValidUrl(url)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e) {
            string url = (string) e.Data.GetData(DataFormats.Text);
            ShowAddDownloadDialogIfValidUrl(url, PreferencesManager.Preferences.AutoConfirmDragDropDownloads);
        }


        #endregion

        public void ShowAddDownloadDialogIfValidUrl(string url, bool silent = false) {
            if (!string.IsNullOrWhiteSpace(url) && Uri.IsWellFormedUriString(url, UriKind.Absolute))
                ShowAddDownloadDialog(url, silent);
        }

        #region Download Context Menu Strip

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {

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

                if (MessageBox.Show(this, Localization.GetString("msg.confirm_download_removal", "Are you sure you want to remove {Count} download(s)?").Replace("{Count}", downloads.Length.ToString()), Localization.GetString("msg.confirm_download_removal.title", "Are you sure?"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

                } catch (ExternalException) { // Clipboard is being used by another process.

                    MessageBox.Show(this, Localization.GetString("msg.failed_clipboard_copy", "Failed to copy URL to clipboard.\n\nClipboard is being used by another process. Please try again later..."), Localization.GetString("msg.failed_clipboard_copy.title", Text).Replace("{ProductName}", Application.ProductName), MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        // Update download URL tooltip text with the video title.
        private void dgvDownloads_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex != 0)
                return;

            Download download = (Download) dgvDownloads.Rows[e.RowIndex].DataBoundItem;
            if (download != null)
                e.ToolTipText = download?.Title ?? e.ToolTipText;
        }

        // This method is called once at startup of YDL-UI, if it returns true we will check for updates.
        private bool ShouldCheckForUpdates() {
            // If last update time isn't set in preferences, it will default to 1/01/0001 12:00AM
            DateTime lastUpdateTime = PreferencesManager.Preferences.LastUpdateTime;
            TimeSpan durationSinceUpdate = (DateTime.Now.ToUniversalTime() - lastUpdateTime).Duration();

            switch (PreferencesManager.Preferences.UpdateInterval) {
                case UpdateInterval.Never:
                    return false;
                case UpdateInterval.EveryStart:
                    return true;
                case UpdateInterval.Daily:
                    return durationSinceUpdate.TotalDays >= 1;
                case UpdateInterval.Weekly:
                    return durationSinceUpdate.TotalDays >= 7;
                case UpdateInterval.Monthly:
                    return durationSinceUpdate.TotalDays >= 30;
                default:
                    return false;
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

                PreferencesManager.Preferences.LastUpdateTime = DateTime.Now.ToUniversalTime();

                int delta = releaseVersion.CompareTo(currentVersion);
                if (delta > 0) {
                    Logger.Instance.Info("Updater", "New version available: {0} -> {1} ({2})", currentVersion, releaseVersion, delta);
                    if (MessageBox.Show(this, Localization.GetString("msg.update.new_update", "{ProductName} v{UpdateVersion} is available! Do you want to go to the download page?").Replace("{ProductName}", Application.ProductName).Replace("{UpdateVersion}", releaseTagName), Localization.GetString("msg.update.new_update.title", "An Update is Available!"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        Process.Start(releasePageUrl);
                    }
                } else {
                    Logger.Instance.Info("Updater", "Up to date.");

                    if (!silent)
                        MessageBox.Show(this, Localization.GetString("msg.update.no_updates", "No new updates found."), Localization.GetString("msg.update", "Check For Updates"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception e) {
                Logger.Instance.Error("Updater", "Failed to check for updates!\n{0}", e.ToString());

                if (!silent)
                    MessageBox.Show(this, Localization.GetString("msg.update.failed", "Failed to check for updates!"), Localization.GetString("msg.update", "Check For Updates"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Import/Export Downloads

        private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.Title = Localization.GetString("export_dialog.title", "Export downloads...");
                dialog.AddExtension = true;
                dialog.Filter = @"Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";

                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    using (StreamWriter sw = new StreamWriter(dialog.FileName, false, new UTF8Encoding(false))) {

                        if (dialog.FilterIndex == 2) { // Export json file.
                            string[] urls = dgvDownloads.Rows.Cast<DataGridViewRow>().Select(r => ((Download) r.DataBoundItem).Url).ToArray();
                            sw.Write(JsonConvert.SerializeObject(urls, Formatting.Indented));

                        } else { // Export plain text file.
                            foreach (Download download in dgvDownloads.Rows.Cast<DataGridViewRow>().Select(r => (Download) r.DataBoundItem))
                                sw.WriteLine(download.Url);
                        }

                        sw.Flush();
                    }
                    MessageBox.Show(this, Localization.GetString("msg.successful_export", "Successfully exported downloads."), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("import_dialog.title", "Import downloads..."), @"Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*");
            if (filepath != null) {
                bool isJson = Path.GetExtension(filepath).Equals(".json", StringComparison.InvariantCultureIgnoreCase);

                using (FormImportDownloads dialog = new FormImportDownloads(filepath, isJson, PreferencesManager.Preferences, downloadManager, ContainedInDownloadList, AddDownload)) {
                    dialog.ShowDialog(this);
                }
            }
        }


        private bool ContainedInDownloadList(string url) {
            return dgvDownloads.Rows.Cast<DataGridViewRow>().Select(r => ((Download) r.DataBoundItem).Url).Contains(url);
        }

        #endregion

        private void dgvDownloads_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 5 && e.Value != null)
                e.Value = Localization.GetString($"download_list.status.{e.Value.ToString().ToLower()}", e.Value.ToString()); // Localize status column.

        }

        // Switch between context menus depending on location of right click (column header vs anywhere else)
        private void dgvDownloads_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;

            DataGridView.HitTestInfo hitTest = dgvDownloads.HitTest(e.X, e.Y);

            dgvDownloads.ContextMenuStrip = hitTest.Type == DataGridViewHitTestType.ColumnHeader ? contextMenuStripView : contextMenuStrip;
        }

        private void contextMenuStripView_Opening(object sender, CancelEventArgs e) {
            foreach (ToolStripMenuItem tsmi in contextMenuStripView.Items) {

                if (!(tsmi.Tag is string tsmiTag))
                    continue;

                foreach (DataGridViewColumn column in dgvDownloads.Columns) {
                    if (column.Tag is string columnTag && columnTag == tsmiTag) {
                        tsmi.Checked = column.Visible;
                        break;
                    }
                }
            }
        }

        private void viewMenuItem_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem tsmi && tsmi.Tag is string tsmiTag) {
                tsmi.Checked = !tsmi.Checked;

                foreach (DataGridViewColumn column in dgvDownloads.Columns) {
                    if (column.Tag is string columnTag && columnTag == tsmiTag) {
                        column.Visible = tsmi.Checked;
                        break;
                    }
                }
            }
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this,
                Localization.GetString("msg.confirm_clear_download_logs", "Are you sure you want to clear all download logs?"),
                Localization.GetString("msg.confirm_clear_download_log.title", "Are you sure?"),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            foreach (Download download in downloadManager.Downloads)
                download.Log = string.Empty;
        }

        private void downloadToolStripMenuItem_DropDownOpening(object sender, EventArgs e) {
            bool hasDownloads = downloadManager.TotalDownloads > 0;
            clearLogsToolStripMenuItem.Enabled = hasDownloads;
            selectToolStripMenuItem.Enabled = hasDownloads;
            exportToolStripMenuItem.Enabled = hasDownloads;
        }

    }

}