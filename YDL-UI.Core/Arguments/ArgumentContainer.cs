namespace Maxstupo.YdlUi.Core.Arguments {
    using System;

    /// <summary>
    /// Indicates that the property is a command-line argument container. The serializer will serialize any class data type properties marked with this attribute. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ArgumentContainer : Attribute { }

}