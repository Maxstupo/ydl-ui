﻿namespace Maxstupo.YdlUi.Core.Arguments {
    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class ArgumentContainer : Attribute { }

    /// <summary>
    /// Marks a property as a command-line argument, contains metadata describing how to serialize the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class Argument : Attribute {

        // public string Id { get; }
        // public string Name { get; set; }
        // public string Description { get; set; }

        public bool Hidden { get; set; } = false;

        /// <summary>
        /// The command-line flag this property argument is representing.
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// The template defining how the flag and property value should be arranged.
        /// </summary>
        public string Template { get; set; } = "{flag}{separator}{value}";

        /// <summary>
        /// The policy that determines if the property value should be quoted.
        /// </summary>
        public QuotePolicy QuotePolicy { get; set; } = QuotePolicy.WhenNecessary;

        /// <summary>
        /// The policy that determines the capitalization of enum properties.
        /// </summary>
        public EnumCasePolicy EnumCase { get; set; } = EnumCasePolicy.Lowercase;

        /// <summary>
        /// Arguments will be serialized in ascending order according to this number.
        /// </summary>
        public int Order { get; set; } = 0;

        /// <summary>
        /// Create a new <see cref="Argument"/> attribute.
        /// </summary>
        /// <param name="flag">The command-line flag this property argument is representing.</param>
        public Argument(string flag) {
            this.Flag = flag ?? throw new ArgumentNullException(nameof(flag));
        }

    }

    /// <summary>
    /// Marks a property as a command-line argument switch. This argument has no value, so it should only be used on boolean types.
    /// </summary>
    public sealed class FlagArgument : Argument {

        public FlagArgument(string flag) : base(flag) {
            Template = "{flag}";
            QuotePolicy = QuotePolicy.Off;
        }

    }

}