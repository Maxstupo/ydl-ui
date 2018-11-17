using ByteSizeLib;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Maxstupo.YdlUi.Utility {
    public static class Util {

        /// <summary>
        /// Removes all text after the <paramref name="lastChar"/> including the last character.
        /// </summary>
        /// <param name="lastChar">The character to remove and everything to the right of it.</param>
        public static string RemoveAfterLast(this string str, char lastChar) {
            int idx = str.LastIndexOf(lastChar);
            return idx > 0 ? str.Substring(0, idx) : str;
        }

        public static ByteSize From(double value, FilesizeUnit unit) {
            switch (unit) {
                case FilesizeUnit.KB: return ByteSize.FromKiloBytes(value);
                case FilesizeUnit.MB: return ByteSize.FromMegaBytes(value);
                case FilesizeUnit.GB: return ByteSize.FromGigaBytes(value);
                default: break;
            }
            throw new Exception();
        }

        public static bool IsValidUrl(string url) {
            if (!Regex.IsMatch(url, @"^https?:\/\/", RegexOptions.IgnoreCase))
                url = "http://" + url;

            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static string GetAppDataPath() {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        public static string GetMyVideosPath() {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        }

        /// <summary>
        /// Returns the relative path of the specified absolute <paramref name="path"/>, based off the current working directory.
        /// </summary>
        /// <param name="path">The absolute path to make relative to the current working directory.</param>
        /// <returns>A relative path, or the specified absolute <paramref name="path"/> if it can't be relativised.</returns>
        public static string GetRelativePath(string path) {
            return GetRelativePath(path, Directory.GetCurrentDirectory());
        }

        /// <summary>
        /// Returns the relative path of the specified absolute <paramref name="path"/>, based off the specified <paramref name="folder"/>.
        /// </summary>
        /// <param name="path">The absolute path to make relative to the specified <paramref name="folder"/>.</param>
        /// <param name="folder">The directory to base the relative path off.</param>
        /// <returns>A relative path, or the specified absolute <paramref name="path"/> if it can't be relativised.</returns>
        public static string GetRelativePath(string path, string folder) {
            if (path == null)
                throw new ArgumentNullException(nameof(path));
            if (folder == null)
                throw new ArgumentNullException(nameof(folder));

            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                folder += Path.DirectorySeparatorChar;

            Uri fileUri = new Uri(path);
            Uri folderUri = new Uri(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar);

            try {
                return Uri.UnescapeDataString(folderUri.MakeRelativeUri(fileUri).ToString().Replace('/', Path.DirectorySeparatorChar));
            } catch (InvalidOperationException e) {
                return path;
            }
        }

    }
}
