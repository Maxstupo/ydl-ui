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
    public partial class FormPromptNumber : Form {

        private readonly Size SIZE_DEFAULT = new Size(305, 138);
        private readonly Size MINIMUM_SIZE_DEFAULT = new Size(200, 138);
        private readonly Size MAXIMUM_SIZE_DEFAULT = new Size(960, 138);

        public int Value1 { get { return nudValue1.ValueToInt32(); } }
        public int Value2 { get { return nudValue2.ValueToInt32(); } }

        public FormPromptNumber(string title, string lbl1) {
            InitializeComponent();

            Text = title;
            lblName1.Text = lbl1 + ":";

            SetInput2(null);
        }

        public void SetInput2(string lbl2) {
            lblName2.Text = lbl2 == null ? null : (lbl2 + ":");

            lblName2.Visible = nudValue2.Visible = lbl2 != null;
            lblName2.Enabled = nudValue2.Enabled = !lblName2.Visible;

            MinimumSize = new Size(MinimumSize.Width, MINIMUM_SIZE_DEFAULT.Height - ((lbl2 == null) ? nudValue2.Size.Height : 0));
            MaximumSize = new Size(MaximumSize.Width, MinimumSize.Height);
            Size = new Size(Size.Width, MinimumSize.Height);
        }

        private void FormPromptNumber_Load(object sender, EventArgs e) {

        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void nudValue_Enter(object sender, EventArgs e) {
            if (sender is NumericUpDown nud)
                nud.Select(0, nud.Text.Length);
        }

        private void nudValue_ValueChanged(object sender, EventArgs e) {
            if (sender is NumericUpDown nud) {
                if (nud == nudValue1) {
                    nudValue2.Value = Math.Max(Value2, Value1);
                } else if (nud == nudValue2) {
                    nudValue1.Value = Math.Min(Value1, Value2);
                }
            }
        }
    }
}
