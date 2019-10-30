using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace Maxstupo.YdlUi.YoutubeDL {
    public class DownloadManager : INotifyPropertyChanged {
        private readonly PreferencesManager<Preferences> preferencesManager;
        private readonly string downloadListFilepath;

        private readonly List<Download> downloads = new List<Download>();

        public event PropertyChangedEventHandler PropertyChanged;

        public SortableBindingList<Download> Downloads { get; }

        public int TotalDownloads { get => downloads.Count; }
        public int ConcurrentDownloads { get => Downloads.Count(dl => dl.Status == DownloadStatus.Downloading || dl.Status == DownloadStatus.Processing); }
        public int CompletedDownloads { get => Downloads.Count(dl => dl.Status == DownloadStatus.Completed); }

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
            foreach (Download download in downloads) {
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
            Downloads.Add(download);


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
                download.Status != DownloadStatus.Completed &&
                download.Status != DownloadStatus.Queued &&
                download.Status != DownloadStatus.Processing;
        }

        public void Queue(Download download) {
            if (CanQueueDownload(download))
                download.Status = DownloadStatus.Queued;
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
    }
}
