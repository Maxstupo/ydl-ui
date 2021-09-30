namespace Maxstupo.YdlUi.Core.Arguments {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A multi-purpose argument serializer that can be derived to add handling for additional types and functionalities.
    /// </summary>
    public class ArgumentSerializer : IArgumentSerializer, ICommandLineSerializer {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// A lookup dictionary to translate argument object values to strings. If the argument data type isn't defined in the dictionary, <see cref="Object.ToString()"/> will be used instead.
        /// </summary>
        protected Dictionary<Type, Func<ArgumentDefinition, object, string>> ValueTranslators { get; } = new Dictionary<Type, Func<ArgumentDefinition, object, string>>();

        /// <summary>
        /// A defined function called for all arguments to check if they should be serialized.
        /// </summary>
        protected Func<ArgumentDefinition, object, bool> CommonChecker { get; set; }

        /// <summary>
        /// A lookup dictionary to check if an argument of a specific data type should be serialized.
        /// </summary>
        protected Dictionary<Type, Func<ArgumentDefinition, object, bool>> Checkers { get; } = new Dictionary<Type, Func<ArgumentDefinition, object, bool>>();

        /// <summary>
        /// A dictionary of builders used to create argument strings for specific argument data types.
        /// </summary>
        protected Dictionary<Type, Func<ArgumentDefinition, object, string>> Builders { get; } = new Dictionary<Type, Func<ArgumentDefinition, object, string>>();


        /// <summary>The separator between each argument.</summary>
        protected string ArgumentSeparator { get; set; } = " ";

        /// <summary>The separator between each flag and value.</summary>
        protected string Separator { get; set; } = " ";

        public ArgumentSerializer() {
            Init();
        }

        /// <summary>
        /// Setup this argument serializer. Override this method to add additional type handling.
        /// </summary>
        protected virtual void Init() {
            ValueTranslators.Clear();
            Builders.Clear();
            Checkers.Clear();

            ArgumentSeparator = " ";
            Separator = " ";

            // Only serialize flag if value isn't null. This is called before any other registered serialization checkers.
            CommonChecker = (argument, value) => value != null;

            // Only serialize boolean flags if the value is true.
            Checkers.Add(typeof(bool), (argument, value) => (bool) value); // Serialize boolean flags if value isn't false.

            // Only serialize dictionaries if they contain items.
            Checkers.Add(typeof(Dictionary<string, string>), (argument, value) => ((Dictionary<string, string>) value).Count > 0);

            // Translates string properties to string... duh!
            ValueTranslators.Add(typeof(string), (argument, value) => value.ToString());

            // Translates enum properties to string by using the name representing the enum value.
            ValueTranslators.Add(typeof(Enum), (argument, value) => {
                string name = Enum.GetName(argument.Type, value);

                switch (argument.EnumCase) {
                    case EnumCasePolicy.Lowercase:
                        return name.ToLower();
                    case EnumCasePolicy.Uppercase:
                        return name.ToUpper();
                    case EnumCasePolicy.Default:
                    default:
                        return name;
                }
            });
        }

        public string Serialize(string filename, IArgumentsCollection argumentsCollection) {
            return $"{filename} {Serialize(argumentsCollection)}";
        }

        public string Serialize(IArgumentsCollection argumentsCollection) {
            // Serialize and sort by argument order.
            List<BuiltFlag> flags = SerializeObject(argumentsCollection).OrderBy(x => x.Argument.Order).ToList();

            // Build the argument string.
            StringBuilder sb = new StringBuilder();
            flags.ForEach(flag => sb.Append(flag.Value).Append(ArgumentSeparator));

            if (flags.Count > 0) // remove unneeded last argument separator.
                sb.Remove(sb.Length - ArgumentSeparator.Length, ArgumentSeparator.Length);

            return sb.ToString();
        }

        private IEnumerable<BuiltFlag> SerializeObject(IArgumentsCollection argumentsCollection) {
            if (argumentsCollection == null)
                yield break;

            foreach (ArgumentDefinition argument in argumentsCollection.Definitions) {

                object value = argumentsCollection.Get(argument.Id); // The value of the argument.

                if (!ShouldAppendFlag(argument, value))
                    continue;

                Type typeKey = argument.Type.IsEnum ? typeof(Enum) : argument.Type;

                // Build the flag using a custom builder if registered for the property type.
                string builtFlag;
                if (Builders.TryGetValue(typeKey, out Func<ArgumentDefinition, object, string> builder)) {
                    builtFlag = builder(argument, value);

                } else { // else build the flag with the registered value translators.
                    string translatedValue = TranslateFlagValue(argument, value);
                    builtFlag = BuildFlag(argument, translatedValue);
                }

                if (!string.IsNullOrWhiteSpace(builtFlag))
                    yield return new BuiltFlag(argument, builtFlag);

            }

        }

        /// <summary>
        /// Translates the raw object value of this argument into a valid string value. 
        /// Uses a registered value translator if available, else uses ToString(). See <see cref="ValueTranslators"/>.
        /// </summary>
        protected virtual string TranslateFlagValue(ArgumentDefinition argument, object value) {
            if (value == null)
                return string.Empty;

            Type typeKey = argument.Type.IsEnum ? typeof(Enum) : argument.Type;

            if (ValueTranslators.TryGetValue(typeKey, out Func<ArgumentDefinition, object, string> translator))
                return translator(argument, value);

            return value.ToString();
        }

        /// <summary>
        /// Returns true if this argument and value are valid based on checking registered checkers.
        /// See <see cref="CommonChecker"/> and <see cref="Checkers"/>.
        /// </summary>
        protected virtual bool ShouldAppendFlag(ArgumentDefinition argument, object value) {

            if (CommonChecker != null && !CommonChecker(argument, value))
                return false;

            if (Checkers.TryGetValue(argument.Type, out Func<ArgumentDefinition, object, bool> append))
                return append(argument, value);

            return true;
        }

        /// <summary>
        /// Returns the combined flag and value, based on the argument template.
        /// </summary>
        /// <param name="argument">The argument that contains the template and flag.</param>
        /// <param name="value">The value of the argument.</param>
        /// <returns>A combined flag and value.</returns>
        protected virtual string BuildFlag(ArgumentDefinition argument, string value) {
            string quotedValue = QuoteValue(argument.QuotePolicy, value);
            string builtFlag = argument.Template;

            return builtFlag
                .Replace("{separator}", Separator.ToString())
                .Replace("{flag}", argument.Flag)
                .Replace("{value}", quotedValue);
        }

        /// <summary>
        /// Quotes and returns the given <paramref name="value"/> if the <paramref name="policy"/> matches the content of the given value.
        /// </summary>
        /// <param name="policy">The <see cref="QuotePolicy"/> to check for.</param>
        /// <param name="value">The string value to apply the <see cref="QuotePolicy"/>.</param>
        /// <returns>A quoted or unquoted variant of <paramref name="value"/>.</returns>
        protected string QuoteValue(QuotePolicy policy, string value) {
            bool containsWhitespace = value.Contains(' ');
            bool notAlphaNumeric = !value.All(char.IsLetterOrDigit);

            if (policy == QuotePolicy.Always || (policy == QuotePolicy.WhenNecessary && (containsWhitespace || notAlphaNumeric)))
                return $"\"{value}\"";

            return value;
        }


        /// <summary>
        /// A container struct that holds an Argument attribute and the parsed value of its property.
        /// </summary>
        protected struct BuiltFlag {
            public ArgumentDefinition Argument { get; }
            public string Value { get; }

            public BuiltFlag(ArgumentDefinition argument, string value) {
                this.Argument = argument;
                this.Value = value;
            }
        }

    }

}
