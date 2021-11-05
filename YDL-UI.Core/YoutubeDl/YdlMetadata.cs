namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Maxstupo.YdlUi.Core.Download;
    using Maxstupo.YdlUi.Core.Download.Metadata;
    using Newtonsoft.Json.Linq;

    public sealed class YdlMetadata : IMetadata {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public string Url { get; }

        public string Title { get; }

        public string ThumbnailUrl { get; }

        public TimeSpan Duration { get; }


        private readonly JToken formats;

        public YdlMetadata(string url, JToken data) {
            this.Url = url ?? throw new ArgumentNullException(nameof(url));

            this.Title = data.Value<string>("title");
            this.ThumbnailUrl = data["thumbnails"].LastOrDefault()?.Value<string>("url");
            this.Duration = TimeSpan.FromSeconds(data.Value<int?>("duration").GetValueOrDefault(0));

            this.formats = data["formats"];
        }


        public List<VideoResolution> GetResolutions(DownloadStream mode) {
            if (mode == DownloadStream.Audio)
                return new List<VideoResolution>();

            Logger.Debug("Getting framerates for {mode}", mode);

            return formats.Select(x => {
                int width = x.Value<int?>("width").GetValueOrDefault(0);
                int height = x.Value<int?>("height").GetValueOrDefault(0);
                return new VideoResolution(width, height);
            }).Where(x => x.Width > 0 && x.Height > 0)
            .ToHashSet().ToList();
        }

        public List<int> GetFramerates(DownloadStream mode, VideoResolution resolution) {
            if (mode == DownloadStream.Audio)
                return new List<int>();

            Logger.Debug("Getting framerates for {mode} @ {res}", mode, resolution);

            return formats.Where(x => {
                int width = x.Value<int?>("width").GetValueOrDefault(0);
                int height = x.Value<int?>("height").GetValueOrDefault(0);
                return resolution.Width == width && resolution.Height == height;
            })
            .Select(x => x.Value<int?>("fps").GetValueOrDefault(0))
            .Where(x => x > 0)
            .ToHashSet().ToList();
        }

    }

}
