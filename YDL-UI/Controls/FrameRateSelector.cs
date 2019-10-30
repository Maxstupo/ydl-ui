using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Controls {
    public partial class FrameRateSelector : UserControl {

        public int FrameRate {
            get {
                if (!IsCustomFrameRate) {
                    return (int)cbxFrameRate.SelectedValue;
                } else {
                    return (int)nudCustomFrameRate.Value;
                }
            }
        }

        public bool IsFallback { get => cbFallback.Checked; }
        public bool IsPreferred { get => cbPreferred.Checked; }

        public bool IsCustomFrameRate { get => cbxFrameRate.SelectedValue == null ? false : (int)cbxFrameRate.SelectedValue < 0; }

        private bool isDropDownOpen;

        public EventHandler OnChange { get; set; }

        public FrameRateSelector() {
            InitializeComponent();
        }

        private void FrameRateSelector_Load(object sender, EventArgs e) {
            List<int> frameRates = new List<int>(FormatSelector.DefaultFrameRates);
            frameRates.Add(-1);
            cbxFrameRate.DataSource = frameRates;
            cbxFrameRate.SelectedIndex = 0;
            cbxFrameRate.Format += (s, ee) => {
                int value = (int)ee.ListItem;
                ee.Value = value < 0 ? Localization.GetString("download_dialog.quality.fr.custom", "Custom") : value.ToString();
            };

            nudCustomFrameRate.Visible = false;
            nudCustomFrameRate.ValueChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };

            cbxFrameRate.DropDown += delegate { isDropDownOpen = true; };
            cbxFrameRate.DropDownClosed += delegate { isDropDownOpen = false; };
            cbxFrameRate.SelectedIndexChanged += CbxFrameRate_SelectedIndexChanged;

            cbPreferred.CheckedChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
            cbFallback.CheckedChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
        }

        private void CbxFrameRate_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isDropDownOpen) nudCustomFrameRate.Visible = IsCustomFrameRate;
        }

        private void cbxFrameRate_SelectionChangeCommitted(object sender, EventArgs e) {
            if (isDropDownOpen) {
                nudCustomFrameRate.Visible = IsCustomFrameRate;
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Set(FrameRateSelector frs) {
            cbxFrameRate.SelectedIndex = frs.cbxFrameRate.SelectedIndex;
            cbPreferred.Checked = frs.cbPreferred.Checked;
            cbFallback.Checked = frs.cbFallback.Checked;

            nudCustomFrameRate.Value = frs.nudCustomFrameRate.Value;
        }

    }


}
