namespace Maxstupo.YdlUi.ViewModels {
    using System;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Services;
    using Stylet;

    /// <summary>
    /// This implementation includes an I18N property for translations. 
    /// </summary>
    public interface IHasI18N {

        II18N I18N { get; }

    }

    /// <summary>
    /// The base view model used by the majority of view models in YDL-UI. Includes I18N property (exposed to view) for translation with design-time support.
    /// </summary>
    public abstract class ViewModelBase : ValidatingModelBase, IHasI18N {

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

    public abstract class ScreenViewModelBase : Screen, IHasI18N {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public II18N I18N { get; }

        public ScreenViewModelBase(II18N i18N) {
            this.I18N = i18N;
        }

        // Dummy designer ctor
        public ScreenViewModelBase() {
            if (!Execute.InDesignMode)
                throw new Exception("Designer constructor!");
            I18N = new I18NDesigner(ViewModelBase.DesignerLocaleFilepath);
        }

    }

    public abstract class ConductorOneActive<T> : Conductor<T>.Collection.OneActive where T : class, IHasI18N {

        public II18N I18N { get; }

        public ConductorOneActive(II18N i18N) {
            this.I18N = i18N;
        }

        // Dummy designer ctor
        public ConductorOneActive() {
            if (!Execute.InDesignMode)
                throw new Exception("Designer constructor!");
            I18N = new I18NDesigner(ViewModelBase.DesignerLocaleFilepath);
        }

    }

}