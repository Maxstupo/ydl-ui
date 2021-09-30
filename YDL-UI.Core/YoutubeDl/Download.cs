namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Utility.Exec;
    using Maxstupo.YdlUi.Core.YoutubeDl.Binaries;

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
        private readonly IOutputParser parser;
        private readonly IExecutableProcess process;

        public DownloadStatus Status { get; }

        public string Directory { get; }

        public Download(IInterpretableBinaryProvider binaryProvider, IArgumentsCollection arguments, string downloadDirectory) {
            this.Directory = downloadDirectory;
            process = binaryProvider.CreateExecutableProcess(arguments, downloadDirectory);
            parser = binaryProvider.CreateParser();
        }

        public void Start() {

        }

        public void Stop() {

        }

    }

}