namespace Maxstupo.YdlUi.ViewModels.Windows {
    using System.Threading.Tasks;
    using Stylet;

    public sealed class MainWindowViewModel : Screen {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindowViewModel() {
            DisplayName = "YDL-UI";
        }

    }

}