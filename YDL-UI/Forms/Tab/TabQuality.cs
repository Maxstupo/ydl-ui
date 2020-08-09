using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms.Tab {
    public partial class TabQuality : UserControl {
        public TabQuality() {
            InitializeComponent();
        }

        private void TabQuality_Load(object sender, EventArgs e) {
            videoQualitySelector.OnChange += UpdateCustomFormat;
            frameRateSelector.OnChange += UpdateCustomFormat;

            txtCustomFormatSelector.BindReadonlyTo(cbCustomFormatSelector).Invert();

            videoQualitySelector.BindEnabledTo(cbCustomFormatSelector).Invert();
            frameRateSelector.BindEnabledTo(cbCustomFormatSelector).Invert();

            UpdateCustomFormat(this, EventArgs.Empty);
        }

        private void UpdateCustomFormat(object sender, EventArgs e) {
            if (cbCustomFormatSelector.Checked)
                return;
            txtCustomFormatSelector.Text = new FormatSelector(videoQualitySelector, frameRateSelector).ToString();
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;

            // General
            arguments.General.IgnoreErrors = cbIgnoreErrors.Checked;
            arguments.General.AbortOnError = cbAbortOnErrors.Checked;

            // Filesystem
            arguments.FileSystem.WriteAnnotations = cbWriteAnnotations.Checked;
            arguments.FileSystem.WriteDescription = cbWriteDescription.Checked;
            arguments.FileSystem.RestrictFilenames = cbRestrictFilenames.Checked;
            arguments.FileSystem.NoOverwrites = cbNoOverwrites.Checked;
            arguments.Thumbnail.WriteThumbnail = cbWriteThumbnail.Checked;
            
            arguments.Subtitle.WriteSub = cbWriteSub.Checked;

            if (cbCustomFormatSelector.Checked) {
                arguments.VideoFormat.Format = txtCustomFormatSelector.Text;
            } else {
                FormatSelector formatSelector = new FormatSelector(videoQualitySelector, frameRateSelector);
                arguments.VideoFormat.Format = formatSelector.ToString();
            }
        }
    }
}
