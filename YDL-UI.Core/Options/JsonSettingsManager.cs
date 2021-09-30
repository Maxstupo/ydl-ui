namespace Maxstupo.YdlUi.Core.Options {
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// A settings manager that will save and load the settings in a key-value pair JSON format.
    /// </summary>
    public sealed class JsonSettingsManager : FallbackSettingsManager {
        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;

        public JsonSettingsManager(IFileSystem fileSystem) : base(fileSystem) {
            this.fileSystem = fileSystem;
        }

        public override void Load() {
            Logger.Info("Loading...");

            if (!fileSystem.File.Exists(Filepath)) {
                Logger.Warn("Settings file doesn't exist! Ignoring load attempt...");
                return;
            }

            Dictionary<string, object> values = new Dictionary<string, object>();

            Logger.Debug("Reading settings from {filepath}", Filepath);
            using (Stream stream = fileSystem.File.Open(Filepath, FileMode.Open)) {
                using (StreamReader sw = new StreamReader(stream, Encoding.UTF8)) {
                    using (JsonReader reader = new JsonTextReader(sw)) {

                        string key = null;
                        while (reader.Read()) {
                            if (reader.Value == null)
                                continue;

                            if (reader.TokenType == JsonToken.PropertyName) { // property name
                                key = reader.Value.ToString();

                            } else if (key != null) { // property value
                                values.Add(key, reader.Value);
                                key = null;
                            }

                        }
                    }
                }
            }

            settings.Clear();
            settings.Apply(new Settings(values));
        }

        public override void Save() {
            Logger.Info("Saving...");

            Logger.Debug("Writing settings to {filepath}", Filepath);

            using (Stream stream = fileSystem.File.Open(Filepath, FileMode.Create)) {
                using (StreamWriter sw = new StreamWriter(stream, Encoding.UTF8)) {
                    using (JsonWriter writer = new JsonTextWriter(sw)) {
                        writer.Formatting = Formatting.Indented;

                        writer.WriteStartObject();
                        {
                            IList<string> keys = settings.Keys;
                            foreach (string key in keys) {
                                writer.WritePropertyName(key);
                                writer.WriteValue(settings.Get(key));
                            }
                        }
                        writer.WriteEndObject();
                    }
                }
            }
        }

        public override void Reset() {
            Logger.Info("Reset to defaults...");

            settings.Clear();
            settings.Apply(Defaults);
        }

    }

}