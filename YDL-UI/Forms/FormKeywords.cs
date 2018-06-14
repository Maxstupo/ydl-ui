using Maxstupo.YdlUi.YoutubeDL;
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
    public partial class FormKeywords : Form {
        private List<Keyword> keywords = new List<Keyword>();


        public Keyword SelectedKeyword { get { return lbxKeywords.SelectedItem as Keyword; } }


        public FormKeywords() {
            InitializeComponent();
        }


        private void FormKeywords_Load(object sender, EventArgs e) {
            lbxKeywords.DisplayMember = "Formatted";
            keywords = YoutubeDLApi.GetKeywords().ToList();

            btnInsert.Enabled = lbxKeywords.SelectedIndex >= 0;

            UpdateList();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void lbxKeywords_SelectedIndexChanged(object sender, EventArgs e) {
            btnInsert.Enabled = lbxKeywords.SelectedIndex >= 0;
        }

        private void UpdateList(string query = null) {

            lbxKeywords.Items.Clear();
            foreach (Keyword keyword in keywords) {
                if (string.IsNullOrWhiteSpace(query) || (keyword.Value.ToLower().Contains(query) || keyword.Description.ToLower().Contains(query)))
                    lbxKeywords.Items.Add(keyword);
            }

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e) {
            string query = txtSearchBox.Text.ToLower();
            UpdateList(query);
        }

        private void txtSearchBox_Enter(object sender, EventArgs e) {
            txtSearchBox.SelectAll();
        }

        private void lbxKeywords_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbxKeywords.SelectedIndex >= 0)
                btnInsert.PerformClick();
        }
    }
}
