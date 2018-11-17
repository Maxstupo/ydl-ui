using System;

namespace Maxstupo.YdlUi.YoutubeDL {
    [Flags]
    public enum DownloadStatus {
        None = 0,
        Queued = 1,
        Downloading = 2,
        Completed = 4,
        Waiting = 8,
        Failed = 16,
        All = Queued | Downloading | Completed | Waiting | Failed
    }
}