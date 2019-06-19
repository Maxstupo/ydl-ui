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
    public partial class FormUpdating : Form {
        public FormUpdating() {
            InitializeComponent();
        }

        private void FormUpdating_Load(object sender, EventArgs e) {
            progressBar.Style = ProgressBarStyle.Marquee;
        }
    }
}
