namespace Maxstupo.YdlUi.ArgumentBuilder {
    /// <summary>
    /// Marks a property as a command line argument switch, use this attribute on boolean properties only.
    /// </summary>
    public class FlagArgument : Argument {
        public FlagArgument(string flag) : base(flag) {
            Template = "{flag}";
            QuotePolicy = QuotePolicy.Off;
        }
    }
}
