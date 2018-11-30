using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormPreferences : Form {

        private Preferences preferences;

        public bool RequiresRestart { get; private set; } = false;

        public FormPreferences(DownloadManager downloadManager, Preferences preferences, string preferencesLocation = null) {
            InitializeComponent();
            this.preferences = preferences;

            if (string.IsNullOrWhiteSpace(preferencesLocation)) {
                llblPreferencesLocation.Visible = false;
            } else {
                llblPreferencesLocation.Tag = preferencesLocation;
                toolTip.SetToolTip(llblPreferencesLocation, preferencesLocation);
            }
        }

        private void FormPreferences_Load(object sender, EventArgs e) {

            btnUpdateYdl.BindEnabledTo(txtYdl, filepath => !string.IsNullOrWhiteSpace(filepath) && File.Exists(filepath));

            // Bind controls to preferences object.
            txtYdl.DataBindings.Add(nameof(txtYdl.Text), preferences.Binaries, nameof(preferences.Binaries.YoutubeDl), false, DataSourceUpdateMode.OnPropertyChanged);
            txtFfmpeg.DataBindings.Add(nameof(txtFfmpeg.Text), preferences.Binaries, nameof(preferences.Binaries.Ffmpeg), false, DataSourceUpdateMode.OnPropertyChanged);
            nudMaxConcurrentDownloads.DataBindings.Add(nameof(nudMaxConcurrentDownloads.Value), preferences, nameof(preferences.MaxConcurrentDownloads), false, DataSourceUpdateMode.OnPropertyChanged);
            cbPromptOnClose.DataBindings.Add(nameof(cbPromptOnClose.Checked), preferences, nameof(preferences.PromptDownloadingOnClose), false, DataSourceUpdateMode.OnPropertyChanged);
            cbxCheckForUpdates.DataBindings.Add(nameof(cbxCheckForUpdates.Checked), preferences, nameof(preferences.CheckForUpdates), false, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultDownloadArchive.DataBindings.Add(nameof(txtDefaultDownloadArchive.Text), preferences, nameof(preferences.DefaultDownloadArchive), false, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultDownloadDirectory.DataBindings.Add(nameof(txtDefaultDownloadDirectory.Text), preferences, nameof(preferences.DefaultDownloadDirectory), false, DataSourceUpdateMode.OnPropertyChanged);
            cbBasicMode.DataBindings.Add(nameof(cbBasicMode.Checked), preferences, nameof(preferences.BasicMode), false, DataSourceUpdateMode.OnPropertyChanged);

            // If our binary paths change, we need to restart YDL-UI
            txtYdl.TextChanged += BinaryPaths_TextChanged;
            txtFfmpeg.TextChanged += BinaryPaths_TextChanged;

            // Ensure filepaths are valid.
            this.ForEachControl<TextBox>(control => control.TextChanged += TextBoxes_TextChanged);

            // Hide notes about binaries when running a portable build, as they are required.
#if PORTABLE
            lblNote1.Visible = false;
#endif
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e) {
            btnOkay.Enabled = false;

            if (!string.IsNullOrWhiteSpace(txtYdl.Text) && !File.Exists(txtYdl.Text))
                return;
            else if (!string.IsNullOrWhiteSpace(txtFfmpeg.Text) && !File.Exists(txtFfmpeg.Text))
                return;
            else if (!string.IsNullOrWhiteSpace(txtDefaultDownloadArchive.Text) && !File.Exists(txtDefaultDownloadArchive.Text))
                return;
            else if (!string.IsNullOrWhiteSpace(txtDefaultDownloadDirectory.Text) && !Directory.Exists(txtDefaultDownloadDirectory.Text))
                return;

            btnOkay.Enabled = true;
        }

        private void BinaryPaths_TextChanged(object sender, EventArgs e) {
            RequiresRestart = true; // TODO: Reset requires restart if we set paths back to the previous value.
        }

        private void btnBrowseYdl_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select youtube-dl.exe file...", "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtYdl.Text);

            if (filepath != null)
                txtYdl.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnBrowseFfmpeg_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select ffmpeg.exe file...", "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtFfmpeg.Text);

            if (filepath != null)
                txtFfmpeg.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnDefaultDownloadArchiveBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select default download archive file...", "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtDefaultDownloadArchive.Text, false);

            if (filepath != null)
                txtDefaultDownloadArchive.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;

        }

        private void btnDefaultDownloadDirectoryBrowse_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFolder("Select default download directory...", txtDefaultDownloadArchive.Text);

            if (filepath != null)
                txtDefaultDownloadDirectory.Text = filepath;

            DialogResult = DialogResult.None;
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void llblPreferencesLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(llblPreferencesLocation.Tag as string);
        }

        private void btnUpdateYdl_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, $"Updating the externally defined youtube-dl application can potentially break {Application.ProductName}.\n\nDo you wish to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                btnUpdateYdl.Enabled = false;

                ExecutableProcess process = new ExecutableProcess(txtYdl.Text, "-U", null);
                process.OnExited += (s, a) => {
                    MessageBox.Show(this, "Youtube-Dl Update Completed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdateYdl.Enabled = true;
                };
                process.Start();


            }
            DialogResult = DialogResult.None;
        }


    }
}
