using Maxstupo.YdlUi.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Utility {
    public class Language {
        public string Code { get; }
        public string DisplayName { get; }

        public Language(string code, string displayName) {
            Code = code; DisplayName = displayName;
        }

        public Language(string code) {
            Code = code;
            try {
                DisplayName = CultureInfo.GetCultureInfo(code).DisplayName;
            } catch (CultureNotFoundException) { DisplayName = code; }
        }
    }


    public static class Localization {
        public static List<Language> AvailableLanguages => locales.Keys.Select(x => new Language(x)).ToList();

        private static readonly Dictionary<string, Dictionary<string, string>> locales = new Dictionary<string, Dictionary<string, string>>();
        private static readonly Dictionary<string, string> originalText = new Dictionary<string, string>(); // The original text of the controls, used for fallback when no key exists.
        private static readonly Dictionary<Control, ToolTip> tooltips = new Dictionary<Control, ToolTip>();

        private static string DefaultCode { get; set; }
        private static string language = "";
        public static string Language {
            get => language;
            set {
                string lang = ResolveLanguageCode(value);
                if (lang != language) {
                    language = lang.ToLower();

                    OnLanguageChanged?.Invoke(null, EventArgs.Empty);
                    Logger.Instance.Info(nameof(Localization), "Setting language to: '{0}'", language);
                }
            }
        }

        public static string DefaultLanguage {
            get {
                try {
                    return CultureInfo.CurrentUICulture.Name;
                } catch (ArgumentException) {
                    return null; // ArgumentNullException/ArgumentException - CurrentUICulture is null, or culture name is invalid.
                }
            }
        }

        public static string LocaleDirectory { get; private set; }

        public static event EventHandler OnLanguageChanged;

        // TODO: Use on-demand loading for locale files.
        // Loads all *.<lang-code>.json files located within the specified locale directory.
        public static void Load(string localeDirectory, string defaultCode = "en") {
            LocaleDirectory = null;
            DefaultCode = defaultCode;
            locales.Clear();
            tooltips.Clear();
            originalText.Clear();

            if (!Directory.Exists(localeDirectory)) {
                Logger.Instance.Warn(nameof(Localization), "Locale directory doesn't exist: '{0}'", localeDirectory);
                locales.Add(defaultCode, new Dictionary<string, string>()); // Add default locale.
                return;
            }

            LocaleDirectory = localeDirectory;

            foreach (string filepath in Directory.EnumerateFiles(localeDirectory, "*.json", SearchOption.AllDirectories)) {
                string filename = Path.GetFileNameWithoutExtension(filepath);

                Match match = Regex.Match(filename, @"\w+\.([\w-]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                if (!match.Success)
                    continue;

                string localeCode = match.Groups[1].Value.ToLower();

                Logger.Instance.Info(nameof(Localization), "Loading locale: ({1}) '{0}'", filepath, localeCode);
                try {
                    // Deserialize json file and store it in a dictionary for later use.
                    Dictionary<string, string> translation = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filepath));
                    locales.Add(localeCode, translation);
                } catch (Exception e) {
                    Logger.Instance.Warn(nameof(Localization), "Failed to load locale: ({1}) '{0}'\n{2}", filepath, localeCode, e);
                }

            }

            if (!locales.ContainsKey(defaultCode)) // Add default locale.
                locales.Add(defaultCode, new Dictionary<string, string>());

        }

        // Convert language code (e.g. en-US) to neutral varient (e.g. en) if it doesn't exist, if the provided code is null or whitespace use the default system language.
        private static string ResolveLanguageCode(string code, bool fallback = false) {
            Logger.Instance.Debug(nameof(Localization), "Resolve language code: '{0}' {1}", code,fallback);

            if (string.IsNullOrWhiteSpace(code)) { // Return the system language if no code was provided.
                string defaultLanguage = DefaultLanguage;

                if (defaultLanguage != null && !fallback)
                    return ResolveLanguageCode(defaultLanguage, true);

                fallback = true; 

            } else if (locales.ContainsKey(code)) { // If we have a valid translation loaded use the provided code.
                return code;

            } else if (code.Contains("-") || code.Contains("_")) { // else try fallback (e.g. en-US -> en)
                return ResolveLanguageCode(code.Split('-', '_')[0], fallback);

            }
            
            return fallback ? DefaultCode : ResolveLanguageCode(null, true);
        }

        public static string Localize(this string defaultValue, string key) {
            return GetString(key, defaultValue);
        }

        // Returns a locale specific value for a given key based off the Language property.
        public static string GetString(string key, string defaultValue = "") {
            if (!locales.TryGetValue(Language, out Dictionary<string, string> translations)) {
#if DEBUG
                Logger.Instance.Warn(nameof(Localization), "Failed to find language for '{0}'", Language);
#endif
                return defaultValue;
            }

            if (translations.TryGetValue(key, out string value)) {
                return value;
            } else {
#if DEBUG
                Logger.Instance.Warn(nameof(Localization), "Failed to find translation for '{0}'", key);
                Logger.Instance.Debug(nameof(Localization), "\"{0}\": \"{1}\",", key, defaultValue);
#endif
                return defaultValue;
            }
        }


        public static void ApplyLocaleText(Control src, ToolTip tooltip = null) {
            ApplyLocaleText(src, tooltip, "", 0);
        }

        private static void ApplyTooltip(ToolTip tooltip, Control src, string realKey) {
            if (tooltip == null)
                return;

            string tooltipValue = tooltip.GetToolTip(src);

            string realTooltipKey = $"{realKey}.tooltip";
            string defaultTooltipValue = originalText.TryGetOrAdd(realTooltipKey, tooltipValue);

            if (!string.IsNullOrWhiteSpace(defaultTooltipValue))
                tooltip.SetToolTip(src, GetString(realTooltipKey, defaultTooltipValue));

        }

        // Allows for registering of multiple tooltip objects that are used in a single Control hierarchy. 
        public static void RegisterTooltip(Control src, ToolTip tip) {
            if (!tooltips.ContainsKey(src))
                tooltips.Add(src, tip);
        }

        // Iterate through all controls within the provided control and localize their text.
        public static void ApplyLocaleText(Control src, ToolTip tooltip, string path, int level) {
            string key = GetKey(src.Tag, src.Name);
            if (string.IsNullOrWhiteSpace(key))
                return;
            if (tooltips.TryGetValue(src, out ToolTip tip))
                tooltip = tip;

            if (!key.Contains("#")) { // Skip this control if '#' is within the key.
                path += (path.Length == 0) ? key.ToLower() : $".{key.ToLower()}";


                // Set the locale string for the control, if the key starts with '@' use the key as an absolute path.
                string realKey = key.StartsWith("@") ? key.Substring(1) : path;

                if (src is CheckBox || src is Label || src is Button || src is RadioButton || src is GroupBox || src is TabPage || src is Form) {

                    string defaultValue = originalText.TryGetOrAdd(realKey, src.Text);
                    src.Text = GetString(realKey, defaultValue);

                    if (!(src is LinkLabel)) // Dont apply tooltips to link labels.
                        ApplyTooltip(tooltip, src, realKey);
                } else if ((src is ComboBox || src is NumericUpDown || src is TextBox) && !(src is LinkLabel)) {
                    ApplyTooltip(tooltip, src, realKey);
                }
            }


            level++;
            if (src is DataGridView dgv) {
                foreach (DataGridViewColumn column in dgv.Columns) { // Localize the column header text if the control is a datagridview.
                    string realKey = $"{path}.{GetKey(column.Tag, column.Name).ToLower()}";
                    string defaultValue = originalText.TryGetOrAdd(realKey, column.HeaderText);

                    column.HeaderText = GetString(realKey, defaultValue);
                }

            } else if (src is ToolStrip ss) {
                foreach (ToolStripItem child in ss.Items)
                    ApplyToolStrip(child, path, level);

            } else if (src is SplitContainer sc) {
                ApplyLocaleText(sc.Panel1, tooltip, path, level);
                ApplyLocaleText(sc.Panel2, tooltip, path, level);

            } else {
                foreach (Control child in src.Controls)
                    ApplyLocaleText(child, tooltip, path, level);

            }


            if (src.ContextMenuStrip != null)
                ApplyLocaleText(src.ContextMenuStrip, tooltip, path, level);
        }

        private static void ApplyToolStrip(ToolStripItem src, string path, int level) {
            string key = GetKey(src.Tag, src.Name);
            if (string.IsNullOrWhiteSpace(key))
                return;

            if (!key.Contains("#")) // Skip this control if '#' is within the key.
                path += (path.Length == 0) ? key.ToLower() : $".{key.ToLower()}";


            if (src is ToolStripMenuItem tsmi) {
                string defaultValue = originalText.TryGetOrAdd(path, tsmi.Text);
                tsmi.Text = GetString(path, defaultValue);

                foreach (ToolStripItem child in tsmi.DropDownItems)
                    ApplyToolStrip(child, path, level + 1);

            } else if (src is ToolStripStatusLabel tssl) {
                string defaultValue = originalText.TryGetOrAdd(path, tssl.Text);
                tssl.Text = GetString(path, defaultValue);
            }
        }

        private static string GetKey(object obj, string fallback) {
            if (obj == null)
                return fallback;
            if (obj is string str) {
                string key = str ?? fallback;
                return key.StartsWith("!") ? null : key;
            } else {
                return obj.ToString();
            }
        }
    }
}
