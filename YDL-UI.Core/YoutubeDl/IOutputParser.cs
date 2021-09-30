namespace Maxstupo.YdlUi.Core.YoutubeDl {

    /// <summary>
    /// Represents an implementation that provides an output parser.
    /// </summary>
    public interface IOutputParserProvider {

        IOutputParser CreateParser();

    }

    /// <summary>
    /// Represents an implementation of a parser that extracts useful information from the output data of a process.
    /// </summary>
    public interface IOutputParser {

    }

}