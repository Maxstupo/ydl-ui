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
                    return new VideoQuality((int)nudCustomWidth.Value, (int)nudCustomHeight.Value, "Custom");
                }
            }
        }

        public bool IsPreferred { get => cbPreferred.Checked; }
        public bool IsFallback { get => cbFallback.Checked; }


        public bool IsCustomQuality {
            get {
                VideoQuality vq = cbxQuality.SelectedValue as VideoQuality;
                return vq.Width < 0 && vq.Height < 0;
            }
        }

        public VideoQualitySelector() {
            InitializeComponent();
        }

        private void VideoQualitySelector_Load(object sender, EventArgs e) {
            cbxQuality.DataSource = VideoQuality.StandardQualities;

            label1.Visible = nudCustomWidth.Visible = nudCustomHeight.Visible = false;
        }

        private void cbxQuality_SelectionChangeCommitted(object sender, EventArgs e) {
            label1.Visible = nudCustomWidth.Visible = nudCustomHeight.Visible = IsCustomQuality;
        }
    }


}
