namespace Maxstupo.YdlUi.ViewModels.Windows {
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Download;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.Utility;
    using Maxstupo.YdlUi.Core.YoutubeDl;
    using Maxstupo.YdlUi.ViewModels.Dialogs;
    using Stylet;

    public enum DisplayMode {
        List,
        Table
    }

    public sealed class MainWindowViewModel : ScreenViewModelBase {

        private static readonly char[] UrlDelimiters = { ';', ',' };

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IWindowManager windowManager;
        private readonly IDownloadManager downloadManager;

        private readonly Func<DownloadViewModel> downloadViewModelFactory;

        private readonly SettingsDialogViewModel settingsDialogViewModel;

        public BindableCollection<DownloadViewModel> Downloads { get; } = new BindableCollection<DownloadViewModel>();
        public BindableCollection<object> SelectedDownloads { get; } = new BindableCollection<object>();

        public string ToolbarUrl { get; set; } = string.Empty;

        public DisplayMode DisplayMode { get; set; } = DisplayMode.List;
        public bool ShowStatusBar { get; set; } = true;
        public bool ShowToolbar { get; set; } = true;

        public MainWindowViewModel(II18N i18n, IWindowManager windowManager, IDownloadManager downloadManager,
            Func<DownloadViewModel> downloadViewModelFactory,
            SettingsDialogViewModel settingsDialogViewModel) : base(i18n) {
            this.windowManager = windowManager;
            this.downloadManager = downloadManager;
            this.downloadViewModelFactory = downloadViewModelFactory;
            this.settingsDialogViewModel = settingsDialogViewModel;

            downloadManager.OnAdded += DownloadManager_OnAdded;
            downloadManager.OnRemoved += DownloadManager_OnRemoved;

            SelectedDownloads.CollectionChanged += (s, e) => {
                NotifyOfPropertyChange(nameof(CanQueueDownloads));
                NotifyOfPropertyChange(nameof(CanRemoveSelectedDownloads));
                NotifyOfPropertyChange(nameof(CanMoveSelectedDownloadsToTop));
                NotifyOfPropertyChange(nameof(CanMoveSelectedDownloadsUp));
                NotifyOfPropertyChange(nameof(CanMoveSelectedDownloadsDown));
                NotifyOfPropertyChange(nameof(CanMoveSelectedDownloadsToBottom));
                NotifyOfPropertyChange(nameof(CanQueueSelectedDownloads));
                
            };

        }

        // Designer ctor
        public MainWindowViewModel() : base() {
            Downloads.Add(new DownloadViewModel());
            Downloads.Add(new DownloadViewModel());
            Downloads.Add(new DownloadViewModel());

            DisplayMode = DisplayMode.Table;
        }

        private void DownloadManager_OnRemoved(object sender, IDownload e) {
            if (e is DownloadViewModel dvm)
                Downloads.Remove(dvm);
        }

        private void DownloadManager_OnAdded(object sender, IDownload e) {
            if (e is DownloadViewModel dvm)
                Downloads.Add(dvm);
        }

        public void ShowSettingsDialog() {
            windowManager.ShowDialog(settingsDialogViewModel, this);
        }

        public void ChangeView(DisplayMode mode) {
            DisplayMode = mode;
        }

        public void ToggleShowStatusBar() {
            ShowStatusBar = !ShowStatusBar;
        }

        public void ToggleShowToolbar() {
            ShowToolbar = !ShowToolbar;
        }

        public bool CanAddURL => ToolbarUrl.Split(UrlDelimiters).All(url => !string.IsNullOrWhiteSpace(url) && Util.IsValidUrl(url));
        public async Task AddURL() {
            foreach (string url in ToolbarUrl.Split(UrlDelimiters)) {
                if (string.IsNullOrWhiteSpace(url))
                    continue;

                DownloadViewModel download = downloadViewModelFactory();
                await download.InitAsync(url, false);

                downloadManager.Add(download);
            }

            ToolbarUrl = string.Empty;
        }

        public bool CanQueueSelectedDownloads => SelectedDownloads.Count > 0;
        public void QueueSelectedDownloads() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>())
                download.Queue(false);
        }

        public bool CanQueueDownloads => Downloads.Count > 0;
        public void QueueDownloads() {
            foreach (IDownload download in Downloads)
                download.Queue(false);
        }

        public bool CanRemoveSelectedDownloads => SelectedDownloads.Count > 0;
        public void RemoveSelectedDownloads() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>().ToList())
                downloadManager.Remove(download);
        }


        public bool CanMoveSelectedDownloadsDown => SelectedDownloads.Count > 0;
        public void MoveSelectedDownloadsDown() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>().OrderBy(x => x.Index))
                downloadManager.MoveDown(download);
        }

        public bool CanMoveSelectedDownloadsUp => SelectedDownloads.Count > 0;
        public void MoveSelectedDownloadsUp() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>().OrderBy(x => x.Index))
                downloadManager.MoveUp(download);
        }

        public bool CanMoveSelectedDownloadsToTop => SelectedDownloads.Count > 0;
        public void MoveSelectedDownloadsToTop() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>().OrderBy(x => x.Index))
                downloadManager.MoveToTop(download);
        }

        public bool CanMoveSelectedDownloadsToBottom => SelectedDownloads.Count > 0;
        public void MoveSelectedDownloadsToBottom() {
            foreach (IDownload download in SelectedDownloads.Cast<IDownload>().OrderBy(x => x.Index))
                downloadManager.MoveToBottom(download);
        }

    }

}