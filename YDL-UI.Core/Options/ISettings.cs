namespace Maxstupo.YdlUi.Core.Options {
    using System.Collections.Generic;

    /// <summary>Represents an implementation of a key-value pair settings store.</summary>
    public interface ISettings {

        /// <summary>Returns a list of existing keys within this settings store.</summary>
        IList<string> Keys { get; }

        /// <summary>Returns the cast value for the associated key, or the specified default value, or the default value of that type.</summary>
        T Get<T>(string key, T defaultValue = default);

        /// <summary>Returns the raw object value for the associated key, or null if the entry doesn't exist.</summary>
        object Get(string key);

        /// <summary>Set the given key to equal the specified value.</summary>
        void Set(string key, bool value);

        /// <summary>Set the given key to equal the specified value.</summary>
        void Set(string key, int value);

        /// <summary>Set the given key to equal the specified value.</summary>
        void Set(string key, string value);

        /// <summary>Set the given key to equal the specified value.</summary>
        void Set(string key, float value);

        /// <summary>Deletes all key-value pairs from this store.</summary>
        void Clear();

        /// <summary>Merges the key-value pairs from the specified settings object into this settings instance.</summary>
        void Apply(ISettings settings);

    }

}