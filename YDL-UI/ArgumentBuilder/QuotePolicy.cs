namespace Maxstupo.YdlUi.ArgumentBuilder {

    /// <summary>
    /// The policies that determine if argument property values should be quoted.
    /// </summary>
    public enum QuotePolicy {
        /// <summary>
        /// No quotes will be added.
        /// </summary>
        Off,

        /// <summary>
        /// Quotes will always be added.
        /// </summary>
        Always,

        /// <summary>
        /// Quotes will be added when necessary (e.g. contains whitespaces, special characters, etc).
        /// </summary>
        WhenNecessary
    }

}
