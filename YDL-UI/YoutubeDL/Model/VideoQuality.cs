namespace Maxstupo.YdlUi.YoutubeDL.Model {

    using System.Collections.Generic;
    using Maxstupo.YdlUi.Utility;

    public class VideoQuality {
        public int Width { get; }
        public int Height { get; }
        public string[] Names { get; }

        public static IReadOnlyList<VideoQuality> StandardQualities { get; } = (new List<VideoQuality>() {
            new VideoQuality(7680, 4320, "8K"),
            new VideoQuality(3840, 2160, "4K"),
            new VideoQuality(2560, 1440),
            new VideoQuality(1920, 1080, "Full HD"),
            new VideoQuality(1280, 720, "HD"),
            new VideoQuality(854, 480),
            new VideoQuality(640, 360),
            new VideoQuality(426, 240),
            new VideoQuality(256, 144),
            new VideoQuality(-1, -1)
        }).AsReadOnly();

        public VideoQuality(int width, int height, params string[] names) {
            this.Width = width;
            this.Height = height;
            this.Names = names;
        }

        public override string ToString() {
            if (Width < 0 && Height < 0)
                return Localization.GetString("download_dialog.quality.vq.custom", "Custom");

            string nicknames = string.Empty;
            if (Names != null && Names.Length > 0) {
                foreach (string name in Names)
                    nicknames += string.Format("({0}){1}", name, Names.Length > 1 ? " " : string.Empty);
            }

            return string.Format("{0}p {1}", Height, nicknames);
        }

    }

}