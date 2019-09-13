using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms.Tab {
    public partial class TabWorkarounds : UserControl {

        public TabWorkarounds() {
            InitializeComponent();
        }

        private void TabWorkarounds_Load(object sender, EventArgs e) {
            cbxLimitRateUnit.DataSource = Enum.GetValues(typeof(FilesizeUnit));

            GuiUtil.MakeRangeNumericUpDown(nudSleepIntervalMin, nudSleepIntervalMax);

            txtReferer.BindEnabledTo(cbReferer);
            txtUserAgent.BindEnabledTo(cbUserAgent);

            txtCookies.BindEnabledTo(cbCookies);
            btnBrowseCookies.BindEnabledTo(cbCookies);

            // Network
            txtProxy.BindEnabledTo(cbProxy);
            txtSourceAddress.BindEnabledTo(cbSourceAddress);
            nudSocketTimeout.BindEnabledTo(cbSocketTimeout);

            // Download
            nudLimitRate.BindEnabledTo(cbLimitRate);
            cbxLimitRateUnit.BindEnabledTo(cbLimitRate);

            nudRetries.BindEnabledTo(cbRetries);
            cbRetriesInf.BindEnabledTo(cbRetries);
            cbRetriesInf.CheckedChanged += delegate {
                nudRetries.Value = nudRetries.Minimum = cbRetriesInf.Checked ? -1 : 0;
                nudRetries.Maximum = cbRetriesInf.Checked ? -1 : 200;
            };

            nudFragmentRetries.BindEnabledTo(cbFragmentRetries);
            cbFragmentRetriesInf.BindEnabledTo(cbFragmentRetries);
            cbFragmentRetriesInf.CheckedChanged += delegate {
                nudFragmentRetries.Value = nudFragmentRetries.Minimum = cbFragmentRetriesInf.Checked ? -1 : 0;
                nudFragmentRetries.Maximum = cbFragmentRetriesInf.Checked ? -1 : 200;
            };

            // Auth
            txtUsername.BindEnabledTo(cbUsername);
            txtPassword.BindEnabledTo(cbUsername);

            txtTwoFactorCode.BindEnabledTo(cbTwoFactorCode);
            txtVideoPassword.BindEnabledTo(cbVideoPassword);

            // Sleep Interval
            nudSleepInterval.BindEnabledTo(rbSleepIntervalValue);
            nudSleepIntervalMin.BindEnabledTo(rbSleepIntervalRange);
            nudSleepIntervalMax.BindEnabledTo(rbSleepIntervalRange);
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;


            arguments.Workarounds.Referer = txtReferer.GetText();
            arguments.Workarounds.UserAgent = txtUserAgent.GetText();
            arguments.FileSystem.Cookies = txtCookies.GetText();

            // Network
            arguments.Network.Proxy = txtProxy.GetText();
            arguments.Network.SocketTimeout = (int?)nudSocketTimeout.GetValue();
            arguments.Network.SourceAddress = txtSourceAddress.GetText();
            arguments.Network.ForceIpv4 = rbForceIp4.Checked;
            arguments.Network.ForceIpv6 = rbForceIp6.Checked;

            // Download
            arguments.Download.LimitRate = nudLimitRate.GetUnitValue(cbxLimitRateUnit);

            int? retries = (int?)nudRetries.GetValue();
            int? fragRetries = (int?)nudFragmentRetries.GetValue();
            arguments.Download.Retries = retries == null ? null : (retries >= 0 ? retries.ToString() : "infinite");
            arguments.Download.FragmentRetries = fragRetries == null ? null : (fragRetries >= 0 ? fragRetries.ToString() : "infinite");

            // Sleep interval
            arguments.Workarounds.SleepInterval = (int?)nudSleepInterval.GetValue();

            if (rbSleepIntervalRange.Checked) {
                arguments.Workarounds.MinSleepInterval = (int?)nudSleepIntervalMin.GetValue();
                arguments.Workarounds.MaxSleepInterval = (int?)nudSleepIntervalMax.GetValue();
            } else {
                arguments.Workarounds.MaxSleepInterval = null;
            }

            // Auth
            arguments.Authentication.Username = txtUsername.GetText();
            arguments.Authentication.Password = txtPassword.GetText();
            arguments.Authentication.TwoFactor = txtTwoFactorCode.GetText();
            arguments.Authentication.VideoPassword = txtVideoPassword.GetText();

            // Headers
            arguments.Workarounds.Headers.Clear();
            foreach (DataGridViewRow row in dgvHeaders.Rows) {
                if (row.IsNewRow)
                    continue;

                string key = (string)row.Cells["colKey"].Value;
                string value = (string)row.Cells["colValue"].Value;

                if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
                    continue;


                if (!arguments.Workarounds.Headers.ContainsKey(key))
                    arguments.Workarounds.Headers.Add(key, value);
            }
        }

        private void btnBrowseCookies_Click(object sender, EventArgs e) {
            string filepath = GuiUtil.SelectFile(this, "Select cookies file...", "Text Files (*.txt)|*.txt|All Files (*.*)|*.*", txtCookies.Text, false);
            if (filepath != null)
                txtCookies.Text = filepath;
        }
    }
}
