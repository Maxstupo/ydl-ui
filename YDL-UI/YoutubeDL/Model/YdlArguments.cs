using ByteSizeLib;
using Maxstupo.YdlUi.ArgumentBuilder;
using System;
using System.Collections.Generic;

namespace Maxstupo.YdlUi.YoutubeDL.Model {

    [ArgumentContainer]
    public class YdlArguments {
        public static readonly string Version = "2018.10.05";


        [Argument("", QuotePolicy = QuotePolicy.Always, Order = int.MaxValue)] public string Url { get; set; } = null;

        public YdlArgumentsGeneral General { get; set; } = new YdlArgumentsGeneral();
        public YdlArgumentsNetwork Network { get; set; } = new YdlArgumentsNetwork();
        public YdlArgumentsGeoRestriction GeoRestriction { get; set; } = new YdlArgumentsGeoRestriction();
        public YdlArgumentsVideoSelection VideoSelection { get; set; } = new YdlArgumentsVideoSelection();
        public YdlArgumentsDownload Download { get; set; } = new YdlArgumentsDownload();
        public YdlArgumentsFilesystem FileSystem { get; set; } = new YdlArgumentsFilesystem();
        public YdlArgumentsThumbnail Thumbnail { get; set; } = new YdlArgumentsThumbnail();
        public YdlArgumentsVerbosity Verbosity { get; set; } = new YdlArgumentsVerbosity();
        public YdlArgumentsWorkarounds Workarounds { get; set; } = new YdlArgumentsWorkarounds();
        public YdlArgumentsVideoFormat VideoFormat { get; set; } = new YdlArgumentsVideoFormat();
        public YdlArgumentsSubtitle Subtitle { get; set; } = new YdlArgumentsSubtitle();
        public YdlArgumentsAuthentication Authentication { get; set; } = new YdlArgumentsAuthentication(); // XmlIgnore auth arguments to prevent password being added to XML file presets.
        public YdlArgumentsAdobePass AdobePass { get; set; } = new YdlArgumentsAdobePass();
        public YdlArgumentsPostProcessing PostProcessing { get; set; } = new YdlArgumentsPostProcessing();
    }

    [ArgumentContainer]
    public class YdlArgumentsGeneral {
        [FlagArgument("--help")] public bool Help { get; set; }

        [FlagArgument("--version")] public bool Version { get; set; }
        // [FlagArgument("--update")] public bool Update { get; set; }

        [FlagArgument("--ignore-errors")] public bool IgnoreErrors { get; set; }
        [FlagArgument("--abort-on-error")] public bool AbortOnError { get; set; }

        [FlagArgument("--dump-user-agent")] public bool DumpUserAgent { get; set; }

        [FlagArgument("--list-extractors")] public bool ListExtractors { get; set; }
        [FlagArgument("--extractor-descriptions")] public bool ExtractorDescriptions { get; set; }
        [FlagArgument("--force-generic-extractor")] public bool ForceGenericExtractor { get; set; }

        [Argument("--default-search")] public string DefaultSearch { get; set; } = null;

        [FlagArgument("--ignore-config")] public bool IgnoreConfig { get; set; }
        [Argument("--config-location")] public string ConfigLocation { get; set; } = null;

        [FlagArgument("--flat-playlist")] public bool FlatPlaylist { get; set; }

        [FlagArgument("--mark-watched")] public bool MarkWatched { get; set; }
        [FlagArgument("--no-mark-watched")] public bool NoMarkWatched { get; set; }

