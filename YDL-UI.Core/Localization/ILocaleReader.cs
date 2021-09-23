namespace Maxstupo.YdlUi.Core.Localization {
    using System.Collections.Generic;
    using System.IO;

    /// <summary>Represents a reader that can read a locale resource and return a dictionary of translations.</summary>
    public interface ILocaleReader {

        /// <summary>Reads the provided stream and returns a dictionary of translations.</summary>
        Dictionary<string, string> Read(Stream stream);

    }

}