namespace Maxstupo.YdlUi.YoutubeDL {

    using System;

    /// <summary>
    /// The status of each <see cref="Download"/>.
    /// </summary>
    [Flags]
    public enum DownloadStatus {
        None = 0,

        /// <summary>
        /// The download is queued to start. A download will queue if the max concurrent download limit is reached.
        /// </summary>
        Queued = 1,

        /// <summary>
        /// The download is downloading, a youtube-dl processing is running.
        /// </summary>
        Downloading = 2,

        /// <summary>
        /// The download is complete, no youtube-dl processes are running.
        /// </summary>
        Completed = 4,

        /// <summary>
        /// The download is waiting to be manually queued/started by the user.
        /// </summary>
        Waiting = 8,

        /// <summary>
        /// During the download status, youtube-dl returned an error. No youtube-dl process is running.
        /// </summary>
        Failed = 16,

        /// <summary>
        /// Occurs after the downloading status, youtube-dl is running ffmpeg.
        /// </summary>
        Processing = 32,

        /// <summary>
        /// Download stopped by user, or application on restart if resume downloads option is unchecked. No youtube-dl process is running.
        /// </summary>
        Stopped = 64,

        All = Queued | Downloading | Completed | Waiting | Failed | Processing,
    }

}