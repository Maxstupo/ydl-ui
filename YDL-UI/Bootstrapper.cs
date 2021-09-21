namespace Maxstupo.YdlUi {
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Threading;
    using System.Xml;
    using Maxstupo.YdlUi.Core.Utility.Extensions;
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

            // Hook unhandle exception event.
            if (!Debugger.IsAttached) {
                AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            } else {
                Logger.Warn("Skipping crash logging initialization! Debugger is attached!");
            }
        }

        protected override void ConfigureIoC(IStyletIoCBuilder builder) {
            Logger.Trace("ConfigureIoC()");

            builder.Bind<IViewManager>().To<MappingViewManager>();
        }


        #region Crash Reporting - Unhandled Exceptions 

        // Called on Application.DispatcherUnhandledException
        protected override void OnUnhandledException(DispatcherUnhandledExceptionEventArgs args) {
            Logger.Fatal(args.Exception, "DispatcherUnhandledException -");
        }

        // TODO: Add crash reporter gui, notify user of crash log + submit to github issue?
        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs args) {
            if (args.ExceptionObject is Exception e) {
                Logger.Fatal(e, "CurrentDomainOnUnhandledException -");
            } else {
                Logger.Fatal("Unhandled Exception!");
            }
        }

        #endregion

    }

}