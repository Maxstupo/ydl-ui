using Maxstupo.YdlUi.Forms;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Maxstupo.YdlUi {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
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
                        hasHandle = mutex.WaitOne(2000, false); // Wait for 2 seconds.
                        if (!hasHandle) {
                            MessageBox.Show("The application is already running.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Environment.Exit(0);
                        }
                    } catch (AbandonedMutexException) {
                        hasHandle = true; // The mutex was abandond in another process, it will still get acquired.
                    }


                    Application.Run(new FormMain());

                } finally {
                    if (hasHandle)
                        mutex.ReleaseMutex();
                }
            }

        }
    }
}
