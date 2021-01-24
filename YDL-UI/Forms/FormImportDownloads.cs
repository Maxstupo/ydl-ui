namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;
    using Maxstupo.YdlUi.YoutubeDL;
    using Newtonsoft.Json;

    public partial class FormImportDownloads : Form {

        private Preferences prefs;
        private readonly DownloadManager downloadManager;

        private Action<Download> callback;

        private readonly int totalUrls;
        private readonly List<string> urlsToAdd;

        private bool AllowPresets => cbAllowPresets.Checked;
        private bool SeparateOptions => cbSeparateOptions.Checked;


        public FormImportDownloads(string filepath, bool isJson, Preferences prefs, DownloadManager downloadManager, Func<string, bool> containedInDownloadList, Action<Download> callback) {
            InitializeComponent();
            this.prefs = prefs;
            this.downloadManager = downloadManager;
            this.callback = callback;

            try {
                List<string> urls = isJson ?
                JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(filepath, new UTF8Encoding(false)))
                :
                File.ReadAllLines(filepath, new UTF8Encoding(false)).ToList();


                totalUrls = urls.Count;
                urlsToAdd = urls.Where(url => !containedInDownloadList(url) && Util.IsValidUrl(url)).ToList();
            } catch (Exception) {
                totalUrls = 0;
                urlsToAdd = new List<string>();
            }
        }



        private void FormImportDownloads_Load(object sender, EventArgs e) {
            Localization.ApplyLocaleText(this, toolTip1);

            int duplicateUrlCount = totalUrls - urlsToAdd.Count;
            lblTotal.Text = lblTotal.Text.Replace("{UrlCount}", totalUrls.ToString()).Replace("{DuplicateCount}", duplicateUrlCount.ToString());
            lblTotalDupes.Text = lblTotalDupes.Text.Replace("{UrlCount}", totalUrls.ToString()).Replace("{DuplicateCount}", duplicateUrlCount.ToString());
        }


        private void btnGo_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.None;


            if (SeparateOptions) {
                foreach (string url in urlsToAdd) {

                    bool isSilent = AllowPresets && Preset.HasValidPreset(prefs.Presets, url);

                    using (FormAddDownload dialog = new FormAddDownload(prefs, downloadManager, url, null, false, isSilent)) {
                        if (dialog.ShowDialog(this) == DialogResult.OK)
                            callback(dialog.Download);
                    }
                }

                DialogResult = DialogResult.OK;

            } else if (urlsToAdd.Count > 0) {

                using (FormAddDownload dialog = new FormAddDownload(prefs, downloadManager, "sharedsettings.", null, false, false)) {
                    if (dialog.ShowDialog(this) == DialogResult.OK) {

                        foreach (string url in urlsToAdd) {
                            bool isSilent = AllowPresets && Preset.HasValidPreset(prefs.Presets, url);

                            if (isSilent) { // Auto add
                                using (FormAddDownload dialog2 = new FormAddDownload(prefs, downloadManager, url, null, false, true)) {
                                    if (dialog2.ShowDialog(this) == DialogResult.OK)
                                        callback(dialog2.Download);
                                }
                            } else {
                                Download download = dialog.CreateDownload(url);
                                callback(download);
                            }

                        }

                        DialogResult = DialogResult.OK;

                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

    }

}