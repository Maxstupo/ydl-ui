namespace Maxstupo.YdlUi.Core.Options {
    using System.ComponentModel;
    using Maxstupo.YdlUi.Core.Utility;
    using Newtonsoft.Json;

    public class AppSettings : PropertyChangedBase {

        [JsonProperty("locale")] public string Locale { get; set; }

        [JsonProperty("locale_variant")] public string LocaleVariant { get; set; }

        [JsonProperty("minimize_to_tray")] public bool MinimizeToTray { get; set; } = false;
        [JsonProperty("exit_to_tray")] public bool ExitToTray { get; set; } = true;


    }


    public class DownloadSettings : PropertyChangedBase {

        [JsonProperty("max_concurrent_downloads")]
        public int MaxConcurrentDownloads { get; set; }

    }

    public class BinarySettings : PropertyChangedBase {

        [JsonProperty("youtube_dl")]
        public string YdlPath { get; set; } = "youtube-dl.exe";

        [JsonProperty("ffmpeg")]
        public string Ffmpeg { get; set; } = "ffmpeg.exe";

    }

    public class AdvancedSettings : PropertyChangedBase {

        [JsonProperty("download_check_interval")]
        public int DownloadCheckInterval { get; set; } = 5000;

        [JsonProperty("max_concurrent_fetches")]
        public int MaxConcurrentFetchingDownloads { get; set; } = 2;

        [JsonProperty("max_concurrent_playlist_fetches")]
        public int MaxConcurrentFetchingPlaylistItems { get; set; } = 3;

    }



}