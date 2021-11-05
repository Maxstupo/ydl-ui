namespace Maxstupo.YdlUi.ViewModels.Dialogs {
    using System;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.Options;

    public sealed class SettingsDialogViewModel : ScreenViewModelBase {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Language Language {
            get => I18N.Language;
            set {
                Logger.Info(value.VariantName);

                I18N.Language = value;

                settings.Value.Locale = value.Locale;
                settings.Value.LocaleVariant = value.VariantName;

                NotifyOfPropertyChange(nameof(I18N));
            }
        }

        private readonly ISettingsManager settingsManager;
        private readonly ISettings<AppSettings> settings;

        private bool loadOnClose;

        public SettingsDialogViewModel(II18N i18n, ISettingsManager settingsManager, ISettings<AppSettings> settings) : base(i18n) {
            this.settingsManager = settingsManager;
            this.settings = settings;
        }

        // Designer ctor
        public SettingsDialogViewModel() : base() { }

        private void SettingsManager_OnSettingsChanged(object sender, EventArgs e) {
            I18N.Locale = Language?.Locale ?? I18N.Locale;
            NotifyOfPropertyChange(null);
        }

        protected override void OnActivate() {
            loadOnClose = true;

            settingsManager.OnChanged += SettingsManager_OnSettingsChanged;
            NotifyOfPropertyChange(null);
        }

        protected override void OnDeactivate() {
            settingsManager.OnChanged -= SettingsManager_OnSettingsChanged;
        }

        protected override void OnClose() {
            base.OnClose();
            if (loadOnClose)
                settingsManager.Load();
        }

        public void Confirm() {
            loadOnClose = false;
            settingsManager.Save();
            RequestClose(true);
        }

        public void Cancel() {
            loadOnClose = false;
            settingsManager.Load();
            RequestClose(false);
        }

        public void Reset() {
            // TODO: Implement settings reset button.
            settingsManager.Reset();
            settingsManager.Load();

        }

    }

}