namespace Maxstupo.YdlUi.Core.Options {
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>A key-value settings store backed by a Dictionary.</summary>
    public sealed class Settings : ISettings {

        private readonly Dictionary<string, object> dictionary = new Dictionary<string, object>();

        /// <summary>Returns a new readonly list of existing keys within this settings store.</summary>
        public IList<string> Keys => dictionary.Keys.ToList().AsReadOnly();

        public Settings() { }

        /// <summary>
        /// Create a new settings store filled with the values from the specified dictionary. 
        /// Values must be of type primitive or string.
        /// </summary>
        public Settings(Dictionary<string, object> options) {
            foreach (KeyValuePair<string, object> pair in options) {
                if (pair.Value != null) {
                    Type type = pair.Value.GetType();

                    if (!type.IsPrimitive && type != typeof(string))
                        throw new ArgumentException("Dictionary values must be primitive or strings!");
                }

                dictionary.Add(pair.Key, pair.Value);
            }
        }

        public void Set(string key, bool value) => SetValue(key, value);
        public void Set(string key, int value) => SetValue(key, value);
        public void Set(string key, string value) => SetValue(key, value);
        public void Set(string key, float value) => SetValue(key, value);

        private void SetValue(string key, object value) {
            dictionary[key] = value;
        }

        public T Get<T>(string key, T defaultValue = default) {
            return dictionary.TryGetValue(key, out object value) ? (T) Convert.ChangeType(value, typeof(T)) : defaultValue;
        }

        public object Get(string key) {
            return dictionary.TryGetValue(key, out object value) ? value : null;
        }

        /// <summary>
        /// Merges the key-value pairs from the specified settings object into this settings instance.
        /// Replaces any existing keys with values from the specified settings object.
        /// </summary>
        public void Apply(ISettings settings) {
            foreach (string key in settings.Keys)
                dictionary[key] = settings.Get(key);
        }

        public void Clear() {
            dictionary.Clear();
        }

        /// <summary>A wrapper implementation around an existing ISettings implementation - disabling all write based methods.</summary>
        public sealed class ReadonlySettings : ISettings {
            private readonly ISettings settings;

            public IList<string> Keys => settings.Keys;

            /// <summary>
            /// Create a new read-only wrapper by using the specified instance as the internal settings store.
            /// Changes to the provided settings store will be reflected within this readonly settings store.
            /// </summary>
            public ReadonlySettings(ISettings settings) {
                this.settings = settings;
            }

            /// <summary>
            /// Create a new settings store filled with the values from the specified dictionary. 
            /// Values must be of type primitive or string.
            /// </summary>
            public ReadonlySettings(Dictionary<string, object> options) : this(new Settings(options)) {
            }

            public T Get<T>(string key, T defaultValue = default) {
                return settings.Get(key, defaultValue);
            }

            public object Get(string key) {
                return settings.Get(key);
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Apply(ISettings settings) {
                throw new NotSupportedException("This settings object is read-only!");
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Clear() {
                throw new NotSupportedException("This settings object is read-only!");
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Set(string key, bool value) {
                throw new NotSupportedException("This settings object is read-only!");
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Set(string key, int value) {
                throw new NotSupportedException("This settings object is read-only!");
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Set(string key, string value) {
                throw new NotSupportedException("This settings object is read-only!");
            }

            /// <summary>Disabled! - This settings object is read-only!</summary>
            public void Set(string key, float value) {
                throw new NotSupportedException("This settings object is read-only!");
            }

        }

    }

}