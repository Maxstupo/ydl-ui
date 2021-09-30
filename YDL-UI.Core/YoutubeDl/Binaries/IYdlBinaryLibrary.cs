namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries {
    using System.Collections.Generic;

    /// <summary>
    /// Represents a implementation that has a collection of binary definitions and a currently active one.
    /// </summary>
    public interface IYdlBinaryLibrary {

        /// <summary>The current binary that is being used to download.</summary>
        YdlBinaryDefinition CurrentBinary { get; }

        /// <summary>All available binaries that are available.</summary>
        IList<YdlBinaryDefinition> Binaries { get; }

        /// <summary>Add a binary definition to this implementation.</summary>
        void Add(YdlBinaryDefinition binaryDef);

    }

}