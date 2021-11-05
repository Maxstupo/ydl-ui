namespace Maxstupo.YdlUi.Core.Download {
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Options;
    using Maxstupo.YdlUi.Core.Utility.Exec;

    public interface IDownloadManager {

        IList<IDownload> Downloads { get; }

        string DownloadDirectory { get; }

        event EventHandler<IDownload> OnAdded;
        event EventHandler<IDownload> OnRemoved;

        void Add(IDownload download);
        Task Remove(IDownload download);


        void MoveToTop(IDownload download);
        void MoveUp(IDownload download);
        void MoveDown(IDownload download);
        void MoveToBottom(IDownload download);

    }


    public sealed class DownloadManager : IDownloadManager, IExecutableProcessProvider, IDisposable {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IArgumentSerializer serializer;
        private readonly ISettings<BinarySettings> binarySettings;
        private readonly ISettings<DownloadSettings> downloadSettings;
        private readonly ISettings<AdvancedSettings> advancedSettings;
        private readonly IList<IDownload> downloads = new List<IDownload>();

        public event EventHandler<IDownload> OnAdded;
        public event EventHandler<IDownload> OnRemoved;

        public string DownloadDirectory { get; }

        public IList<IDownload> Downloads => downloads;

        private CancellationTokenSource schedulerTokenSource;

        private int currentConcurrentDownloads = 0;

        public DownloadManager(IArgumentSerializer serializer, ISettings<BinarySettings> binarySettings, ISettings<DownloadSettings> downloadSettings, ISettings<AdvancedSettings> advancedSettings) {
            this.serializer = serializer;
            this.binarySettings = binarySettings;
            this.downloadSettings = downloadSettings;
            this.advancedSettings = advancedSettings;
        }

        private void StartDownloadScheduler() {
            if (schedulerTokenSource != null)
                return;

            Logger.Info("Starting download scheduler...");

            schedulerTokenSource = new CancellationTokenSource();
            CancellationToken token = schedulerTokenSource.Token;


            Task.Factory.StartNew(async () => {
                while (!token.IsCancellationRequested) {
                    // Logger.Trace("Download Scheduler Checking...");

                    List<Task> tasks = new List<Task>();

                    foreach (IDownload download in downloads) {
                        if (token.IsCancellationRequested)
                            break;

                        DownloadStatus status = download.Status;

                        // Fetch metadata if download is pending.
                        if (status == DownloadStatus.Pending && tasks.Count < (advancedSettings.Value?.MaxConcurrentFetchingDownloads ?? 2))
                            tasks.Add(Task.Run(download.FetchMetadataAsync));

                        // Start download if queued.
                        if (status == DownloadStatus.Queued && currentConcurrentDownloads < (downloadSettings.Value?.MaxConcurrentDownloads ?? 2))
                            _ = download.DownloadAsync();

                    }

                    await Task.WhenAll(tasks);
                    await Task.Delay(advancedSettings.Value?.DownloadCheckInterval ?? 5000, token).ContinueWith(_ => { }); // ignore TaskCanceledException
                }
            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        private void StopDownloadScheduler() {
            if (schedulerTokenSource == null)
                return;
            Logger.Info("Stopping download scheduler...");
            schedulerTokenSource.Cancel();
            schedulerTokenSource.Dispose();
            schedulerTokenSource = null;
        }

        public void Add(IDownload download) {
            StartDownloadScheduler();

            download.Index = downloads.Count;

            downloads.Add(download);
            OnAdded?.Invoke(this, download);
        }

        public async Task Remove(IDownload download) {
            await download.StopAsync();

            downloads.Remove(download);
            OnRemoved?.Invoke(this, download);

            for (int i = 0; i < downloads.Count; i++)
                downloads[i].Index = i;

            if (downloads.Count == 0)
                StopDownloadScheduler();
        }

        public void MoveUp(IDownload download) {
            int index = downloads.IndexOf(download);
            if (index != -1 && index > 0) {
                downloads.Remove(download);
                downloads.Insert(index - 1, download);
            }

            for (int i = 0; i < downloads.Count; i++)
                downloads[i].Index = i;
        }

        public void MoveDown(IDownload download) {
            int index = downloads.IndexOf(download);
            if (index != -1 && index + 1 < downloads.Count) {
                downloads.Remove(download);
                downloads.Insert(index + 1, download);
            }

            for (int i = 0; i < downloads.Count; i++)
                downloads[i].Index = i;
        }

        public void MoveToTop(IDownload download) {

        }

        public void MoveToBottom(IDownload download) {

        }


        public IExecutableProcess CreateExecutableProcess(object arguments) {
            string path = binarySettings.Value.YdlPath;
            string args = serializer.Serialize(arguments);

            Logger.Debug("Creating executable process for {path} with '{args:l}' @ {workingDirectory}", path, args, DownloadDirectory);

            return new ExecutableProcess(path, args, DownloadDirectory);
        }

        public void Dispose() {
            StopDownloadScheduler();
        }

    }

}