        [FlagArgument("--no-color")] public bool NoColor { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsNetwork {
        [Argument("--proxy")] public string Proxy { get; set; } = null;
        [Argument("--socket-timeout")] public int? SocketTimeout { get; set; } = null;
        [Argument("--source-address")] public string SourceAddress { get; set; } = null;

        [FlagArgument("--force-ipv4")] public bool ForceIpv4 { get; set; }
        [FlagArgument("--force-ipv6")] public bool ForceIpv6 { get; set; }
    }

    [ArgumentContainer]
    public class YdlArgumentsGeoRestriction {
        [Argument("--geo-verification-proxy")] public string GeoVerificationProxy { get; set; } = null;

        [FlagArgument("--geo-bypass")] public bool GeoBypass { get; set; }
        [FlagArgument("--no-geo-bypass")] public bool NoGeoBypass { get; set; }

        [Argument("--geo-bypass-country")] public string GeoBypassCountry { get; set; } = null;
        [Argument("--geo-bypass-ip-block")] public string GeoBypassIpBlock { get; set; } = null;

    }

    [ArgumentContainer]
    public class YdlArgumentsVideoSelection {
        [Argument("--playlist-start")] public int? PlaylistStart { get; set; } = null;
        [Argument("--playlist-end")] public int? PlaylistEnd { get; set; } = null;
        [Argument("--playlist-items")] public string PlaylistItems { get; set; } = null;

        [Argument("--match-title")] public string MatchTitle { get; set; } = null;
        [Argument("--reject-title")] public string RejectTitle { get; set; } = null;
        [Argument("--max-downloads")] public int? MaxDownloads { get; set; } = null;

        [Argument("--min-filesize")] public ByteSize? MinFilesize { get; set; } = null;
        [Argument("--max-filesize")] public ByteSize? MaxFilesize { get; set; } = null;

        [Argument("--date")] public DateTime? Date { get; set; } = null;
        [Argument("--datebefore")] public DateTime? DateBefore { get; set; } = null;
        [Argument("--dateafter")] public DateTime? DateAfter { get; set; } = null;

        [Argument("--min-views")] public int? MinViews { get; set; } = null;
        [Argument("--max-views")] public int? MaxViews { get; set; } = null;
        [Argument("--match-filter")] public string MatchFilter { get; set; } = null;

        [FlagArgument("--no-playlist")] public bool NoPlaylist { get; set; }
        [FlagArgument("--yes-playlist")] public bool YesPlaylist { get; set; }

        [Argument("--age-limit")] public int? AgeLimit { get; set; } = null;

        [Argument("--download-archive")] public string DownloadArchive { get; set; } = null;

        [FlagArgument("--include-ads")] public bool IncludeAds { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsDownload {
        [Argument("--limit-rate")] public ByteSize? LimitRate { get; set; } = null;
        [Argument("--retries")] public string Retries { get; set; } = null;
        [Argument("--fragment-retries")] public string FragmentRetries { get; set; } = null;
        [FlagArgument("--skip-unavailable-fragments")] public bool SkipUnavailableFragments { get; set; }
        [FlagArgument("--abort-on-unavailable-fragment")] public bool AbortOnUnavailableFragment { get; set; }
        [FlagArgument("--keep-fragments")] public bool KeepFragments { get; set; }

        [Argument("--buffer-size")] public int? BufferSize { get; set; } = null;
        [FlagArgument("--no-resize-buffer")] public bool NoResizeBuffer { get; set; }
        [Argument("--http-chunk-size")] public int? HttpChunkSize { get; set; } = null;

        [FlagArgument("--playlist-reverse")] public bool PlaylistReverse { get; set; }
        [FlagArgument("--playlist-random")] public bool PlaylistRandom { get; set; }
        [FlagArgument("--xattr-set-filesize")] public bool XAttrSetFilesize { get; set; }
        [FlagArgument("--hls-prefer-native")] public bool HlsPreferNative { get; set; }
        [FlagArgument("--hls-prefer-ffmpeg")] public bool HlsPreferFFmpeg { get; set; }
        [FlagArgument("--hls-use-mpegts")] public bool HlsUseMpegts { get; set; }

        [Argument("--external-downloader")] public string ExternalDownloader { get; set; } = null;
        [Argument("--external-downloader-args")] public string ExternalDownloaderArgs { get; set; } = null;

    }

    [ArgumentContainer]
    public class YdlArgumentsFilesystem {
        [Argument("--batch-file")] public string BatchFile { get; set; } = null;
        [FlagArgument("--id")] public bool Id { get; set; }
        [Argument("--output")] public string OutputTemplate { get; set; } = null;
        [Argument("--autonumber-start")] public int? AutonumberStart { get; set; } = null;
        [FlagArgument("--restrict-filenames")] public bool RestrictFilenames { get; set; }
        [FlagArgument("--no-overwrites")] public bool NoOverwrites { get; set; }
        [FlagArgument("--continue")] public bool Continue { get; set; }

        [FlagArgument("--no-continue")] public bool NoContinue { get; set; }
        [FlagArgument("--no-part")] public bool NoPart { get; set; }
        [FlagArgument("--no-mtime")] public bool NoMTime { get; set; }

        [FlagArgument("--write-description")] public bool WriteDescription { get; set; }
        [FlagArgument("--write-info-json")] public bool WriteInfoJson { get; set; }
        [FlagArgument("--write-annotations")] public bool WriteAnnotations { get; set; }

        [Argument("--load-info-json")] public string LoadInfoJson { get; set; } = null;
        [Argument("--cookies")] public string Cookies { get; set; } = null;
        [Argument("--cache-dir")] public string CacheDir { get; set; } = null;

        [FlagArgument("--no-cache-dir")] public bool NoCacheDir { get; set; }
        [FlagArgument("--rm-cache-dir")] public bool RmCacheDir { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsThumbnail {
        [FlagArgument("--write-thumbnail")] public bool WriteThumbnail { get; set; }
        [FlagArgument("--write-all-thumbnails")] public bool WriteAllThumbnails { get; set; }
        [FlagArgument("--list-thumbnails")] public bool ListThumbnails { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsVerbosity {

        [FlagArgument("--quiet")] public bool Quiet { get; set; }
        [FlagArgument("--no-warnings")] public bool NoWarnings { get; set; }
        [FlagArgument("--simulate")] public bool Simulate { get; set; }
        [FlagArgument("--skip-download")] public bool SkipDownload { get; set; }
        [FlagArgument("--get-url")] public bool GetUrl { get; set; }
        [FlagArgument("--get-title")] public bool GetTitle { get; set; }
        [FlagArgument("--get-id")] public bool GetId { get; set; }
        [FlagArgument("--get-thumbnail")] public bool GetThumbnail { get; set; }
        [FlagArgument("--get-description")] public bool GetDescription { get; set; }
        [FlagArgument("--get-duration")] public bool GetDuration { get; set; }
        [FlagArgument("--get-filename")] public bool GetFilename { get; set; }
        [FlagArgument("--get-format")] public bool GetFormat { get; set; }
        [FlagArgument("--dump-json")] public bool DumpJson { get; set; }
        [FlagArgument("--dump-single-json")] public bool DumpSingleJson { get; set; }
        [FlagArgument("--print-json")] public bool PrintJson { get; set; }
        [FlagArgument("--newline")] public bool Newline { get; set; }
        [FlagArgument("--no-progress")] public bool NoProgress { get; set; }
        [FlagArgument("--console-title")] public bool ConsoleTitle { get; set; }
        [FlagArgument("--verbose")] public bool Verbose { get; set; }
        [FlagArgument("--dump-pages")] public bool DumpPages { get; set; }
        [FlagArgument("--write-pages")] public bool WritePages { get; set; }
        [FlagArgument("--print-traffic")] public bool PrintTraffic { get; set; }
        [FlagArgument("--call-home")] public bool CallHome { get; set; }
        [FlagArgument("--no-call-home")] public bool NoCallHome { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsWorkarounds {
        [Argument("--encoding")] public string Encoding { get; set; } = null;
        [FlagArgument("--no-check-certificate")] public bool NoCheckCertificate { get; set; }
        [FlagArgument("--prefer-insecure")] public bool PreferInsecure { get; set; }

        [Argument("--user-agent")] public string UserAgent { get; set; } = null;
        [Argument("--referer")] public string Referer { get; set; } = null;

        [Argument("--add-header")] public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();



        [FlagArgument("--bidi-workaround")] public bool BidiWorkaround { get; set; }
        [Argument("--sleep-interval")] public int? SleepInterval { get; set; } = null;
        [Argument("--max-sleep-interval")] public int? MaxSleepInterval { get; set; } = null;
        public int? MinSleepInterval { get { return SleepInterval; } set { SleepInterval = value; } }

    }

    [ArgumentContainer]
    public class YdlArgumentsVideoFormat {
        [Argument("--format")] public string Format { get; set; } = null;
        [FlagArgument("--all-formats")] public bool AllFormats { get; set; }
        [FlagArgument("--prefer-free-formats")] public bool PreferFreeFormats { get; set; }
        [FlagArgument("--list-formats")] public bool ListFormats { get; set; }
        [FlagArgument("--youtube-skip-dash-manifest")] public bool YoutubeSkipDashManifest { get; set; }
        [Argument("--merge-output-format", EnumCase = EnumCasePolicy.Lowercase)] public MergeVideoFormat? MergeOutputFormat { get; set; } = null;

    }

    [ArgumentContainer]
    public class YdlArgumentsSubtitle {
        [FlagArgument("--write-sub")] public bool WriteSub { get; set; }
        [FlagArgument("--write-auto-sub")] public bool WriteAutoSub { get; set; }
        [FlagArgument("--all-subs")] public bool AllSubs { get; set; }
        [FlagArgument("--list-subs")] public bool ListSubs { get; set; }
        [Argument("--sub-format")] public string SubFormat { get; set; } = null;
        [Argument("--sub-lang")] public string SubLang { get; set; } = null;


    }

    [ArgumentContainer]
    public class YdlArgumentsAuthentication {
        [Argument("--username")] public string Username { get; set; } = null;
        [Argument("--password")] public string Password { get; set; } = null;
        [Argument("--twofactor")] public string TwoFactor { get; set; } = null;
        [FlagArgument("--netrc")] public bool NetRc { get; set; }
        [Argument("--video-password")] public string VideoPassword { get; set; } = null;

    }

    [ArgumentContainer]
    public class YdlArgumentsAdobePass {
        [Argument("--ap-mso")] public string ApMso { get; set; } = null;
        [Argument("--ap-username")] public string ApUsername { get; set; } = null;
        [Argument("--ap-password")] public string ApPassword { get; set; } = null;
        [FlagArgument("--ap-list-mso")] public bool ApListMso { get; set; }

    }

    [ArgumentContainer]
    public class YdlArgumentsPostProcessing {

        [FlagArgument("--extract-audio")] public bool ExtractAudio { get; set; }
        [Argument("--audio-format", EnumCase = EnumCasePolicy.Lowercase)] public AudioFormat? AudioFormat { get; set; } = null;
        [Argument("--audio-quality")] public string AudioQuality { get; set; } = null;
        [Argument("--recode-video", EnumCase = EnumCasePolicy.Lowercase)] public VideoFormatRecode? RecodeVideo { get; set; } = null;
        [Argument("--post-processor-args")] public string PostProcessorArgs { get; set; } = null;
        [FlagArgument("--keep-video")] public bool KeepVideo { get; set; }
        [FlagArgument("--no-post-overwrites")] public bool NoPostOverwrites { get; set; }
        [FlagArgument("--embed-subs")] public bool EmbedSubs { get; set; }
        [FlagArgument("--embed-thumbnail")] public bool EmbedThumbnail { get; set; }
        [FlagArgument("--add-metadata")] public bool AddMetadata { get; set; }
        [Argument("--metadata-from-title")] public string MetadataFromTitle { get; set; } = null;
        [FlagArgument("--xattrs")] public bool XAttrs { get; set; }
        [Argument("--fixup")] public string Fixup { get; set; } = null;
        [FlagArgument("--prefer-avconv")] public bool PreferAvconv { get; set; }
        [FlagArgument("--prefer-ffmpeg")] public bool PreferFFmpeg { get; set; }
        [Argument("--ffmpeg-location")] public string FFmpegLocation { get; set; } = null;
        [Argument("--exec")] public string Exec { get; set; } = null;
        [Argument("--convert-subs", EnumCase = EnumCasePolicy.Lowercase)] public SubtitleFormat? ConvertSubs { get; set; } = null;
    }

}
