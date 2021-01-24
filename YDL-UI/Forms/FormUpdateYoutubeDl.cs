namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Utility;

    public partial class FormUpdateYoutubeDl : Form {
        private string BinaryLocation { get; }

        public FormUpdateYoutubeDl(string binaryLocation) {
            InitializeComponent();
            this.BinaryLocation = binaryLocation;
        }

        private void FormUpdateYoutubeDl_Load(object sender, EventArgs e) {
            btnDone.Enabled = false;
            progressBar.Maximum = 1000;
            progressBar.Minimum = 0;

            Localization.ApplyLocaleText(this);
        }

        private void FormUpdateYoutubeDl_Shown(object sender, EventArgs e) {
            Task.Run((Action) StartDownload);
        }

        private void btnDone_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }


        private void StartDownload() {
            BeginInvoke(((Action) delegate {
                lblStatus.Text = Localization.GetString("update_dialog.status.waiting", "Please wait...");
            }));

            string currentVersion = GetYdlVersion(BinaryLocation);

            WriteLogLine(Localization.GetString("update_dialog.log.current_version", "Current version: {CurrentVersion}").Replace("{CurrentVersion}", currentVersion));

            string checkingText = Localization.GetString("update_dialog.checking", "Checking for updates...");
            BeginInvoke(((Action) delegate {
                lblStatus.Text = checkingText;
            }));

            WriteLogLine(checkingText);

            bool hasErrors = false;

            using (ExecutableProcess ep = new ExecutableProcess(BinaryLocation, "-U")) {
                ep.OnReceived += (s, data) => {
                    if (data == null) return;

                    if (data.IndexOf("ERROR", StringComparison.InvariantCultureIgnoreCase) != -1)
                        hasErrors = true;
                    WriteLogLine(data);
                };
                ep.OnError += (s, data) => WriteLogLine(data);

                ep.Start();
                ep.WaitForExit();
            }

            UpdateCompleted(!hasErrors);

        }

        private static string GetYdlVersion(string binaryLocation) {
            // Get the version of the current youtube-dl binary.
            string currentVersion = string.Empty;
            using (ExecutableProcess process = new ExecutableProcess(binaryLocation, "--version", Path.GetDirectoryName(binaryLocation))) {
                process.OnReceived += (ee, data) => {
                    currentVersion += data;
                };
                process.Start();
                process.WaitForExit();
            }
            return currentVersion.ToLower();
        }

        private void UpdateCompleted(bool success) {
            BeginInvoke((Action) delegate {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Value = 1000;
                lblStatus.Text = success ? Localization.GetString("update_dialog.completed", "Update Completed.") : Localization.GetString("update_dialog.failed", "Update Failed.");
                btnDone.Enabled = true;
            });
        }

        private void WriteLogLine(string data) {
            BeginInvoke((Action) delegate {
                txtUpdateLog.Text += (txtUpdateLog.Text.Length == 0) ? data : $"{Environment.NewLine}{data}";
            });
        }

    }

}