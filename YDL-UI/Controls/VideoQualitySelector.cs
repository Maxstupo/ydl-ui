using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Controls {
    public partial class VideoQualitySelector : UserControl {
        public VideoQuality Quality {
            get {
                if (!IsCustomQuality) {
                    return cbxQuality.SelectedValue as VideoQuality;
                } else {
                    return new VideoQuality((int)nudCustomWidth.Value, (int)nudCustomHeight.Value, "Custom"); //  Name "Custom" not used.
                }
            }
        }

        public bool IsPreferred { get => cbPreferred.Checked; }
        public bool IsFallback { get => cbFallback.Checked; }
        private bool isDropDownOpen;


        public bool IsCustomQuality {
            get {
                VideoQuality vq = cbxQuality.SelectedValue as VideoQuality;
                if (vq == null) return false;
                return vq.Width < 0 && vq.Height < 0;
            }
        }

        public EventHandler OnChange { get; set; }

        public VideoQualitySelector() {
            InitializeComponent();
        }

        private void VideoQualitySelector_Load(object sender, EventArgs e) {
            cbxQuality.DataSource = VideoQuality.StandardQualities;

            label1.Visible = nudCustomWidth.Visible = nudCustomHeight.Visible = false;
            cbxQuality.DropDown += delegate { isDropDownOpen = true; };
            cbxQuality.DropDownClosed += delegate { isDropDownOpen = false; };
            cbxQuality.SelectedIndexChanged += CbxQuality_SelectedIndexChanged;

            nudCustomWidth.ValueChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
            nudCustomHeight.ValueChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
            cbPreferred.CheckedChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
            cbFallback.CheckedChanged += delegate { OnChange?.Invoke(this, EventArgs.Empty); };
        }

        private void CbxQuality_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isDropDownOpen) label1.Visible = nudCustomWidth.Visible = nudCustomHeight.Visible = IsCustomQuality;
        }

        private void cbxQuality_SelectionChangeCommitted(object sender, EventArgs e) {
            if (isDropDownOpen) {
                label1.Visible = nudCustomWidth.Visible = nudCustomHeight.Visible = IsCustomQuality;
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Set(VideoQualitySelector vqs) {
            cbxQuality.SelectedIndex = vqs.cbxQuality.SelectedIndex;
            cbPreferred.Checked = vqs.cbPreferred.Checked;
            cbFallback.Checked = vqs.cbFallback.Checked;

            nudCustomWidth.Value = vqs.nudCustomWidth.Value;
            nudCustomHeight.Value = vqs.nudCustomHeight.Value;
        }
    }


}
