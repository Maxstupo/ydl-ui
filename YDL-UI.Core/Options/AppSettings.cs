namespace Maxstupo.YdlUi.Core.Options {
    using Maxstupo.YdlUi.Core.Utility;
    using Newtonsoft.Json;

    public class AppSettings : PropertyChangedBase {

        [JsonProperty("locale")] public string Locale { get; set; }

        [JsonProperty("locale_variant")] public string LocaleVariant { get; set; }

        [JsonProperty("exit_to_tray")] public bool ExitToTray { get; set; } = true;


    }

    public class DownloadSettings : PropertyChangedBase {
        private int maxConcurrentDownloads = 1;

        [JsonProperty("max_concurrent_downloads")]
        public int MaxConcurrentDownloads {
            get => maxConcurrentDownloads;
            set { maxConcurrentDownloads = value; NotifyPropertyChanged(); }
        }

    }

}