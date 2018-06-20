using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.YdlUi.Util {
    public class Version {
        public int Major { get; }
        public int Minor { get; }
        public int Revision { get; }

        public Version(int major, int minor, int revision) {
            Major = major;
            Minor = minor;
            Revision = revision;
        }

        public static Version Parse(string version) {
            string ver = version.ToLower();
            string v = ver.StartsWith("v") ? ver.Substring(1) : ver;

            string[] tokens = v.Split('.');

            int major = 0, minor = 0, revision = 0;

            if (tokens.Length > 0)
                int.TryParse(tokens[0], out major);
            if (tokens.Length > 1)
                int.TryParse(tokens[1], out minor);
            if (tokens.Length > 2)
                int.TryParse(tokens[2], out revision);

            return new Version(major, minor, revision);
        }

        public bool IsNewerThan(Version version) {
            if (Major > version.Major || Minor > version.Minor || Revision > version.Revision)
                return true;
            return false;
        }

        public override string ToString() {
            return string.Format("v{0}.{1}.{2}", Major, Minor, Revision);
        }
    }
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
