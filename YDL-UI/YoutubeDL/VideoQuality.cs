using System;
using System.Collections;
using System.Collections.Generic;

namespace Maxstupo.YdlUi.YoutubeDL {
    public struct VideoQuality {
        private static readonly string LESS_THAN = "<";
        private static readonly string IF_EXISTS = "?";

        public int Width { get; }
        public int Height { get; }
        public int Fps { get; }

        public bool ResPreferred { get; }
        public bool ResFallback { get; }
        public bool FpsPreferred { get; }
        public bool FpsFallback { get; }

        public string FormatSelector {
            get {
                string resP = ResPreferred ? LESS_THAN : string.Empty;
                string fpsP = FpsPreferred ? LESS_THAN : string.Empty;
                string resF = ResFallback ? IF_EXISTS : string.Empty;
                string fpsF = FpsFallback ? IF_EXISTS : string.Empty;

                return string.Format("bestvideo[width{3}={5}{0}][height{3}={5}{1}][fps{4}={6}{2}]+bestaudio/best[width{3}={5}{0}][height{3}={5}{1}][fps{4}={6}{2}]", Width, Height, Fps, resP, fpsP, resF, fpsF);
            }
        }

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
