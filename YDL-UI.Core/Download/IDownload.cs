namespace Maxstupo.YdlUi.Core.Download {
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Download.Metadata;
    using Maxstupo.YdlUi.Core.YoutubeDl.Arguments;

    /// <summary>
    /// Represents an implementation of a download. Provides the means to start and stop a download and check the status.
    /// </summary>
    public interface IDownload {

        int Index { get; set; }

        string Url { get; }

        /// <summary>The download status used by the download manager.</summary>
        DownloadStatus Status { get; }


        string FilenameTemplate { get; set; }

        string DownloadDirectory { get; set; }

        DownloadStream TargetStreams { get; set; }

        VideoResolution TargetResolution { get; set; }

        int TargetFramerate { get; set; }


        IList<IMetadata> Metadata { get; }


        /// <summary>Initialize this download with the given URL.</summary>
        Task InitAsync(string url, bool immediateStart);

        /// <summary>Fetch the metadata for this download. InitAsync must have been called prior to calling this method. Once the fetch operation is started, StopAsync can cancel it.</summary>
        Task FetchMetadataAsync();

        /// <summary>Start the download process. Downloading the video. If InitAsync hasn't been called this method will fail.</summary>
        Task DownloadAsync();

        /// <summary>Stop the download or initialization process.</summary>       
        Task StopAsync();

        void Queue(bool allowCompleted);

    }

}