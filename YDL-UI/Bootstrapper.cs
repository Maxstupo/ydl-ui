namespace Maxstupo.YdlUi {
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.ViewModels.Windows;
    using Stylet;
    using StyletIoC;

    public sealed class Bootstrapper : Bootstrapper<MainWindowViewModel> {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        protected override void OnStart() {
            Logger.Trace("OnStart()");

            // Link stylet logging to NLog logging.
            Stylet.Logging.LogManager.LoggerFactory = name => new NLogLogger(name);
            Stylet.Logging.LogManager.Enabled = true;
        }

        protected override void ConfigureIoC(IStyletIoCBuilder builder) {
            Logger.Trace("ConfigureIoC()");

            builder.Bind<IViewManager>().To<MappingViewManager>();
        }

    }

}