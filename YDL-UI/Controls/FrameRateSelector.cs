using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Controls {
    public partial class FrameRateSelector : UserControl {
        private List<int> frameRates = new List<int>() { 144, 120, 60, 30, 25, -1 };

        public int FrameRate {
            get {
                if (!IsCustomFrameRate) {
                    return (int)cbxFrameRate.SelectedValue;
                } else {
                    return (int) nudCustomFrameRate.Value;
                }
            }
        }

        public bool IsFallback { get => cbFallback.Checked; }
        public bool IsPreferred { get => cbPreferred.Checked; }

        public bool IsCustomFrameRate { get => (int)cbxFrameRate.SelectedValue < 0; }

        public FrameRateSelector() {
            InitializeComponent();
        }

        private void FrameRateSelector_Load(object sender, EventArgs e) {
            cbxFrameRate.DataSource = frameRates;
            cbxFrameRate.SelectedIndex = 0;
            cbxFrameRate.Format += (s, ee) => {
                int value = (int)ee.ListItem;
                ee.Value = value < 0 ? "Custom" : value.ToString();
            };

            nudCustomFrameRate.Visible = false;

        }

        private void cbxFrameRate_SelectionChangeCommitted(object sender, EventArgs e) {
            nudCustomFrameRate.Visible = IsCustomFrameRate;
        }
    }


}
