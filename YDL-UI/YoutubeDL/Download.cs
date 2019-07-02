using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maxstupo.YdlUi.YoutubeDL {
    public class Download : INotifyPropertyChanged {
        private static readonly YdlArgumentSerializer argumentSerializer = new YdlArgumentSerializer();

        public event PropertyChangedEventHandler PropertyChanged;

        private string title;
        private int progress;
        private string speed;
        private string size;
        private string eta;
        private string log;
        private DownloadStatus status = DownloadStatus.Queued;

        public string Title { get => title; set { title = value; FirePropertyChanged(); } }
        [JsonIgnore] public string Url { get => Arguments.Url; }
        public int Progress { get => progress; set { progress = value; FirePropertyChanged(); } }
        public string Size { get => size; set { size = value; FirePropertyChanged(); } }
        public string Speed { get => speed; set { speed = value; FirePropertyChanged(); } }
        public string Eta { get => eta; set { eta = value; FirePropertyChanged(); } }


        public DownloadStatus Status { get => status; set { status = value; FirePropertyChanged(); } }

        public YdlArguments Arguments { get; set; } = new YdlArguments();

        public string Log { get => log; set { log = value; FirePropertyChanged(); } }

        public string DownloadDirectory { get; }

        [JsonIgnore]
        private ExecutableProcess process, titleProcess;

        public Download(string url, string downloadDirectory) {
            this.Arguments.Url = url;
            this.DownloadDirectory = downloadDirectory;
        }


        private void FirePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void Stop() {
            if (Status != DownloadStatus.Downloading && Status != DownloadStatus.Queued)
                return;

            if (Status == DownloadStatus.Downloading && process != null) {
                process.Stop();
                titleProcess?.Stop();
            }

            Status = DownloadStatus.Stopped;
            Log += $"\r\nDownload Stopped";
        }

        public void Start(string ydlPath, string ffmpegPath) {
            if (Status != DownloadStatus.Queued && Status != DownloadStatus.Waiting)
                return;
            Status = DownloadStatus.Downloading;

            Log += $"Working Directory: {DownloadDirectory}\r\n";

            // Get the video title.
            // TODO: Maybe add an option to disable video title collection?
            // Use a regex to extract video title from the process output, instead of starting another one?
            if (Title == null) {
                YdlArguments args = new YdlArguments();
                args.Url = Arguments.Url;
                args.General.IgnoreConfig = true;
                args.General.FlatPlaylist = true;
                args.VideoSelection.NoPlaylist = true;
                args.Verbosity.Simulate = true;
                args.Verbosity.GetTitle = true;

                titleProcess = new ExecutableProcess(ydlPath, argumentSerializer.Serialize(args, true), DownloadDirectory);
                Log += $"\r\nExecuting: {titleProcess.Command}\r\n";

                titleProcess.OnReceived += (sender, data) => {
                    if (Title == null && !string.IsNullOrWhiteSpace(data?.Trim())) {
                        Title = data.Trim();
                        Log += $"\r\nTitle: {Title}";
                    }
                };
                titleProcess.Start();
            }


            // Begin download
            Arguments.General.IgnoreConfig = true;
            Arguments.PostProcessing.PreferFFmpeg = true;
            Arguments.PostProcessing.FFmpegLocation = ffmpegPath;
#if DEBUG
            Arguments.Verbosity.Simulate = true;
#endif

            string arguments = argumentSerializer.Serialize(Arguments, true);

            process = new ExecutableProcess(ydlPath, arguments, DownloadDirectory);

            Log += $"\r\nExecuting: {process.Command}\r\n";

            process.OnExited += (s, exitCode) => {
                Status = (exitCode == 0) ? DownloadStatus.Completed : DownloadStatus.Failed;
            };

            process.OnReceived += (s, e) => {
                YdlApi.Parse(e, this);
                Log += $"\r\n{e}";
            };

            process.OnError += (s, exitCode) => {
                Log += $"\r\n{exitCode}";
            };

            process.Start();

        }

    }

}
