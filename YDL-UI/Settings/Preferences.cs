using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Maxstupo.YdlUi.Settings {
    public class Preferences {
        public int Version { get; set; } = 1;
        public string Language { get; set; } = "";

        public bool CheckForUpdates { get; set; } = true;

        public bool PromptDownloadingOnClose { get; set; } = true;

        public bool BasicMode { get; set; } = true;
        public bool StayOnTop { get; set; } = false;

        public int MaxConcurrentDownloads { get; set; } = 4;
        public bool ResumeDownloads { get; set; } = true;
        public bool RememberDownloadSettings { get; set; } = false;
        public bool UseBasicFolderPicker { get; set; } = false;
        public bool AutoConfirmDragDropDownloads { get; set; } = false;
        
        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadArchive { get; set; } = string.Empty;

        [JsonProperty(Required = Required.AllowNull)]
        public string DefaultDownloadDirectory { get; set; } = string.Empty;


        public PreferencesBinaries Binaries { get; private set; } = new PreferencesBinaries();
        public Preset StoredDownloadSettings { get; set; } = new Preset("(PreviousOptions)", false);
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
        public bool IsSimpleMode { get; set; }


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
            IsSimpleMode = preset.IsSimpleMode;
            foreach (ControlState controlState in preset.State)
                State.Add(controlState.Copy());
        }

        public static bool HasValidPreset(IList<Preset> presets, string url) {
            return GetMatchingPreset(presets, url) != null;
        }

        public static Preset GetMatchingPreset(IList<Preset> presets, string url) {
            return presets.Where(p => {
                if (string.IsNullOrWhiteSpace(p.MatchUrl))
                    return false;

                if (p.IsSimpleMode) {
                    return StringPattern.IsMatch(p.MatchUrl, url);
                } else {
                    return Regex.IsMatch(url, p.MatchUrl);
                }
            }).FirstOrDefault();
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
