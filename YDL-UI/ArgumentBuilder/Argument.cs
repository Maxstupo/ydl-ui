namespace Maxstupo.YdlUi.ArgumentBuilder {

    using System;

    /// <summary>
    /// Marks a property as a command line argument, contains metadata describing how to serialize the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Argument : Attribute {
        /// <summary>
        /// The flag representing this property argument.
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// The template defining how the flag and property value should be arranged.
        /// </summary>
        public string Template { get; set; } = "{flag}{seperator}{value}";

        /// <summary>
        /// The policy that determines if the property value should be quoted.
        /// </summary>
        public QuotePolicy QuotePolicy { get; set; } = QuotePolicy.WhenNecessary;

        /// <summary>
        /// The policy that determines the capitalization of enum properties.
        /// </summary>
        public EnumCasePolicy EnumCase { get; set; } = EnumCasePolicy.Lowercase;

        /// <summary>
        /// Arguments will be serialized in order of this number.
        /// </summary>
        public int Order { get; set; } = 0;

        /// <summary>
        /// Create a new <see cref="Argument"/> attribute.
        /// </summary>
        /// <param name="flag">The flag of this argument.</param>
        public Argument(string flag) {
            this.Flag = flag ?? throw new ArgumentNullException(nameof(flag));
        }

    }

}