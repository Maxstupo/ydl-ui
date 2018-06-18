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
    public partial class FormOptions : Form {
        public FormOptions() {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e) {
            txtDefaultPresetLocation.BindEnableTo(cbDefaultPresetLocation);
            btnBrowsePresetLocation.BindEnableTo(cbDefaultPresetLocation);

            cbPromptSaveOnClose.Checked = Properties.Settings.Default.PromptSaveOnClose;

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DefaultPresetLocation)) {
                cbDefaultPresetLocation.Checked = true;
                txtDefaultPresetLocation.Text = Properties.Settings.Default.DefaultPresetLocation;
            }

            txtDefaultPresetLocation.BindValueTo(v => Properties.Settings.Default.DefaultPresetLocation = v, cbDefaultPresetLocation);
            cbPromptSaveOnClose.BindValueTo(v => Properties.Settings.Default.PromptSaveOnClose = v);
        }

        private void btnBrowsePresetLocation_Click(object sender, EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Title = "Select default preset file...";
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.DefaultExt = "xml";

                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    txtDefaultPresetLocation.Text = dialog.FileName;
                }
            }
        }

        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }
    }
}
