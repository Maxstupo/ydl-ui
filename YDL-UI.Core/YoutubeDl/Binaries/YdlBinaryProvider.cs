namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Options;
    using Maxstupo.YdlUi.Core.Utility.Exec;

    /// <summary>
    /// Represents a system that provides both the means to execute youtube-dl binaries and parse their output. 
    /// Hooks into the settings system to get the currently enabled binary.
    /// </summary>
    public sealed class YdlBinaryProvider : IYdlBinaryLibrary, IInterpretableBinaryProvider, IArgumentSerializer {
        private readonly IArgumentSerializer serializer; // the serializer that will be used to create the command line arguments.

        private readonly ISettings settings;

        private readonly Dictionary<string, YdlBinaryDefinition> binaryDefinitions = new Dictionary<string, YdlBinaryDefinition>();

        public IList<YdlBinaryDefinition> Binaries => binaryDefinitions.Values.ToList().AsReadOnly();

        public YdlBinaryDefinition CurrentBinary => binaryDefinitions[settings.Get<string>("binary")];

        public YdlBinaryProvider(ISettings settings, IArgumentSerializer serializer) {
            this.settings = settings;
            this.serializer = serializer;
        }

        public void Add(YdlBinaryDefinition binaryDef) {
            binaryDefinitions.Add(binaryDef.Id, binaryDef);
        }
        
        // Create a new argument collection instance for the current binary.
        public IArgumentsCollection CreateArguments() {
            return new ArgumentsCollection(CurrentBinary.Arguments.ToList());
        }

        // Create a new executable process targeting the correct filepath.
        public IExecutableProcess CreateExecutableProcess(IArgumentsCollection arguments, string workingDirectory) {
            string filename = $"bin/yt/{CurrentBinary.Id}/{CurrentBinary.TargetFilename}";

            string args = Serialize(arguments);
            return new ExecutableProcess(filename, args, workingDirectory);
        }

        // Create a parser that can parse the output of the current binary.
        public IOutputParser CreateParser() {
            throw new NotSupportedException();
        }

        public string Serialize(IArgumentsCollection arguments) {
            return serializer.Serialize(arguments);
        }

    }

}