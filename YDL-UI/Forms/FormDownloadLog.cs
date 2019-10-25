using Maxstupo.YdlUi.Utility;
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

            txtLog.Text = download.Log;
            download.LogUpdate += Download_LogUpdate;
        }

        private void FormDownloadLog_Load(object sender, EventArgs e) {
            Localization.ApplyLocaleText(this);
        }

        private void FormDownloadLog_FormClosing(object sender, FormClosingEventArgs e) {
            download.LogUpdate -= Download_LogUpdate;
        }

        private void Download_LogUpdate(object sender, string e) {
            txtLog.AppendText(e);
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.None;

            if (MessageBox.Show(this, Localization.GetString("msg.confirm_clear_download_log", "Are you sure you want to clear this download log?"), Localization.GetString("msg.confirm_clear_download_log.title", "Are you sure?"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            download.Log = string.Empty;
            txtLog.Text = string.Empty;
        }
    }
}
