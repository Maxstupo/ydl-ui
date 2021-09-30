namespace Maxstupo.YdlUi.ViewModels.Dialogs {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Maxstupo.YdlUi.Core.Localization;

    public sealed class SettingsDialogViewModel : ViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public SettingsDialogViewModel(II18N i18n) : base(i18n) {

        }

        // Designer ctor
        public SettingsDialogViewModel() : base() { }


    }

}