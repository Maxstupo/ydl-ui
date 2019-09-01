using Maxstupo.YdlUi.Settings;
using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {
    public partial class FormImportDownloads : Form {

        private Preferences prefs;
        private Action<Download> callback;

        private readonly int totalUrls;
        private readonly List<string> urlsToAdd;

        private bool AllowPresets => cbAllowPresets.Checked;
        private bool SeparateOptions => cbSeparateOptions.Checked;


        public FormImportDownloads(string filepath, bool isJson, Preferences prefs, Func<string, bool> containedInDownloadList, Action<Download> callback) {
            InitializeComponent();
            this.prefs = prefs;
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
            lblTotal.Text = lblTotal.Text.Replace("{0}", totalUrls.ToString());
            lblTotalDupes.Text = lblTotalDupes.Text.Replace("{0}", (totalUrls - urlsToAdd.Count).ToString());
        }


        private void btnGo_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.None;


            if (SeparateOptions) {
                foreach (string url in urlsToAdd) {

                    bool isSilent = AllowPresets && Preset.HasValidPreset(prefs.Presets, url);

                    using (FormAddDownload dialog = new FormAddDownload(prefs, url, null, false, isSilent)) {
                        if (dialog.ShowDialog(this) == DialogResult.OK)
                            callback(dialog.Download);
                    }
                }

                DialogResult = DialogResult.OK;

            } else if (urlsToAdd.Count > 0) {

                using (FormAddDownload dialog = new FormAddDownload(prefs, "sharedsettings.", null, false, false)) {
                    if (dialog.ShowDialog(this) == DialogResult.OK) {

                        foreach (string url in urlsToAdd) {
                            bool isSilent = AllowPresets && Preset.HasValidPreset(prefs.Presets, url);

                            if (isSilent) { // Auto add
                                using (FormAddDownload dialog2 = new FormAddDownload(prefs, url, null, false, true)) {
                                    if (dialog2.ShowDialog(this) == DialogResult.OK)
                                        callback(dialog.Download);
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
