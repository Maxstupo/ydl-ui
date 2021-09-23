namespace Maxstupo.YdlUi.Services {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.CompilerServices;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.Localization.Readers;

    /// <summary>A class for translating text between multiple languages. This is a dummy version for use with the WPF designer.</summary>
    public sealed class I18NDesigner : II18N {

        public string this[string key] => Get(key);

        public Language Language { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public List<Language> Languages => throw new NotSupportedException();
        public string Locale { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public string Variant { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public ILocaleReader Reader { get; }

        public string RelativeLocalePath { get; }

        private static string GetSourcePath([CallerFilePath] string from = null) => from;

        private string Filepath {
            get {
                string souceFilepath = Path.GetDirectoryName(GetSourcePath());
                return Path.GetFullPath(Path.Combine(souceFilepath, RelativeLocalePath));
            }
        }

        public I18NDesigner(string relativeLocalePath, ILocaleReader reader = null) {
            this.RelativeLocalePath = relativeLocalePath;
            this.Reader = reader ?? new JsonTreeReader();
        }

        public string Get(string key, params object[] args) {
            if (File.Exists(Filepath)) {

                using (Stream stream = File.OpenRead(Filepath)) {
                    Dictionary<string, string> translations = Reader.Read(stream);

                    if (translations.TryGetValue(key, out string value))
                        return args.Length == 0 ? value : string.Format(value, args);
                }

            }

            return $"${key}$";
        }

        public string GetOrNull(string key, params object[] args) {
            return Get(key, args);
        }

    }

}