namespace Maxstupo.YdlUi.Core.Localization {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Maxstupo.YdlUi.Core.Utility.Extensions;

    /// <summary>
    /// A class for translating text between multiple languages using a key-value system. Supports multiple formats and can load translations from multiple locations.
    /// </summary>
    public sealed class I18N : II18NSource {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly NLog.Logger LoggerTranslations = NLog.LogManager.GetLogger($"{nameof(I18N)}T"); // Used for printing translation key value pairs.

        public string this[string key] => Get(key);

        private string locale;
        public string Locale {
            get => locale;
            set {
                if (locale == value) Logger.Info("{newLocale} is the current locale. No action needed.", value);
                else {
                    LoadLocale(value, Variant);
                }
            }
        }

        private string variantName = null;
        public string Variant {
            get => variantName;
            set {
                string newValue = !string.IsNullOrWhiteSpace(value) ? value : null;

                if (variantName == newValue) Logger.Info("{newVariant} is the current variant. No action needed.", newValue);
                else {
                    LoadLocale(Locale, newValue);
                }

            }
        }

        public string FallbackLocale { get; set; } = "en";

        public string UnknownKeySymbol { get; set; } = "$";

        public Language Language {
            get => Languages.FirstOrDefault(x => x.Locale == Locale && x.VariantName == Variant);
            set {
                if (value == null)
                    throw new ArgumentNullException(nameof(Language));

                Language lang = Language;
                if (lang != null && lang == value) Logger.Info("{newLanguage} is the current language. No action needed.", value);
                else {
                    LoadLocale(value.Locale, value.VariantName);
                }

            }
        }

        public List<Language> Languages => availableLocales.Select(localeFormat => new Language(
                localeFormat.Locale,
                localeFormat.Name,
                GetOrNull(localeFormat.Locale) ?? new CultureInfo(localeFormat.Locale).NativeName.CapitalizeFirstCharacter()
        )).ToList();

        private List<LocaleFormat> availableLocales;

        public event PropertyChangedEventHandler PropertyChanged;


        private readonly Dictionary<string, ILocaleReader> readers = new Dictionary<string, ILocaleReader>();  // File Extension -> ILocaleReader
        private readonly List<ILocaleProvider> providers = new List<ILocaleProvider>();

        private HashSet<string> localeCodes = new HashSet<string>();
        private readonly Dictionary<string, string> localeToExtension = new Dictionary<string, string>(); // Locale -> File Extension

        private Dictionary<string, string> translations = new Dictionary<string, string>();

        public II18NSource Init(string initialLocale = null, string initialVariant = null) {
            if (providers.Count == 0)
                Logger.Warn("No providers are registered!");
            if (readers.Count == 0)
                Logger.Warn("No readers are registered!");

            List<string> knownFileExtensions = readers.Keys.ToList();

            Logger.Info("Known file extensions: {knownFileExtensions}", string.Join(", ", knownFileExtensions));

            Logger.Info("Initializing locale providers...");
            foreach (ILocaleProvider provider in providers)
                provider.Init(knownFileExtensions);

            // Get all available locales (locale codes) from all providers. (These are the locales that each provider has found).
            availableLocales = providers.SelectMany(x => x.GetAvailableLocales()).ToList();

            // Get all the available locale codes from all providers.
            localeCodes = availableLocales.Select(x => x.Locale).ToHashSet();

            // Get a lookup dictionary for all locale codes -> file extensions.
            localeToExtension.Clear();
            foreach (LocaleFormat localeFormat in availableLocales) {
                if (localeToExtension.ContainsKey(localeFormat.Locale))
                    continue;
                localeToExtension.Add(localeFormat.Locale, localeFormat.Extension);
            }


            LoadInitialLocale(initialLocale, initialVariant);

            NotifyPropertyChanged(nameof(Locale));
            NotifyPropertyChanged(nameof(Language));

            return this;
        }

