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

        private int progress;
        private string speed;
        private string size;
        private string eta;
        private string log;
        private DownloadStatus status = DownloadStatus.Queued;

        [JsonIgnore] public string Url { get => Arguments.Url; }
        public int Progress { get => progress; set { progress = value; FirePropertyChanged(); } }
        public string Size { get => size; set { size = value; FirePropertyChanged(); } }
        public string Speed { get => speed; set { speed = value; FirePropertyChanged(); } }
        public string Eta { get => eta; set { eta = value; FirePropertyChanged(); } }


        public DownloadStatus Status { get => status; set { status = value; FirePropertyChanged(); } }

        public YdlArguments Arguments { get; set; } = new YdlArguments();

        public string Log { get => log; set { log = value; FirePropertyChanged(); } }

        public string DownloadDirectory { get; }

        public Download(string url, string downloadDirectory) {
            this.Arguments.Url = url;
            this.DownloadDirectory = downloadDirectory;
        }


        private void FirePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public void Start(string ydlPath, string ffmpegPath) {
            if (Status != DownloadStatus.Queued && Status != DownloadStatus.Waiting)
                return;
            Status = DownloadStatus.Downloading;

            Arguments.PostProcessing.PreferFFmpeg = true;
            Arguments.PostProcessing.FFmpegLocation = ffmpegPath;

#if DEBUG
            Arguments.Verbosity.Simulate = true;
#endif

            string arguments = argumentSerializer.Serialize(Arguments, true);

            ExecutableProcess process = new ExecutableProcess(ydlPath, arguments, DownloadDirectory);

            Log += $"\r\nWorking Directory: {DownloadDirectory}";
            Log += $"\r\nExecuting: {process.Command}";

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
