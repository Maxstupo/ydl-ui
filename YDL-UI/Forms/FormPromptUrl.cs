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
    public partial class FormPromptUrl : Form {

        public string Url { get { return txtUrl.Text; } }

        public FormPromptUrl(string title) {
            InitializeComponent();
            Text = title;
        }

        private void FormPromptUrl_Load(object sender, EventArgs e) {
            txtUrl.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }



        private void txtUrl_TextChanged(object sender, EventArgs e) {
            btnConfirm.Enabled = txtUrl.IsValidUrl();
        }
    }
}
