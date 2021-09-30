namespace Maxstupo.YdlUi.Core.Arguments {

    /// <summary>
    /// Represents an implementation that converts a collection of arguments into a string 
    /// ready to be used with command-line utilities.
    /// </summary>
    public interface IArgumentSerializer {

        string Serialize(IArgumentsCollection argumentsCollection);

    }

    /// <summary>
    /// Represents an implementation that converts a collection of arguments into a string, and
    /// appends them to the end of a filename ready to be used with command-line utilities.
    /// </summary>
    public interface ICommandLineSerializer {

        string Serialize(string filename, IArgumentsCollection argumentsCollection);

    }

}