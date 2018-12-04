using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maxstupo.YdlUi.Settings {
    public class Preferences {
        public int Version { get; set; } = 1;

        public bool CheckForUpdates { get; set; } = true;

        public bool PromptDownloadingOnClose { get; set; } = true;

        public bool BasicMode { get; set; } = true;
        public bool StayOnTop { get; set; } = false;

        public int MaxConcurrentDownloads { get; set; } = 4;

        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadArchive { get; set; } = string.Empty;

        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadDirectory { get; set; } = string.Empty;


        public PreferencesBinaries Binaries { get; private set; } = new PreferencesBinaries();
        public BindingList<Preset> Presets { get; private set; } = new BindingList<Preset>();

    }

    public class PreferencesBinaries {

        [JsonProperty(PropertyName = "youtube-dl")]
        public string YoutubeDl { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "ffmpeg")]
        public string Ffmpeg { get; set; } = string.Empty;

    }

    public class Preset : IEquatable<Preset> {

        public string Name { get; set; }
        public bool IsDefault { get; set; }

        public string MatchUrl { get; set; }


        [JsonIgnore] public string DisplayText { get => IsDefault ? $"{Name} (Default)" : Name; }

        public List<ControlState> State { get; set; } = new List<ControlState>();

        public Preset() { }

        public Preset(string name, bool isDefault) {
            Name = name;
            IsDefault = isDefault;
        }

        public Preset(Preset preset) {
            Name = preset.Name;
            IsDefault = preset.IsDefault;
            MatchUrl = preset.MatchUrl;
            foreach (ControlState controlState in preset.State)
                State.Add(controlState.Copy());
        }

        public override bool Equals(object obj) {
            return Equals(obj as Preset);
        }

        public bool Equals(Preset other) {
            return other != null &&
                   Name == other.Name;
        }

        public override int GetHashCode() {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public static bool operator ==(Preset preset1, Preset preset2) {
            return EqualityComparer<Preset>.Default.Equals(preset1, preset2);
        }

        public static bool operator !=(Preset preset1, Preset preset2) {
            return !(preset1 == preset2);
        }
    }



}
