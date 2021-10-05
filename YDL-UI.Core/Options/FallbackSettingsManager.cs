namespace Maxstupo.YdlUi.Core.Options {
    using System;
    using System.Collections.Generic;
    using System.IO.Abstractions;
    using System.Linq;

    /// <summary>
    /// A settings manager for the file system using filepath "fallback" system.
    /// During initialization the first existing filepath will be used for saving and loading, or the first in the list if no filepaths exist.
    /// </summary>
    public abstract class FallbackSettingsManager : IFileSettingsManager, ISettingsProvider {
        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;

        public string Filepath { get; private set; }
        public string Directory => fileSystem.Path.GetDirectoryName(Filepath);

        public abstract EventHandler OnChanged { get; set; }

        protected (Type Type, string Key)[] Defaults { get; private set; }

        public FallbackSettingsManager(IFileSystem fileSystem) {
            this.fileSystem = fileSystem;
        }

        /// <summary>
        /// Initialize this settings manager, the first filepath provided that exists will be used for saving and loading.
        /// If no filepaths exist the last in the array will be used. If no settings file is found, the settings manager 
        /// will be reset to defaults and save.
        /// </summary>
        public void Init((Type Type, string Key)[] defaults, string appName, string settingsName, params string[] filepaths) {
            if (filepaths.Length == 0)
                throw new ArgumentException("At least one filepath must be provided!");

            Logger.Info("Initializing...");
            this.Defaults = defaults;
            this.Filepath = filepaths.FirstOrDefault(x => {
                Logger.Debug("Checking for settings at {filepath}", fileSystem.Path.GetFullPath(x));
                return fileSystem.File.Exists(x);
            });

            if (this.Filepath == null) {
                Logger.Info("Failed to find local settings, using AppData for settings...");

                string appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appDirectory = fileSystem.Path.Combine(appDataDirectory, appName);

                fileSystem.Directory.CreateDirectory(appDirectory);

                this.Filepath = fileSystem.Path.Combine(appDirectory, settingsName);
            }


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

        public abstract ISettings<T> GetSettings<T>(string key) where T : class;

    }


}