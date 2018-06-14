using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Controls {
    public partial class NumberTextBox : TextBox {

        public bool AllowDecimal { get; set; } = true;
        public char[] WhitelistedChars { get; set; } = new char[0];

        public NumberTextBox() {
            InitializeComponent();
            KeyPress += NumberTextbox_KeyPress;
        }

        private void NumberTextbox_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !WhitelistedChars.Contains(e.KeyChar))
                e.Handled = true;


            // only allow one decimal point
            if (e.KeyChar == '.')
                e.Handled = AllowDecimal ? (Text.IndexOf('.') > -1) : true;

        }


    }
}
