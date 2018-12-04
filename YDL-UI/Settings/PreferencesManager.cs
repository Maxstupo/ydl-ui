using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Maxstupo.YdlUi.Settings {

    public class PreferencesManager<T> where T : class {

        public string PrefPath { get; }
        public string PrefDirectory { get => new FileInfo(PrefPath).DirectoryName; }

        public T Preferences { get; private set; }

        public EventHandler<T> OnSave { get; set; }
        public EventHandler<T> OnLoad { get; set; }
        public EventHandler<T> OnUpdate { get; set; }

        public PreferencesManager(string[] filenames, T defaultPreferences = null) {
            if (filenames == null)
                throw new ArgumentNullException(nameof(filenames));

            PrefPath = FindExistingFile(filenames, "preferences.json");
            Logger.Instance.Debug(nameof(PreferencesManager<T>), "Found preferences filepath: {0}", PrefPath);

            string directory = PrefDirectory;
            try {
                if (!Directory.Exists(directory)) {
                    Logger.Instance.Debug(nameof(PreferencesManager<T>), "Creating application directory: {0}", directory);
                    Directory.CreateDirectory(directory);
                }
            } catch (Exception e) {
                Logger.Instance.Error(nameof(PreferencesManager<T>), "Failed to create application directory: {0}", directory);
            }

            this.Preferences = defaultPreferences ?? Activator.CreateInstance<T>();
        }

        private static string FindExistingFile(string[] filenames, string defaultFile) {
            foreach (string file in filenames) {
                if (File.Exists(file))
                    return file;
            }
            return filenames.Length > 0 ? filenames.Last() : defaultFile;
        }

        public bool Load(bool createIfNotExists = true) {
            Logger.Instance.Debug(nameof(PreferencesManager<T>), "Loading preferences from disk...");

            if (!File.Exists(PrefPath)) {
                Logger.Instance.Warn(nameof(PreferencesManager<T>), "No preferences file found!");

                if (createIfNotExists)
                    Save();
                return false;
            }

            using (StreamReader sr = new StreamReader(PrefPath, Encoding.UTF8)) {
                string json = sr.ReadToEnd();
                Preferences = JsonConvert.DeserializeObject<T>(json);
            }
            OnLoad?.Invoke(this, Preferences);
            OnUpdate?.Invoke(this, Preferences);
            return true;
        }

        public void Save() {
            Save(PrefPath, Preferences);
            OnSave?.Invoke(this, Preferences);
            OnUpdate?.Invoke(this, Preferences);
        }

        public static void Save(string filepath, T preferences) {
            Logger.Instance.Debug(nameof(PreferencesManager<T>), "Saving preferences to disk...");

            string json = JsonConvert.SerializeObject(preferences, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8))
                sw.WriteLine(json);
        }


    }
}
