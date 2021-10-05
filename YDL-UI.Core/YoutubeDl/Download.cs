namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Utility.Exec;
    using Maxstupo.YdlUi.Core.YoutubeDl.Arguments;

    /// <summary>The status of the download. Negative values are errors/failures.</summary>
    public enum DownloadStatus : int {
        Failed = -1,
        Waiting = 0,
        Queued = 1,
        Downloading = 2,
        Processing = 3,
        Completed = 4,
        Stopped = 5
    }

    /// <summary>
    /// Represents an implementation of a download. Provides the means to start and stop a download and check the status.
    /// </summary>
    public interface IDownload {

        DownloadStatus Status { get; }

        string Directory { get; }

        /// <summary>Start the download.</summary>
        void Start();

        /// <summary>Stop the download.</summary>       
        void Stop();

    }

    public sealed class Download : IDownload {

        public DownloadStatus Status { get; }

        public string Directory { get; }

        private readonly YdlArguments arguments;

        public Download(IExecutableProcessProvider provider, YdlArguments arguments, string downloadDirectory) {
            this.arguments = arguments;
            this.Directory = downloadDirectory;
        }

        public void Start() {

        }

        public void Stop() {

        }

    }

}