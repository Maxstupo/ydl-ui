namespace Maxstupo.YdlUi.ViewModels.Windows {
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Localization;
    using Stylet;

    public sealed class MainWindowViewModel : ViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindowViewModel(II18N i18n) : base(i18n) {

        }

        // Designer ctor
        public MainWindowViewModel() : base() { }

    }

}