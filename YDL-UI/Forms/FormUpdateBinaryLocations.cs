namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.IO;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;

    public partial class FormUpdateBinaryLocations : Form {
        private readonly Preferences preferences;

        public FormUpdateBinaryLocations(Preferences preferences) {
            InitializeComponent();
            this.preferences = preferences;
        }

        private void FormUpdateBinaryLocations_Load(object sender, EventArgs e) {
            txtYdlPath.DataBindings.Add(nameof(txtYdlPath.Text), preferences.Binaries, nameof(preferences.Binaries.YoutubeDl), false, DataSourceUpdateMode.OnPropertyChanged);
            txtFfmpegPath.DataBindings.Add(nameof(txtFfmpegPath.Text), preferences.Binaries, nameof(preferences.Binaries.Ffmpeg), false, DataSourceUpdateMode.OnPropertyChanged);

            txtYdlPath.TextChanged += txtPath_TextChanged;
            txtFfmpegPath.TextChanged += txtPath_TextChanged;
            txtPath_TextChanged(this, new EventArgs());

            Localization.ApplyLocaleText(this);
            lblNote.Text = lblNote.Text.Replace("{ProductName}", Application.ProductName);
        }

        private void txtPath_TextChanged(object sender, EventArgs e) {
            btnOkay.Enabled = File.Exists(txtYdlPath.Text) && File.Exists(txtFfmpegPath.Text);
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnBrowseYdl_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_youtube-dl.title", "Select youtube-dl.exe file..."), "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtYdlPath.Text);

            if (filepath != null)
                txtYdlPath.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnBrowseFfmpeg_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, Localization.GetString("msg.select_ffmpeg.title", "Select ffmpeg.exe file..."), "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtFfmpegPath.Text);

            if (filepath != null)
                txtFfmpegPath.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

    }

}