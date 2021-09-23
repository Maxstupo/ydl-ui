namespace Maxstupo.YdlUi.Core.Arguments {
    using System;

    /// <summary>
    /// Indicates that the property is a command-line argument container. The serializer will serialize any properties marked with this attribute. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentContainer : Attribute { }

}