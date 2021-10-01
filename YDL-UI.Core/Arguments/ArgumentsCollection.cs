namespace Maxstupo.YdlUi.Core.Arguments {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Maxstupo.YdlUi.Core.Utility.Extensions;

    /// <summary>Represents an implementation that can provide argument collections.</summary>
    public interface IArgumentsProvider {

        IArgumentsCollection CreateArguments(string key = null);

    }

    /// <summary>
    /// Represents an implementation that provides the means to set and get argument values based on predefined argument definitions.
    /// </summary>
    public interface IArgumentsCollection {

        string Key { get; }

        /// <summary>The valid definitions that can be used within this collection.</summary>
        IList<ArgumentDefinition> Definitions { get; }

        /// <summary>
        /// Returns true if this collection has the given argument. If it does it will be available within the Definitions property.
        /// </summary>
        bool Has(string id);

        /// <summary>Returns the argument value cast, or the default value specified, or the default value of the type.</summary>
        T Get<T>(string id, T defaultValue = default);

        /// <summary>Returns the raw argument object value, or null if no object exists with the given id.</summary>
        object Get(string id);

        /// <summary>
        /// Set the given argument to equal the value specified. 
        /// Method will silently fail if no argument exists with the given id.
        /// </summary>
        void Set(string id, object value);

    }

    /// <summary>An argument collection backed by a Dictionary.</summary>
    public sealed class ArgumentsCollection : IArgumentsCollection {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public string Key { get; }

        /// <summary>A readonly list of valid definitions that can be used within this collection.</summary>
        public IList<ArgumentDefinition> Definitions { get; }

        private readonly Dictionary<string, object> values = new Dictionary<string, object>();

        /// <summary>
        /// Create a new arguments collection using the provided arguments definitions. Argument values will be initialized to their defaults. 
        /// If multiple arguments exist with the same ID, it will be logged and ignored, but no error exception will be thrown.
        /// </summary>
        public ArgumentsCollection(string key, params ArgumentDefinition[] argumentDefinitions) : this(key, argumentDefinitions.ToList()) {
        }

        /// <summary>
        /// Create a new arguments collection using the provided arguments definitions. Argument values will be initialized to their defaults. 
        /// If multiple arguments exist with the same ID, it will be logged and ignored, but no error exception will be thrown.
        /// </summary>
        public ArgumentsCollection(string key, List<ArgumentDefinition> argumentDefinitions) {
            this.Key = key;
            this.Definitions = argumentDefinitions.AsReadOnly();

            foreach (ArgumentDefinition definition in argumentDefinitions) {
                if (values.ContainsKey(definition.Id)) {
                    Logger.Warn("An argument definition with the id {id} already exists in this collection! Ignoring...", definition.Id);
                    continue;
                }

                values[definition.Id] = definition.Type.GetDefaultValue();
            }
        }

        public T Get<T>(string id, T defaultValue = default) {
            return values.TryGetValue(id, out object value) ? (T) Convert.ChangeType(value, typeof(T)) : defaultValue;
        }

        public object Get(string id) {
            return values.TryGetValue(id, out object value) ? value : null;
        }

        public bool Has(string id) {
            return values.ContainsKey(id);
        }

        public void Set(string id, object value) {
            if (Has(id))
                values[id] = value;
            else
                Logger.Warn("Failed to set argument {id} not a valid argument id for this {key} argument collection.", id, Key);
        }

    }

}