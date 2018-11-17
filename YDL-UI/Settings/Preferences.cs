using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maxstupo.YdlUi.Settings {
    public class Preferences {
        public bool CheckForUpdates { get; set; } = true;

        public bool PromptDownloadingOnClose { get; set; } = true;

        public bool BasicMode { get; set; } = true;

        public int MaxConcurrentDownloads { get; set; } = 4;

        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadArchive { get; set; } = string.Empty;

        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadDirectory { get; set; } = string.Empty;


        public PreferencesBinaries Binaries { get; private set; } = new PreferencesBinaries();
        public Dictionary<string, string> Defaults { get; private set; } = new Dictionary<string, string>();
    }

    public class PreferencesBinaries {

        [JsonProperty(PropertyName = "youtube-dl")]
        public string YoutubeDl { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "ffmpeg")]
        public string Ffmpeg { get; set; } = string.Empty;

    }





}
