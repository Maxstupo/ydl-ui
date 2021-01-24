namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Controls;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL;
    using Maxstupo.YdlUi.YoutubeDL.Model;

    public partial class FormAddDownload : Form {
        private readonly UiState uiState = new UiState();
        private readonly Preferences preferences;
        private readonly DownloadManager downloadManager;

        private Preset preset;

        private bool IsPresetEditMode { get; }
        private bool IsSilent { get; }

        public Download Download { get; private set; }

        private bool BasicMode { get => cbBasicMode.Checked; }

        private BasicAddDownloadPanel basicAddDownloadPanel;

        private Size previousSizeAdvancedMode;
        private Size minimumSizeAdvancedMode;
        private Size previousSizeBasicMode;

        public FormAddDownload(Preferences preferences, DownloadManager downloadManager, string url, Preset preset, bool isPresetEditMode, bool isSilent = false) {
            InitializeComponent();
            InitializeBasicAdvancedModes(preferences.BasicMode);

            this.preferences = preferences;
            this.downloadManager = downloadManager;
            this.preset = preset;
            this.IsPresetEditMode = isPresetEditMode;
            this.IsSilent = isSilent;

            if (IsPresetEditMode) {

                Text = $"Customize Preset - {preset.Name}";
                btnAdd.Tag = "add.preset";
                btnAdd.Text = "Okay";
                txtUrl.Enabled = false;
                lblUrl.Enabled = false;
                cbxPreset.Visible = false;

                // Allow users to set download directory to use the global default download directory in presets, by setting textbox empty.
                txtDownloadDirectory.ReadOnly = false;
                txtDownloadArchive.ReadOnly = false;
            } else {
                txtUrl.Text = url ?? string.Empty;
            }

        }

        private void FormAddDownload_Load(object sender, EventArgs e) {
            panelActions.BackColor = Color.FromArgb(211, 211, 211);
            BackColor = Color.FromArgb(238, 238, 238);

            txtFilenameTemplate.BindEnabledTo(cbFilenameTemplate);
            btnInsertKeyword.BindEnabledTo(cbFilenameTemplate);
            txtDownloadArchive.BindEnabledTo(cbDownloadArchive);
            btnDownloadArchiveBrowse.BindEnabledTo(cbDownloadArchive);

            txtUrl.TextChanged += tabControl_AttemptPreviewUpdate;
            txtDownloadDirectory.TextChanged += tabControl_AttemptPreviewUpdate;

            cbFilenameTemplate.CheckStateChanged += tabControl_AttemptPreviewUpdate;
            txtFilenameTemplate.TextChanged += tabControl_AttemptPreviewUpdate;

            cbDownloadArchive.CheckStateChanged += tabControl_AttemptPreviewUpdate;
            txtDownloadArchive.TextChanged += tabControl_AttemptPreviewUpdate;

            // Preload data bindings for tabs. (XXX: Really need to find a better way of doing this)
            tabControl.PreloadTabs();

            UpdateDownloadDirectory();
            UpdateDownloadArchive();


            if (IsPresetEditMode) {
                ApplyState(preset);
            } else {
                cbxPreset.DisplayMember = nameof(Preset.DisplayText);

                // If we have a previous remembered options, and the setting is enabled, prepend it to the preset list.
                if (preferences.RememberDownloadSettings && preferences.StoredDownloadSettings.State.Count > 0) {
                    List<Preset> presets = new List<Preset>(preferences.Presets);

                    preferences.StoredDownloadSettings.MatchUrl = null;
                    preferences.StoredDownloadSettings.IsDefault = false;
                    presets.Insert(0, preferences.StoredDownloadSettings);

                    cbxPreset.DataSource = presets;
                    cbxPreset.SelectedItem = preferences.StoredDownloadSettings;

                } else { // else function like before.
                    cbxPreset.DataSource = preferences.Presets;

                    if (preferences.Presets.Count > 0) {
                        cbxPreset.SelectedItem = preferences.Presets.Where(p => p.IsDefault).First();
                    } else {
                        cbxPreset.Visible = false;
                    }
                }

                // Ensure preset dropdown is wide enough.
                int maxPresetTextWidth = cbxPreset.Size.Width;
                foreach (Preset item in cbxPreset.Items.Cast<Preset>())
                    maxPresetTextWidth = Math.Max(maxPresetTextWidth, TextRenderer.MeasureText(item.DisplayText, cbxPreset.Font).Width);

                // +20 width for "dropdown arrow"
                cbxPreset.MaximumSize = new Size(Math.Max(maxPresetTextWidth + 20, cbxPreset.MinimumSize.Width), cbxPreset.MaximumSize.Height);
                cbxPreset.DropDownWidth = maxPresetTextWidth;

                txtUrl.TextChanged += TxtUrl_TextChanged;
                TxtUrl_TextChanged(this, new EventArgs());
            }


            Localization.RegisterTooltip(quality, quality.toolTip);
            Localization.RegisterTooltip(quality.frameRateSelector, quality.frameRateSelector.toolTip);
            Localization.RegisterTooltip(quality.videoQualitySelector, quality.videoQualitySelector.toolTip);

            Localization.RegisterTooltip(postProcessing, postProcessing.toolTip);
            Localization.RegisterTooltip(workarounds, workarounds.toolTip);
            Localization.RegisterTooltip(videoSelection, videoSelection.toolTip);

            Localization.ApplyLocaleText(this, toolTip);

            if (IsPresetEditMode) {
                Text = Localization.GetString($"{Tag}.preset", "Customize Preset - {PresetName}");
                Text = Text.Replace("{PresetName}", preset.Name);
            }

            if (IsSilent) {
                BeginInvoke((Action<Button>) (btn => {
                    btn.PerformClick();
                }), btnAdd);
            } else {
                BeginInvoke((Action) delegate {
                    txtUrl.Focus();
                });
            }
        }

        private void SelectMatchingPreset(string url) {
            if (IsPresetEditMode)
                return;

            Preset preset = Preset.GetMatchingPreset(preferences.Presets, url);
            if (preset != null)
                cbxPreset.SelectedItem = preset;
        }

        private void TxtUrl_TextChanged(object sender, EventArgs e) {
            btnAdd.Enabled = Util.IsValidUrl(txtUrl.Text) && Directory.Exists(txtDownloadDirectory.Text);

            if (btnAdd.Enabled)
                SelectMatchingPreset(txtUrl.Text);
        }

        private void UpdateDownloadArchive(bool setAlways = true) {
            if (!setAlways && !string.IsNullOrWhiteSpace(txtDownloadArchive.Text))
                return;

            // Set the default download archive location if one is set in the preferences.
            if (!string.IsNullOrWhiteSpace(preferences.DefaultDownloadArchive)) {
                txtDownloadArchive.Text = preferences.DefaultDownloadArchive;
                cbDownloadArchive.Checked = true;
            }
        }

        private void UpdateDownloadDirectory(bool setAlways = true) {
            if (!setAlways && Directory.Exists(txtDownloadDirectory.Text))
                return;

            // Set the default download directory from preferences or use the OS default videos library directory.
            if (!string.IsNullOrWhiteSpace(preferences.DefaultDownloadDirectory) && Directory.Exists(preferences.DefaultDownloadDirectory)) {
                txtDownloadDirectory.Text = preferences.DefaultDownloadDirectory;
            } else {
                try {
                    txtDownloadDirectory.Text = Util.GetMyVideosPath();
                } catch (Exception) { // Exception if GetMyVideosPath() isn't supported.
                                      // TODO: Add fallback download directory
                }
            }
        }

        private void FormAddDownload_FormClosing(object sender, FormClosingEventArgs e) {
            cbxPreset.DataSource = null;
        }


        #region Basic/Advanced Mode Logic

        private void InitializeBasicAdvancedModes(bool basicMode) {
            previousSizeAdvancedMode = minimumSizeAdvancedMode = Size;
            previousSizeBasicMode = new Size(650, 280);


            basicAddDownloadPanel = new BasicAddDownloadPanel {
                Location = new Point(12, 67),
                Visible = false,
                TabIndex = 11,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Name = "basicAddDownloadPanel"
            };

            Controls.Add(basicAddDownloadPanel);
            basicAddDownloadPanel.Size = new Size(774, basicAddDownloadPanel.Height);


            cbBasicMode.Checked = basicMode;
        }

        private void cbBasicMode_CheckedChanged(object sender, EventArgs e) {
            txtFilenameTemplate.Visible = btnInsertKeyword.Visible = cbFilenameTemplate.Visible = !BasicMode;
            btnDownloadArchiveBrowse.Visible = cbDownloadArchive.Visible = txtDownloadArchive.Visible = !BasicMode;

            if (BasicMode) {
                cbDownloadArchive.Checked = false;
                cbFilenameTemplate.Checked = false;


                previousSizeAdvancedMode = Size;

                Location = new Point(Location.X + ((Size.Width - previousSizeBasicMode.Width) / 2), Location.Y);

                WindowState = FormWindowState.Normal;

                MinimumSize = new Size(635, previousSizeBasicMode.Height);
                MaximumSize = new Size(9999, previousSizeBasicMode.Height);

                Size = previousSizeBasicMode;


            } else {

                Location = new Point(Location.X - ((previousSizeAdvancedMode.Width - Size.Width) / 2), Location.Y);

                previousSizeBasicMode = Size;

                MaximumSize = Size.Empty;
                MinimumSize = minimumSizeAdvancedMode;
                Size = previousSizeAdvancedMode;
            }


            MaximizeBox = !BasicMode;

            tabControl.Visible = !BasicMode;
            basicAddDownloadPanel.Visible = BasicMode;

            UpdateStateBetweenModes();

        }

        #endregion

        public Download CreateDownload(string overrideUrl = null) {
            if (IsPresetEditMode)
                return null;
            Download download = new Download(overrideUrl ?? txtUrl.Text, Util.GetAbsolutePath(txtDownloadDirectory.Text)) {
                Status = cbImmediateStart.Checked ? DownloadStatus.Queued : DownloadStatus.Waiting
            };
            SetArguments(download.Arguments);
            return download;
        }

        private void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;
            arguments.FileSystem.OutputTemplate = txtFilenameTemplate.GetText();
            arguments.VideoSelection.DownloadArchive = txtDownloadArchive.GetText();
            if (arguments.VideoSelection.DownloadArchive != null)
                arguments.VideoSelection.DownloadArchive = Util.GetAbsolutePath(arguments.VideoSelection.DownloadArchive);


            if (!BasicMode) {
                quality.SetArguments(arguments);
                videoSelection.SetArguments(arguments);
                postProcessing.SetArguments(arguments);
                workarounds.SetArguments(arguments);
            } else {
                basicAddDownloadPanel.SetArguments(arguments);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Download = CreateDownload();
            RememberState();
            DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }


        private void btnBrowseDownloadDirectory_Click(object sender, EventArgs e) {

            string filepath = GuiUtil.SelectFolder(this, Localization.GetString("msg.select_download_directory.title", "Select download directory..."), txtDownloadDirectory.Text, preferences.UseBasicFolderPicker);
            if (filepath != null)
                txtDownloadDirectory.Text = filepath;
        }

        private void btnDownloadArchiveBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_download_archive_file.title", "Select download archive..."), "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtDownloadArchive.Text, false);
            if (filepath != null)
                txtDownloadArchive.Text = filepath;
        }

        private void btnInsertKeyword_Click(object sender, EventArgs e) {
            txtFilenameTemplate.ShowKeywordDialog();
        }

        private void cbxPreset_SelectedIndexChanged(object sender, EventArgs e) {
            if (IsPresetEditMode)
                return;
            Preset preset = cbxPreset.GetSelectedValue<Preset>();
            if (preset != null) {
                Logger.Instance.Debug(nameof(FormAddDownload), $"Applying preset '{preset.Name}'");
                ApplyState(preset);
                UpdateDownloadDirectory(false);
                UpdateDownloadArchive(false);
            }
        }

        private void tabControl_AttemptPreviewUpdate(object sender, EventArgs e) {
            int tpCmdIndex = tabControl.TabPages.IndexOf(tpCommandPreview);
            if (tabControl.SelectedIndex == tpCmdIndex)
                UpdateCommandPreview();
        }

        private void UpdateCommandPreview() {
            if (txtUrl.Text.Length == 0) {
                txtCommandPreview.Text = Localization.GetString("download_dialog.preview.no_url", "<Waiting for URL>");
            } else {
                YdlArguments args = new YdlArguments { Url = txtUrl.Text };
                SetArguments(args);

                txtCommandPreview.Text = $"\"{downloadManager.YdlPath}\" {Download.ArgumentSerializer.Serialize(args)}";
            }
        }

        private void UpdateStateBetweenModes() {
            if (BasicMode) {
                basicAddDownloadPanel.cbWriteThumbnail.Checked = quality.cbWriteThumbnail.Checked;
                basicAddDownloadPanel.cbRestrictFilenames.Checked = quality.cbRestrictFilenames.Checked;
                basicAddDownloadPanel.cbNoOverwrites.Checked = quality.cbNoOverwrites.Checked;

                basicAddDownloadPanel.cbAudioOnly.Checked = postProcessing.cbAudioOnly.Checked;
                basicAddDownloadPanel.cbxAudioOnly.SelectedIndex = postProcessing.cbxAudioOnly.SelectedIndex;

                basicAddDownloadPanel.videoQualitySelector.Set(quality.videoQualitySelector);
                basicAddDownloadPanel.frameRateSelector.Set(quality.frameRateSelector);
            } else {

                quality.cbWriteThumbnail.Checked = basicAddDownloadPanel.cbWriteThumbnail.Checked;
                quality.cbRestrictFilenames.Checked = basicAddDownloadPanel.cbRestrictFilenames.Checked;
                quality.cbNoOverwrites.Checked = basicAddDownloadPanel.cbNoOverwrites.Checked;

                postProcessing.cbAudioOnly.Checked = basicAddDownloadPanel.cbAudioOnly.Checked;
                basicAddDownloadPanel.cbxAudioOnly.SelectedIndex = postProcessing.cbxAudioOnly.SelectedIndex;

                quality.videoQualitySelector.Set(basicAddDownloadPanel.videoQualitySelector);
                quality.frameRateSelector.Set(basicAddDownloadPanel.frameRateSelector);

            }
        }

        public List<ControlState> GetState() {
            return uiState.CreateFrom(this, nameof(txtUrl), nameof(cbxPreset));
        }

        public void ApplyState(Preset preset) {
            uiState.Apply(this, preset.State, nameof(txtUrl), nameof(cbxPreset));
        }

        public void RememberState() {
            if (!IsPresetEditMode && preferences.RememberDownloadSettings)
                preferences.StoredDownloadSettings.State = uiState.CreateFrom(this, nameof(txtUrl), nameof(cbxPreset));
        }


        #region Performance Optimization

        private void FormAddDownload_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }

        private void FormAddDownload_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout();
        }

        #endregion

    }

}