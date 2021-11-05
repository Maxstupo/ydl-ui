namespace Maxstupo.YdlUi.Core.Download.Metadata {
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents an implementation that can provide metadata about a video or playlist.
    /// </summary>
    public interface IMetadata {

        /// <summary>The URL to the video.</summary>
        string Url { get; }

        /// <summary>The title of the video.</summary>
        string Title { get; }

        /// <summary>The URL to the thumbnail image of the video.</summary>
        string ThumbnailUrl { get; }

        /// <summary>The duration of the video.</summary>
        TimeSpan Duration { get; }

        // long Views { get; }

        // int Likes { get; }

        // int Dislikes { get; }

        // float Rating { get; }

        // string Description { get; }

        // string Uploader { get; }

        // string Extractor { get; }

        /// <summary>
        /// Returns a list of valid video resolutions for the download this metadata instance represents, and for the specific download mode provided.
        /// </summary>
        List<VideoResolution> GetResolutions(DownloadStream mode);

        /// <summary>
        /// Returns a list of valid video framerates for the download this metadata instance represents, and for the specific download mode and resolution.
        /// </summary>
        List<int> GetFramerates(DownloadStream mode, VideoResolution resolution);

    }

}
