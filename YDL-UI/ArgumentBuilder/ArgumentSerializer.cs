using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Maxstupo.YdlUi.ArgumentBuilder {

    /// <summary>
    /// Serializes object properties into a command-line argument string.
    /// </summary>
    public class ArgumentSerializer {
        /// <summary>
        /// A lookup dictionary to translate argument object values to strings. If the argument data type isn't defined in the dictionary, <see cref="Object.ToString()"/> will be used instead.
        /// </summary>
        protected Dictionary<Type, Func<Argument, Type, object, string>> ValueTranslators { get; } = new Dictionary<Type, Func<Argument, Type, object, string>>();

        /// <summary>
        /// A defined function called for all arguments to check if they should be serialized.
        /// </summary>
        protected Func<Argument, Type, object, bool> CommonSerializationChecker { get; set; }

        /// <summary>
        /// A lookup dictionary to check if an argument of a specific data type should be serialized.
        /// </summary>
        protected Dictionary<Type, Func<Argument, Type, object, bool>> SerializationCheckers { get; } = new Dictionary<Type, Func<Argument, Type, object, bool>>();

        /// <summary>
        /// A dictionary of builders used to create argument strings for specific argument data types.
        /// </summary>
        protected Dictionary<Type, Func<Argument, Type, object, string>> Builders { get; } = new Dictionary<Type, Func<Argument, Type, object, string>>();

        /// <summary>
        /// The seperator between each argument.
        /// </summary>
        protected string ArgumentSeperator { get; set; } = " ";

        /// <summary>
        /// The seperator between each flag and value.
        /// </summary>
        protected string Seperator { get; set; } = " ";

        public ArgumentSerializer() {
            SetDefaults();
        }

        /// <summary>
        /// Sets this <see cref="CommandLineBuilder"/> to its default settings.
        /// </summary>
        public virtual void SetDefaults() {

            ValueTranslators.Clear();
            Builders.Clear();
            SerializationCheckers.Clear();

            ArgumentSeperator = " ";
            Seperator = " ";

            // Only serialize flag if value isn't null. This is called before any other registered serialization checkers.
            CommonSerializationChecker = (a, t, v) => v != null;

            // Only serialize boolean flags if the value is true.
            SerializationCheckers.Add(typeof(bool), (a, t, v) => (bool)v); // Serialize boolean flags if value isn't false.

            // Only serialize dictionaries if they contain items.
            SerializationCheckers.Add(typeof(Dictionary<string, string>), (a, t, v) => ((Dictionary<string, string>)v).Count > 0);

            // Translates string properties to string... duh!
            ValueTranslators.Add(typeof(string), (a, t, v) => v.ToString());

            // Translate DateTime objects to the format of "yyyyMMdd".
            ValueTranslators.Add(typeof(DateTime), (a, t, v) => ((DateTime)v).ToString("yyyyMMdd"));

            // Translates enum properties to string by using the name representing the enum value.
            ValueTranslators.Add(typeof(Enum), (a, t, v) => {
                string name = Enum.GetName(t, v);

                switch (a.EnumCase) {
                    case EnumCasePolicy.Lowercase:
                        return name.ToLower();
                    case EnumCasePolicy.Uppercase:
                        return name.ToUpper();
                    case EnumCasePolicy.Default:
                    default:
                        return name;
                }
            });


            // Custom builder for string -> string dictionaries repeatedly adds flag with key-value pair seperated by colon.
            Builders.Add(typeof(Dictionary<string, string>), (argument, type, value) => {
                Dictionary<string, string> dictionary = (Dictionary<string, string>)value;
                if (dictionary.Count == 0)
                    return null; // Returning null for a builder, or value translator ignores this argument.

                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, string> entry in dictionary)
                    sb.Append(BuildFlag(argument, string.Format("{0}:{1}", entry.Key, entry.Value))).Append(ArgumentSeperator);

                if (dictionary.Count > 1)
                    sb.Remove(sb.Length - ArgumentSeperator.Length, ArgumentSeperator.Length);

                return sb.ToString();
            });
        }


        /// <summary>
        /// Serializes the given object and returns a command-line argument string.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <param name="failWithoutAttribute">If true the given object must have <see cref="ArgumentContainer"/> defined on the class.</param>
        /// <returns>A command-line argument string, or an empty string.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="obj"/> is null.</exception>
        /// <exception cref="Exception">If <paramref name="failWithoutAttribute"/> is true, and the object is missing the <see cref="ArgumentContainer"/> attribute.</exception>
        /// <seealso cref="Argument"/>
        /// <seealso cref="FlagArgument"/>
        public string Serialize(object obj, bool failWithoutAttribute = true) {
            List<BuiltFlag> flags = Serialize(obj, failWithoutAttribute, new List<BuiltFlag>());
            flags.Sort((x, y) => x.Argument.Order - y.Argument.Order);

            StringBuilder sb = new StringBuilder();
            flags.ForEach(flag => sb.Append(flag.Value).Append(ArgumentSeperator));

            if (flags.Count > 0)
                sb.Remove(sb.Length - ArgumentSeperator.Length, ArgumentSeperator.Length);

            return sb.ToString();

        }

        private List<BuiltFlag> Serialize(object obj, bool failWithoutAttribute, List<BuiltFlag> flags) {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            Type containerType = obj.GetType();
            if (containerType.GetCustomAttribute<ArgumentContainer>() == null)
                return !failWithoutAttribute ? flags : throw new Exception("Invalid argument object! Must have ArgumentContainer attribute defined for class!");


            // Get all properties from arguments object.
            PropertyInfo[] propertyInfos = containerType.GetProperties(BindingFlags.Instance | BindingFlags.Public);


            foreach (PropertyInfo propertyInfo in propertyInfos) {
                Type propertyType = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType; // The property type.

                object value = propertyInfo.GetValue(obj, null); // The value of the property.


                // Only process properties that have an Argument attribute defined.
                Argument argument = propertyInfo.GetCustomAttribute<Argument>();
                if (argument == null) {
                    if (propertyType.IsClass)
                        Serialize(value, true, flags); // Inspect objects that are defined without an argument attribute.

                    continue;
                }

                if (!ShouldAppendFlag(argument, propertyType, value))
                    continue;

                Type typeKey = propertyType.IsEnum ? typeof(Enum) : propertyType;

                // Build the flag using a custom builder if registered for the property type.
                string builtFlag;
                if (Builders.TryGetValue(typeKey, out Func<Argument, Type, object, string> builder)) {
                    builtFlag = builder(argument, propertyType, value);

                } else { // Else build the flag with the registered value translators.
                    string translatedValue = TranslateFlagValue(argument, propertyType, value);
                    builtFlag = BuildFlag(argument, translatedValue);
                }

                if (!string.IsNullOrWhiteSpace(builtFlag))
                    flags.Add(new BuiltFlag(argument, builtFlag));
            }

            return flags;
        }

        /// <summary>
        /// Returns the combined flag and value, based on the argument template.
        /// </summary>
        /// <param name="argument">The argument that contains the template and flag.</param>
        /// <param name="value">The value of the argument.</param>
        /// <returns>A combined flag and value.</returns>
        protected virtual string BuildFlag(Argument argument, string value) {
            string quotedValue = QuoteValue(argument.QuotePolicy, value);
            string builtFlag = argument.Template;

            builtFlag = builtFlag.Replace("{seperator}", Seperator.ToString());
            builtFlag = builtFlag.Replace("{flag}", argument.Flag);
            builtFlag = builtFlag.Replace("{value}", quotedValue);
            return builtFlag;
        }

        protected virtual string TranslateFlagValue(Argument argument, Type type, object value) {
            if (value == null)
                return string.Empty;

            Type typeKey = type.IsEnum ? typeof(Enum) : type;

            if (ValueTranslators.TryGetValue(typeKey, out Func<Argument, Type, object, string> translator))
                return translator(argument, type, value);

            return value.ToString();
        }

        protected virtual bool ShouldAppendFlag(Argument argument, Type type, object value) {

            if (CommonSerializationChecker != null && !CommonSerializationChecker(argument, type, value))
                return false;

            if (SerializationCheckers.TryGetValue(type, out Func<Argument, Type, object, bool> append))
                return append(argument, type, value);

            return true;
        }

        /// <summary>
        /// Quotes and returns the given <paramref name="value"/> if the <paramref name="policy"/> matches the content of the given value.
        /// </summary>
        /// <param name="policy">The <see cref="QuotePolicy"/> to check for.</param>
        /// <param name="value">The string value to apply the <see cref="QuotePolicy"/>.</param>
        /// <returns>A quoted or unquoted variant of <paramref name="value"/>.</returns>
        protected virtual string QuoteValue(QuotePolicy policy, string value) {
            bool containsWhitespace = value.Contains(' ');
            bool notAlphaNumeric = !value.All(char.IsLetterOrDigit);

            if (policy == QuotePolicy.Always || (policy == QuotePolicy.WhenNecessary && (containsWhitespace || notAlphaNumeric)))
                return string.Format("\"{0}\"", value);
            return value;
        }


        /// <summary>
        /// A container struct that holds an <see cref="Maxstupo.CommandBuilder.Argument"/> attribute and the parsed value of its property.
        /// </summary>
        protected struct BuiltFlag {
            public Argument Argument { get; }
            public string Value { get; }

            public BuiltFlag(Argument argument, string value) {
                this.Argument = argument;
                this.Value = value;
            }
        }

    }
}
