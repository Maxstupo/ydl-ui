using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormUpdateBinaryLocations : Form {
        private Preferences preferences;

        public FormUpdateBinaryLocations(Preferences preferences) {
            InitializeComponent();
            this.preferences = preferences;
        }

        private void FormUpdateBinaryLocations_Load(object sender, EventArgs e) {
            lblNote.Text = lblNote.Text.Replace("{ProductName}", Application.ProductName);

            txtYdlPath.DataBindings.Add(nameof(txtYdlPath.Text), preferences.Binaries, nameof(preferences.Binaries.YoutubeDl), false, DataSourceUpdateMode.OnPropertyChanged);
            txtFfmpegPath.DataBindings.Add(nameof(txtFfmpegPath.Text), preferences.Binaries, nameof(preferences.Binaries.Ffmpeg), false, DataSourceUpdateMode.OnPropertyChanged);

            txtYdlPath.TextChanged += txtPath_TextChanged;
            txtFfmpegPath.TextChanged += txtPath_TextChanged;
            txtPath_TextChanged(this, new EventArgs());
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
            string filepath = GuiUtil.SelectFile(this, "Select youtube-dl.exe file...", "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtYdlPath.Text);

            if (filepath != null)
                txtYdlPath.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }

        private void btnBrowseFfmpeg_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select ffmpeg.exe file...", "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*", txtFfmpegPath.Text);

            if (filepath != null)
                txtFfmpegPath.Text = Util.GetRelativePath(filepath);

            DialogResult = DialogResult.None;
        }        
    }
}
