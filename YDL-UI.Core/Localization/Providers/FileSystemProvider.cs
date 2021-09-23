namespace Maxstupo.YdlUi.Core.Localization.Providers {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    /// <summary>
    /// Represents a locale resource provider for the file system. Provides locale files directly from the file system. Uses abstracted System.IO for flexibility (See System.IO.Abstractions).
    /// Add directories to scan using AddDirectory()
    /// </summary>
    public sealed class FileSystemProvider : ILocaleProvider {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;
        private readonly string defaultVariantName;

        // Scanning Directories
        private readonly HashSet<string> directories = new HashSet<string>();

        // Locale Code -> (Variant Name -> Locale Filepath)
        private readonly Dictionary<string, Dictionary<string, string>> locales = new Dictionary<string, Dictionary<string, string>>();


        public FileSystemProvider(IFileSystem fileSystem, string defaultVariantName) {
            this.fileSystem = fileSystem;
            this.defaultVariantName = defaultVariantName;
        }


        /// <summary>Initialize the provider. Scan for all supported locale files in the registered directories.</summary>
        public ILocaleProvider Init(IEnumerable<string> knownFileExtensions) {
            Logger.Info("Initializing locales...");

            locales.Clear();


            Logger.Debug("Finding available locales...");
            List<string> localeFiles = directories
                .Where(x => fileSystem.Directory.Exists(x))
                .SelectMany(x => fileSystem.Directory.EnumerateFiles(x, "*.*", SearchOption.AllDirectories))
                .Where(x => knownFileExtensions.Contains(fileSystem.Path.GetExtension(x)))
                .ToList();

            if (localeFiles.Count == 0)
                Logger.Warn("No locales have been found. Make sure you've added a directory via AddDirectory() containing locale files (with extensions {knownFileExtensions})", string.Join(" or ", knownFileExtensions));

            int invalidLocaleCount = 0;
            foreach (string localeFile in localeFiles) {
                string name = fileSystem.Path.GetFileName(localeFile);

                string[] parts = name.Split('.');

                if (parts.Length < 3) { // <name>.<locale>.<ext>
                    Logger.Warn("Locale file {localeFile} is missing a language code specifier! Skipping...", localeFile);
                    invalidLocaleCount++;
                    continue;
                }

                string localeCode = parts[parts.Length - 2];

                string variantName = parts[0];

                Dictionary<string, string> variants;
                if (!locales.ContainsKey(localeCode)) {
                    variants = new Dictionary<string, string>();
                    locales.Add(localeCode, variants);
                } else {
                    variants = locales[localeCode];
                }

                if (variants.ContainsKey(variantName)) {
                    invalidLocaleCount++;
                    Logger.Warn("Locale variants already exists! Ignoring variant... {localeName}", name);
                    continue;
                }

                variants.Add(variantName, localeFile);
            }

            string localeStr = string.Join(", ", locales.Select(x => $"{x.Key} ({string.Join(", ", x.Value.Keys)})"));
            Logger.Info("Found {localeFileCount} locale files {localeCodes}", localeFiles.Count - invalidLocaleCount, localeStr);

            return this;
        }

        /// <summary>Returns an open stream to the locale resource. Caller is expected to close/dispose the stream. If resource is unavailable, null is returned.</summary>
        public Stream GetStream(string locale, string variantName) {
            if (variantName == null)
                variantName = defaultVariantName;

            if (!locales.TryGetValue(locale, out Dictionary<string, string> variants))
                return null;

            if (!variants.TryGetValue(variantName, out string filepath))
                return null;

            return fileSystem.File.OpenRead(filepath);
        }

        public bool IsLocaleAvailable(string locale, string variantName) {
            if (variantName == null)
                variantName = defaultVariantName;

            if (!locales.TryGetValue(locale, out Dictionary<string, string> variants))
                return false;

            if (!variants.ContainsKey(variantName))
                return false;

            return true;
        }

        public IEnumerable<LocaleFormat> GetAvailableLocales() {
            return locales.SelectMany(locale => {
                return locale.Value.Select(variant => {
                    string name = variant.Key == defaultVariantName ? null : variant.Key;

                    string extension = fileSystem.Path.GetExtension(variant.Value);
                    return new LocaleFormat(name, locale.Key, extension);
                });
            });
        }

        /// <summary>Add the given directory for scanning.</summary>
        public ILocaleProvider AddDirectory(string directory) {
            if (string.IsNullOrWhiteSpace(directory))
                throw new ArgumentNullException("Directory cant be null or whitespace only!", nameof(directory));

            Logger.Debug("Adding locale directory {directory}", directory);

            directories.Add(directory);
            return this;
        }

        /// <summary>Clear all added directories.</summary>
        public ILocaleProvider ClearDirectories() {
            directories.Clear();
            return this;
        }

    }

}