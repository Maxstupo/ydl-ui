using ByteSizeLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maxstupo.YdlUi.Utility {
    public static class Util {

        /// <summary>
        /// Replaces the <paramref name="oldItem"/> with the <paramref name="newItem"/>.
        /// </summary
        /// <param name="oldItem">The item to replace.</param>
        /// <param name="newItem">The item to be used as replacement.</param>
        /// <exception cref="ArgumentException">If the <paramref name="oldItem"/> couldn't be found in the list.</exception>
        public static void Replace<T>(this IList<T> src, T oldItem, T newItem) {
            int idx = src.IndexOf(oldItem);
            if (idx == -1)
                throw new ArgumentException(nameof(oldItem));
            src.RemoveAt(idx);
            src.Insert(idx, newItem);
        }

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
            if (string.IsNullOrWhiteSpace(url))
                return false;

            if (!Regex.IsMatch(url, @"^https?:\/\/", RegexOptions.IgnoreCase))
                url = "http://" + url;

            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// Returns the <see cref="Environment.SpecialFolder.ApplicationData"/> path for this current system.
        /// </summary>
        /// <returns>The <see cref="Environment.SpecialFolder.ApplicationData"/> path for this current system.</returns>
        public static string GetAppDataPath() {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        /// <summary>
        /// Returns the <see cref="Environment.SpecialFolder.MyVideos"/> path for this current system.
        /// </summary>
        /// <returns>The <see cref="Environment.SpecialFolder.MyVideos"/> path for this current system.</returns>
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

        public static string GetAbsolutePath(string path) {
            return GetAbsolutePath(path, Directory.GetCurrentDirectory());
        }

        public static string GetAbsolutePath(string path, string folder) {
            string absolutePath = Path.Combine(folder, path);
            return Path.GetFullPath((new Uri(absolutePath).LocalPath));
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

    public class NetUtil {
        private NetUtil() { }

        public static async Task<string> HttpGetAsync(string url, string userAgent = null) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 15000; // 15 seconds

            if (userAgent != null)
                request.UserAgent = userAgent;


            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync()) {
                using (Stream stream = response.GetResponseStream()) {
                    using (StreamReader streamReader = new StreamReader(stream)) {
                        return await streamReader.ReadToEndAsync();
                    }
                }
            }
        }
    }
}
