namespace Maxstupo.YdlUi.ViewModels.Windows {
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.ViewModels.Dialogs;
    using Stylet;

    public sealed class MainWindowViewModel : ViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IWindowManager windowManager;

        private readonly SettingsDialogViewModel settingsDialogViewModel;
        private readonly AddDownloadDialogViewModel addDownloadDialog;

        public MainWindowViewModel(II18N i18n, IWindowManager windowManager, 

            SettingsDialogViewModel settingsDialogViewModel,
            AddDownloadDialogViewModel addDownloadDialog

        ) : base(i18n) {
            this.windowManager = windowManager;
            this.settingsDialogViewModel = settingsDialogViewModel;
            this.addDownloadDialog = addDownloadDialog;
        }

        // Designer ctor
        public MainWindowViewModel() : base() { }


        public void ShowSettingsDialog() {
            windowManager.ShowDialog(settingsDialogViewModel, this);
        }
        public void ShowAddDownloadDialog() {
            windowManager.ShowDialog(addDownloadDialog, this);
        }


    }

}