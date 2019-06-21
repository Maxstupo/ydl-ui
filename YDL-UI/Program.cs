using Maxstupo.YdlUi.Forms;
using Maxstupo.YdlUi.Utility;
using System;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Maxstupo.YdlUi {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            string inputUrl = null;
            bool silent = false;

            // Process command line arguments.
            foreach (string arg in args) {
                /* Valid arguments:
                        /silent
                        +silent
                        /auto
                        +auto
                */
                if (arg.StartsWith("/") || arg.StartsWith("+")) {
                    string option = arg.Substring(1);
                    if (option.Equals("silent", StringComparison.OrdinalIgnoreCase) || option.Equals("auto", StringComparison.OrdinalIgnoreCase))
                        silent = true;

                } else if (inputUrl == null && Util.IsValidUrl(arg)) {
                    inputUrl = arg;
                }
            }

            // Get the application GUID defined in AssemblyInfo.cs
            string guid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();

            // id for global mutex (global to machine)
            string mutexId = string.Format("Global\\{{{0}}}", guid);

            bool createdNew = false;

            MutexAccessRule allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
            MutexSecurity securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Only allow a single instance of YDL-UI to run.
            using (Mutex mutex = new Mutex(false, mutexId, out createdNew, securitySettings)) {
                bool hasHandle = false;
                try {
                    try {
                        hasHandle = mutex.WaitOne(250, false); // Timeout after 250ms.
                        if (!hasHandle) { // Application is already running.

                            if (inputUrl != null) { // A url was provided, send it to the currently running instance of YDL-UI.
                                SendUrl(inputUrl, silent);
                            } else {
                                MessageBox.Show("The application is already running.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            Environment.Exit(0);
                            return;
                        }
                    } catch (AbandonedMutexException) {
                        hasHandle = true; // The mutex was abandoned in another process, it will still get acquired.
                    }

                    // Start application normally.
                    Application.Run(new FormMain(inputUrl, silent));
                } finally {
                    if (hasHandle)
                        mutex.ReleaseMutex();
                }
            }

        }

        // Connect to the currently running YDL-UI process and send the URL provided.
        private static void SendUrl(string url, bool silent = false) {
            try {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", FormMain.PipeName, PipeDirection.Out, PipeOptions.None, TokenImpersonationLevel.Identification)) {
                    pipeClient.Connect(1000);
                    using (StreamWriter sw = new StreamWriter(pipeClient, new UTF8Encoding(false))) {

                        sw.WriteLine($"{(silent ? "1" : "0")} {url}");
                        sw.Flush();
                        pipeClient.WaitForPipeDrain();
                    }
                }
            } catch (Exception) {
                // TODO: Catch exception - Not really important, if it fails we dont add the URL.
            }
        }
    }
}
