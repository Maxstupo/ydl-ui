namespace Maxstupo.YdlUi.Core.Download.Metadata {
    using System;
    using System.Collections.Generic;

    public sealed class VideoResolution : IEquatable<VideoResolution> {

        public int Width { get; }
        public int Height { get; }

        public float AspectRatio => (float) Width / Height;

        public bool IsBest => Width == 0;
        public bool IsWorst => Width == -1;

        public VideoResolution(bool isBestOrWorst) {
            this.Width = this.Height = isBestOrWorst ? 0 : -1;
        }

        public VideoResolution(int width, int height) {
            this.Width = width;
            this.Height = height;
        }

        public override string ToString() {
            if (IsBest)
                return "Best";
            else if (IsWorst)
                return "Worst";

            const float Tar = 16f / 9f;
            const float Tol = 0.02f;

            if (AspectRatio >= Tar - Tol && AspectRatio <= Tar + Tol) // if aspect ratio is nearly 16:9 use the standard 1080P, 720P, etc format.
                return $"{Height}P";

            return $"{Width}x{Height}"; // else output the exact value.
        }

        public override bool Equals(object obj) {
            return Equals(obj as VideoResolution);
        }

        public bool Equals(VideoResolution other) {
            return other != null &&
                   this.Width == other.Width &&
                   this.Height == other.Height;
        }

        public override int GetHashCode() {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(VideoResolution left, VideoResolution right) {
            return EqualityComparer<VideoResolution>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoResolution left, VideoResolution right) {
            return !(left == right);
        }

    }

}
