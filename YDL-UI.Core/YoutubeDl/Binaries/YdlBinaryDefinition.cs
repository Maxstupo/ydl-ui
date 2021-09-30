namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries {
    using System;
    using System.Collections.Generic;
    using Maxstupo.YdlUi.Core.Arguments;

    /// <summary>
    /// Represents a youtube-dl binary (or fork) and the specifcation needed to run and parse it.
    /// </summary>
    public sealed class YdlBinaryDefinition {

        /// <summary>ID used for config files and translation.</summary>
        public string Id { get; }

        /// <summary>Friendly name used in GUI.</summary>
        public string Name { get; }

        /// <summary>Friendly description used in GUI.</summary>
        public string Description { get; }

        /// <summary>The GitHub username this binary is from. Used for auto download/updating.</summary>
        public string Username { get; }

        /// <summary>The GitHub repository name this binary is from. Used for auto download/updating.</summary>
        public string Project { get; }

        /// <summary>A regex used for matching a GitHub release asset that represents this binary.</summary>
        public string AssetMatch { get; }

        /// <summary>A filename that will be used once the asset has been matched.</summary>
        public string TargetFilename { get; }

        /// <summary>Available arguments that binary can use.</summary>
        public IList<ArgumentDefinition> Arguments { get; }

        public YdlBinaryDefinition(string id, string name, string description, string username, string project, string assetMatch, string targetFilename, List<ArgumentDefinition> arguments) {
            this.Id = id ?? throw new ArgumentNullException(nameof(id));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Description = description ?? throw new ArgumentNullException(nameof(description));
            this.Username = username ?? throw new ArgumentNullException(nameof(username));
            this.Project = project ?? throw new ArgumentNullException(nameof(project));
            this.AssetMatch = assetMatch ?? throw new ArgumentNullException(nameof(assetMatch));
            this.TargetFilename = targetFilename ?? throw new ArgumentNullException(nameof(targetFilename));
            this.Arguments = arguments?.AsReadOnly() ?? throw new ArgumentNullException(nameof(arguments));
        }

    }

}