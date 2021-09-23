namespace Maxstupo.YdlUi {
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Abstractions;
    using System.Reflection;
    using System.Windows.Threading;
    using System.Xml;
    using Maxstupo.YdlUi.Core.Arguments;
    using Maxstupo.YdlUi.Core.Localization;
    using Maxstupo.YdlUi.Core.Localization.Providers;
    using Maxstupo.YdlUi.Core.Localization.Readers;
    using Maxstupo.YdlUi.Core.Utility.Extensions;
    using Maxstupo.YdlUi.Services;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.ViewModels.Windows;
    using NLog.Config;
    using Stylet;
    using StyletIoC;

    public sealed class Bootstrapper : Bootstrapper<MainWindowViewModel> {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        protected override void OnStart() {
            // NLog didn't find a config file, so load the embedded one.
            if (NLog.LogManager.Configuration == null) {
                using (Stream configFileStream = Assembly.GetExecutingAssembly().GetEmbeddedResourceStream("NLog.config")) {
                    using (XmlReader xmlReader = XmlReader.Create(configFileStream))
                        NLog.LogManager.Configuration = new XmlLoggingConfiguration(xmlReader, null);
                }
            }

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

            builder.Bind<IFileFolderDialog>().To<NativeFileFolderDialog>().InSingletonScope();

            // bind file system
            IFileSystem fileSystem = new FileSystem();
            builder.Bind<IFileSystem>().ToInstance(fileSystem);
            builder.Bind<IDirectory>().ToInstance(fileSystem.Directory);
            builder.Bind<IFile>().ToInstance(fileSystem.File);
            builder.Bind<IPath>().ToInstance(fileSystem.Path);

            // bind i18n
            builder.Bind<II18N>().And<II18NSource>().To<I18N>().InSingletonScope();

            builder.Bind<ICommandLineSerializer>().To<YdlArgumentSerializer>().InSingletonScope();
        }

        protected override void Configure() {
            Logger.Trace("Configure()");

            IFileSystem fileSystem = Container.Get<IFileSystem>();

            // init i18n
            II18NSource i18n = Container.Get<II18NSource>();

            FileSystemProvider provider = new FileSystemProvider(fileSystem, "default");
            provider.AddDirectory("locales");
            i18n.RegisterProvider(provider);

            i18n.RegisterReader(new JsonTreeReader(), ".json");
            i18n.RegisterReader(new JsonKvpReader(), ".jkvp");

            i18n.Init();
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