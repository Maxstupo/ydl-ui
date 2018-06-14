using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.CommandBuilder {
    [Flags]
    public enum ProcType : byte {
        NONE = 0,
        ERROR = 1,
        DATA_RECEIVED = 2,
        EXITED = 4
    }
    public delegate bool ProcessCallback(string data, ProcType type);

    public class BuiltFlag {
        public Argument Argument { get; }
        public string Value { get; }

        public BuiltFlag(Argument argument, string value) {
            this.Argument = argument;
            this.Value = value;
        }
    }

    public abstract class CommandLineBuilder<T> where T : class {
        public string Executable { get; set; }

        public T Arguments { get; set; }
        public abstract string Version { get; }

        protected Dictionary<Type, Func<Argument, Type, object, string>> ValueTranslators { get; } = new Dictionary<Type, Func<Argument, Type, object, string>>();

        protected Func<Argument, Type, object, bool> PreAppendChecker { get; set; }
        protected Dictionary<Type, Func<Argument, Type, object, bool>> AppendCheckers { get; } = new Dictionary<Type, Func<Argument, Type, object, bool>>();
        protected Dictionary<Type, Func<Argument, Type, object, string>> Builders { get; } = new Dictionary<Type, Func<Argument, Type, object, string>>();

        public char FlagSeperator { get; set; } = ' ';

        public CommandLineBuilder(string executable, T arguments = default(T)) {
            this.Executable = executable;
            this.Arguments = arguments;

            SetDefaults();
        }

        protected void SetDefaults(bool clear = true) {
            if (clear) {
                ValueTranslators.Clear();
                Builders.Clear();
                AppendCheckers.Clear();
                PreAppendChecker = null;
            }

            // Translates string properties to string... duh!
            ValueTranslators.Add(typeof(string), (a, t, v) => v.ToString());

            // Translates enum properties to string by using the name representing the enum value.
            ValueTranslators.Add(typeof(Enum), (a, t, v) => {
                string name = Enum.GetName(t, v);
                return a.EnumCase == EnumCasePolicy.LOWERCASE ? name.ToLower() : a.EnumCase == EnumCasePolicy.UPPERCASE ? name.ToUpper() : name;
            });

            // Only append flag if value isn't null. This is checked before any other registered append checkers.
            PreAppendChecker = (a, t, v) => v != null;

            // Only append boolean flags if the value is true.
            AppendCheckers.Add(typeof(bool), (a, t, v) => (bool)v); // Add bool flags if value isnt false.

            // Custom builder for string -> string dictionaries repeatedly adds flag with key-value pair seperated by colon.
            Builders.Add(typeof(Dictionary<string, string>), (a, t, v) => {
                string builtFlag = string.Empty;
                int count = 0;

                Dictionary<string, string> dic = (Dictionary<string, string>)v;
                foreach (KeyValuePair<string, string> entry in dic) {
                    string value = string.Format("{0}:{1}", entry.Key, entry.Value);
                    value = QuoteFlagValue(a.QuotePolicy, value);

                    builtFlag += string.Format("{0}{1} ", (dic.Count > 1 && count > 0) ? (a.Flag + " ") : string.Empty, value);
                    count++;
                }

                if (dic.Count > 0)
                    builtFlag = builtFlag.Remove(builtFlag.Length - 1, 1);

                return a.Template.Replace("{flag}", a.Flag).Replace("{value}", builtFlag);
            });
        }

        public bool Execute(string workingDirectory = null) {
            string arguments = BuildArgumentsString();
            return DoExecute(arguments, workingDirectory);
        }

        public bool Execute(ProcessCallback callback, string workingDirectory = null) {
            string arguments = BuildArgumentsString();
            return DoExecute(arguments, workingDirectory, callback);
        }

        protected abstract bool DoExecute(string arguments, string workingDirectory, ProcessCallback callback=null);

        public bool ExecuteWithTempArguments(T tempArguments, ProcessCallback callback, string workingDirectory = null) {
            T savedArgs = Arguments;
            Arguments = tempArguments;

            bool result = Execute(callback, workingDirectory);

            Arguments = savedArgs;
            return result;
        }

        public string BuildCommandString() {
            string args = BuildArgumentsString();
            return string.Format("{0} {1}", Executable, args);
        }

        public string BuildArgumentsString() {
            List<BuiltFlag> arguments = BuildArgumentsString(Arguments, new List<BuiltFlag>(), true);
            arguments.Sort((x, y) => x.Argument.Order - y.Argument.Order);

            StringBuilder sb = new StringBuilder();
            foreach (BuiltFlag arg in arguments)
                sb.Append(arg.Value).Append(FlagSeperator);

            return sb.ToString().Trim(FlagSeperator);
        }

        private List<BuiltFlag> BuildArgumentsString(object obj, List<BuiltFlag> flags, bool failWithoutAttribute) {
            if (obj == null)
                return flags;

            Type containerType = obj.GetType();
            if (containerType.GetCustomAttribute<ArgumentContainer>() == null)
                return !failWithoutAttribute ? flags : throw new Exception("Invalid argument object! Must have ArgumentContainer attribute defined for class!");


            // Get all properties from arguments object.
            PropertyInfo[] propertyInfos = containerType.GetProperties(BindingFlags.Instance | BindingFlags.Public);


            foreach (PropertyInfo propertyInfo in propertyInfos) {
                Type propertyType = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType; // The property type.

                object value = propertyInfo.GetValue(obj, null); // The value of the property.



                Argument argument = propertyInfo.GetCustomAttribute<Argument>();
                if (argument == null) { // Only process properties that have an Argument attribute defined.
                    if (propertyType.IsClass)
                        BuildArgumentsString(value, flags, false); // Inspect objects that are defined without an argument attribute.
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

                flags.Add(new BuiltFlag(argument, builtFlag));
            }

            return flags;
        }

        public virtual string TranslateFlagValue(Argument argument, Type type, object value) {
            if (value == null)
                return string.Empty;

            Type typeKey = type.IsEnum ? typeof(Enum) : type;

            if (ValueTranslators.TryGetValue(typeKey, out Func<Argument, Type, object, string> translator))
                return translator(argument, type, value);
            return value.ToString();
        }

        public virtual bool ShouldAppendFlag(Argument argument, Type type, object value) {

            if (PreAppendChecker != null && !PreAppendChecker(argument, type, value))
                return false;

            if (AppendCheckers.TryGetValue(type, out Func<Argument, Type, object, bool> append))
                return append(argument, type, value);

            return true;
        }

        public virtual string QuoteFlagValue(QuotePolicy policy, string value) {
            bool containsWhitespace = value.Contains(' ');
            bool notAlphaNumeric = !value.All(char.IsLetterOrDigit);

            if (policy == QuotePolicy.ALWAYS || (policy == QuotePolicy.WHEN_NECESSARY && (containsWhitespace || notAlphaNumeric)))
                return string.Format("\"{0}\"", value);
            return value;
        }

        public virtual string BuildFlag(Argument argument, string value) {
            string val = QuoteFlagValue(argument.QuotePolicy, value);
            return argument.Template.Replace("{flag}", argument.Flag).Replace("{value}", val).Trim(' ');
        }


        public abstract bool IsCompatibleVersion(string version);


    }
}
