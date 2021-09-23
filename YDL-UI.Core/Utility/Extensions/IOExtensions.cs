namespace Maxstupo.YdlUi.Core.Utility.Extensions {
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public static class IOExtensions {

        /// <summary>
        /// Returns a Stream to the first embedded resource found in the assembly, or null if none was found. Caller is expected to dispose of returned Stream.
        /// </summary>
        public static Stream GetEmbeddedResourceStream(this Assembly assembly, string fileName) {
            string path = assembly.GetManifestResourceNames().FirstOrDefault(x => x.EndsWith(fileName, StringComparison.OrdinalIgnoreCase));

            return path != null ? assembly.GetManifestResourceStream(path) : null;
        }

    }
}
