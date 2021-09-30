namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries {
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Utility.Exec;

    /// <summary>
    /// Represents an implementation that can provide the means to execute a process with a suitable parser for
    /// reading the output of that process. Includes a means to create a valid argument set that can be used with the process.
    /// </summary>
    public interface IInterpretableBinaryProvider : IExecutableProcessProvider, IOutputParserProvider, IArgumentsProvider {

    }

}