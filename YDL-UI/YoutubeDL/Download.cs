namespace Maxstupo.YdlUi.YoutubeDL {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL.Model;
    using Newtonsoft.Json;

    public class Download : INotifyPropertyChanged {
        public static readonly YdlArgumentSerializer ArgumentSerializer = new YdlArgumentSerializer();

        public event PropertyChangedEventHandler PropertyChanged;

        private int index;
        private string title;
        private int progress;
        private string speed;
        private string size;
        private string eta;
        private string playlist;
        private DownloadStatus status = DownloadStatus.Queued;

        public int Index { get => index; set { index = value; FirePropertyChanged(); } }
        public string Title { get => title; set { title = value; FirePropertyChanged(); } }
        [JsonIgnore] public string Url => Arguments.Url;
        public int Progress { get => progress; set { progress = value; FirePropertyChanged(); } }
        public string Size { get => size; set { size = value; FirePropertyChanged(); } }
        public string Speed { get => speed; set { speed = value; FirePropertyChanged(); } }
        public string Eta { get => eta; set { eta = value; FirePropertyChanged(); } }
        public string Playlist { get => playlist; set { playlist = value; FirePropertyChanged(); } }

        public DownloadStatus Status { get => status; set { status = value; FirePropertyChanged(); } }

        public YdlArguments Arguments { get; set; } = new YdlArguments();

        private readonly StringBuilder logBuilder = new StringBuilder();
        public string Log { get => logBuilder.ToString(); set { logBuilder.Clear().Append(value); FirePropertyChanged(); } }

        public event EventHandler<string> LogUpdate; // Fires for each new log message.

        public string DownloadDirectory { get; }

        public int RetryAttempts { get; set; } = 0;

        [JsonIgnore]
        public int RetryCounter { get; set; } = 0;

        [JsonIgnore]
        private ExecutableProcess process;

        public Download(string url, string downloadDirectory) {
            this.Arguments.Url = url;
            this.DownloadDirectory = downloadDirectory;
        }

        private void WriteLog(string msg) {
            logBuilder.Append(msg);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Log)));

            LogUpdate?.Invoke(this, msg);
        }

        private void FirePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void Stop() {
            if (Status == DownloadStatus.Downloading || Status == DownloadStatus.Queued || Status == DownloadStatus.Processing) {

                if ((Status == DownloadStatus.Downloading || Status == DownloadStatus.Processing) && process != null)
                    process.Stop();


                Status = DownloadStatus.Stopped;
                Speed = string.Empty;
                Eta = string.Empty;
                Playlist = string.Empty;

                WriteLog("\r\nDownload Stopped");
            }
        }

        public void Start(string ydlPath, string ffmpegPath) {
            if (Status != DownloadStatus.Queued && Status != DownloadStatus.Waiting)
                return;
            Status = DownloadStatus.Downloading;

            WriteLog($"Working Directory: {DownloadDirectory}\r\nYDL Version: {Application.ProductVersion.RemoveAfterLast('.')}\r\n");

            // Begin download
            Arguments.General.IgnoreConfig = true;
            Arguments.FileSystem.NoCacheDir = true;
            Arguments.PostProcessing.PreferFFmpeg = true;
            Arguments.PostProcessing.FFmpegLocation = ffmpegPath;
#if DEBUG
            Arguments.Verbosity.Simulate = true;
#endif

            string arguments = ArgumentSerializer.Serialize(Arguments, true);

            process = new ExecutableProcess(ydlPath, arguments, DownloadDirectory);

            WriteLog($"\r\nExecuting: {process.Command}\r\n");

            process.OnExited += (s, exitCode) => {
#if DEBUG
                if (exitCode != 0)
                    Logger.Instance.Warn(nameof(Download), $"Exit code: {exitCode}");
#endif
                Status = (exitCode == 0) ? DownloadStatus.Completed : DownloadStatus.Failed;
                if (Status == DownloadStatus.Failed)
                    RetryAttempts++;

                Progress = 100;
            };

            process.OnReceived += (s, e) => {
                YdlApi.Parse(e, this);
                WriteLog($"\r\n{e}");
            };

            process.OnError += (s, exitCode) => WriteLog($"\r\n{exitCode}");

            process.Start();

        }



    }

}