        public bool LoadInitialLocale(string initialLocale = null, string initialVariant = null) {
            string locale = initialLocale ?? GetDefaultLocale();

            // No starting locale.
            if (locale == null) {
                if (!string.IsNullOrWhiteSpace(FallbackLocale) && localeCodes.Contains(FallbackLocale)) { // Use fallback locale.
                    locale = FallbackLocale;

                    if (locale != null)
                        Logger.Info("Using fallback locale: {fallbackLocale}", FallbackLocale);

                } else { // Use first locale available in loaded locales.
                    locale = localeCodes.FirstOrDefault();

                    if (locale != null)
                        Logger.Info("Using first locale available: {locale}", locale);

                }
            } else {

                if (initialLocale == null)
                    Logger.Info("Using default locale from current culture: {locale}", locale);
                else
                    Logger.Info("Using locale: {locale}", locale);
            }

            if (!LoadLocale(locale, initialVariant)) { // Attempt to load using locale, else retry.
                if (localeCodes.Count == 0) {
                    Logger.Warn("Failed to set default locale. No locales found!");
                    return false;
                }
                return LoadInitialLocale(null);
            }

            return true;
        }

        private bool LoadLocale(string locale, string variantName) {
            if (string.IsNullOrWhiteSpace(locale))
                return false;

            Logger.Info("Attempting to load locale: {locale}", locale);

            ILocaleProvider provider = providers.FirstOrDefault(x => x.IsLocaleAvailable(locale, variantName));
            if (provider == null) {
                Logger.Warn("No available locale provider can provide that locale! The locale might not exist!");
                return false;
            }


            string extension = localeToExtension[locale]; // should always exist, due to  the above check.
            if (!readers.TryGetValue(extension, out ILocaleReader reader)) {
                Logger.Warn("No locale reader is available for the file extension {extension}!", extension);
                return false;
            }

            using (Stream stream = provider.GetStream(locale, variantName)) {
                try {
                    translations = reader.Read(stream) ?? new Dictionary<string, string>();
                } catch (Exception e) {
                    Logger.Error(e, "Failed to load locale {locale}{extension} using {reader} -", locale, extension, reader.GetType().Name);
                    return false;
                }
            }

            Logger.Info("Loaded locale: {locale}", locale);

            this.locale = locale;
            this.variantName = variantName;

            NotifyPropertyChanged(nameof(Locale));
            NotifyPropertyChanged(nameof(Variant));
            NotifyPropertyChanged(nameof(Language));

            // Update bindings to indexer
            NotifyPropertyChanged("Item[]");

#if DEBUG
            LoggerTranslations.Debug("============ Translations ============");
            foreach (KeyValuePair<string, string> pair in translations)
                LoggerTranslations.Debug("{key} = {value}", pair.Key, pair.Value);
            LoggerTranslations.Debug("========== End Translations ==========");
#endif

            return true;
        }


        public string Get(string key, params object[] args) {
            string value = GetOrNull(key, args);

            if (value != null) return value;
            else if (string.IsNullOrEmpty(UnknownKeySymbol)) {
                return key;

            }

            Logger.Warn("Missing translation {key} for locale {locale}", key, Locale);
            return $"{UnknownKeySymbol}{key}{UnknownKeySymbol}";
        }

        public string GetOrNull(string key, params object[] args) {
            if (translations.TryGetValue(key, out string value))
                return args.Length == 0 ? value : string.Format(value, args);

            return null;
        }

        public II18N RegisterProvider(ILocaleProvider provider) {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            if (providers.Contains(provider))
                throw new ArgumentException("The provider is already registered!", nameof(provider));

            Logger.Debug("Registering locale provider: {provider}", provider.GetType().FullName);

            providers.Add(provider);
            return this;
        }

        public II18N RegisterReader(ILocaleReader reader, string extension) {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            if (string.IsNullOrWhiteSpace(extension))
                throw new ArgumentException("An extension is needed.", nameof(extension));

            if (!extension.StartsWith("."))
                throw new ArgumentException("The extension must start with a dot!", nameof(extension));

            if (readers.ContainsKey(extension))
                throw new ArgumentException("The extension is already registered with a reader!", nameof(extension));

            if (readers.ContainsValue(reader))
                throw new ArgumentException("The reader is already registered with an extension!", nameof(reader));

            Logger.Debug("Registering locale reader: {extension} -> {reader}", extension, reader.GetType().FullName);

            readers.Add(extension, reader);
            return this;
        }

        public string GetDefaultLocale() {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            string langRegionCode = currentCulture.Name;
            string langCode = currentCulture.TwoLetterISOLanguageName;

            if (localeCodes.TryGetValue(langRegionCode, out string value))
                return value;

            if (localeCodes.TryGetValue(langCode, out value))
                return value;

            return null;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}