namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Utility.Exec;
    using Maxstupo.YdlUi.Core.YoutubeDl.Arguments;

    public interface IDownloadManager {

        IDownload CreateDownload(YdlArguments arguments, string downloadDirectory);

    }

    public sealed class DownloadManager : IDownloadManager, IExecutableProcessProvider {
        private readonly IArgumentSerializer serializer;

        public DownloadManager(IArgumentSerializer serializer) {
            this.serializer = serializer;
        }

        public IDownload CreateDownload(YdlArguments arguments, string downloadDirectory) {
            IDownload download = new Download(null, arguments, downloadDirectory);

            return download;
        }

        public IExecutableProcess CreateExecutableProcess(object arguments, string workingDirectory) {
            string args = serializer.Serialize(arguments);
            return new ExecutableProcess("", args, workingDirectory);
        }

    }

}
