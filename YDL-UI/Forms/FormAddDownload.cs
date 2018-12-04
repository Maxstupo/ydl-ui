using Maxstupo.YdlUi.Controls;
using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormAddDownload : Form {
        private readonly UiState uiState = new UiState();
        private readonly Preferences preferences;

        private Preset preset;

        private bool IsEditMode { get; }

        public Download Download { get; private set; }

        private bool BasicMode { get => cbBasicMode.Checked; }

        private BasicAddDownloadPanel basicAddDownloadPanel;

        private Size oldMaxSize, oldMinSize;

        public FormAddDownload(Preferences preferences, string url, Preset preset, bool isEditMode) {
            InitializeComponent();
            InitializeBasicAdvancedModes(preferences.BasicMode);

            this.preferences = preferences;

            this.preset = preset;
            this.IsEditMode = isEditMode;

            if (IsEditMode) {

                Text = $"Customize Preset - {preset.Name}";

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
            txtDownloadArchive.BindEnabledTo(cbDownloadArchive);
            btnDownloadArchiveBrowse.BindEnabledTo(cbDownloadArchive);


            // Preload data bindings for tabs. (XXX: Really need to find a better way of doing this)
            tabControl.PreloadTabs();

            UpdateDownloadDirectory();
            UpdateDownloadArchive();


            if (IsEditMode) {
                ApplyState(preset);
            } else {
                cbxPreset.DataSource = preferences.Presets;
                cbxPreset.DisplayMember = nameof(Preset.DisplayText);


                if (preferences.Presets.Count > 0) {
                    cbxPreset.SelectedItem = preferences.Presets.Where(p => p.IsDefault).First();
                } else {
                    cbxPreset.Visible = false;
                }

                txtUrl.TextChanged += TxtUrl_TextChanged;
                TxtUrl_TextChanged(this, new EventArgs());
            }

        }

        private void SelectMatchingPreset(string url) {
            if (IsEditMode)
                return;

            Preset preset = preferences.Presets.Where(p => !string.IsNullOrWhiteSpace(p.MatchUrl) && Regex.IsMatch(url, p.MatchUrl)).FirstOrDefault();
            if (preset != null) {
                cbxPreset.SelectedItem = preset;
            }
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
            oldMaxSize = MaximumSize;
            oldMinSize = MinimumSize;

            basicAddDownloadPanel = new BasicAddDownloadPanel {
                Location = new Point(12, 67),
                Visible = false,
                TabIndex = 11
            };
            Controls.Add(basicAddDownloadPanel);

            cbBasicMode.Checked = basicMode;
        }

        private void cbBasicMode_CheckedChanged(object sender, EventArgs e) {
            txtFilenameTemplate.Visible = cbFilenameTemplate.Visible = !BasicMode;
            btnDownloadArchiveBrowse.Visible = cbDownloadArchive.Visible = txtDownloadArchive.Visible = !BasicMode;

            FormBorderStyle = BasicMode ? FormBorderStyle.FixedSingle : FormBorderStyle.Sizable;

            if (BasicMode) {
                cbDownloadArchive.Checked = false;
                cbFilenameTemplate.Checked = false;

                Size = MinimumSize = MaximumSize = new Size(basicAddDownloadPanel.Size.Width + 33, 280);
                WindowState = FormWindowState.Normal;

            } else {
                MaximumSize = oldMaxSize;
                Size = MinimumSize = oldMinSize;
            }

         
            MaximizeBox = !BasicMode;

            tabControl.Visible = !BasicMode;
            basicAddDownloadPanel.Visible = BasicMode;

            UpdateStateBetweenModes();

        }

        #endregion

        private Download CreateDownload() {
            if (IsEditMode)
                return null;
            Download download = new Download(txtUrl.Text, txtDownloadDirectory.Text) {
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

            if (!BasicMode) {
                tabQuality.SetArguments(arguments);
                tabVideoSelection1.SetArguments(arguments);
                tabPostProcessing.SetArguments(arguments);
                tabWorkarounds.SetArguments(arguments);
            } else {
                basicAddDownloadPanel.SetArguments(arguments);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Download = CreateDownload();
            DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }


        private void btnBrowseDownloadDirectory_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFolder("Select download directory...", txtDownloadDirectory.Text);
            if (filepath != null)
                txtDownloadDirectory.Text = filepath;
        }

        private void btnDownloadArchiveBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select download archive...", "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtDownloadArchive.Text, false);
            if (filepath != null)
                txtDownloadArchive.Text = filepath;
        }

        private void cbxPreset_SelectedIndexChanged(object sender, EventArgs e) {
            if (IsEditMode)
                return;
            Preset preset = cbxPreset.GetSelectedValue<Preset>();
            if (preset != null) {
                Logger.Instance.Debug(nameof(FormAddDownload), $"Applying preset '{preset.Name}'");
                ApplyState(preset);
                UpdateDownloadDirectory(false);
                UpdateDownloadArchive(false);
            }
        }

        private void UpdateStateBetweenModes() {
            if (BasicMode) {
                basicAddDownloadPanel.cbWriteThumbnail.Checked = tabQuality.cbWriteThumbnail.Checked;
                basicAddDownloadPanel.cbRestrictFilenames.Checked = tabQuality.cbRestrictFilenames.Checked;
                basicAddDownloadPanel.cbNoOverwrites.Checked = tabQuality.cbNoOverwrites.Checked;

                basicAddDownloadPanel.cbAudioOnly.Checked = tabPostProcessing.cbAudioOnly.Checked;
                basicAddDownloadPanel.cbxAudioOnly.SelectedIndex = tabPostProcessing.cbxAudioOnly.SelectedIndex;

                basicAddDownloadPanel.videoQualitySelector1.Set(tabQuality.videoQualitySelector);
                basicAddDownloadPanel.frameRateSelector1.Set(tabQuality.frameRateSelector);
            } else {

                tabQuality.cbWriteThumbnail.Checked = basicAddDownloadPanel.cbWriteThumbnail.Checked;
                tabQuality.cbRestrictFilenames.Checked = basicAddDownloadPanel.cbRestrictFilenames.Checked;
                tabQuality.cbNoOverwrites.Checked = basicAddDownloadPanel.cbNoOverwrites.Checked;

                tabPostProcessing.cbAudioOnly.Checked = basicAddDownloadPanel.cbAudioOnly.Checked;
                basicAddDownloadPanel.cbxAudioOnly.SelectedIndex = tabPostProcessing.cbxAudioOnly.SelectedIndex;

                tabQuality.videoQualitySelector.Set(basicAddDownloadPanel.videoQualitySelector1);
                tabQuality.frameRateSelector.Set(basicAddDownloadPanel.frameRateSelector1);

            }
        }

        public List<ControlState> GetState() {
            return uiState.CreateFrom(this, nameof(txtUrl), nameof(cbxPreset));
        }

        public void ApplyState(Preset preset) {
            Console.WriteLine(IsEditMode);
            uiState.Apply(this, preset.State, nameof(txtUrl), nameof(cbxPreset));
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
