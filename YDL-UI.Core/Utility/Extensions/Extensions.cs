namespace Maxstupo.YdlUi.Core.Utility.Extensions {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public static class IOExtensions {

        public static Stream GetEmbeddedResourceStream(this Assembly assembly, string resourceFileName) {
            List<string> paths = assembly.GetManifestResourceNames().Where(x => x.EndsWith(resourceFileName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (paths.Count == 1)
                return assembly.GetManifestResourceStream(paths.First());

            return null;
        }

    }
}
