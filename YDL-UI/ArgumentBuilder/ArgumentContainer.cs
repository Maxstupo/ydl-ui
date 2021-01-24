namespace Maxstupo.YdlUi.ArgumentBuilder {

    using System;

    /// <summary>
    /// Indicates that the class is a command line argument container. This attribute is mainly used for code readability. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ArgumentContainer : Attribute { }

}