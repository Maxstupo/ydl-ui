namespace Maxstupo.YdlUi.Core.Arguments {
    using System;

    /// <summary>
    /// Represents an command-line argument, this includes information about format, data type, and, description.
    /// </summary>
    public sealed class ArgumentDefinition {

        public string Id { get; }
        public string Name { get; }

        /// <summary>
        /// The command-line flag this property argument is representing.
        /// </summary>
        public string Flag { get; }

        /// <summary>
        /// The template defining how the flag and property value should be arranged.
        /// </summary>
        public string Template { get; }

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

        public string Description { get; }

        public Type Type { get; }

        public bool Enabled { get; set; } = true;
        public bool Hidden { get; } 

        public ArgumentDefinition(string id, string flag, string template = null, QuotePolicy quotePolicy = QuotePolicy.WhenNecessary, EnumCasePolicy enumCase = EnumCasePolicy.Lowercase, int order = 0, Type type = null, string description = null) {
            this.Id = id;
            this.Flag = flag ?? throw new ArgumentNullException(nameof(flag));
            this.Template = template ?? "{flag}{separator}{value}";
            this.QuotePolicy = quotePolicy;
            this.EnumCase = enumCase;
            this.Order = order;
            this.Type = type ?? typeof(string);
            this.Description = description ?? string.Empty;

        }

    }

}