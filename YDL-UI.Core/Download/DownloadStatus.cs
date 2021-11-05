namespace Maxstupo.YdlUi.Core.Download {

    /// <summary>The status of the download. Negative values are errors/failures.</summary>
    public enum DownloadStatus : int {
        Failed = -1,

        /// <summary>Download is waiting for initialization and doesn't have a valid URL.</summary>
        Uninitialized = 0,

        /// <summary>The download is waiting in queue for metadata fetching to start.</summary>
        Pending = 1,

        /// <summary>The download is currently fetching metadata about the URL.</summary>
        Fetching = 2,

        /// <summary>The download is waiting for the user to manually queue it.</summary>
        Waiting = 3,

        /// <summary>The download is queued in the download manager, and will be downloaded in the future.</summary>
        Queued = 4,

        Downloading = 5,
        Completed = 6,

        Processing = 7,
        Stopped = 8
    }

}