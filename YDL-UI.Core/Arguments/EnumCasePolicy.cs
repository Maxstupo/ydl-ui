namespace Maxstupo.YdlUi.Core.Arguments {

    /// <summary>
    /// The policy that determines the capitalization of enum property arguments.
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