namespace Maxstupo.YdlUi.ViewModels.Dialogs {
    using System.Collections.Generic;
    using System.Linq;
    using Maxstupo.YdlUi.Core.Download;
    using Maxstupo.YdlUi.Core.Download.Metadata;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Services;
    using Stylet;

    public sealed class DownloadSettingsDialogViewModel : ScreenViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileFolderDialog fileFolderDialog;

        public IDownload Download { get; set; }

        public LabelledValue<DownloadStream> Mode { get; set; }
        public BindableCollection<LabelledValue<DownloadStream>> Modes { get; } = new BindableCollection<LabelledValue<DownloadStream>> {
            LabelledValue.Create("Video + Audio", DownloadStream.VideoAudio),
            LabelledValue.Create("Audio Only", DownloadStream.Audio),
            LabelledValue.Create("Video Only", DownloadStream.Video)
        };

        public bool CanResolution => DownloadStream.Audio != (Mode?.Value ?? null);
        public VideoResolution Resolution { get; set; }
        public BindableCollection<VideoResolution> Resolutions { get; } = new BindableCollection<VideoResolution>();

        public bool CanFramerate => CanResolution;
        public LabelledValue<int> Framerate { get; set; }
        public BindableCollection<LabelledValue<int>> Framerates { get; } = new BindableCollection<LabelledValue<int>>();

        public bool CanAudioBitrate => DownloadStream.Video != (Mode?.Value ?? null);

        public string DownloadLocation { get; set; }

        public DownloadSettingsDialogViewModel(II18N i18n, IFileFolderDialog fileFolderDialog) : base(i18n) {
            this.fileFolderDialog = fileFolderDialog;
        }

        // Designer ctor
        public DownloadSettingsDialogViewModel() : base() {
            Mode = Modes.First();
        }

        public void Confirm() {
            if (Download != null) {
                Download.TargetFramerate = Framerate?.Value ?? Download.TargetFramerate;
                Download.TargetResolution = Resolution;
                Download.TargetStreams = Mode.Value;
            }
            RequestClose(true);
        }

        public void Cancel() {
            RequestClose(false);
        }

        public void ShowBrowseFolderDialog() {
            string[] folders = fileFolderDialog.ShowOpenFolderDialog("Select a download location...", false, owner: View);
            if (folders.Length == 1)
                DownloadLocation = folders[0];
        }

        protected override void OnPropertyChanged(string propertyName) {
            base.OnPropertyChanged(propertyName);

            if (Download == null) 
                return;

            if (propertyName == nameof(Download)) {
                if (Framerate != null)
                    Framerate.Value = Download.TargetFramerate;
                if (Mode != null)
                    Mode.Value = Download.TargetStreams;
                Resolution = Download.TargetResolution ?? Resolution;
            }


            IMetadata metadata = Download.Metadata?.FirstOrDefault();
            if (metadata == null)
                return;

            // Update available resolutions when the mode changes.
            if (propertyName == nameof(Mode) && Mode != null) {

                VideoResolution oldRes = Resolution;
                Resolutions.Clear();

                List<VideoResolution> resolutions = metadata.GetResolutions(Mode.Value);
                if (resolutions != null) {
                    Resolutions.AddRange(resolutions);
                    Resolution = Resolutions.FirstOrDefault(x => x == oldRes);

                    if (Resolution == null && Resolutions.Count == 1)
                        Resolution = Resolutions.First();

                }

            }

            // Update available framerates when the mode or resolution changes.
            if (propertyName == nameof(Mode) || propertyName == nameof(Resolution)) {
                if (Mode != null && Resolution != null) {

                    int oldFramerate = Framerate?.Value ?? 0;

                    Framerates.Clear();
                    List<int> framerates = metadata.GetFramerates(Mode.Value, Resolution);
                    if (framerates != null) {
                        Framerates.AddRange(framerates.Select(x => LabelledValue.Create($"{x} FPS", x)));
                        Framerate = Framerates.FirstOrDefault(x => x.Value == oldFramerate);

                        if (Framerate == null && Framerates.Count == 1)
                            Framerate = Framerates.First();
                    }

                }

            }

        }

    }

}