using Maxstupo.YdlUi.Controls;
using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormAddDownload : Form {
        private readonly Preferences preferences;

        public Download Download { get; private set; }

        private bool BasicMode { get => cbBasicMode.Checked; }

        private BasicAddDownloadPanel basicAddDownloadPanel;

        private Size oldMaxSize, oldMinSize, oldSize;

        public FormAddDownload(Preferences preferences, string url = null) {
            InitializeComponent();
            InitializeBasicAdvancedModes(preferences.BasicMode);

            this.preferences = preferences;

            txtUrl.TextChanged += delegate {
                btnAdd.Enabled = Util.IsValidUrl(txtUrl.Text);
            };
            txtUrl.Text = " "; // Used to trigger TextChanged event.
            txtUrl.Text = url ?? string.Empty;
            
        }

        private void FormAddDownload_Load(object sender, EventArgs e) {

            txtFilenameTemplate.BindEnabledTo(cbFilenameTemplate);
            txtDownloadArchive.BindEnabledTo(cbDownloadArchive);
            btnDownloadArchiveBrowse.BindEnabledTo(cbDownloadArchive);

            // Set the default download directory from preferences or use the OS default videos library directory.
            if (!string.IsNullOrWhiteSpace(preferences.DefaultDownloadDirectory)) {
                txtDownloadDirectory.Text = preferences.DefaultDownloadDirectory;
            } else {
                try {
                    txtDownloadDirectory.Text = Util.GetMyVideosPath();
                } catch (Exception) { // Exception if GetMyVideosPath() isn't supported.
                                      // TODO: Add fallback download directory
                }
            }

            // Set the default download archive location if one is set in the preferences.
            if (!string.IsNullOrWhiteSpace(preferences.DefaultDownloadArchive)) {
                txtDownloadArchive.Text = preferences.DefaultDownloadArchive;
                cbDownloadArchive.Checked = true;
            }

            // Preload data bindings for tabs. (XXX: Really need to find a better way of doing this)
            tabControl.PreloadTabs();

        }

        private void FormAddDownload_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private Download CreateDownload() {
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

        #region Basic/Advanced Mode Logic

        private void InitializeBasicAdvancedModes(bool basicMode) {
            oldMaxSize = MaximumSize;
            oldMinSize = MinimumSize;
            oldSize = Size;

            basicAddDownloadPanel = new BasicAddDownloadPanel {
                Location = new Point(12, 67),
                Visible = false
            };
            Controls.Add(basicAddDownloadPanel);

            cbBasicMode.Checked = basicMode;
        }

        private void cbBasicMode_CheckedChanged(object sender, EventArgs e) {
            txtFilenameTemplate.Visible = cbFilenameTemplate.Visible = !BasicMode;
            btnDownloadArchiveBrowse.Visible = cbDownloadArchive.Visible = txtDownloadArchive.Visible = !BasicMode;

            if (BasicMode) {
                cbDownloadArchive.Checked = false;
                cbFilenameTemplate.Checked = false;

                oldSize = Size;
                Size = MinimumSize = MaximumSize = new Size(basicAddDownloadPanel.Size.Width + 33, 280);

            } else {
                MaximumSize = oldMaxSize;
                Size = oldSize;
                MinimumSize = oldMinSize;

            }

            tabControl.Visible = !BasicMode;
            basicAddDownloadPanel.Visible = BasicMode;
        }

        #endregion

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
            string filepath = GuiUtil.SelectFile(this, "Select download archive...", "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtDownloadArchive.Text,false);
            if (filepath != null)
                txtDownloadArchive.Text = filepath;
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
