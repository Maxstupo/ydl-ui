using Maxstupo.YdlUi.Controls;
using System;

namespace Maxstupo.YdlUi.YoutubeDL.Model {
    public class FormatSelector {
        public const string SelectorTemplate = "";
        public const string MissingMetadata = "?";

        public VideoQuality VideoQuality { get; set; }
        public int FrameRate { get; set; }

        public bool IsVideoQualityPreferred { get; set; }
        public bool IsFrameRatePreferred { get; set; }

        public bool VideoQualityFallback { get; set; }
        public bool FrameRateFallback { get; set; }

        public FormatSelector(VideoQualitySelector videoQualitySelector, FrameRateSelector frameRateSelector) : this(videoQualitySelector.Quality, videoQualitySelector.IsPreferred, videoQualitySelector.IsFallback, frameRateSelector.FrameRate, frameRateSelector.IsPreferred, frameRateSelector.IsFallback) {
        }

        public FormatSelector(VideoQuality videoQuality, bool isVideoQualityPreferred, bool videoQualityFallback, int frameRate, bool isFrameRatePreferred, bool frameRateFallback) {
            VideoQuality = videoQuality ?? throw new ArgumentNullException(nameof(videoQuality));
            IsVideoQualityPreferred = isVideoQualityPreferred;
            VideoQualityFallback = videoQualityFallback;
            FrameRate = frameRate;
            IsFrameRatePreferred = isFrameRatePreferred;
            FrameRateFallback = frameRateFallback;
        }

        private string CreateSelector() {
            string vqFallback = VideoQualityFallback ? MissingMetadata : string.Empty;
            string vqPreferred = IsVideoQualityPreferred ? "<" : string.Empty;

            string frFallback = FrameRateFallback ? MissingMetadata : string.Empty;
            string frPreferred = IsFrameRatePreferred ? "<" : string.Empty;


            return string.Format("bestvideo[width{4}={3}{0}][height{4}={3}{1}][fps{6}={5}{2}]+bestaudio/best[width{4}={3}{0}][height{4}={3}{1}][fps{6}={5}{2}]", VideoQuality.Width, VideoQuality.Height, FrameRate, vqFallback, vqPreferred, frFallback, frPreferred);
        }

        public override string ToString() {
            return CreateSelector();
        }

    }
}
