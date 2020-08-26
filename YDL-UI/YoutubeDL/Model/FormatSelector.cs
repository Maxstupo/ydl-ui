using Maxstupo.YdlUi.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maxstupo.YdlUi.YoutubeDL.Model {
    public class FormatSelector {
        public static readonly int[] DefaultFrameRates = { 144, 120, 60, 50, 48, 30, 25, 24 };
     
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

            List<int> heights = new List<int>();
            List<int> frameRates = new List<int>(DefaultFrameRates);

            foreach (VideoQuality quality in VideoQuality.StandardQualities) {
                if (quality.Width > 0 && quality.Height > 0)
                    heights.Add(quality.Height);
            }
            if (!heights.Contains(VideoQuality.Height)) // Custom height.
                heights.Add(VideoQuality.Height);
            heights = heights.OrderByDescending(i => i).ToList();

            if (!frameRates.Contains(FrameRate)) // Custom framerate.
                frameRates.Add(FrameRate);
            frameRates = frameRates.OrderByDescending(i => i).ToList();


            int vqIndex = heights.IndexOf(VideoQuality.Height);
            int frIndex = frameRates.IndexOf(FrameRate);

            string vqFallback = VideoQualityFallback ? "?" : string.Empty;
            string frFallback = FrameRateFallback ? "?" : string.Empty;

            StringBuilder sb = new StringBuilder();
            for (int i = vqIndex; i < heights.Count; i++) {

                for (int j = frIndex; j < frameRates.Count; j++) {

                    sb.Append($"bestvideo[height={vqFallback}{heights[i]}][fps={frFallback}{frameRates[j]}]+bestaudio/");

                    if (!IsFrameRatePreferred)
                        break;
                }

                if (!IsVideoQualityPreferred)
                    break;
            }

            // If no video formats are available with the specific resolution/framerate, find the best available.
            sb.Append($"bestvideo[height<={vqFallback}{VideoQuality.Height}][fps<={frFallback}{FrameRate}]+bestaudio/best");
            return sb.ToString();
        }

        public override string ToString() {
            return CreateSelector();
        }

    }
}
