namespace Maxstupo.YdlUi.Core.Localization {
    using System.Collections.Generic;
    using System.IO;

    /// <summary>Represents a provider that provides IO streams to locale resources based on the requested locale.</summary>
    public interface ILocaleProvider {

        /// <summary>Initialize this locale provider. Discover available locales, etc. The caller informs the provider of the supported file extensions.</summary>
        ILocaleProvider Init(IEnumerable<string> knownFileExtensions);

        /// <summary>Returns a open stream to the locale resource. Caller is expected to close/dispose the stream.</summary>
        Stream GetStream(string locale, string variantName);

        /// <summary>Returns true if this provider can provide a stream for the requested locale.</summary>
        bool IsLocaleAvailable(string locale, string variantName);

        /// <summary>Returns an enumerable of all available locales and their file extensions.</summary>
        IEnumerable<LocaleFormat> GetAvailableLocales();

    }

}