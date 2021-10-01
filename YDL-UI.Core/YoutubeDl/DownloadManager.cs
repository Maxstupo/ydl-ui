namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.YoutubeDl.Binaries;

    public interface IDownloadManager : IArgumentsProvider {

        IDownload CreateDownload(IArgumentsCollection arguments, string downloadDirectory);

    }

    public sealed class DownloadManager : IDownloadManager {
        private readonly IInterpretableBinaryProvider binaryProvider;

        public DownloadManager(IInterpretableBinaryProvider binaryProvider) {
            this.binaryProvider = binaryProvider;
        }

        public IArgumentsCollection CreateArguments(string key) {
            return binaryProvider.CreateArguments(key);
        }

        public IDownload CreateDownload(IArgumentsCollection arguments, string downloadDirectory) {
            IDownload download = new Download(binaryProvider, arguments, downloadDirectory);

            return download;
        }


    }

}
