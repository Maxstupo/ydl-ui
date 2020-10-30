using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
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
            Task.Run((Action)StartDownload);
        }

        private void btnDone_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }


        private async void StartDownload() {

            string currentVersion = GetYdlVersion(BinaryLocation);

            WriteLogLine(Localization.GetString("update_dialog.log.current_version", "Current version: {CurrentVersion}").Replace("{CurrentVersion}", currentVersion));
            WriteLogLine(Localization.GetString("update_dialog.log.check", "Finding latest release..."));

            // Make HTTP Get request from api.github.com to find the latest version of youtube-dl available.
            string userAgent = $"YDL-UI v{Application.ProductVersion}";
            JObject json;
            try {
                string data = await NetUtil.HttpGetAsync(FormMain.YoutubeDlLatest, userAgent);
                json = JObject.Parse(data);
            } catch (Exception) {
                WriteLogLine(Localization.GetString("update_dialog.log.check.failed", "Failed to find latest release!"));
                UpdateCompleted(false);
                return;
            }

            string latestVersion = json["tag_name"].Value<string>().ToLower();
            WriteLogLine(Localization.GetString("update_dialog.log.check.found", "Found {Version}").Replace("{Version}", latestVersion));

            // Compare versions.
            if (latestVersion.Equals(currentVersion, StringComparison.OrdinalIgnoreCase)) {
                WriteLogLine(Localization.GetString("update_dialog.log.check.no_new_versions", "youtube-dl is up-to-date ({CurrentVersion})").Replace("{CurrentVersion}", currentVersion));
                UpdateCompleted(true);

            } else { // Begin Update

                string latestBinaryDownloadUrl = null;
                long downloadSize = 1;

                bool is64BitOS = Environment.Is64BitOperatingSystem;

                // Find youtube-dl binary from the list of assets.
                foreach (var asset in json["assets"]) {
                    string name = asset["name"].Value<string>();

                    if (!name.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || !name.StartsWith("youtube-dl", StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (!is64BitOS && name.IndexOf("x86", StringComparison.OrdinalIgnoreCase) < 0)
                        continue;


                    latestBinaryDownloadUrl = asset["browser_download_url"].Value<string>();
                    downloadSize = asset["size"].Value<long>();
                    break;
                }

                // Unable to find youtube-dl binary download URL from latest release assets.
                if (latestBinaryDownloadUrl == null) {
                    WriteLogLine(Localization.GetString("update_dialog.log.download.failed.missing", "Download failed! Latest release is missing download link!"));
                    UpdateCompleted(false);

                } else {

                    WriteLogLine(Localization.GetString("update_dialog.log.download.start", "Downloading: {DownloadUrl}").Replace("{DownloadUrl}", latestBinaryDownloadUrl));

                    BeginInvoke((Action)delegate {
                        progressBar.Style = ProgressBarStyle.Continuous;
                        lblStatus.Text = Localization.GetString("update_dialog.status.downloading", "Downloading...");
                    });

                    // Begin downloading file.
                    try {
                        NetUtil.HttpGetFileDownload(latestBinaryDownloadUrl, BinaryLocation, downloadSize, userAgent, (progress) => {
                            BeginInvoke((Action<int>)((val) => {
                                progressBar.Value = val;
                            }), (int)(progress * 1000));
                        });
                    } catch (Exception) {
                        WriteLogLine(Localization.GetString("update_dialog.log.download.failed", "Download failed!"));
                        UpdateCompleted(false);
                        return;
                    }

                    BeginInvoke((Action)delegate {
                        progressBar.Style = ProgressBarStyle.Marquee;
                        lblStatus.Text = Localization.GetString("update_dialog.status.waiting", "Please wait...");
                    });

                    WriteLogLine(Localization.GetString("update_dialog.log.download.complete", "Download complete.\r\nVerifying download..."));

                    // Display the new downloaded version of youtube-dl.
                    string newCurrentVersion = GetYdlVersion(BinaryLocation);

                    WriteLogLine(Localization.GetString("update_dialog.log.new_version", "New version: {NewVersion}\r\nUpdate complete!").Replace("{NewVersion}", newCurrentVersion));
                    UpdateCompleted(true);
                }

            }

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
            BeginInvoke((Action)delegate {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Value = 1000;
                lblStatus.Text = success ? Localization.GetString("update_dialog.completed", "Update Completed.") : Localization.GetString("update_dialog.failed", "Update Failed.");
                btnDone.Enabled = true;
            });
        }

        private void WriteLogLine(string data) {
            BeginInvoke((Action)delegate {
                txtUpdateLog.Text += (txtUpdateLog.Text.Length == 0) ? data : $"{Environment.NewLine}{data}";
            });
        }

    }
}
