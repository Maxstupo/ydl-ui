using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace Maxstupo.YdlUi.YoutubeDL {
    public class DownloadManager : INotifyPropertyChanged {
        private readonly Preferences preferences;
        private readonly string downloadListFilepath;

        private readonly List<Download> downloads = new List<Download>();

        public event PropertyChangedEventHandler PropertyChanged;

        public SortableBindingList<Download> Downloads { get; }

        public int TotalDownloads { get => downloads.Count; }
        public int ConcurrentDownloads { get => Downloads.Count(dl => dl.Status == DownloadStatus.Downloading); }
        public int CompletedDownloads { get => Downloads.Count(dl => dl.Status == DownloadStatus.Completed); }

        public string YdlPath { get; set; }
        public string FfmpegPath { get; set; }

        private readonly Timer updateTimer = new Timer(2000);

        public DownloadManager(Preferences preferences, string downloadListFilepath) {
            this.preferences = preferences;
            this.downloadListFilepath = downloadListFilepath;

            Downloads = new SortableBindingList<Download>(downloads);

            updateTimer.Elapsed += delegate { Update(); };
            updateTimer.Start();
        }
        
        private void Update() {
            foreach (Download download in downloads) {
                if (download.Status != DownloadStatus.Queued)
                    continue;
                if (ConcurrentDownloads >= preferences.MaxConcurrentDownloads)
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

            if (download.Status == DownloadStatus.Downloading)
                download.Status = DownloadStatus.Queued;
            
            Downloads.Add(download);

            FirePropertyChanged(nameof(TotalDownloads));
            return true;
        }

        private void FirePropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool CanRemoveDownload(Download download) {
            return download.Status != DownloadStatus.Downloading;
        }

        public bool CanQueueDownload(Download download) {
            return download.Status != DownloadStatus.Downloading && download.Status != DownloadStatus.Completed;
        }

        public void Queue(Download download) {
            if (CanQueueDownload(download))
                download.Status = DownloadStatus.Queued;
        }

        public bool RemoveDownload(Download download) {
            if (!CanRemoveDownload(download))
                return false;
            
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

            using (StreamWriter sw = new StreamWriter(downloadListFilepath, false, Encoding.UTF8)) {
#if DEBUG
                string json = JsonConvert.SerializeObject(downloads, Formatting.Indented);
#else
                string json = JsonConvert.SerializeObject(downloads, Formatting.None);
#endif

                sw.WriteLine(json);
            }
        }

        public bool Load(bool createIfNotExists = true) {
            Logger.Instance.Debug(nameof(DownloadManager), "Loading downloads from disk...");

            if (!File.Exists(downloadListFilepath)) {
                Logger.Instance.Warn(nameof(DownloadManager), "No download file found...");

                if (createIfNotExists)
                    Save();
                return false;
            }

            using (StreamReader sw = new StreamReader(downloadListFilepath, Encoding.UTF8)) {
                string json = sw.ReadToEnd();

                List<Download> downloads = JsonConvert.DeserializeObject<List<Download>>(json);
                downloads.ForEach(d => AddDownload(d));
            }
            return true;
        }


    }
}
