namespace Maxstupo.YdlUi.Core.Localization {
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>An implementation that supports getting text translated in a specific language.</summary>
    public interface II18N : INotifyPropertyChanged {

        /// <inheritdoc cref="Get(string, object[])"/>
        string this[string key] { get; }

        /// <summary>The current language being used for translations.</summary>
        Language Language { get; set; }

        /// <summary>A list of available languages.</summary>
        List<Language> Languages { get; }

        /// <summary>The current locale being used.</summary>
        string Locale { get; set; }

        /// <summary>The current locale variant (The same language/region but different translations).</summary>
        string Variant { get; set; }

        /// <summary>Returns a translation for the given key based on the current locale. If translation doesn't exist return the key.</summary>
        string Get(string key, params object[] args);

        /// <summary>Returns a translation for the given key based on the current locale. If the translation doesn't exist return null.</summary>
        string GetOrNull(string key, params object[] args);

    }

    /// <summary>Represents a system for translating text between multiple languages/regions.</summary>
    public interface II18NSource : II18N {

        /// <summary>The fallback locale, if the current system locale doesn't have available translations.</summary>
        string FallbackLocale { get; set; }

        /// <summary>A string that is prefixed and suffixed to the returned translation key when the translation doesn't exist.</summary>
        string UnknownKeySymbol { get; set; }


        /// <summary>Initialize everything and allow translations to be provided. The locale provided will attempt to be loaded, else if failed or is null, use default.</summary>
        II18NSource Init(string initialLocale = null, string initialVariant = null);


        /// <summary>Register a locale reader for a given extension.</summary>
        II18N RegisterReader(ILocaleReader reader, string extension);

        /// <summary>Register a locale provider.</summary>
        II18N RegisterProvider(ILocaleProvider provider);


        /// <summary>Returns the best matched locale based on the system and if a translation is available, or null otherwise.</summary>
        string GetDefaultLocale();

    }

}