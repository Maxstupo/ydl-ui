namespace Maxstupo.YdlUi.Core.Utility {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Util {

        public static bool IsValidUrl(string url) {
            if (string.IsNullOrWhiteSpace(url))
                return false;
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

        public static bool Contains(this string str, string value, StringComparison comparison) {
            return str.IndexOf(value, 0, comparison) != -1;
        }

    }
}
