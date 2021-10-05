namespace Maxstupo.YdlUi.Core.Options {
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>Represents an implementation that has settings.</summary>
    /// <typeparam name="T">The settings type.</typeparam>
    public interface ISettings<T> where T : class {

        /// <summary>The settings object.</summary>
        T Value { get; }

    }

    /// <summary>Represents an implementation that can save and load a settings object.</summary>
    public interface ISettingsManager {

        /// <summary>Invoked when the settings changes due to loading or resetting.</summary>
        EventHandler OnChanged { get; set; }

        /// <summary>Load the settings instance, updating the values to what was stored.</summary>
        void Load();

        /// <summary>Save the settings instance so it can be reloaded in the future.</summary>
        void Save();

        /// <summary>Reset the settings instance to default values.</summary>
        void Reset();

    }

    public interface ISettingsProvider {

        ISettings<T> GetSettings<T>(string key) where T : class;

    }

    public interface IFileSettingsManager : ISettingsManager {

        void Init((Type Type, string Key)[] defaults, string appName, string settingsName, params string[] filepaths);

    }

}