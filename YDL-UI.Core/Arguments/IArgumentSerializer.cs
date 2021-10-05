namespace Maxstupo.YdlUi.Core.Arguments {
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Represents an implementation that converts a class with argument definitions into a string 
    /// ready to be used with command-line utilities.
    /// </summary>
    public interface IArgumentSerializer {

        IEnumerable<Tuple<Argument, PropertyInfo, Type>> GetAvailableArguments(Type argumentsObject, bool excludeHidden = false);

        string Serialize(object argumentsObject);

    }

    /// <summary>
    /// Represents an implementation that converts a class with argument definitions into a string, and
    /// appends them to the end of a filename ready to be used with command-line utilities.
    /// </summary>
    public interface ICommandLineSerializer {

        string Serialize(string filename, object argumentsObject);

    }

}