namespace Maxstupo.YdlUi.Core.Options {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO.Abstractions;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A settings manager that will save and load the settings in a key-value pair JSON format.
    /// </summary>
    public sealed class JsonSettingsManager : FallbackSettingsManager {
        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;

        private JObject jSettings;

        public override EventHandler OnChanged { get; set; }

        public JsonSettingsManager(IFileSystem fileSystem) : base(fileSystem) {
            this.fileSystem = fileSystem;
        }

        public override void Load() {
            Logger.Info("Loading...");

            if (!fileSystem.File.Exists(Filepath)) {
                Logger.Warn("Settings file doesn't exist! Ignoring load attempt...");
                return;
            }

            Logger.Debug("Reading settings from {filepath}", Filepath);

            string json = fileSystem.File.ReadAllText(Filepath, Encoding.UTF8);
            jSettings = JObject.Parse(json);

            OnChanged?.Invoke(this, EventArgs.Empty);
        }

        public override void Save() {
            Logger.Info("Saving...");

            Logger.Debug("Writing settings to {filepath}", Filepath);

            string json = jSettings.ToString(Formatting.Indented);
            fileSystem.File.WriteAllText(Filepath, json, Encoding.UTF8);
        }

        public override void Reset() {
            Logger.Info("Reset to defaults...");

            jSettings = new JObject();

            foreach ((Type Type, string Key) tuple in Defaults) {
                object defaultInstanceValues = Activator.CreateInstance(tuple.Type);

                MergeValue(tuple.Key, defaultInstanceValues);
            }

            OnChanged?.Invoke(this, EventArgs.Empty);
        }

        private void MergeValue(string key, object value) {
            JObject jValue = JObject.FromObject(value);
            JObject jSettings = key == null ? this.jSettings : (JObject) this.jSettings[key];
            jSettings.Merge(jValue);
        }

        public override ISettings<T> GetSettings<T>(string key) {
            // since the JToken instance is reinstantiated every load or reset, we need to fetch it each time.
            return new SettingsProxy<T>(key,
                 // Get value
                 (_key) => (key == null ? jSettings : jSettings[key])?.ToObject<T>() ?? null,

                 // Set value                 
                 (_key, value) => MergeValue(key, value)
            );
        }

        // An ISettings proxy that will fetch and set using delegates.
        // Supports types with INotifyPropertyChanged by calling the set value delegate when a change occurs.
        private sealed class SettingsProxy<T> : ISettings<T> where T : class {

            private readonly string key;
            private readonly Func<string, T> getValue;
            private readonly Action<string, T> setValue;

            private T lastValue;
            public T Value {
                get {
                    if (lastValue != null && lastValue is INotifyPropertyChanged propertyChangedLast)
                        propertyChangedLast.PropertyChanged -= UpdateValue_PropertyChanged;

                    lastValue = getValue(key);

                    if (lastValue != null && lastValue is INotifyPropertyChanged propertyChangedNew)
                        propertyChangedNew.PropertyChanged += UpdateValue_PropertyChanged;

                    return lastValue;
                }

            }

            public SettingsProxy(string key, Func<string, T> getValue, Action<string, T> setValue) {
                this.key = key;
                this.getValue = getValue;
                this.setValue = setValue;
            }

            private void UpdateValue_PropertyChanged(object sender, PropertyChangedEventArgs e) {
                setValue(key, lastValue);
            }

        }

    }

}