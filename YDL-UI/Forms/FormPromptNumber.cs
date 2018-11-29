using Maxstupo.YdlUi.Utility;
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
    public partial class FormPromptNumber : Form {

        public int Value1 { get => (int)nud1.Value; }
        public int Value2 { get => (int)nud2.Value; }

        public FormPromptNumber(string title, string lbl1, string lbl2 = null) {
            InitializeComponent();

            Text = title;
            label1.Text = $"{lbl1}:";
            
            if (lbl2 == null) {
                MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - nud2.Height);

                tableLayoutPanel1.Controls.Remove(label2);
                tableLayoutPanel1.Controls.Remove(nud2);
                tableLayoutPanel1.RowStyles.RemoveAt(1);

            } else {
                label2.Text = $"{lbl2}:";

                GuiUtil.MakeRangeNumericUpDown(nud1, nud2, 1);
            }


        }

        private void FormPromptNumber_Load(object sender, EventArgs e) {
            nud1.Enter += NumericUpDown_Enter;
            nud2.Enter += NumericUpDown_Enter;
            Size = new Size(Size.Width, MinimumSize.Height);
        }

        private void NumericUpDown_Enter(object sender, EventArgs e) {
            if (sender is NumericUpDown nud)
                nud.Select(0, nud.Text.Length);
        }


        private void btnAdd_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }


    }
}
