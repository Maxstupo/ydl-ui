using System;

namespace Maxstupo.YdlUi.ArgumentBuilder {
    /// <summary>
    /// Indicates that the class is a command line argument container. This attribute is mainly used for code readability.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ArgumentContainer : Attribute { }
}
