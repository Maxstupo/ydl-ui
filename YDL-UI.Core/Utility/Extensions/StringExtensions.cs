namespace Maxstupo.YdlUi.Core.Utility.Extensions {
    using System;

    public static class StringExtensions {

        /// <summary>Converts all escaped linebreaks (e.g. \\r\\n, \\n, \r\n) into linebreaks suitable for this environment.</summary>
        public static string UnescapeLineBreaks(this string str) {
            return str
                .Replace("\\r\\n", "\\n")
                .Replace("\\n", Environment.NewLine)
                .Replace("\r\n", "\n")
                .Replace("\n", Environment.NewLine);
        }

        /// <summary>Returns a string with the first character capitalized.</summary>
        public static string CapitalizeFirstCharacter(this string str) {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            if (str.Length == 1)
                return str.ToUpper();

            return char.ToUpper(str[0]) + str.Substring(1);
        }

    }

}