namespace Maxstupo.YdlUi.Core.Options {

    /// <summary>Represents an implementation that can save and load a ISettings object.</summary>
    public interface ISettingsManager {

        /// <summary>The settings store. The instance should remain constant.</summary>
        ISettings Settings { get; }

        /// <summary>Load the settings instance, updating the values to what was stored.</summary>
        void Load();

        /// <summary>Save the settings instance so it can be reloaded in the future.</summary>
        void Save();

        /// <summary>Reset the settings instance to default values.</summary>
        void Reset();

    }

    /// <summary>A settings manager specifically for a file system. Provides initialization and a filepath.</summary>
    public interface IFileSettingsManager : ISettingsManager {

        /// <summary>The file location that loading and saving will read and write from.</summary>
        string Filepath { get; }

        // TODO: Update XML doc.
        string Directory { get; }

        // TODO: Update XML doc.
        /// <summary>Initialize this settings manager, by providing default settings and filepaths.</summary>
        void Init(ISettings defaults, string appName, string settingsName, string[] filepaths);

    }

}