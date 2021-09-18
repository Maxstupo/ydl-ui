namespace Maxstupo.YdlUi.YoutubeDL {
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Timers;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL.Model;
    using Newtonsoft.Json;

    public class DownloadManager : INotifyPropertyChanged {
        private readonly PreferencesManager<Preferences> preferencesManager;
        private readonly string downloadListFilepath;

        private readonly List<Download> downloads = new List<Download>();

        public event PropertyChangedEventHandler PropertyChanged;

        public SortableBindingList<Download> Downloads { get; }

        public int TotalDownloads => downloads.Count;
        public int ConcurrentDownloads => Downloads.Count(dl => dl.Status == DownloadStatus.Downloading || dl.Status == DownloadStatus.Processing);
        public int CompletedDownloads => Downloads.Count(dl => dl.Status == DownloadStatus.Completed);

        public string YdlPath { get; set; }
        public string FfmpegPath { get; set; }

        private readonly Timer updateTimer = new Timer(2000);

        public DownloadManager(PreferencesManager<Preferences> preferencesManager, string downloadListFilepath) {
            this.preferencesManager = preferencesManager;
            this.downloadListFilepath = downloadListFilepath;

            Downloads = new SortableBindingList<Download>(downloads);

            updateTimer.Elapsed += delegate { Update(); };
            updateTimer.Start();
        }

        private void Update() {
            foreach (Download download in downloads.OrderBy(x => x.Index)) {

                // Attempt to restart the download.
                if (download.Status == DownloadStatus.Failed && download.RetryAttempts <= preferencesManager.Preferences.RetryAttempts) {

                    if (download.RetryCounter >= preferencesManager.Preferences.RetryAttemptInterval) {
                        download.RetryCounter = 0;
                        download.Status = DownloadStatus.Queued;
                    } else {
                        download.RetryCounter += (int) (updateTimer.Interval / 1000);
                    }

                }

                if (download.Status != DownloadStatus.Queued)
                    continue;
                if (ConcurrentDownloads >= preferencesManager.Preferences.MaxConcurrentDownloads)
                    return;
                download.Start(YdlPath, FfmpegPath);
            }

            FirePropertyChanged(nameof(ConcurrentDownloads));
            FirePropertyChanged(nameof(CompletedDownloads));
        }


        public bool AddDownload(Download download) {
            if (download == null)
                return true;

            foreach (Download dl in Downloads) {
                if (dl.Url == download.Url)
                    return false;
            }

            if (download.Status == DownloadStatus.Downloading || download.Status == DownloadStatus.Processing)
                download.Status = preferencesManager.Preferences.ResumeDownloads ? DownloadStatus.Queued : DownloadStatus.Stopped;

            download.PropertyChanged += Download_PropertyChanged;

            download.Index = Downloads.Count + 1;

            Downloads.Add(download);

            // Get the video title, but dont download the video yet, even if the download is 'Waiting' or 'Stopped'
            if (preferencesManager.Preferences.FetchTitle && download.Title == null) {
                YdlArguments args = new YdlArguments();
                args.General.IgnoreConfig = true;
                args.General.FlatPlaylist = true;
                args.VideoSelection.NoPlaylist = true;
                args.Verbosity.Simulate = true;
                args.Verbosity.GetTitle = true;

                args.Url = download.Url;

                string strArgs = Download.ArgumentSerializer.Serialize(args, true);
                ExecutableProcess titleProcess = new ExecutableProcess(YdlPath, strArgs, download.DownloadDirectory);

                titleProcess.OnReceived += (sender, data) => {
                    if (download.Title == null && !string.IsNullOrWhiteSpace(data?.Trim()))
                        download.Title = data.Trim();
                };
#if DEBUG
                titleProcess.OnExited += (sender, code) => Logger.Instance.Debug(nameof(DownloadManager), $"Title process has exited: {code}");
#endif
                titleProcess.Start();
            }

            FirePropertyChanged(nameof(TotalDownloads));
            return true;
        }

        private void Download_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            FirePropertyChanged(nameof(ConcurrentDownloads));
            FirePropertyChanged(nameof(CompletedDownloads));
        }

        private void FirePropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool CanStopDownload(Download download) {
            return download.Status == DownloadStatus.Downloading || download.Status == DownloadStatus.Queued || download.Status == DownloadStatus.Processing;
        }

        public bool CanRemoveDownload(Download download) {
            return download.Status != DownloadStatus.Downloading && download.Status != DownloadStatus.Processing;
        }

        public bool CanQueueDownload(Download download) {
            return download.Status != DownloadStatus.Downloading &&
                download.Status != DownloadStatus.Queued &&
                download.Status != DownloadStatus.Processing;
        }

        public void Queue(Download download) {
            if (CanQueueDownload(download)) {
                download.Status = DownloadStatus.Queued;
                download.RetryAttempts = 0;
            }
        }


        public void Stop(Download download) {
            if (!CanStopDownload(download))
                return;

            download.Stop();
        }

        public bool RemoveDownload(Download download) {
            if (!CanRemoveDownload(download))
                return false;

            download.PropertyChanged -= Download_PropertyChanged;
            Downloads.Remove(download);

            FirePropertyChanged(nameof(TotalDownloads));

            // Update download indices
            int index = download.Index;
            foreach (Download dl in downloads.OrderBy(x => x.Index)) {
                if (dl.Index > download.Index)
                    dl.Index = index++;
            }

            return true;
        }

        public void ClearDownloads(DownloadStatus toClear = DownloadStatus.All) {
            for (int i = downloads.Count - 1; i >= 0; i--) {
                Download download = downloads[i];

                if (!toClear.HasFlag(download.Status))
                    continue;
                RemoveDownload(download);
            }
        }


        public void Save() {
            Logger.Instance.Debug(nameof(DownloadManager), "Saving downloads to disk...");

#if DEBUG
            File.WriteAllText(downloadListFilepath, JsonConvert.SerializeObject(downloads, Formatting.Indented), Encoding.UTF8);
#else
            File.WriteAllText(downloadListFilepath, JsonConvert.SerializeObject(downloads, Formatting.None), Encoding.UTF8);
#endif

        }

        public bool Load(bool createIfNotExists = true) {
            Logger.Instance.Debug(nameof(DownloadManager), "Loading downloads from disk...");

            if (!File.Exists(downloadListFilepath)) {
                Logger.Instance.Warn(nameof(DownloadManager), "No download file found...");

                if (createIfNotExists)
                    Save();
                return false;
            }


            List<Download> downloads = JsonConvert.DeserializeObject<List<Download>>(File.ReadAllText(downloadListFilepath, Encoding.UTF8));
            downloads.ForEach(d => AddDownload(d));

            return true;
        }

        public void MoveToBottomOfQueue(Download[] toMove) {
            int index = 0;
            int moveIndex = 0;
            foreach (Download download in downloads.OrderBy(x => x.Index)) {
                if (toMove.Contains(download)) {
                    download.Index = downloads.Count - (toMove.Length - ++moveIndex);
                } else {
                    download.Index = ++index;
                }
            }
        }

        public void MoveToTopOfQueue(Download[] toMove) {
            int index = toMove.Length;
            int moveIndex = 0;
            foreach (Download download in downloads.OrderBy(x => x.Index)) {
                if (toMove.Contains(download)) {
                    download.Index = ++moveIndex;
                } else {
                    download.Index = ++index;
                }
            }
        }

        public void MoveDownQueue(Download[] toMove) {
            foreach (Download download in toMove.OrderBy(x => x.Index)) {
                Download other = downloads.FirstOrDefault(x => x.Index == download.Index + 1);
                if (other != null && other.Index > 1) {
                    other.Index--;

                    download.Index++;
                }
            }
        }

        public void MoveUpQueue(Download[] toMove) {
            foreach (Download download in toMove.OrderBy(x => x.Index)) {
                if (download.Index > 1) {
                    download.Index--;

                    Download other = downloads.First(x => x.Index == download.Index);
                    other.Index++;
                }
            }
        }

    }

}