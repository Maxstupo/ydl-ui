using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.YdlUi.Util {
    public class Utils {
        private static readonly object _lock = new object();


        public static bool IsValidUrl(string url) {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri result) && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        public static void WriteMessage(string message, bool newline = true, ConsoleColor background = ConsoleColor.Black, ConsoleColor foreground = ConsoleColor.White) {
            lock (_lock) {
                Console.BackgroundColor = background;
                Console.ForegroundColor = foreground;
                if (newline)
                    Console.WriteLine(message);
                else
                    Console.Write(message);
                Console.ResetColor();
            }
        }

    }
}
