using Maxstupo.YdlUi.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Maxstupo.YdlUi {
    static class Program {

        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Only allow a single instance of YDL-UI to run.
            mutex = new Mutex(true, "YDL-UI_Mutex", out bool createdNew);
            if (createdNew) {
                Application.Run(new FormMain());
            } else {
                MessageBox.Show("The application is already running.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
