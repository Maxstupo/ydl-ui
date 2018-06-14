using Maxstupo.YdlUi.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {


    public partial class FormUrlsEditor : Form {

        private BindingList<string> list = new BindingList<string>();


        public string UrlList {
            get {
                StringBuilder sb = new StringBuilder();
                foreach (string url in list)
                    sb.Append(url).Append(';');
                if (sb.Length > 0 && list.Count > 0)
                    sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
        }


        public FormUrlsEditor(string input = null) {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(input)) {
                foreach (string token in input.Split(new string[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries)) {
                    if (Utils.IsValidUrl(token))
                        list.Add(token);
                }
            }
        }

        private void FormUrlsEditor_Load(object sender, EventArgs e) {
            lbxUrls.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (FormPromptUrl dialog = new FormPromptUrl("Add URL...")) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    list.Add(dialog.Url);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lbxUrls.SelectedItem is string item)
                list.Remove(item);
        }



        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            btnAdd.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            btnDelete.PerformClick();
        }

        private void lbxUrls_SelectedValueChanged(object sender, EventArgs e) {
            btnDelete.Enabled = (lbxUrls.SelectedItem as string) != null;
            deleteToolStripMenuItem.Enabled = btnDelete.Enabled;
        }
        
    }

}
