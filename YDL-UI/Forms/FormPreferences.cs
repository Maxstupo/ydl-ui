﻿namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL;

    public partial class FormPreferences : Form {
        private readonly DownloadManager downloadManager;
        private readonly Preferences preferences;

        public bool RequiresRestart { get; private set; } = false;

        private readonly BindingSource bsPresets = new BindingSource();

        private bool hasConcurrentDownloads = false;

        public FormPreferences(DownloadManager downloadManager, Preferences preferences) {
            InitializeComponent();
            this.downloadManager = downloadManager;
            this.preferences = preferences;

            downloadManager.PropertyChanged += DownloadManager_PropertyChanged;
            FormClosing += delegate {
                Localization.OnLanguageChanged -= OnLanguageChanged;
                downloadManager.PropertyChanged -= DownloadManager_PropertyChanged;
            };


            DownloadManager_PropertyChanged(downloadManager, new PropertyChangedEventArgs(nameof(DownloadManager.ConcurrentDownloads)));
        }


        private void DownloadManager_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DownloadManager.ConcurrentDownloads)) {
                hasConcurrentDownloads = (sender as DownloadManager).ConcurrentDownloads > 0;
                btnUpdateYoutubeDl.Enabled = !hasConcurrentDownloads && !string.IsNullOrWhiteSpace(txtBinaryYdl.Text) && File.Exists(Util.GetAbsolutePath(txtBinaryYdl.Text));
            }
        }

        private void FormPreferences_Load(object sender, EventArgs e) {
            panelActions.BackColor = Color.FromArgb(211, 211, 211);
            BackColor = Color.FromArgb(238, 238, 238);


            // Setup tabcontrol.
            lbxCategories.DisplayMember = "Text";
            UpdateCategoryList();
            lbxCategories.SelectedIndex = 0;

            tablessTabControl.PreloadTabs();


            #region Data Bindings

            cbxLanguage.DataSource = Localization.AvailableLanguages;
            cbxLanguage.DisplayMember = nameof(Language.DisplayName);
            cbxLanguage.ValueMember = nameof(Language.Code);


            SetupUpdateIntervalDataSource();

            cbxLanguage.SelectedValue = preferences.Language;
            cbxLanguage.SelectionChangeCommitted += delegate { Localization.Language = (string) cbxLanguage.SelectedValue; };

            txtBinaryYdl.DataBindings.Add(nameof(txtBinaryYdl.Text), preferences.Binaries, nameof(preferences.Binaries.YoutubeDl), false, DataSourceUpdateMode.OnPropertyChanged);
            txtBinaryFfmpeg.DataBindings.Add(nameof(txtBinaryFfmpeg.Text), preferences.Binaries, nameof(preferences.Binaries.Ffmpeg), false, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultDownloadDirectory.DataBindings.Add(nameof(txtDefaultDownloadDirectory.Text), preferences, nameof(preferences.DefaultDownloadDirectory), false, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultDownloadArchive.DataBindings.Add(nameof(txtDefaultDownloadArchive.Text), preferences, nameof(preferences.DefaultDownloadArchive), false, DataSourceUpdateMode.OnPropertyChanged);

            nudMaxConcurrentDownloads.DataBindings.Add(nameof(nudMaxConcurrentDownloads.Value), preferences, nameof(preferences.MaxConcurrentDownloads), false, DataSourceUpdateMode.OnPropertyChanged);

            cbPromptOnClose.DataBindings.Add(nameof(cbPromptOnClose.Checked), preferences, nameof(preferences.PromptDownloadingOnClose), false, DataSourceUpdateMode.OnPropertyChanged);
            cbxUpdateInterval.DataBindings.Add(nameof(cbxUpdateInterval.SelectedItem), preferences, nameof(preferences.UpdateIntervalDisplay), false, DataSourceUpdateMode.OnPropertyChanged);
            cbBasicMode.DataBindings.Add(nameof(cbBasicMode.Checked), preferences, nameof(preferences.BasicMode), false, DataSourceUpdateMode.OnPropertyChanged);
            cbStayTop.DataBindings.Add(nameof(cbStayTop.Checked), preferences, nameof(preferences.StayOnTop), false, DataSourceUpdateMode.OnPropertyChanged);
            cbResumeDownload.DataBindings.Add(nameof(cbResumeDownload.Checked), preferences, nameof(preferences.ResumeDownloads), false, DataSourceUpdateMode.OnPropertyChanged);
            cbRememberDownloadSettings.DataBindings.Add(nameof(cbRememberDownloadSettings.Checked), preferences, nameof(preferences.RememberDownloadSettings), false, DataSourceUpdateMode.OnPropertyChanged);
            cbUseBasicFolderPicker.DataBindings.Add(nameof(cbUseBasicFolderPicker.Checked), preferences, nameof(preferences.UseBasicFolderPicker), false, DataSourceUpdateMode.OnPropertyChanged);
            cbAutoStartDragDropDownloads.DataBindings.Add(nameof(cbAutoStartDragDropDownloads.Checked), preferences, nameof(preferences.AutoConfirmDragDropDownloads), false, DataSourceUpdateMode.OnPropertyChanged);
            cbKeepOriginalDateAndTime.DataBindings.Add(nameof(cbKeepOriginalDateAndTime.Checked), preferences, nameof(preferences.KeepOriginalDateAndTime), false, DataSourceUpdateMode.OnPropertyChanged);

            nudFailedRetryAttempts.DataBindings.Add(nameof(nudFailedRetryAttempts.Value), preferences, nameof(preferences.RetryAttempts), false, DataSourceUpdateMode.OnPropertyChanged);
            nudRetryDelay.DataBindings.Add(nameof(nudRetryDelay.Value), preferences, nameof(preferences.RetryAttemptInterval), false, DataSourceUpdateMode.OnPropertyChanged);

            bsPresets.DataSource = preferences.Presets;
            lbxPresets.DataSource = bsPresets;
            lbxPresets.DisplayMember = nameof(Preset.DisplayText);

            #endregion

            lbxPresets.SelectedIndexChanged += LbxPresets_SelectedIndexChanged;
            LbxPresets_SelectedIndexChanged(this, new EventArgs());

            txtBinaryYdl.TextChanged += BinaryPaths_TextChanged;
            txtBinaryFfmpeg.TextChanged += BinaryPaths_TextChanged;

            this.ForEachControl<TextBox>(control => control.TextChanged += TextBoxes_TextChanged);

            btnUpdateYoutubeDl.Enabled = !hasConcurrentDownloads && !string.IsNullOrWhiteSpace(txtBinaryYdl.Text) && File.Exists(Util.GetAbsolutePath(txtBinaryYdl.Text));

            Localization.OnLanguageChanged += OnLanguageChanged;
            OnLanguageChanged(null, EventArgs.Empty);
        }

        private void SetupUpdateIntervalDataSource() {
            cbxUpdateInterval.DataSource = Enum.GetValues(typeof(UpdateInterval)).Cast<UpdateInterval>().Select(x => new UpdateIntervalDisplay(x)).ToArray();
            cbxUpdateInterval.SelectedItem = preferences.UpdateIntervalDisplay;
        }

        private void OnLanguageChanged(object sender, EventArgs args) {
            Localization.ApplyLocaleText(this, toolTip);
            UpdateCategoryList();

            SetupUpdateIntervalDataSource();

            // Replace common templates in labels.
            this.ForEachControl<Label>(c => {
                c.Text = c.Text.Replace("{ProductName}", Application.ProductName)
                .Replace("{ProductVersion}", Application.ProductVersion.RemoveAfterLast('.'));
            });
        }

        private void UpdateCategoryList() {
            int selectedIndex = lbxCategories.SelectedIndex;
            lbxCategories.Items.Clear();
            foreach (TabPage page in tablessTabControl.TabPages) {
                page.BackColor = BackColor;
                lbxCategories.Items.Add(page);
            }
            lbxCategories.SelectedIndex = selectedIndex;
        }

        private void LbxPresets_SelectedIndexChanged(object sender, EventArgs e) {
            btnPresetEdit.Enabled = lbxPresets.SelectedItem as Preset != null;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e) {
            btnOkay.Enabled = false;

            string ydlPath = Util.GetAbsolutePath(txtBinaryYdl.Text);
            string ffmpegPath = Util.GetAbsolutePath(txtBinaryFfmpeg.Text);

            btnUpdateYoutubeDl.Enabled = !hasConcurrentDownloads && !string.IsNullOrWhiteSpace(txtBinaryYdl.Text) && File.Exists(ydlPath);

            try {
                if (!string.IsNullOrWhiteSpace(txtBinaryYdl.Text) && !File.Exists(ydlPath))
                    return;
                else if (!string.IsNullOrWhiteSpace(txtBinaryFfmpeg.Text) && !File.Exists(ffmpegPath))
                    return;
                else if (!string.IsNullOrWhiteSpace(txtDefaultDownloadArchive.Text) && !File.Exists(Util.GetAbsolutePath(txtDefaultDownloadArchive.Text)))
                    return;
                else if (!string.IsNullOrWhiteSpace(txtDefaultDownloadDirectory.Text) && !Directory.Exists(Util.GetAbsolutePath(txtDefaultDownloadDirectory.Text)))
                    return;

                btnOkay.Enabled = true;
            } catch (Exception) {
                // Provided file paths are incorrect. Leave okay button disabled until user fixes the filepath.
            }
        }

        private void BinaryPaths_TextChanged(object sender, EventArgs e) {
            RequiresRestart = true; // TODO: Reset requires restart if we set paths back to the previous value.
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            if (!preferences.RememberDownloadSettings)
                preferences.StoredDownloadSettings.State.Clear();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void lbxCategories_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbxCategories.SelectedItem == null)
                return;
            TabPage tp = lbxCategories.SelectedItem as TabPage;
            tablessTabControl.SelectedIndex = tablessTabControl.TabPages.IndexOf(tp);
            lblCategory.Text = tp.Text;
        }

        #region Presets

        private void btnPresetAdd_Click(object sender, EventArgs e) {
            using (FormPreset dialog = new FormPreset(preferences)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {

                    Preset preset = dialog.Preset;

                    Logger.Instance.Fine(nameof(FormPreferences), "Opening preset customizer...");
                    using (FormAddDownload presetDialog = new FormAddDownload(preferences, downloadManager, null, preset, true)) {
                        if (presetDialog.ShowDialog(this) == DialogResult.OK) {
                            preset.State = presetDialog.GetState();
                            Logger.Instance.Fine(nameof(FormPreferences), "Setting preset state.");
                        }
                    }


                    UpdatePresets(preset);
                    preferences.Presets.Add(preset);

                    LbxPresets_SelectedIndexChanged(this, new EventArgs());

                    Logger.Instance.Fine(nameof(FormPreferences), "Added preset.");
                }
            }
        }

        private void btnPresetEdit_Click(object sender, EventArgs e) {
            Preset preset = lbxPresets.SelectedItem as Preset;
            if (preset == null)
                return;

            using (FormPreset dialog = new FormPreset(preferences, preset)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {

                    if (dialog.RequestRemoval) {
                        Logger.Instance.Fine(nameof(FormPreferences), "Removing preset.");
                        preferences.Presets.Remove(preset);
                        UpdatePresets(null);
                    } else {
                        Preset prs = dialog.Preset;

                        Logger.Instance.Fine(nameof(FormPreferences), "Opening preset customizer...");
                        using (FormAddDownload presetDialog = new FormAddDownload(preferences, downloadManager, null, prs, true)) {

                            if (presetDialog.ShowDialog(this) == DialogResult.OK) {
                                prs.State = presetDialog.GetState();
                                Logger.Instance.Fine(nameof(FormPreferences), "Setting preset state.");
                            }
                        }

                        preferences.Presets.Replace(preset, prs);
                        UpdatePresets(prs);
                    }
                }
            }
        }

        private void UpdatePresets(Preset preset) {
            Logger.Instance.Fine(nameof(FormPreferences), "Updating default preset.");
            if (preset == null || !preset.IsDefault) {
                if (preferences.Presets.Count > 0 && preferences.Presets.All(p => !p.IsDefault))
                    preferences.Presets.First().IsDefault = true;
            } else {
                foreach (Preset p in preferences.Presets) {
                    if (p == preset)
                        continue;
                    p.IsDefault = false;
                }
            }
            bsPresets.ResetBindings(false);

        }

        #endregion

        #region Browse Events

        private void btnBrowseYdl_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_youtube-dl.title", "Select youtube-dl.exe file..."), "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtBinaryYdl.Text);

            if (filepath != null)
                txtBinaryYdl.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnBrowseFfmpeg_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_ffmpeg.title", "Select ffmpeg.exe file..."), "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtBinaryFfmpeg.Text);

            if (filepath != null)
                txtBinaryFfmpeg.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnDefaultDownloadDirectoryBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFolder(this, Localization.GetString("msg.select_default_download_directory.title", "Select default download directory..."), txtDefaultDownloadDirectory.Text, preferences.UseBasicFolderPicker);

            if (filepath != null)
                txtDefaultDownloadDirectory.Text = filepath;

            DialogResult = DialogResult.None;
        }

        private void btnDefaultDownloadArchiveBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_default_download_archive_file.title", "Select default download archive file..."), "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtDefaultDownloadArchive.Text, false);

            if (filepath != null)
                txtDefaultDownloadArchive.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;

        }

        #endregion

        private void btnUpdateYoutubeDl_Click(object sender, EventArgs e) {
            string path = Util.GetAbsolutePath(txtBinaryYdl.Text);

            if (!File.Exists(path))
                return;


            if (MessageBox.Show(this, Localization.GetString("msg.update_youtube-dl", "Updating youtube-dl can fix download issues.\n\nDo you want to update now?"), Localization.GetString("msg.update_youtube-dl.title", "Update Confirmation"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                using (FormUpdateYoutubeDl dialog = new FormUpdateYoutubeDl(path))
                    dialog.ShowDialog(this);

            }

        }

    }

}