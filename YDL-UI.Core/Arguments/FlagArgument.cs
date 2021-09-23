namespace Maxstupo.YdlUi.Core.Arguments {

    /// <summary>
    /// Marks a property as a command-line argument switch. This argument has no value, so it should only be used on boolean types.
    /// </summary>
    public class FlagArgument : Argument {

        public FlagArgument(string flag) : base(flag) {
            Template = "{flag}";
            QuotePolicy = QuotePolicy.Off;
        }

    }

}
