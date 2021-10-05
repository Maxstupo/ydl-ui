namespace Maxstupo.YdlUi.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ByteSizeLib;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.YoutubeDl;

    public sealed class DownloadItemViewModel : ViewModelBase {

        public int Index { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public long Size { get; set; } // bytes

        public long Speed { get; set; } // bytes/sec

        public TimeSpan Eta { get; set; }

        public DownloadStatus Status { get; set; }

        public string DownloadDirectory { get; set; }

        public string ThumbnailUrl { get; set; }


        public DownloadItemViewModel(II18N i18n) : base(i18n) {

        }

        // Designer ctor
        public DownloadItemViewModel() : base() { }



    }

}
