namespace Maxstupo.YdlUi.Forms.Tab {

    using System;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL.Model;

    public partial class TabGeneral : UserControl {

        public TabGeneral() {
            InitializeComponent();
        }

        private void TabGeneral_Load(object sender, EventArgs e) {
            videoQualitySelector.OnChange += UpdateCustomFormat;
            frameRateSelector.OnChange += UpdateCustomFormat;

            txtCustomFormatSelector.BindReadonlyTo(cbCustomFormatSelector).Invert();

            videoQualitySelector.BindEnabledTo(cbCustomFormatSelector).Invert();
            frameRateSelector.BindEnabledTo(cbCustomFormatSelector).Invert();

            UpdateCustomFormat(this, EventArgs.Empty);


            cbxAudioOnly.DataSource = Enum.GetValues(typeof(AudioFormat));
            cbxAudioOnly.Format += (s, ee) => {
                if (((AudioFormat) ee.ListItem) == AudioFormat.Best)
                    ee.Value = Localization.GetString("download_dialog.general.post_processing.audio_only.best", AudioFormat.Best.ToString());
            };
            cbxAudioOnly.SelectedItem = AudioFormat.Mp3;

            cbxRecodeFormat.DataSource = Enum.GetValues(typeof(VideoFormatRecode));
            cbxRecodeFormat.SelectedItem = VideoFormatRecode.Mp4;

            cbxAudioOnly.BindEnabledTo(cbAudioOnly);
            cbxRecodeFormat.BindEnabledTo(cbRecodeFormat);
        }

        private void UpdateCustomFormat(object sender, EventArgs e) {
            if (cbCustomFormatSelector.Checked)
                return;
            txtCustomFormatSelector.Text = new FormatSelector(videoQualitySelector, frameRateSelector).ToString();
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;

            // Download
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


            // Post Processing 
            arguments.PostProcessing.AudioFormat = cbxAudioOnly.Enabled ? (AudioFormat?) cbxAudioOnly.SelectedValue : null;
            arguments.PostProcessing.ExtractAudio = (arguments.PostProcessing.AudioFormat != null);

            arguments.PostProcessing.EmbedThumbnail = cbEmbedThumbnail.Checked;
            arguments.PostProcessing.AddMetadata = cbAddMetadata.Checked;

            arguments.PostProcessing.RecodeVideo = cbxRecodeFormat.Enabled ? (VideoFormatRecode?) cbxRecodeFormat.SelectedValue : null;

        }

    }

}