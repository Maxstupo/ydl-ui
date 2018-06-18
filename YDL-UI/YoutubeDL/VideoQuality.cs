using System;
using System.Collections;
using System.Collections.Generic;

namespace Maxstupo.YdlUi.YoutubeDL {
    [Serializable]
    public class VideoQuality {
        private static readonly string LESS_THAN = "<";
        private static readonly string IF_EXISTS = "?";

        public int Width { get; set; }
        public int Height { get; set; }
        public int Fps { get; set; }

        public bool ResPreferred { get; set; }
        public bool ResFallback { get; set; }
        public bool FpsPreferred { get; set; }
        public bool FpsFallback { get; set; }

        public string FormatSelector {
            get {
                string resP = ResPreferred ? LESS_THAN : string.Empty;
                string fpsP = FpsPreferred ? LESS_THAN : string.Empty;
                string resF = ResFallback ? IF_EXISTS : string.Empty;
                string fpsF = FpsFallback ? IF_EXISTS : string.Empty;

                return string.Format("bestvideo[width{3}={5}{0}][height{3}={5}{1}][fps{4}={6}{2}]+bestaudio/best[width{3}={5}{0}][height{3}={5}{1}][fps{4}={6}{2}]", Width, Height, Fps, resP, fpsP, resF, fpsF);
            }
        }

        public VideoQuality() : this(0, 0, 0, true, true, true, true) { }

        public VideoQuality(int width, int height, int fps, bool resPreferred, bool resFallback, bool fpsPreferred, bool fpsFallback) {
            this.Width = width;
            this.Height = height;
            this.Fps = fps;
            this.ResPreferred = resPreferred;
            this.ResFallback = resFallback;
            this.FpsPreferred = fpsPreferred;
            this.FpsFallback = fpsFallback;
        }
    }
}
