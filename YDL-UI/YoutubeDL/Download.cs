using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.YoutubeDL {
    public class Download : INotifyPropertyChanged {
        private static readonly YdlArgumentSerializer argumentSerializer = new YdlArgumentSerializer();

        public event PropertyChangedEventHandler PropertyChanged;

        private string title;
        private int progress;
        private string speed;
        private string size;
        private string eta;
        private DownloadStatus status = DownloadStatus.Queued;

        public string Title { get => title; set { title = value; FirePropertyChanged(); } }
        [JsonIgnore] public string Url { get => Arguments.Url; }
        public int Progress { get => progress; set { progress = value; FirePropertyChanged(); } }
        public string Size { get => size; set { size = value; FirePropertyChanged(); } }
        public string Speed { get => speed; set { speed = value; FirePropertyChanged(); } }
        public string Eta { get => eta; set { eta = value; FirePropertyChanged(); } }


        public DownloadStatus Status { get => status; set { status = value; FirePropertyChanged(); } }

        public YdlArguments Arguments { get; set; } = new YdlArguments();

        private readonly StringBuilder logBuilder = new StringBuilder();
        public string Log { get => logBuilder.ToString(); set { logBuilder.Clear().Append(value); FirePropertyChanged(); } }

        public event EventHandler<string> LogUpdate; // Fires for each new log message.

        public string DownloadDirectory { get; }

        [JsonIgnore]
        private ExecutableProcess process, titleProcess;

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
            if (Status != DownloadStatus.Downloading && Status != DownloadStatus.Queued)
                return;

            if (Status == DownloadStatus.Downloading && process != null) {
                process.Stop();
                titleProcess?.Stop();
            }

            Status = DownloadStatus.Stopped;
            Speed = string.Empty;
            Eta = string.Empty;

            WriteLog("\r\nDownload Stopped");
        }


        public void Start(string ydlPath, string ffmpegPath) {
            if (Status != DownloadStatus.Queued && Status != DownloadStatus.Waiting)
                return;
            Status = DownloadStatus.Downloading;

            WriteLog($"Working Directory: {DownloadDirectory}\r\nYDL Version: {Application.ProductVersion.RemoveAfterLast('.')}\r\n");

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
                WriteLog($"\r\nExecuting: {titleProcess.Command}\r\n");

                titleProcess.OnReceived += (sender, data) => {
                    if (Title == null && !string.IsNullOrWhiteSpace(data?.Trim())) {
                        Title = data.Trim();
                        WriteLog($"\r\nTitle: {Title}");
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

            WriteLog($"\r\nExecuting: {process.Command}\r\n");

            process.OnExited += (s, exitCode) => {
                Status = (exitCode == 0) ? DownloadStatus.Completed : DownloadStatus.Failed;
            };

            process.OnReceived += (s, e) => {
                YdlApi.Parse(e, this);
                WriteLog($"\r\n{e}");
            };

            process.OnError += (s, exitCode) => {
                WriteLog($"\r\n{exitCode}");
            };

            process.Start();

        }

    }

}
