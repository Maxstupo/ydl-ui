namespace Maxstupo.YdlUi.Core.Download {
    using System;

    [Flags]
    public enum DownloadStream : int {
        Video = 1,
        Audio = 2,
        VideoAudio = Video | Audio
    }

}