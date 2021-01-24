namespace Maxstupo.YdlUi.Controls {

    using System;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL.Model;

    public partial class BasicAddDownloadPanel : UserControl {

        public BasicAddDownloadPanel() {
            InitializeComponent();
        }

        private void BasicAddDownloadPanel_Load(object sender, EventArgs e) {
            cbxAudioOnly.DataSource = Enum.GetValues(typeof(AudioFormat));
            cbxAudioOnly.SelectedItem = AudioFormat.Mp3;

            cbxAudioOnly.BindEnabledTo(cbAudioOnly);
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;

            arguments.FileSystem.RestrictFilenames = cbRestrictFilenames.Checked;
            arguments.FileSystem.NoOverwrites = cbNoOverwrites.Checked;
            arguments.Thumbnail.WriteThumbnail = cbWriteThumbnail.Checked;

            FormatSelector formatSelector = new FormatSelector(videoQualitySelector, frameRateSelector);
            arguments.VideoFormat.Format = formatSelector.ToString();

            arguments.PostProcessing.AudioFormat = cbxAudioOnly.Enabled ? (AudioFormat?) cbxAudioOnly.SelectedValue : null;
            arguments.PostProcessing.ExtractAudio = (arguments.PostProcessing.AudioFormat != null);

        }

    }

}