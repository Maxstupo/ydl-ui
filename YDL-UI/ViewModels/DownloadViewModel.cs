namespace Maxstupo.YdlUi.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ByteSizeLib;
    using Maxstupo.YdlUi.Core.Download;
    using Maxstupo.YdlUi.Core.Download.Metadata;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.Utility;
    using Maxstupo.YdlUi.Core.YoutubeDl;
    using Maxstupo.YdlUi.ViewModels.Dialogs;
    using Stylet;

    public sealed class DownloadViewModel : ViewModelBase, IDownload, IProgress<Progress>, IProgress<DownloadStatistics> {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IDownloadManager downloadManager;
        private readonly IWindowManager windowManager;
        private readonly IYdlApi api;
        private readonly DownloadSettingsDialogViewModel downloadSettingsDialogViewModel;

        public int Index { get; set; }

        public string Url { get; private set; }

        public string Title => metadata.FirstOrDefault()?.Title ?? Url;

        public string ThumbnailUrl => metadata.FirstOrDefault()?.ThumbnailUrl ?? "pack://application:,,,/YDL-UI.Styles;component/download.png";

        public ByteSize Size { get; private set; }

        public TimeSpan Duration => metadata.FirstOrDefault()?.Duration ?? TimeSpan.Zero;

        public ByteSize Speed { get; private set; }

        public TimeSpan Eta { get; private set; }

        public DownloadStatus Status { get; private set; } = DownloadStatus.Uninitialized;

        public string StatusText {
            get {
                if (!string.IsNullOrWhiteSpace(ErrorText))
                    return ErrorText;

                switch (Status) {
                    case DownloadStatus.Pending:
                        return "Pending...";

                    case DownloadStatus.Downloading:
                        return "Downloading...";

                    case DownloadStatus.Fetching:
                        return IsIndeterminate ? "Fetching metadata..." : $"Fetching metadata {Progress}/{ProgressMaximum}";

                    case DownloadStatus.Queued:
                        return "Queued to download...";

                    default:
                        return "Ready to download...";
                }
            }
        }

        public string ErrorText { get; private set; }

        public float Progress { get; private set; } = 0;
        public float ProgressMaximum { get; private set; } = 0;
        public bool IsIndeterminate => ProgressMaximum < 0;

        private readonly BindableCollection<IMetadata> metadata = new BindableCollection<IMetadata>();
        public IList<IMetadata> Metadata => metadata;

        public DownloadStream TargetStreams { get; set; } = DownloadStream.VideoAudio;
        public VideoResolution TargetResolution { get; set; }
        public int TargetFramerate { get; set; }
        public string DownloadDirectory { get; set; }
        public string FilenameTemplate { get; set; }


        private CancellationTokenSource Cts { get; set; }
        private bool immediateStart;

        public DownloadViewModel(II18N i18n, IDownloadManager downloadManager, IWindowManager windowManager, IYdlApi api, DownloadSettingsDialogViewModel downloadSettingsDialogViewModel) : base(i18n) {
            this.downloadManager = downloadManager;
            this.windowManager = windowManager;
            this.api = api;
            this.downloadSettingsDialogViewModel = downloadSettingsDialogViewModel;

            this.metadata.CollectionChanged += (s, e) => {
                NotifyOfPropertyChange(nameof(Title));
                NotifyOfPropertyChange(nameof(ThumbnailUrl));
                NotifyOfPropertyChange(nameof(Duration));
                NotifyOfPropertyChange(nameof(CanQueue));
                NotifyOfPropertyChange(nameof(CanShowDownloadSettingsDialog));
            };
        }

        // Designer ctor
        public DownloadViewModel() : base() {
            Url = "https://www.youtube.com/watch?v=example";
        }

        public Task InitAsync(string url, bool immediateStart) {
            this.immediateStart = immediateStart;
            this.Url = url;
            Status = DownloadStatus.Pending;

            return Task.CompletedTask;
        }

        #region Tasks

        protected override void OnPropertyChanged(string propertyName) {
            base.OnPropertyChanged(propertyName);
            Logger.Info(propertyName);
        }

        public async Task FetchMetadataAsync() {
            if (Status != DownloadStatus.Pending)
                return;

            ErrorText = string.Empty;
            Status = DownloadStatus.Fetching;

            // Fetch metadata
            Logger.Info("Fetching metadata for {url}", Url);

            try {
                Cts = new CancellationTokenSource();
                CancellationToken token = Cts.Token;

                List<IMetadata> list = await api.FetchMetdataAsync(Url, this, token);

                metadata.Clear();
                metadata.AddRange(list);

                Status = immediateStart ? DownloadStatus.Queued : DownloadStatus.Waiting;
            } catch (Exception e) {
                Logger.Error(e, "Failed to fetch metadata for {url}", Url);
                ParseError(e);
            } finally {
                Cts?.Dispose();
                Cts = null;
            }

        }

        public async Task DownloadAsync() {
            if (Cts != null)
                return;

            ErrorText = string.Empty;
            Status = DownloadStatus.Downloading;

            try {
                Cts = new CancellationTokenSource();
                CancellationToken token = Cts.Token;

                await Task.Run(() => api.DownloadAsync(this, this, token), token);

            } catch (Exception e) {
                Logger.Error(e, "Failed to download video for {url}", Url);
                ParseError(e);
            } finally {
                Cts?.Dispose();
                Cts = null;
            }

        }

        public Task StopAsync() {
            Logger.Info("Stopping download {url}", Url);
            Status = DownloadStatus.Stopped;
            Cts?.Cancel();
            return Task.CompletedTask;
        }

        #endregion

        #region Actions

        public bool CanQueue => Cts == null && metadata.Count > 0;
        public void Queue(bool allowCompleted) {
            if (CanQueue && (Status == DownloadStatus.Waiting || Status == DownloadStatus.Failed || (allowCompleted && Status == DownloadStatus.Completed))) {
                Logger.Info("Queuing download {url}", Url);
                Status = DownloadStatus.Queued;
            }
        }

        public bool CanRemove => Cts == null;
        public async Task Remove() {
            Logger.Info("Removing download {url}", Url);

            await downloadManager.Remove(this);
        }

        public bool CanShowDownloadSettingsDialog => Cts == null && metadata.Count > 0;
        public void ShowDownloadSettingsDialog() {
            downloadSettingsDialogViewModel.Download = this;

            windowManager.ShowDialog(downloadSettingsDialogViewModel);
        }

        #endregion

        private void ParseError(Exception e) {
            Status = DownloadStatus.Failed;
            Progress = ProgressMaximum = 0;

            if (api.ParseError(e.Message, out string id, out string message)) {
                ErrorText = I18N.GetOrNull(id) ?? message;
            } else {
                ErrorText = "Failed: Unknown Error";
            }
        }

        // Metadata reporting
        public void Report(Progress value) {
            Execute.OnUIThread(() => {
                Progress = value.Value;
                ProgressMaximum = value.Maximum;
            });
        }

        // Download reporting.
        public void Report(DownloadStatistics value) {
            Execute.OnUIThread(() => {
                Progress = value.Value;
                ProgressMaximum = value.Maximum;
                Size = value.Size;
                Speed = value.Speed;
                Eta = value.Eta;
            });
        }

    }

}
