namespace Maxstupo.YdlUi.YoutubeDL {

    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides methods to parse youtube-dl output.
    /// </summary>
    public class YdlApi {
        // TODO: Add youtube-dl version support checking.
        private static readonly Regex regexStatus = new Regex(@"\[download\]\s+(?<percent>\d{1,3}\.?\d{0,2})%?\s+of\s+\~?(?<filesize>\d{1,4}\.?\d{1,3})(?<filesizeUnit>\w{1,3})\s+at\s+((?<speed>\d{1,3}\.?\d{1,3})(?<speedUnit>\w{1,3}\/s)|Unknown speed)\s+ETA\s+\~?(?<eta>\d{1,3}:\d{1,3}(?:\:\d{1,3})?)", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Regex regexPlaylist = new Regex(@"\[download\]\s{0,}?Downloading video\s{0,}?(\d{1,4})\s{0,}?of\s{0,}?(\d{1,4})", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Parse the youtube-dl output and update the stats for the provided <paramref name="download"/>.
        /// </summary>
        /// <param name="line">A line from youtube-dl.</param>
        /// <param name="download">The download to update.</param>
        public static void Parse(string line, Download download) {
            if ((download.Status != DownloadStatus.Downloading && download.Status != DownloadStatus.Processing) || string.IsNullOrWhiteSpace(line))
                return;

            // Attempt to update download status, this could break if we are using a user-specified youtube-dl binary.
            try {
                Match match = regexStatus.Match(line);
                if (match.Success) {
                    download.Progress = (int) float.Parse(match.Groups["percent"].Value, CultureInfo.InvariantCulture); // Issue #41 - Fix regional decimal separator.

                    // Issue #33
                    string rawEta = match.Groups["eta"].Value;
                    if (rawEta.Count(c => c == ':') == 1) // If ETA is "mm:ss"
                        rawEta = "00:" + rawEta; // Prefix "00:"
                    download.Eta = rawEta;

                    download.Size = match.Groups["filesize"].Value + " " + match.Groups["filesizeUnit"].Value;

                    string unit = match.Groups["speedUnit"].Value;
                    download.Speed = match.Groups["speed"].Value + " " + unit;

                }

                Match match2 = regexPlaylist.Match(line);
                if (match2.Success)
                    download.Playlist = $"{match2.Groups[1].Value} / {match2.Groups[2].Value}";

            } catch (Exception e) {
                Console.WriteLine(e);
            }

            if (download.Status == DownloadStatus.Downloading && line.StartsWith("[ffmpeg]"))
                download.Status = DownloadStatus.Processing;
            else if (download.Status == DownloadStatus.Processing && line.StartsWith("[download]"))
                download.Status = DownloadStatus.Downloading;


        }

    }

}