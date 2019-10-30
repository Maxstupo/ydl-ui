using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms.Tab {
    public partial class TabPostProcessing : UserControl {
        public TabPostProcessing() {
            InitializeComponent();
        }

        private void TabPostProcessing_Load(object sender, EventArgs e) {
            cbxAudioOnly.DataSource = Enum.GetValues(typeof(AudioFormat));
            cbxAudioOnly.Format += (s, ee) => {
                if (((AudioFormat)ee.ListItem) == AudioFormat.Best)
                    ee.Value = Localization.GetString("download_dialog.post_processing.audio_only.best", AudioFormat.Best.ToString());
            };
            cbxAudioOnly.SelectedItem = AudioFormat.Mp3;

            cbxRecodeFormat.DataSource = Enum.GetValues(typeof(VideoFormatRecode));
            cbxRecodeFormat.SelectedItem = VideoFormatRecode.Mp4;

            cbxAudioOnly.BindEnabledTo(cbAudioOnly);
            cbxRecodeFormat.BindEnabledTo(cbRecodeFormat);
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;

            arguments.PostProcessing.AudioFormat = cbxAudioOnly.Enabled ? (AudioFormat?)cbxAudioOnly.SelectedValue : null;
            arguments.PostProcessing.ExtractAudio = (arguments.PostProcessing.AudioFormat != null);

            arguments.PostProcessing.RecodeVideo = cbxRecodeFormat.Enabled ? (VideoFormatRecode?)cbxRecodeFormat.SelectedValue : null;
        }
    }
}
