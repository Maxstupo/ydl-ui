using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Maxstupo.YdlUi.Settings {
    /// <summary>
    /// Manages saving and loading of an object containing the settings of the application.
    /// </summary>
    /// <typeparam name="T">The object</typeparam>
    public class PreferencesManager<T> where T : class {

        /// <summary>
        /// The path that the preference file will be stored.
        /// </summary>
        public string PrefPath { get; }

        /// <summary>
        /// The directory containing the preference file.
        /// </summary>
        public string PrefDirectory { get => new FileInfo(PrefPath).DirectoryName; }

        /// <summary>
        /// The preferences object, this object will be serialized/deserialized to the <see cref="PrefPath"/>.
        /// </summary>
        public T Preferences { get; private set; }

        /// <summary>
        /// Invoked after the preferences have been saved from calling <see cref="Save"/>. Called before <see cref="OnUpdate"/>.
        /// </summary>
        public EventHandler<T> OnSave { get; set; }

        /// <summary>
        /// Invoked after the preferences have been loaded from calling <see cref="Load(bool)"/>. Called before <see cref="OnUpdate"/>.
        /// </summary>
        public EventHandler<T> OnLoad { get; set; }

        /// <summary>
        /// Invoked when <see cref="Load(bool)"/> or <see cref="Save"/> is called.
        /// </summary>
        public EventHandler<T> OnUpdate { get; set; }

        /// <summary>
        /// Create a new preferences manager. If a preferences file already exists in one of the provided filepaths use that path, otherwise use the last filepath from <paramref name="filenames"/>.
        /// </summary>
        /// <param name="filenames">An array of potential filepaths representing the preference file.</param>
        /// <param name="defaultPreferences">The default preference object, set null to use <see cref="Activator.CreateInstance{T}"/></param>
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

        /// <summary>
        /// Returns the first filepath that exists from <paramref name="filenames"/>, if none exist the last element is returned.
        /// </summary>
        /// <param name="filenames">An array contain filepaths.</param>
        /// <param name="defaultFile">The value to return if <paramref name="filenames"/> is empty.</param>
        /// <returns>The first filepath that exists from <paramref name="filenames"/>, if none exist the last element is returned.</returns>
        private static string FindExistingFile(string[] filenames, string defaultFile) {
            foreach (string file in filenames) {
                if (File.Exists(file))
                    return file;
            }
            return filenames.Length > 0 ? filenames.Last() : defaultFile;
        }

        /// <summary>
        /// Load the preferences file located at <see cref="PrefPath"/> and invoke the required event handlers. If the file doesn't exist and <paramref name="createIfNotExists"/> is true <see cref="Save"/> will be called (<see cref="OnLoad"/> will not be invoked).
        /// </summary>
        /// <param name="createIfNotExists"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Save the preferences object and invoke the required event handlers.
        /// </summary>
        public void Save() {
            Save(PrefPath, Preferences);
            OnSave?.Invoke(this, Preferences);
            OnUpdate?.Invoke(this, Preferences);
        }

        /// <summary>
        /// Serialize <paramref name="preferences"/> to the specified <paramref name="filepath"/>.
        /// </summary>
        /// <param name="filepath">The filepath to save the serialized preferences object.</param>
        /// <param name="preferences">The object to be serialized.</param>
        public static void Save(string filepath, T preferences) {
            Logger.Instance.Debug(nameof(PreferencesManager<T>), "Saving preferences to disk...");

            string json = JsonConvert.SerializeObject(preferences, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8))
                sw.WriteLine(json);
        }


    }
}
