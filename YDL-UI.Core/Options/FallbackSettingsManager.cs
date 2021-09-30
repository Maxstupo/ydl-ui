namespace Maxstupo.YdlUi.Core.Options {
    using System.IO.Abstractions;
    using System.Linq;

    /// <summary>
    /// A settings manager for the file system using filepath "fallback" system.
    /// During initialization the first existing filepath will be used for saving and loading, or the first in the list if no filepaths exist.
    /// </summary>
    public abstract class FallbackSettingsManager : IFileSettingsManager {
        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;

        public string Filepath { get; private set; }

        /// <summary>The write-enabled settings store. This should be used when saving, loading, or reseting.</summary>
        protected readonly ISettings settings = new Settings();

        /// <summary>A readonly settings store. This instance will remain constant between loading, saving, and reseting.</summary>
        public ISettings Settings { get; }

        /// <summary>The readonly settings store for default values. Used for reseting to default values.</summary>
        protected ISettings Defaults { get; private set; }

        public FallbackSettingsManager(IFileSystem fileSystem) {
            this.fileSystem = fileSystem;
            Settings = new Settings.ReadonlySettings(settings);
        }

        /// <summary>
        /// Initialize this settings manager, the first filepath provided that exists will be used for saving and loading.
        /// If no filepaths exist the first in the array will be used. If no settings file is found, the settings manager 
        /// will be reset to defaults and save.
        /// </summary>
        public void Init(ISettings defaults, params string[] filepaths) {
            if (filepaths.Length == 0)
                throw new System.ArgumentException("At least one filepath must be provided!");

            Logger.Info("Initializing...");

            this.Filepath = filepaths.FirstOrDefault(x => fileSystem.File.Exists(x)) ?? filepaths.First();
            this.Defaults = new Settings.ReadonlySettings(defaults);

            Logger.Debug("Using settings filepath: {filepath}", Filepath);

            if (!fileSystem.File.Exists(Filepath)) {
                Logger.Warn("Settings file doesn't exist! Save defaults...");

                Reset();
                Save();
            }
        }

        public abstract void Load();

        public abstract void Reset();

        public abstract void Save();

    }


}