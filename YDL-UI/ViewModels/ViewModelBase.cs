namespace Maxstupo.YdlUi.ViewModels {
    using System;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Services;
    using Stylet;

    /// <summary>
    /// The base view model used by the majority of view models in YDL-UI. Includes I18N property (exposed to view) for translation with design-time support.
    /// </summary>
    public abstract class ViewModelBase : Screen {

        public static readonly string DesignerLocaleFilepath = "../../ydl-ui_i18n/locales/en/default.en.json";

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public II18N I18N { get; }

        public ViewModelBase(II18N i18N) {
            this.I18N = i18N;
        }

        // Dummy designer ctor
        public ViewModelBase() {
            if (!Execute.InDesignMode)
                throw new Exception("Designer constructor!");
            I18N = new I18NDesigner(DesignerLocaleFilepath);
        }

    }

}