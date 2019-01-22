using Maxstupo.YdlUi.YoutubeDL;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormDownloadLog : Form {

        private Download download;

        public FormDownloadLog(Download download) {
            InitializeComponent();
            this.download = download;

            download.PropertyChanged += Download_PropertyChanged;
            txtLog.Text = download.Log;
        }

        private void FormDownloadLog_Load(object sender, EventArgs e) {

        }

        private void FormDownloadLog_FormClosing(object sender, FormClosingEventArgs e) {
            download.PropertyChanged -= Download_PropertyChanged;
        }

        private void Download_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(Download.Log))
                txtLog.Text = download.Log;
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void txtLog_TextChanged(object sender, EventArgs e) {
            if (!cbAutoScroll.Checked)
                return;
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "Are you sure you want to clear this download log?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            download.Log = string.Empty;
            DialogResult = DialogResult.None;
        }
    }
}
