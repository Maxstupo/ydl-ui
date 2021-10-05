namespace Maxstupo.YdlUi.Core.YoutubeDl.Arguments {
    using System;
    using System.Collections.Generic;
    using ByteSizeLib;
    using Maxstupo.YdlUi.Core.Arguments;
    using Newtonsoft.Json;

    /// <summary>
    /// A data structure containing all command-line arguments for youtube-dl, supported by the command-line argument serializer. See <see cref="YdlArgumentSerializer"/>.
    /// <br/>
    /// XML doc from "youtube-dl --help" version 2021.06.06.
    /// <br/>
    /// <br/>
    /// Setting a property null will prevent that argument from being serialized. This is also supported for nullable value types (int?, TimeSpan?, DateTime?, etc.).
    /// </summary>
    public sealed class YdlArguments {

        /// <summary>The URL to download.</summary>
        [Argument("", QuotePolicy = QuotePolicy.Always, Order = int.MaxValue, Hidden = true)]
        [JsonProperty("url")] public string Url { get; set; } = null;

        /// <summary>Extra command-line arguments to be appended to the serialized command-line argument string.</summary>
        [Argument("", QuotePolicy = QuotePolicy.Off, Order = int.MaxValue - 1)]
        [JsonProperty("custom_arguments")] public string CustomArgs { get; set; }

        [JsonProperty("general")] [ArgumentContainer] public YdlArgumentsGeneral General { get; set; } = new YdlArgumentsGeneral();
        [JsonProperty("network")] [ArgumentContainer] public YdlArgumentsNetwork Network { get; } = new YdlArgumentsNetwork();
        [JsonProperty("geo_restriction")] [ArgumentContainer] public YdlArgumentsGeoRestriction GeoRestriction { get; } = new YdlArgumentsGeoRestriction();
        [JsonProperty("video_selection")] [ArgumentContainer] public YdlArgumentsVideoSelection VideoSelection { get; } = new YdlArgumentsVideoSelection();
        [JsonProperty("download")] [ArgumentContainer] public YdlArgumentsDownload Download { get; } = new YdlArgumentsDownload();
        [JsonProperty("file_system")] [ArgumentContainer] public YdlArgumentsFileSystem FileSystem { get; } = new YdlArgumentsFileSystem();
        [JsonProperty("thumbnail")] [ArgumentContainer] public YdlArgumentsThumbnail Thumbnail { get; } = new YdlArgumentsThumbnail();
        [JsonProperty("verbosity")] [ArgumentContainer] public YdlArgumentsVerbosity Verbosity { get; } = new YdlArgumentsVerbosity();
        [JsonProperty("workarounds")] [ArgumentContainer] public YdlArgumentsWorkarounds Workarounds { get; } = new YdlArgumentsWorkarounds();
        [JsonProperty("video_format")] [ArgumentContainer] public YdlArgumentsVideoFormat VideoFormat { get; } = new YdlArgumentsVideoFormat();
        [JsonProperty("subtitle")] [ArgumentContainer] public YdlArgumentsSubtitle Subtitle { get; } = new YdlArgumentsSubtitle();
        [JsonProperty("auth")] [ArgumentContainer] public YdlArgumentsAuthentication Authentication { get; } = new YdlArgumentsAuthentication();
        [JsonProperty("adobe_pass")] [ArgumentContainer] public YdlArgumentsAdobePass AdobePass { get; } = new YdlArgumentsAdobePass();
        [JsonProperty("post_processing")] [ArgumentContainer] public YdlArgumentsPostProcessing PostProcessing { get; } = new YdlArgumentsPostProcessing();

    }

    /// <summary>General options for youtube-dl.</summary>
    public sealed class YdlArgumentsGeneral {

        /// <summary>Print the help text and exit.</summary>
        [JsonIgnore] [FlagArgument("--help")] public bool Help { get; set; }

        /// <summary>Print program version and exit.</summary>
        [FlagArgument("--version")] public bool Version { get; set; }

        /// <summary>Update this program to latest version. Make sure that you have sufficient permissions (run with sudo if needed).</summary>
        // [FlagArgument("--update")] public bool Update { get; set; }

        /// <summary>Continue on download errors, for example to skip unavailble videos in a playlist.</summary>
        [FlagArgument("--ignore-errors")] public bool IgnoreErrors { get; set; }

        /// <summary>Abort downloading of further videos (in the playlist or the command line) if an error occurs.</summary>
        [FlagArgument("--abort-on-error")] public bool AbortOnError { get; set; }

        /// <summary>Display the current browser identification.</summary>
        [FlagArgument("--dump-user-agent")] public bool DumpUserAgent { get; set; }

        /// <summary>List all supported extractors.</summary>
        [FlagArgument("--list-extractors")] public bool ListExtractors { get; set; }

        /// <summary>Output descriptions of all supported extractors.</summary>
        [FlagArgument("--extractor-descriptions")] public bool ExtractorDescriptions { get; set; }

        /// <summary>Force extraction to use the generic extractor.</summary>
        [FlagArgument("--force-generic-extractor")] public bool ForceGenericExtractor { get; set; }

        /// <summary>
        /// Use this prefix for unqualified URLs. For example "gvsearch2:" downloads two videos from google videos for youtube-dl "large apple".
        /// Use the value "auto" to let youtube-dl guess("auto_warning" to emit a warning when guessing). "error" just throws an error.
        /// The default value "fixup_error" repairs broken URLs, but emits an error if this is not possible instead of searching.
        /// </summary>
        [Argument("--default-search")] public string DefaultSearch { get; set; } = null;

        /// <summary>Do not read configuration files. When given in the global configuration file /etc/youtube-dl.conf: Do not read the user configuration in ~/.config/youtube-dl/config (%APPDATA%/youtube-dl/config.txt on Windows).</summary>
        [FlagArgument("--ignore-config")] public bool IgnoreConfig { get; set; }

        /// <summary>Location of the configuration file; either the path to the config or its containing directory.</summary>
        [Argument("--config-location")] public string ConfigLocation { get; set; } = null;

        /// <summary>Do not extract the videos of a playlist, only list them.</summary>
        [FlagArgument("--flat-playlist")] public bool FlatPlaylist { get; set; }

        /// <summary>Mark videos watched (YouTube only).</summary>
        [FlagArgument("--mark-watched")] public bool MarkWatched { get; set; }

        /// <summary>Do not mark videos watched (YouTube only).</summary>
        [FlagArgument("--no-mark-watched")] public bool NoMarkWatched { get; set; }

        /// <summary>Do not emit color codes in output.</summary>
        [FlagArgument("--no-color")] public bool NoColor { get; set; }

    }

    /// <summary>Network options for youtube-dl.</summary>
    public sealed class YdlArgumentsNetwork {

        /// <summary>
        /// Use the specified HTTP/HTTPS/SOCKS proxy. To enable SOCKS proxy, specify a proper scheme.
        /// For example socks5://127.0.0.1:1080/. Pass in an empty string for direct connection.
        /// </summary>
        [JsonProperty("proxy")] [Argument("--proxy")] public string Proxy { get; set; } = null;

        /// <summary>Time to wait before giving up, in seconds.</summary>
        [JsonProperty("socket_timeout")] [Argument("--socket-timeout")] public TimeSpan? SocketTimeout { get; set; } = null;

        /// <summary>Client-side IP address to bind to.</summary>
        [JsonProperty("source_address")] [Argument("--source-address")] public string SourceAddress { get; set; } = null;

        /// <summary>Make all connections via IPv4.</summary>
        [JsonProperty("force_ipv4")] [FlagArgument("--force-ipv4")] public bool ForceIp4 { get; set; }

        /// <summary>Make all connections via IPv6.</summary>
        [JsonProperty("force_ipv6")] [FlagArgument("--force-ipv6")] public bool ForceIp6 { get; set; }

    }

    /// <summary>Geo restriction options for youtube-dl.</summary>
    public sealed class YdlArgumentsGeoRestriction {

        /// <summary>
        /// Use this proxy to verify the IP address for some geo-restricted sites.
        /// The default proxy specified by --proxy (or none, if the option is not present) is used for the actual downloading.
        /// </summary>
        [JsonProperty("geo_verification_proxy")] [Argument("--geo-verification-proxy")] public string GeoVerificationProxy { get; set; } = null;

        /// <summary>Bypass geographic restriction via faking X-Forwarded-For HTTP header.</summary>
        [JsonProperty("geo_bypass")] [FlagArgument("--geo-bypass")] public bool GeoBypass { get; set; }

        /// <summary>Do not bypass geographic restriction via faking X-Forwarded-For HTTP header.</summary>
        [JsonProperty("no_geo_bypass")] [FlagArgument("--no-geo-bypass")] public bool NoGeoBypass { get; set; }

        /// <summary>Force bypass geographic restriction with explicitly provided two-letter ISO 3166-2 country code.</summary>
        [JsonProperty("geo_bypass_country")] [Argument("--geo-bypass-country")] public string GeoBypassCountry { get; set; } = null;

        /// <summary>Force bypass geographic restriction with explicitly provided IP block in CIDR notation.</summary>
        [JsonProperty("geo_bypass_ip_block")] [Argument("--geo-bypass-ip-block")] public string GeoBypassIpBlock { get; set; } = null;

    }

    /// <summary>Video selection options for youtube-dl.</summary>
    public sealed class YdlArgumentsVideoSelection {

        /// <summary>Playlist video to start at (default is 1).</summary>
        [Argument("--playlist-start")] public int? PlaylistStart { get; set; } = null;

        /// <summary>Playlist video to end at (default is last).</summary>
        [Argument("--playlist-end")] public int? PlaylistEnd { get; set; } = null;

        /// <summary> 
        /// Playlist video items to download. Specify indices of the videos in the playlist 
        /// separated by commas like: "--playlist-items 1,2,5,8" if you want to download 
        /// videos indexed 1, 2, 5, 8 in the playlist. You can specify range: "--playlist-
        /// items 1-3,7,10-13", it will download the videos at index 1, 2, 3, 7, 10, 11, 12 and 13.
        /// </summary>
        [Argument("--playlist-items")] public string PlaylistItems { get; set; } = null;

        /// <summary>Download only matching titles (regex or caseless sub-string).</summary>
        [Argument("--match-title")] public string MatchTitle { get; set; } = null;

        /// <summary>Skip download for matching titles (regex or caseless sub-string).</summary>
        [Argument("--reject-title")] public string RejectTitle { get; set; } = null;

        /// <summary>Abort after downloading NUMBER files.</summary>
        [Argument("--max-downloads")] public int? MaxDownloads { get; set; } = null;

        /// <summary>Do not download any videos smaller than SIZE.</summary>
        [Argument("--min-filesize")] public ByteSize? MinFilesize { get; set; } = null;

        /// <summary>Do not download any videos larger than SIZE.</summary>
        [Argument("--max-filesize")] public ByteSize? MaxFilesize { get; set; } = null;

        /// <summary>Download only videos uploaded in this date.</summary>
        [Argument("--date")] public DateTime? Date { get; set; } = null;

        /// <summary>Download only videos uploaded on or before this date (i.e. inclusive).</summary>
        [Argument("--datebefore")] public DateTime? DateBefore { get; set; } = null;

        /// <summary>Download only videos uploaded on or after this date (i.e. inclusive).</summary>
        [Argument("--dateafter")] public DateTime? DateAfter { get; set; } = null;

        /// <summary>Do not download any videos with less than COUNT views.</summary>
        [Argument("--min-views")] public int? MinViews { get; set; } = null;

        /// <summary>Do not download any videos with more than COUNT views.</summary>
        [Argument("--max-views")] public int? MaxViews { get; set; } = null;

        /// <summary>
        /// Generic video filter. Specify any key (see the "OUTPUT TEMPLATE" for a list of available keys) to match if the key is present, !key to check if the key is not
        /// present, key &gt; NUMBER (like "comment_count &gt; 12", also works with &gt;=, &lt;, &lt;=, !=, =) to compare against a number, key = 'LITERAL' (like "uploader = 'Mike
        /// Smith'", also works with !=) to match against a string literal and &amp; to require
        /// multiple matches. Values which are not known are excluded unless you put a
        /// question mark (?) after the operator. For example, to only match videos that have been liked more than 100 times and disliked less than 50 times (or the
        /// dislike functionality is not available at the given service), but who also have
        /// a description, use --match-filter "like_count &gt; 100 &amp; dislike_count &lt;? 50 &amp;  description".
        /// </summary>
        [Argument("--match-filter")] public string MatchFilter { get; set; } = null;

        /// <summary>Download only the video, if the URL refers to a video and a playlist.</summary>
        [FlagArgument("--no-playlist")] public bool NoPlaylist { get; set; }

        /// <summary>Download the playlist, if the URL refers to a video and a playlist.</summary>
        [FlagArgument("--yes-playlist")] public bool YesPlaylist { get; set; }

        /// <summary>Download only videos suitable for the given age.</summary>
        [Argument("--age-limit")] public int? AgeLimit { get; set; } = null;

        /// <summary>Download only videos not listed in the archive file. Record the IDs of all downloaded videos in it.</summary>
        [Argument("--download-archive")] public string DownloadArchive { get; set; } = null;

    }

    /// <summary>Download options for youtube-dl.</summary>
    public sealed class YdlArgumentsDownload {

        /// <summary>Maximum download rate in bytes per second.</summary>
        [Argument("--limit-rate")] public ByteSize? LimitRate { get; set; } = null;

        /// <summary>Number of retries (default is 10), or "infinite".</summary>
        [Argument("--retries")] public string Retries { get; set; } = null;

        /// <summary>Number of retries for a fragment (default is 10), or "infinite" (DASH, hlsnative and ISM).</summary>
        [Argument("--fragment-retries")] public string FragmentRetries { get; set; } = null;

        /// <summary>Skip unavailable fragments (DASH, hlsnative and ISM).</summary>
        [FlagArgument("--skip-unavailable-fragments")] public bool SkipUnavailableFragments { get; set; }

        /// <summary>Abort downloading when some fragment is not available.</summary>
        [FlagArgument("--abort-on-unavailable-fragment")] public bool AbortOnUnavailableFragment { get; set; }

        /// <summary>Keep downloaded fragments on disk after downloading is finished; fragments are erased by default.</summary>
        [FlagArgument("--keep-fragments")] public bool KeepFragments { get; set; }

        /// <summary>Size of download buffer (e.g. 1024 or 16K) (default is 1024).</summary>
        [Argument("--buffer-size")] public int? BufferSize { get; set; } = null;

        /// <summary>
        /// Do not automatically adjust the buffer size. By default, the buffer size is 
        /// automatically resized from an initial value of SIZE.
        /// </summary>
        [FlagArgument("--no-resize-buffer")] public bool NoResizeBuffer { get; set; }

        /// <summary>
        /// Size of a chunk for chunk-based HTTP downloading (e.g. 10485760 or 10M) (default is disabled). 
        /// May be useful for bypassing bandwidth throttling imposed by a webserver (experimental)
        /// </summary>
        [Argument("--http-chunk-size")] public int? HttpChunkSize { get; set; } = null;

        /// <summary>Download playlist videos in reverse order.</summary>
        [FlagArgument("--playlist-reverse")] public bool PlaylistReverse { get; set; }

        /// <summary>Download playlist videos in random order.</summary>
        [FlagArgument("--playlist-random")] public bool PlaylistRandom { get; set; }

        /// <summary>Set file xattribute ytdl.filesize with expected file size.</summary>
        [FlagArgument("--xattr-set-filesize")] public bool XAttrSetFilesize { get; set; }

        /// <summary>Use the native HLS downloader instead of ffmpeg.</summary>
        [FlagArgument("--hls-prefer-native")] public bool HlsPreferNative { get; set; }

        /// <summary>Use ffmpeg instead of the native HLS downloader.</summary>
        [FlagArgument("--hls-prefer-ffmpeg")] public bool HlsPreferFFmpeg { get; set; }

        /// <summary> 
        /// Use the mpegts container for HLS videos, allowing to play the video while
        /// downloading (some players may not be able to play it).
        /// </summary>
        [FlagArgument("--hls-use-mpegts")] public bool HlsUseMpegts { get; set; }

        /// <summary>Use the specified external downloader. Currently supports: aria2c, avconv, axel, curl, ffmpeg, httpie, wget</summary>
        [Argument("--external-downloader")] public string ExternalDownloader { get; set; } = null;

        /// <summary>Give these arguments to the external downloader.</summary>
        [Argument("--external-downloader-args")] public string ExternalDownloaderArgs { get; set; } = null;

    }

    /// <summary>File system options for youtube-dl.</summary>
    public sealed class YdlArgumentsFileSystem {

        /// <summary>
        /// File containing URLs to download ('-' for stdin), one URL per line.
        /// Lines starting with '#', ';', or ']' are considered as comments and ignored.
        /// </summary>
        [Argument("--batch-file")] public string BatchFile { get; set; } = null;

        /// <summary>
        /// Output filename template, see the "OUTPUT TEMPLATE" for all the info.<br/><br/>
        /// https://github.com/ytdl-org/youtube-dl/tree/2021.06.06#output-template
        /// </summary>
        [Argument("--output")] public string OutputTemplate { get; set; } = null;

        /// <summary>Specify the start value for %(autonumber)s (default is 1).</summary>
        [Argument("--autonumber-start")] public int? AutonumberStart { get; set; } = null;

        /// <summary>Restrict filenames to only ASCII characters, and avoid "&" and spaces in filenames.</summary>
        [FlagArgument("--restrict-filenames")] public bool RestrictFilenames { get; set; }

        /// <summary>Do not overwrite files.</summary>
        [FlagArgument("--no-overwrites")] public bool NoOverwrites { get; set; }

        /// <summary>Force resume of partially downloaded files. By default, youtube-dl will resume downloads if possible.</summary>
        [FlagArgument("--continue")] public bool Continue { get; set; }

        /// <summary>Do not resume partially downloaded files (restart from beginning).</summary>
        [FlagArgument("--no-continue")] public bool NoContinue { get; set; }

        /// <summary>Do not use .part files - write directly into output file.</summary>
        [FlagArgument("--no-part")] public bool NoPart { get; set; }

        /// <summary>Do not use the Last-modified header to set the file modification time.</summary>
        [FlagArgument("--no-mtime")] public bool NoMTime { get; set; }

        /// <summary>Write video description to a .description file.</summary>
        [FlagArgument("--write-description")] public bool WriteDescription { get; set; }

        /// <summary>Write video metadata to a .info.json file.</summary>
        [FlagArgument("--write-info-json")] public bool WriteInfoJson { get; set; }

        /// <summary>JSON file containing the video information (created with the WriteInfoJson option).</summary>
        [Argument("--load-info-json")] public string LoadInfoJson { get; set; } = null;

        /// <summary>File to read cookies from and dump cookie jar in.</summary>
        [Argument("--cookies")] public string Cookies { get; set; } = null;

        /// <summary>
        /// Location in the filesystem where youtube-dl can store some downloaded information permanently.
        /// By default $XDG_CACHE_HOME/youtube-dl or ~/.cache/youtube-dl.
        /// At the moment, only YouTube player files (for videos with obfuscated signatures) are cached, but that may change.
        /// </summary>
        [Argument("--cache-dir")] public string CacheDir { get; set; } = null;

        /// <summary>Disable filesystem caching.</summary>
        [FlagArgument("--no-cache-dir")] public bool NoCacheDir { get; set; }

        /// <summary>Delete all filesystem cache files.</summary>
        [FlagArgument("--rm-cache-dir")] public bool RmCacheDir { get; set; }

    }

    /// <summary>Thumbnail options for youtube-dl.</summary>
    public sealed class YdlArgumentsThumbnail {

        /// <summary>Write thumbnail image to disk.</summary>
        [JsonProperty("write_thumbnail")] [FlagArgument("--write-thumbnail")] public bool WriteThumbnail { get; set; }

        /// <summary>Write all thumbnail image formats to disk.</summary>
        [JsonProperty("write_all_thumbnails")] [FlagArgument("--write-all-thumbnails")] public bool WriteAllThumbnails { get; set; }

        /// <summary>Simulate and list all available thumbnail formats.</summary>
        [JsonProperty("list_thumbnails")] [FlagArgument("--list-thumbnails")] public bool ListThumbnails { get; set; }

    }

    /// <summary>Verbosity options for youtube-dl.</summary>
    public sealed class YdlArgumentsVerbosity {

        /// <summary>Activate quiet mode.</summary>
        [FlagArgument("--quiet")] public bool Quiet { get; set; }

        /// <summary>Ignore warnings.</summary>
        [FlagArgument("--no-warnings")] public bool NoWarnings { get; set; }

        /// <summary>Do not download the video and do not write anything to disk.</summary>
        [FlagArgument("--simulate")] public bool Simulate { get; set; }

        /// <summary>Do not download the video.</summary>
        [FlagArgument("--skip-download")] public bool SkipDownload { get; set; }

        /// <summary>Simulate, quiet but print URL.</summary>
        [FlagArgument("--get-url")] public bool GetUrl { get; set; }

        /// <summary>Simulate, quiet but print title.</summary>
        [FlagArgument("--get-title")] public bool GetTitle { get; set; }

        /// <summary>Simulate, quiet but print id.</summary>
        [FlagArgument("--get-id")] public bool GetId { get; set; }

        /// <summary>Simulate, quiet but print video thumbnail URL.</summary>
        [FlagArgument("--get-thumbnail")] public bool GetThumbnail { get; set; }

        /// <summary>Simulate, quiet but print video description.</summary>
        [FlagArgument("--get-description")] public bool GetDescription { get; set; }

        /// <summary>Simulate, quiet but print video length.</summary>
        [FlagArgument("--get-duration")] public bool GetDuration { get; set; }

        /// <summary>Simulate, quiet but print output filename.</summary>
        [FlagArgument("--get-filename")] public bool GetFilename { get; set; }

        /// <summary>Simulate, quiet but print output format.</summary>
        [FlagArgument("--get-format")] public bool GetFormat { get; set; }

        /// <summary>
        /// Simulate, quiet but print JSON information. See the "OUTPUT TEMPLATE" for a description of available keys.<br/><br/>
        /// https://github.com/ytdl-org/youtube-dl/tree/2021.06.06#output-template
        /// </summary>
        [FlagArgument("--dump-json")] public bool DumpJson { get; set; }

        /// <summary>
        /// Simulate, quiet but print JSON information for each command-line argument.
        /// If the URL refers to a playlist, dump the whole playlist information in a single line.
        /// </summary>
        [FlagArgument("--dump-single-json")] public bool DumpSingleJson { get; set; }

        /// <summary>Be quiet and print the video information as JSON (video is still being downloaded).</summary>
        [FlagArgument("--print-json")] public bool PrintJson { get; set; }

        /// <summary>Output progress bar as new lines.</summary>
        [FlagArgument("--newline")] public bool Newline { get; set; }

        /// <summary>Do not print progress bar.</summary>
        [FlagArgument("--no-progress")] public bool NoProgress { get; set; }

        /// <summary>Display progress in console titlebar.</summary>
        [FlagArgument("--console-title")] public bool ConsoleTitle { get; set; }

        /// <summary>Print various debugging information.</summary>
        [FlagArgument("--verbose")] public bool Verbose { get; set; }

        /// <summary>Print downloaded pages encoded using base64 to debug problems (very verbose).</summary>
        [FlagArgument("--dump-pages")] public bool DumpPages { get; set; }

        /// <summary>Write downloaded intermediary pages to files in the current directory to debug problems.</summary>
        [FlagArgument("--write-pages")] public bool WritePages { get; set; }

        /// <summary>Display sent and read HTTP traffic.</summary>
        [FlagArgument("--print-traffic")] public bool PrintTraffic { get; set; }

        /// <summary>Do NOT contact the youtube-dl server for debugging.</summary>
        [FlagArgument("--no-call-home")] public bool NoCallHome { get; set; }

    }

    /// <summary>Workaround options for youtube-dl.</summary>
    public sealed class YdlArgumentsWorkarounds {

        /// <summary>Force the specified encoding (experimental).</summary>
        [Argument("--encoding")] public string Encoding { get; set; } = null;

        /// <summary>Suppress HTTPS certificate validation.</summary>
        [FlagArgument("--no-check-certificate")] public bool NoCheckCertificate { get; set; }

        /// <summary>Use an unencrypted connection to retrieve information about the video (Currently only supported for YouTube).</summary>
        [FlagArgument("--prefer-insecure")] public bool PreferInsecure { get; set; }

        /// <summary>Specify a custom user agent.</summary>
        [Argument("--user-agent")] public string UserAgent { get; set; } = null;

        /// <summary>Specify a custom referer, use if the video access is restricted to one domain.</summary>
        [Argument("--referer")] public string Referer { get; set; } = null;

        // TODO: Use an enum for HTTP header types.
        /// <summary>Specify custom HTTP headers and their values.</summary>
        [Argument("--add-header")] public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>Work around terminals that lack bidirectional text support. Requires bidiv or fribidi executable in path.</summary>
        [FlagArgument("--bidi-workaround")] public bool BidiWorkaround { get; set; }

        /// <summary>Number of seconds to sleep before each download.</summary>
        [Argument("--sleep-interval")] public int? SleepInterval { get; set; } = null;

        /// <summary>
        /// Lower bound of a range for randomized sleep before each download (minimum possible number of seconds to sleep). 
        /// Must only be used along with MaxSleepInterval.
        /// </summary>
        [JsonIgnore] public int? MinSleepInterval { get => SleepInterval; set => SleepInterval = value; }

        /// <summary>
        /// Upper bound of a range for randomized sleep before each download (maximum possible number of seconds to sleep). 
        /// Must only be used along with MinSleepInterval.
        /// </summary>
        [Argument("--max-sleep-interval")] public int? MaxSleepInterval { get; set; } = null;

    }

    /// <summary>Video format options for youtube-dl.</summary>
    public sealed class YdlArgumentsVideoFormat {

        /// <summary>
        /// Video format code, see the "FORMAT SELECTION" for all the info.<br/><br/>
        /// https://github.com/ytdl-org/youtube-dl/tree/2021.06.06#format-selection
        /// </summary>
        [JsonProperty("format")] [Argument("--format")] public string Format { get; set; } = null;

        /// <summary>Download all available video formats.</summary>
        [JsonProperty("all_formats")] [FlagArgument("--all-formats")] public bool AllFormats { get; set; }

        /// <summary>Prefer free video formats unless a speciic one is requested.</summary>
        [JsonProperty("prefer_free_formats")] [FlagArgument("--prefer-free-formats")] public bool PreferFreeFormats { get; set; }

        /// <summary>List all available formats of requested videos.</summary>
        [JsonProperty("list_formats")] [FlagArgument("--list-formats")] public bool ListFormats { get; set; }

        /// <summary>Do not download the DASH manifests and related data on YouTube videos.</summary>
        [JsonProperty("youtube_skip_dash_manifest")] [FlagArgument("--youtube-skip-dash-manifest")] public bool YoutubeSkipDashManifest { get; set; }

        /// <summary>If a merge is required (e.g. bestvideo+bestaudio), output to given container format. Ignored if no merge is required.</summary>
        [JsonProperty("merge_output_format")] [Argument("--merge-output-format", EnumCase = EnumCasePolicy.Lowercase)] public MergeVideoFormat? MergeOutputFormat { get; set; } = null;

    }

    /// <summary>Subtitle options for youtube-dl.</summary>
    public sealed class YdlArgumentsSubtitle {

        /// <summary>Write subtitle file.</summary>
        [JsonProperty("write_sub")] [FlagArgument("--write-sub")] public bool WriteSub { get; set; }

        /// <summary>Write automatically generated subtitle file (YouTube only).</summary>
        [JsonProperty("write_auto_sub")] [FlagArgument("--write-auto-sub")] public bool WriteAutoSub { get; set; }

        /// <summary>Download all the available subtitles of the video.</summary>
        [JsonProperty("all_subs")] [FlagArgument("--all-subs")] public bool AllSubs { get; set; }

        /// <summary>List all available subtitles for the video.</summary>
        [JsonProperty("list_subs")] [FlagArgument("--list-subs")] public bool ListSubs { get; set; }

        /// <summary>Subtitle format, accepts formats preference, for example: "srt" or "ass/srt/best"</summary>
        [JsonProperty("sub_format")] [Argument("--sub-format")] public string SubFormat { get; set; } = null;

        /// <summary>Languages of the subtitles to download (optional) separated by commas, use --list-subs for available language tags.</summary>
        [JsonProperty("sub_lang")] [Argument("--sub-lang")] public string SubLang { get; set; } = null;

    }

    /// <summary>Authentication options for youtube-dl.</summary>
    public sealed class YdlArgumentsAuthentication {

        /// <summary>Login with this account id.</summary>
        [JsonProperty("username")] [Argument("--username")] public string Username { get; set; } = null;

        /// <summary>Account password. If this option is left out, youtube-dl will ask interactively.</summary>
        [JsonProperty("password")] [Argument("--password")] public string Password { get; set; } = null;

        /// <summary>Two-factor authentication code.</summary>
        [JsonProperty("two_factor")] [Argument("--twofactor")] public string TwoFactor { get; set; } = null;

        /// <summary>Use .netrc authentication data.</summary>
        [JsonProperty("net_rc")] [FlagArgument("--netrc")] public bool NetRc { get; set; }

        /// <summary>Video password (vimeo, youku)</summary>
        [JsonProperty("video_password")] [Argument("--video-password")] public string VideoPassword { get; set; } = null;

    }

    /// <summary>Adobe Pass options for youtube-dl.</summary>
    public sealed class YdlArgumentsAdobePass {

        /// <summary>Adobe Pass multiple-system operator (TV provider) identifier, use --ap-list-mso for a list of available MSOs.</summary>
        [JsonProperty("mso")] [Argument("--ap-mso")] public string ApMso { get; set; } = null;

        /// <summary>Multiple-system operator account login.</summary>
        [JsonProperty("username")] [Argument("--ap-username")] public string ApUsername { get; set; } = null;

        /// <summary>Multiple-system operator account password. If this option is left out, youtube-dl will ask interactively.</summary>
        [JsonProperty("password")] [Argument("--ap-password")] public string ApPassword { get; set; } = null;

        /// <summary>List all supported multiple-system operators.</summary>
        [JsonProperty("list_mso")] [FlagArgument("--ap-list-mso")] public bool ApListMso { get; set; }

    }

    /// <summary>Post processing options for youtube-dl.</summary>
    public sealed class YdlArgumentsPostProcessing {

        /// <summary>Convert video files to audio-only files (requires ffmpeg/avconv and ffprobe/avprobe).</summary>
        [FlagArgument("--extract-audio")] public bool ExtractAudio { get; set; }

        /// <summary>Specify audio format. Best by default; No effect without ExtractAudio.</summary>
        [Argument("--audio-format", EnumCase = EnumCasePolicy.Lowercase)] public AudioFormat? AudioFormat { get; set; } = null;

        // TODO: Use data structure for audio quality. 
        /// <summary>Specify ffmpeg/avconv audio quality, insert a value between 0 (better) and 9 (worse) for VBR or a specific bitrate like 128K (default 5).</summary>
        [Argument("--audio-quality")] public string AudioQuality { get; set; } = null;

        /// <summary>Encode the video to another format if necessary.</summary>
        [Argument("--recode-video", EnumCase = EnumCasePolicy.Lowercase)] public VideoFormatRecode? RecodeVideo { get; set; } = null;

        /// <summary>Give these arguments to the postprocessor.</summary>
        [Argument("--post-processor-args")] public string PostProcessorArgs { get; set; } = null;

        /// <summary>Keep the video file on disk after the post-processing; the video is erased by default.</summary>
        [FlagArgument("--keep-video")] public bool KeepVideo { get; set; }

        /// <summary>Do not overwrite post-processed files; the post-processed files are overwritten by default.</summary>
        [FlagArgument("--no-post-overwrites")] public bool NoPostOverwrites { get; set; }

        /// <summary>Embed subtitles in the video (only for mp4, webm and mkv videos).</summary>
        [FlagArgument("--embed-subs")] public bool EmbedSubs { get; set; }

        /// <summary>Embed thumbnail in the audio as cover art.</summary>
        [FlagArgument("--embed-thumbnail")] public bool EmbedThumbnail { get; set; }

        /// <summary>Write metadata to the video file.</summary>
        [FlagArgument("--add-metadata")] public bool AddMetadata { get; set; }

        /// <summary>
        /// Parse additional metadata like song title / artist from the video title.
        /// The format syntax is the same as --output.Regular expression with named capture groups may also be used.
        /// The parsed parameters replace existing values.
        /// </summary>
        [Argument("--metadata-from-title")] public string MetadataFromTitle { get; set; } = null;

        /// <summary>Write metadata to the video file's xattrs (using dublin core and xdg standards).</summary>
        [FlagArgument("--xattrs")] public bool XAttrs { get; set; }

        /// <summary>
        /// Automatically correct known faults of the file. 
        /// One of never (do nothing), warn (only emit a warning), detect_or_warn(the default; fix file if we can, warn otherwise)
        /// </summary>
        [Argument("--fixup")] public string Fixup { get; set; } = null;

        /// <summary>Prefer ffmpeg over avconv for running the postprocessors (default).</summary>
        [FlagArgument("--prefer-ffmpeg")] public bool PreferFFmpeg { get; set; }

        /// <summary>Location of the ffmpeg/avconv binary; either the path to the binary or its containing directory.</summary>
        [Argument("--ffmpeg-location")] public string FFmpegLocation { get; set; } = null;

        /// <summary>
        /// Execute a command on the file after downloading and post-processing, similar to
        /// find's -exec syntax. Example: --exec 'adb push { } /sdcard/Music/ && rm {}'
        /// </summary>
        [Argument("--exec")] public string Exec { get; set; } = null;

        /// <summary>Convert the subtitles to other format (currently supported: srt|ass|vtt|lrc).</summary>
        [Argument("--convert-subs", EnumCase = EnumCasePolicy.Lowercase)] public SubtitleFormat? ConvertSubs { get; set; } = null;

    }

    public enum VideoFormatRecode {
        Mp4,
        Flv,
        Ogg,
        Webm,
        Mkv,
        Avi
    }

    public enum MergeVideoFormat {
        Mvk,
        Mp4,
        Ogg,
        Webm,
        Flv
    }

    public enum SubtitleFormat {
        Srt,
        Ass,
        Vtt,
        Lrc
    }

    public enum AudioFormat {
        Best,
        Aac,
        Flac,
        Mp3,
        M4a,
        Opus,
        Vorbis,
        Wav
    }

}