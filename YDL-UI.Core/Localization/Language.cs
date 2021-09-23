namespace Maxstupo.YdlUi.Core.Localization {
    using System;
    using System.Collections.Generic;

    /// <summary>Represents a locale and its official name.</summary>
    public sealed class Language : IEquatable<Language> {

        /// <summary>The locale code.</summary>
        public string Locale { get; }

        /// <summary>The name of the locale variant (e.g. if two "en" locales are loaded, but both use different language styles)</summary>
        public string VariantName { get; }

        /// <summary>The official name of the locale. Usually the language name, and potentially the country/region.</summary>
        public string DisplayName { get; }


        public Language(string locale, string variantName, string displayName) {
            this.Locale = locale ?? throw new ArgumentNullException(nameof(locale));
            this.VariantName = variantName;
            this.DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
        }

        /// <summary>Returns the DisplayName of this language.</summary>
        public override string ToString() {
            if (VariantName == null)
                return $"{DisplayName}";
            return $"{DisplayName} ({VariantName})";
        }

        public override bool Equals(object obj) {
            return Equals(obj as Language);
        }

        public bool Equals(Language other) {
            return other != null &&
                   this.Locale == other.Locale &&
                   this.VariantName == other.VariantName;
        }

        public override int GetHashCode() {
            int hashCode = -930982774;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Locale);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.VariantName);
            return hashCode;
        }

        public static bool operator ==(Language left, Language right) {
            return EqualityComparer<Language>.Default.Equals(left, right);
        }

        public static bool operator !=(Language left, Language right) {
            return !(left == right);
        }

    }

}