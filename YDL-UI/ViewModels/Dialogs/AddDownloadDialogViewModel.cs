namespace Maxstupo.YdlUi.ViewModels.Dialogs {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Localization;

    public sealed class AddDownloadDialogViewModel : ViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public AddDownloadDialogViewModel(II18N i18n) : base(i18n) {

        }

        // Designer ctor
        public AddDownloadDialogViewModel() : base() { }


    }

}