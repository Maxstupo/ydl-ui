namespace Maxstupo.YdlUi.ArgumentBuilder {

    /// <summary>
    /// The policy that determines the capitalization of enum properties.
    /// </summary>
    public enum EnumCasePolicy {
        /// <summary>
        /// Enum names will remain unchanged.
        /// </summary>
        Default,

        /// <summary>
        /// Enum names will be changed to uppercase.
        /// </summary>
        Uppercase,
        
        /// <summary>
        /// Enum names will be changed to lowercase.
        /// </summary>
        Lowercase
    }
}
