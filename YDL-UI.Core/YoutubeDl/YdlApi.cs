namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using ByteSizeLib;
    using Maxstupo.YdlUi.Core.Download;
    using Maxstupo.YdlUi.Core.Download.Metadata;
    using Maxstupo.YdlUi.Core.Options;
    using Maxstupo.YdlUi.Core.Utility;
    using Maxstupo.YdlUi.Core.Utility.Exec;
    using Maxstupo.YdlUi.Core.YoutubeDl.Arguments;
    using Newtonsoft.Json.Linq;

    public interface IYdlApi {

        Task<List<IMetadata>> FetchMetdataAsync(string url, IProgress<Progress> progress, CancellationToken ct);

        bool ParseError(string data, out string id, out string message);

        Task DownloadAsync(IDownload download, IProgress<DownloadStatistics> progress, CancellationToken ct);

    }

    /// <summary>
    /// The default API implementation for youtube-dl.
    /// </summary>
    public class YdlApi : IYdlApi {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IExecutableProcessProvider provider;
        private readonly ISettings<AdvancedSettings> advancedSettings;

        private static readonly (string errorPartial, string id, string message)[] Errors = new (string, string, string)[] {
                ("ERROR: Incomplete YouTube ID", "incomplete_video_id", "Failed: Incomplete YouTube ID"),
                ("ERROR: Video unavailable", "video_unavailable", "Failed: Video Unavailable")
        };

        public YdlApi(IExecutableProcessProvider provider, ISettings<AdvancedSettings> advancedSettings) {
            this.provider = provider;
            this.advancedSettings = advancedSettings;
        }

        public bool ParseError(string data, out string id, out string message) {
            string text = data.ToLower().Trim();

            var err = Errors.FirstOrDefault(x => text.Contains(x.errorPartial, StringComparison.OrdinalIgnoreCase));

            if (err != default) {
                id = err.id;
                message = err.message;
                return true;
            }

            id = string.Empty;
            message = string.Empty;
            return false;
        }

        private static readonly RegexOptions Options = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant;
        private static readonly Regex RegexPercentage = new Regex(@"(\d+(?:\.\d+))\%", Options);
        private static readonly Regex RegexEta = new Regex(@"\d{2}\:\d{2}\:\d{2}", Options);

        public void ParseOutput(string data, ref IProgress<DownloadStatistics> progress) {
            string text = data.ToLower().Trim();

            // [download]   0.1% of 1001.23MiB at 71.70KiB/s ETA 03:58:01

            float percent = 0;
            TimeSpan eta = TimeSpan.Zero;

            var percentMatch = RegexPercentage.Match(data);
            if (percentMatch.Success)
                float.TryParse(percentMatch.Groups[1].Value, out percent);

            var etaMatch = RegexEta.Match(data);
            if (etaMatch.Success)
                TimeSpan.TryParse(etaMatch.Value, out eta);


            progress.Report(new DownloadStatistics((int) ((percent / 100f) * 1000f), 1000, ByteSize.FromBits(0), ByteSize.FromBits(0), eta));
        }


        public async Task DownloadAsync(IDownload download, IProgress<DownloadStatistics> progress, CancellationToken ct) {
            Logger.Info("Starting download for {url}", download.Url);

            progress.Report(new DownloadStatistics(0, 0, ByteSize.FromBytes(0), ByteSize.FromBytes(0), TimeSpan.Zero));


            IExecutableProcess process = provider.CreateExecutableProcess(new YdlArguments {
                Url = download.Url,
                General = { IgnoreConfig = true },
                FileSystem = { NoCacheDir = true },
                Verbosity = {
                    // Verbose = true // Note: youtube-dl verbose breaks, since we throw an exception on stderr and verbose text is output on stderr. 
                },
                VideoFormat = {
                    Format = "bestvideo+bestaudio/best"
                }
            });

            process.OnReceived += (s, e) => {
                Logger.Info(e);
                ParseOutput(e, ref progress);
            };
            process.OnExited += (s, e) => {
                Logger.Info("Process Exited!");
            };


            await process.StartAsync(ct);

        }

        public async Task<List<IMetadata>> FetchMetdataAsync(string url, IProgress<Progress> progress, CancellationToken ct) {

            progress.Report(new Progress(0, -1));

            List<IMetadata> list = new List<IMetadata>();

            await FetchMetadataAsync(url, progress, ct, list).ConfigureAwait(false);

            return list;
        }

        private async Task FetchMetadataAsync(string url, IProgress<Progress> progress, CancellationToken ct, List<IMetadata> metadatas) {
            Logger.Info("Fetching metadata for {url}", url);

            // youtube-dl.exe --flat-playlist --dump-single-json <url>
            IExecutableProcess process = provider.CreateExecutableProcess(new YdlArguments {
                Url = url,
                General = { FlatPlaylist = true },
                Verbosity = { DumpSingleJson = true }
            });

            string json = await process.QueryAsync(ct).ConfigureAwait(false);

            if (json == null)
                return;

            //            Logger.Trace("Fetch metadata response - {json}", json);

            JToken data = JToken.Parse(json);

            if (data.Value<string>("is_live") != null && data.Value<bool>("is_live")) {
                Logger.Warn("{url} detected as livestream, not implemented yet!", url);

            } else if (data.Value<string>("_type") == "playlist") { // playlist
                Logger.Debug("{url} detected as playlist, fetching metadata for playlist items...", url);

                List<JToken> list = data["entries"].ToList();

                progress.Report(new Progress(0, list.Count));

                // limit number of fetching concurrent playlist items to MaxConcurrentFetchingPlaylistItems
                using (SemaphoreSlim limiter = new SemaphoreSlim(advancedSettings.Value?.MaxConcurrentFetchingPlaylistItems ?? 3)) {
                    List<Task> tasks = new List<Task>();

                    int count = 0;
                    foreach (JToken item in list) {

                        if (ct.IsCancellationRequested)
                            break;

                        string suburl = item.Value<string>("url");

                        await limiter.WaitAsync();

                        tasks.Add(Task.Run(async () => {
                            try {
                                await FetchMetadataAsync(suburl, progress, ct, metadatas).ConfigureAwait(false);

                                progress.Report(new Progress(Interlocked.Increment(ref count), list.Count));
                            } finally {
                                limiter.Release();
                            }
                        }, ct));
                    }

                    await Task.WhenAll(tasks).ConfigureAwait(false);
                }
            } else { // single video
                Logger.Debug("{url} detected as video...", url);

                progress.Report(new Progress(1, 1));

                metadatas.Add(new YdlMetadata(url, data));
            }

        }


    }

}
