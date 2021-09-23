namespace Maxstupo.YdlUi.Core.Localization {
    using System;
    using System.Collections.Generic;

    /// <summary>Represents a locale resource and format based of the file extension.</summary>
    public sealed class LocaleFormat : IEquatable<LocaleFormat> {

        /// <summary>The locale code. (e.g. en-AU)</summary>
        public string Locale { get; }

        /// <summary>The locale (variant) name. (e.g. default, pirate)</summary>
        public string Name { get; }

        /// <summary>The locale resource file extension.</summary>
        public string Extension { get; }


        public LocaleFormat(string name, string locale, string extension) {
            this.Name = name;
            this.Locale = locale ?? throw new ArgumentNullException(nameof(locale));
            this.Extension = extension ?? throw new ArgumentNullException(nameof(extension));
        }

        public override bool Equals(object obj) {
            return Equals(obj as LocaleFormat);
        }

        public bool Equals(LocaleFormat other) {
            return other != null &&
                   this.Locale == other.Locale &&
                   this.Name == other.Name &&
                   this.Extension == other.Extension;
        }

        public override int GetHashCode() {
            int hashCode = 1037471447;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Locale);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Extension);
            return hashCode;
        }

        public static bool operator ==(LocaleFormat left, LocaleFormat right) {
            return EqualityComparer<LocaleFormat>.Default.Equals(left, right);
        }

        public static bool operator !=(LocaleFormat left, LocaleFormat right) {
            return !(left == right);
        }

    }

}