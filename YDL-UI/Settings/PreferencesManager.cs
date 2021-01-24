namespace Maxstupo.YdlUi.Settings {

    using System;
    using System.IO;
    using System.Text;
    using Maxstupo.YdlUi.Utility;
    using Newtonsoft.Json;

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
        public string PrefDirectory => new FileInfo(PrefPath).DirectoryName;

        /// <summary>
        /// The preferences object, this object will be serialized/deserialized to the <see cref="PrefPath"/>.
        /// </summary>
        public T Preferences { get; private set; }

        /// <summary>
        /// Invoked before the preferences have been saved from calling <see cref="Save"/>. 
        /// </summary>
        public event EventHandler<T> OnPreSave;

        /// <summary>
        /// Invoked after the preferences have been saved from calling <see cref="Save"/>. Called before <see cref="OnUpdate"/>.
        /// </summary>
        public event EventHandler<T> OnSave;

        /// <summary>
        /// Invoked after the preferences have been loaded from calling <see cref="Load(bool)"/>. Called before <see cref="OnUpdate"/>.
        /// </summary>
        public event EventHandler<T> OnLoad;

        /// <summary>
        /// Invoked when <see cref="Load(bool)"/> or <see cref="Save"/> is called.
        /// </summary>
        public event EventHandler<T> OnUpdate;

        /// <summary>
        /// Create a new preferences manager.
        /// </summary>
        /// <param name="filepath">The filepath to the preference file.</param>
        /// <param name="defaultPreferences">The default preference object, set null to use <see cref="Activator.CreateInstance{T}"/></param>
        public PreferencesManager(string filepath, T defaultPreferences = null) {
            PrefPath = filepath ?? throw new ArgumentNullException(nameof(filepath));

            Logger.Instance.Debug(nameof(PreferencesManager<T>), "Found preferences filepath: {0}", PrefPath);

            string directory = string.Empty;
            try {
                directory = PrefDirectory;
                if (!Directory.Exists(directory)) {
                    Logger.Instance.Debug(nameof(PreferencesManager<T>), "Creating application directory: {0}", directory);
                    Directory.CreateDirectory(directory);
                }
            } catch (Exception) {
                Logger.Instance.Error(nameof(PreferencesManager<T>), "Failed to create application directory: {0}", directory);
            }

            Preferences = defaultPreferences ?? Activator.CreateInstance<T>();
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

            Preferences = JsonConvert.DeserializeObject<T>(File.ReadAllText(PrefPath, Encoding.UTF8));

            OnLoad?.Invoke(this, Preferences);
            OnUpdate?.Invoke(this, Preferences);
            return true;
        }

        /// <summary>
        /// Save the preferences object and invoke the required event handlers.
        /// </summary>
        public void Save() {
            OnPreSave?.Invoke(this, Preferences);
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

            File.WriteAllText(filepath, JsonConvert.SerializeObject(preferences, Formatting.Indented), Encoding.UTF8);
        }

    }

}