namespace Maxstupo.YdlUi.Core.Arguments {
    using System;

    /// <summary>
    /// Represents an command-line argument, this includes information about format, data type, and, description.
    /// </summary>
    public sealed class ArgumentDefinition {

        public string Id { get; }

        public string Name { get; }

        public string Description { get; }

        /// <summary>
        /// The command-line flag this property argument is representing.
        /// </summary>
        public string Flag { get; }

        /// <summary>
        /// The template defining how the flag and property value should be arranged.
        /// </summary>
        public string Template { get; } = "{flag}{separator}{value}";

        /// <summary>
        /// The policy that determines if the property value should be quoted.
        /// </summary>
        public QuotePolicy QuotePolicy { get; }

        /// <summary>
        /// The policy that determines the capitalization of enum properties.
        /// </summary>
        public EnumCasePolicy EnumCase { get; }

        /// <summary>
        /// Arguments will be serialized in ascending order according to this number.
        /// </summary>
        public int Order { get; }

        public Type Type { get; }

        public bool Enabled { get; set; } = true;

        public bool Hidden { get; }

        public ArgumentDefinition(string id, string name, string description, string flag, string template = null, QuotePolicy? quotePolicy = QuotePolicy.WhenNecessary, EnumCasePolicy? enumCase = EnumCasePolicy.Lowercase, int? order = 0, Type type = null, bool hidden = false) {
            this.Id = id ?? throw new ArgumentNullException(nameof(id));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Description = description ?? string.Empty;
            this.Flag = flag ?? throw new ArgumentNullException(nameof(flag));
            this.Template = template ?? this.Template;
            this.QuotePolicy = quotePolicy.GetValueOrDefault(QuotePolicy.WhenNecessary);
            this.EnumCase = enumCase.GetValueOrDefault(EnumCasePolicy.Lowercase);
            this.Order = order ?? 0;
            this.Type = type ?? typeof(string);
            this.Description = description ?? string.Empty;
            this.Hidden = hidden;

            if (Type.IsPrimitive) {
                throw new ArgumentException("The type must be nullable if it's a primitive");

            } else if (Nullable.GetUnderlyingType(Type) == null && Type != typeof(string))
                throw new ArgumentException("The type can only be a nullable primitive or a string!");

        }

    }

}