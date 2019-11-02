namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabWorkarounds {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.gbDownload = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbLimitRate = new System.Windows.Forms.CheckBox();
            this.nudFragmentRetries = new System.Windows.Forms.NumericUpDown();
            this.cbFragmentRetriesInf = new System.Windows.Forms.CheckBox();
            this.cbRetriesInf = new System.Windows.Forms.CheckBox();
            this.cbxLimitRateUnit = new System.Windows.Forms.ComboBox();
            this.cbFragmentRetries = new System.Windows.Forms.CheckBox();
            this.nudLimitRate = new System.Windows.Forms.NumericUpDown();
            this.cbRetries = new System.Windows.Forms.CheckBox();
            this.nudRetries = new System.Windows.Forms.NumericUpDown();
            this.gbAuthentication = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbUsername = new System.Windows.Forms.CheckBox();
            this.txtTwoFactorCode = new System.Windows.Forms.TextBox();
            this.txtVideoPassword = new System.Windows.Forms.TextBox();
            this.cbVideoPassword = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbTwoFactorCode = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gbHeaders = new System.Windows.Forms.GroupBox();
            this.dgvHeaders = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSleepInterval = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSleepIntervalDefault = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudSleepIntervalMin = new System.Windows.Forms.NumericUpDown();
            this.lblSleepIntervalRangeSeperator = new System.Windows.Forms.Label();
            this.nudSleepIntervalMax = new System.Windows.Forms.NumericUpDown();
            this.rbSleepIntervalValue = new System.Windows.Forms.RadioButton();
            this.nudSleepInterval = new System.Windows.Forms.NumericUpDown();
            this.rbSleepIntervalRange = new System.Windows.Forms.RadioButton();
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.rbAnyIp = new System.Windows.Forms.RadioButton();
            this.rbForceIp4 = new System.Windows.Forms.RadioButton();
            this.rbForceIp6 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbProxy = new System.Windows.Forms.CheckBox();
            this.cbSocketTimeout = new System.Windows.Forms.CheckBox();
            this.cbSourceAddress = new System.Windows.Forms.CheckBox();
            this.txtSourceAddress = new System.Windows.Forms.TextBox();
            this.nudSocketTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.cbUserAgent = new System.Windows.Forms.CheckBox();
            this.txtReferer = new System.Windows.Forms.TextBox();
            this.cbReferer = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtCookies = new System.Windows.Forms.TextBox();
            this.cbCookies = new System.Windows.Forms.CheckBox();
            this.btnBrowseCookies = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp.SuspendLayout();
            this.gbDownload.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).BeginInit();
            this.gbAuthentication.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
            this.gbSleepInterval.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepInterval)).BeginInit();
            this.gbNetwork.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlp.Controls.Add(this.gbDownload, 1, 0);
            this.tlp.Controls.Add(this.gbAuthentication, 0, 1);
            this.tlp.Controls.Add(this.gbHeaders, 2, 0);
            this.tlp.Controls.Add(this.gbSleepInterval, 1, 1);
            this.tlp.Controls.Add(this.gbNetwork, 0, 0);
            this.tlp.Location = new System.Drawing.Point(3, 85);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.Size = new System.Drawing.Size(778, 285);
            this.tlp.TabIndex = 1;
            this.tlp.Tag = "#";
            // 
            // gbDownload
            // 
            this.gbDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDownload.Controls.Add(this.tableLayoutPanel5);
            this.gbDownload.Location = new System.Drawing.Point(290, 3);
            this.gbDownload.Name = "gbDownload";
            this.gbDownload.Size = new System.Drawing.Size(281, 136);
            this.gbDownload.TabIndex = 2;
            this.gbDownload.TabStop = false;
            this.gbDownload.Tag = "download";
            this.gbDownload.Text = "Download";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.cbLimitRate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.nudFragmentRetries, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbFragmentRetriesInf, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbRetriesInf, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbxLimitRateUnit, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbFragmentRetries, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.nudLimitRate, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbRetries, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.nudRetries, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(275, 85);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Tag = "#$";
            // 
            // cbLimitRate
            // 
            this.cbLimitRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbLimitRate.AutoSize = true;
            this.cbLimitRate.Location = new System.Drawing.Point(3, 5);
            this.cbLimitRate.Name = "cbLimitRate";
            this.cbLimitRate.Size = new System.Drawing.Size(79, 17);
            this.cbLimitRate.TabIndex = 0;
            this.cbLimitRate.Tag = "limit_rate";
            this.cbLimitRate.Text = "Limit Rate:";
            this.toolTip.SetToolTip(this.cbLimitRate, "Maximum download rate per second.");
            this.cbLimitRate.UseVisualStyleBackColor = true;
            // 
            // nudFragmentRetries
            // 
            this.nudFragmentRetries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFragmentRetries.Location = new System.Drawing.Point(125, 59);
            this.nudFragmentRetries.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFragmentRetries.Name = "nudFragmentRetries";
            this.nudFragmentRetries.Size = new System.Drawing.Size(78, 22);
            this.nudFragmentRetries.TabIndex = 7;
            this.nudFragmentRetries.Tag = "frag_retries.value";
            this.toolTip.SetToolTip(this.nudFragmentRetries, "Number of retries for a fragment (default is 10) (DASH, hlsnative and ISM)");
            // 
            // cbFragmentRetriesInf
            // 
            this.cbFragmentRetriesInf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFragmentRetriesInf.AutoSize = true;
            this.cbFragmentRetriesInf.Location = new System.Drawing.Point(209, 62);
            this.cbFragmentRetriesInf.Name = "cbFragmentRetriesInf";
            this.cbFragmentRetriesInf.Size = new System.Drawing.Size(63, 17);
            this.cbFragmentRetriesInf.TabIndex = 8;
            this.cbFragmentRetriesInf.Tag = "infinite";
            this.cbFragmentRetriesInf.Text = "Infinite";
            this.toolTip.SetToolTip(this.cbFragmentRetriesInf, "Infinite fragment retries.");
            this.cbFragmentRetriesInf.UseVisualStyleBackColor = true;
            // 
            // cbRetriesInf
            // 
            this.cbRetriesInf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRetriesInf.AutoSize = true;
            this.cbRetriesInf.Location = new System.Drawing.Point(209, 33);
            this.cbRetriesInf.Name = "cbRetriesInf";
            this.cbRetriesInf.Size = new System.Drawing.Size(63, 17);
            this.cbRetriesInf.TabIndex = 5;
            this.cbRetriesInf.Tag = "infinite";
            this.cbRetriesInf.Text = "Infinite";
            this.toolTip.SetToolTip(this.cbRetriesInf, "Infinite retries.");
            this.cbRetriesInf.UseVisualStyleBackColor = true;
            // 
            // cbxLimitRateUnit
            // 
            this.cbxLimitRateUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxLimitRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLimitRateUnit.FormattingEnabled = true;
            this.cbxLimitRateUnit.Location = new System.Drawing.Point(209, 3);
            this.cbxLimitRateUnit.Name = "cbxLimitRateUnit";
            this.cbxLimitRateUnit.Size = new System.Drawing.Size(62, 21);
            this.cbxLimitRateUnit.TabIndex = 2;
            // 
            // cbFragmentRetries
            // 
            this.cbFragmentRetries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFragmentRetries.AutoSize = true;
            this.cbFragmentRetries.Location = new System.Drawing.Point(3, 62);
            this.cbFragmentRetries.Name = "cbFragmentRetries";
            this.cbFragmentRetries.Size = new System.Drawing.Size(116, 17);
            this.cbFragmentRetries.TabIndex = 6;
            this.cbFragmentRetries.Tag = "frag_retries";
            this.cbFragmentRetries.Text = "Fragment Retries:";
            this.toolTip.SetToolTip(this.cbFragmentRetries, "Number of retries for a fragment (default is 10) (DASH, hlsnative and ISM)");
            this.cbFragmentRetries.UseVisualStyleBackColor = true;
            // 
            // nudLimitRate
            // 
            this.nudLimitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLimitRate.DecimalPlaces = 1;
            this.nudLimitRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLimitRate.Location = new System.Drawing.Point(125, 3);
            this.nudLimitRate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLimitRate.Name = "nudLimitRate";
            this.nudLimitRate.Size = new System.Drawing.Size(78, 22);
            this.nudLimitRate.TabIndex = 1;
            this.nudLimitRate.Tag = "limit_rate.value";
            this.toolTip.SetToolTip(this.nudLimitRate, "Maximum download rate per second.");
            // 
            // cbRetries
            // 
            this.cbRetries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRetries.AutoSize = true;
            this.cbRetries.Location = new System.Drawing.Point(3, 33);
            this.cbRetries.Name = "cbRetries";
            this.cbRetries.Size = new System.Drawing.Size(64, 17);
            this.cbRetries.TabIndex = 3;
            this.cbRetries.Tag = "retries";
            this.cbRetries.Text = "Retries:";
            this.toolTip.SetToolTip(this.cbRetries, "Number of retries (default is 10).");
            this.cbRetries.UseVisualStyleBackColor = true;
            // 
            // nudRetries
            // 
            this.nudRetries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRetries.Location = new System.Drawing.Point(125, 31);
            this.nudRetries.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudRetries.Name = "nudRetries";
            this.nudRetries.Size = new System.Drawing.Size(78, 22);
            this.nudRetries.TabIndex = 4;
            this.nudRetries.Tag = "retries.value";
            this.toolTip.SetToolTip(this.nudRetries, "Number of retries (default is 10).");
            // 
            // gbAuthentication
            // 
            this.gbAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAuthentication.Controls.Add(this.tableLayoutPanel3);
            this.gbAuthentication.Location = new System.Drawing.Point(3, 145);
            this.gbAuthentication.MinimumSize = new System.Drawing.Size(218, 134);
            this.gbAuthentication.Name = "gbAuthentication";
            this.gbAuthentication.Size = new System.Drawing.Size(281, 136);
            this.gbAuthentication.TabIndex = 1;
            this.gbAuthentication.TabStop = false;
            this.gbAuthentication.Tag = "authentication";
            this.gbAuthentication.Text = "Authentication";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cbUsername, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTwoFactorCode, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtVideoPassword, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbVideoPassword, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblPassword, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbTwoFactorCode, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(275, 113);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Tag = "#$";
            // 
            // cbUsername
            // 
            this.cbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUsername.AutoSize = true;
            this.cbUsername.Location = new System.Drawing.Point(3, 5);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(80, 17);
            this.cbUsername.TabIndex = 0;
            this.cbUsername.Tag = "username";
            this.cbUsername.Text = "Username:";
            this.toolTip.SetToolTip(this.cbUsername, "Login with this account ID.");
            this.cbUsername.UseVisualStyleBackColor = true;
            // 
            // txtTwoFactorCode
            // 
            this.txtTwoFactorCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTwoFactorCode.Location = new System.Drawing.Point(123, 59);
            this.txtTwoFactorCode.Name = "txtTwoFactorCode";
            this.txtTwoFactorCode.Size = new System.Drawing.Size(149, 22);
            this.txtTwoFactorCode.TabIndex = 5;
            this.txtTwoFactorCode.Tag = "two_factor_code.value";
            this.toolTip.SetToolTip(this.txtTwoFactorCode, "Two-factor authentication code.");
            // 
            // txtVideoPassword
            // 
            this.txtVideoPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoPassword.Location = new System.Drawing.Point(123, 87);
            this.txtVideoPassword.Name = "txtVideoPassword";
            this.txtVideoPassword.PasswordChar = '•';
            this.txtVideoPassword.Size = new System.Drawing.Size(149, 22);
            this.txtVideoPassword.TabIndex = 7;
            this.txtVideoPassword.Tag = "video_password.value";
            this.toolTip.SetToolTip(this.txtVideoPassword, "Video password (vimeo, smotri, youku)");
            // 
            // cbVideoPassword
            // 
            this.cbVideoPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbVideoPassword.AutoSize = true;
            this.cbVideoPassword.Location = new System.Drawing.Point(3, 90);
            this.cbVideoPassword.Name = "cbVideoPassword";
            this.cbVideoPassword.Size = new System.Drawing.Size(111, 17);
            this.cbVideoPassword.TabIndex = 6;
            this.cbVideoPassword.Tag = "video_password";
            this.cbVideoPassword.Text = "Video Password:";
            this.toolTip.SetToolTip(this.cbVideoPassword, "Video password (vimeo, smotri, youku)");
            this.cbVideoPassword.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 35);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Tag = "password";
            this.lblPassword.Text = "Password:";
            this.toolTip.SetToolTip(this.lblPassword, "Account password.");
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(123, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(149, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "password.value";
            this.toolTip.SetToolTip(this.txtPassword, "Account password.");
            // 
            // cbTwoFactorCode
            // 
            this.cbTwoFactorCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTwoFactorCode.AutoSize = true;
            this.cbTwoFactorCode.Location = new System.Drawing.Point(3, 61);
            this.cbTwoFactorCode.Name = "cbTwoFactorCode";
            this.cbTwoFactorCode.Size = new System.Drawing.Size(114, 17);
            this.cbTwoFactorCode.TabIndex = 4;
            this.cbTwoFactorCode.Tag = "two_factor_code";
            this.cbTwoFactorCode.Text = "Two Factor Code:";
            this.toolTip.SetToolTip(this.cbTwoFactorCode, "Two-factor authentication code.");
            this.cbTwoFactorCode.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(123, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Tag = "username.value";
            this.toolTip.SetToolTip(this.txtUsername, "Login with this account ID.");
            // 
            // gbHeaders
            // 
            this.gbHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeaders.Controls.Add(this.dgvHeaders);
            this.gbHeaders.Location = new System.Drawing.Point(577, 3);
            this.gbHeaders.Name = "gbHeaders";
            this.tlp.SetRowSpan(this.gbHeaders, 2);
            this.gbHeaders.Size = new System.Drawing.Size(198, 279);
            this.gbHeaders.TabIndex = 4;
            this.gbHeaders.TabStop = false;
            this.gbHeaders.Tag = "headers";
            this.gbHeaders.Text = "Headers";
            // 
            // dgvHeaders
            // 
            this.dgvHeaders.AllowUserToOrderColumns = true;
            this.dgvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colValue});
            this.dgvHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeaders.Location = new System.Drawing.Point(3, 18);
            this.dgvHeaders.Name = "dgvHeaders";
            this.dgvHeaders.RowHeadersVisible = false;
            this.dgvHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeaders.Size = new System.Drawing.Size(192, 258);
            this.dgvHeaders.TabIndex = 0;
            this.dgvHeaders.Tag = "#";
            this.toolTip.SetToolTip(this.dgvHeaders, "Specify custom HTTP headers.");
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            // 
            // gbSleepInterval
            // 
            this.gbSleepInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSleepInterval.Controls.Add(this.tableLayoutPanel4);
            this.gbSleepInterval.Location = new System.Drawing.Point(290, 145);
            this.gbSleepInterval.Name = "gbSleepInterval";
            this.gbSleepInterval.Size = new System.Drawing.Size(281, 136);
            this.gbSleepInterval.TabIndex = 3;
            this.gbSleepInterval.TabStop = false;
            this.gbSleepInterval.Tag = "sleep";
            this.gbSleepInterval.Text = "Sleep Interval";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rbSleepIntervalDefault, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.rbSleepIntervalValue, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudSleepInterval, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.rbSleepIntervalRange, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(275, 81);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Tag = "#$";
            // 
            // rbSleepIntervalDefault
            // 
            this.rbSleepIntervalDefault.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSleepIntervalDefault.AutoSize = true;
            this.rbSleepIntervalDefault.Checked = true;
            this.rbSleepIntervalDefault.Location = new System.Drawing.Point(3, 3);
            this.rbSleepIntervalDefault.MinimumSize = new System.Drawing.Size(0, 22);
            this.rbSleepIntervalDefault.Name = "rbSleepIntervalDefault";
            this.rbSleepIntervalDefault.Size = new System.Drawing.Size(63, 22);
            this.rbSleepIntervalDefault.TabIndex = 0;
            this.rbSleepIntervalDefault.TabStop = true;
            this.rbSleepIntervalDefault.Tag = "default";
            this.rbSleepIntervalDefault.Text = "Default";
            this.toolTip.SetToolTip(this.rbSleepIntervalDefault, "Don\'t sleep before each download.");
            this.rbSleepIntervalDefault.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.nudSleepIntervalMin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSleepIntervalRangeSeperator, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudSleepIntervalMax, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(72, 56);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 28);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // nudSleepIntervalMin
            // 
            this.nudSleepIntervalMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepIntervalMin.Location = new System.Drawing.Point(0, 3);
            this.nudSleepIntervalMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.nudSleepIntervalMin.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepIntervalMin.Name = "nudSleepIntervalMin";
            this.nudSleepIntervalMin.Size = new System.Drawing.Size(88, 22);
            this.nudSleepIntervalMin.TabIndex = 0;
            this.nudSleepIntervalMin.Tag = "range.value_start";
            this.toolTip.SetToolTip(this.nudSleepIntervalMin, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            // 
            // lblSleepIntervalRangeSeperator
            // 
            this.lblSleepIntervalRangeSeperator.AutoSize = true;
            this.lblSleepIntervalRangeSeperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSleepIntervalRangeSeperator.Location = new System.Drawing.Point(94, 0);
            this.lblSleepIntervalRangeSeperator.Name = "lblSleepIntervalRangeSeperator";
            this.lblSleepIntervalRangeSeperator.Size = new System.Drawing.Size(11, 28);
            this.lblSleepIntervalRangeSeperator.TabIndex = 1;
            this.lblSleepIntervalRangeSeperator.Tag = "!ignore";
            this.lblSleepIntervalRangeSeperator.Text = "-";
            this.lblSleepIntervalRangeSeperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSleepIntervalMax
            // 
            this.nudSleepIntervalMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepIntervalMax.Location = new System.Drawing.Point(111, 3);
            this.nudSleepIntervalMax.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.nudSleepIntervalMax.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepIntervalMax.Name = "nudSleepIntervalMax";
            this.nudSleepIntervalMax.Size = new System.Drawing.Size(89, 22);
            this.nudSleepIntervalMax.TabIndex = 2;
            this.nudSleepIntervalMax.Tag = "range.value_end";
            this.toolTip.SetToolTip(this.nudSleepIntervalMax, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            // 
            // rbSleepIntervalValue
            // 
            this.rbSleepIntervalValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSleepIntervalValue.AutoSize = true;
            this.rbSleepIntervalValue.Location = new System.Drawing.Point(3, 33);
            this.rbSleepIntervalValue.Name = "rbSleepIntervalValue";
            this.rbSleepIntervalValue.Size = new System.Drawing.Size(56, 17);
            this.rbSleepIntervalValue.TabIndex = 1;
            this.rbSleepIntervalValue.Tag = "value";
            this.rbSleepIntervalValue.Text = "Value:";
            this.toolTip.SetToolTip(this.rbSleepIntervalValue, "The number of seconds to sleep before each download.");
            this.rbSleepIntervalValue.UseVisualStyleBackColor = true;
            // 
            // nudSleepInterval
            // 
            this.nudSleepInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepInterval.Location = new System.Drawing.Point(72, 31);
            this.nudSleepInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepInterval.Name = "nudSleepInterval";
            this.nudSleepInterval.Size = new System.Drawing.Size(200, 22);
            this.nudSleepInterval.TabIndex = 2;
            this.nudSleepInterval.Tag = "value.value";
            this.toolTip.SetToolTip(this.nudSleepInterval, "The number of seconds to sleep before each download.");
            // 
            // rbSleepIntervalRange
            // 
            this.rbSleepIntervalRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSleepIntervalRange.AutoSize = true;
            this.rbSleepIntervalRange.Location = new System.Drawing.Point(3, 61);
            this.rbSleepIntervalRange.Name = "rbSleepIntervalRange";
            this.rbSleepIntervalRange.Size = new System.Drawing.Size(61, 17);
            this.rbSleepIntervalRange.TabIndex = 3;
            this.rbSleepIntervalRange.Tag = "range";
            this.rbSleepIntervalRange.Text = "Range:";
            this.toolTip.SetToolTip(this.rbSleepIntervalRange, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            this.rbSleepIntervalRange.UseVisualStyleBackColor = true;
            // 
            // gbNetwork
            // 
            this.gbNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNetwork.Controls.Add(this.tableLayoutPanel7);
            this.gbNetwork.Controls.Add(this.tableLayoutPanel6);
            this.gbNetwork.Location = new System.Drawing.Point(3, 3);
            this.gbNetwork.MinimumSize = new System.Drawing.Size(218, 125);
            this.gbNetwork.Name = "gbNetwork";
            this.gbNetwork.Size = new System.Drawing.Size(281, 136);
            this.gbNetwork.TabIndex = 0;
            this.gbNetwork.TabStop = false;
            this.gbNetwork.Tag = "network";
            this.gbNetwork.Text = "Network";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.rbAnyIp, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rbForceIp4, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.rbForceIp6, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 105);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(275, 24);
            this.tableLayoutPanel7.TabIndex = 1;
            this.tableLayoutPanel7.Tag = "#$";
            // 
            // rbAnyIp
            // 
            this.rbAnyIp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbAnyIp.AutoSize = true;
            this.rbAnyIp.Checked = true;
            this.rbAnyIp.Location = new System.Drawing.Point(3, 3);
            this.rbAnyIp.Name = "rbAnyIp";
            this.rbAnyIp.Size = new System.Drawing.Size(44, 17);
            this.rbAnyIp.TabIndex = 0;
            this.rbAnyIp.TabStop = true;
            this.rbAnyIp.Tag = "any";
            this.rbAnyIp.Text = "Any";
            this.toolTip.SetToolTip(this.rbAnyIp, "Use either IPv4 or IPv6.");
            this.rbAnyIp.UseVisualStyleBackColor = true;
            // 
            // rbForceIp4
            // 
            this.rbForceIp4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbForceIp4.AutoSize = true;
            this.rbForceIp4.Location = new System.Drawing.Point(53, 3);
            this.rbForceIp4.Name = "rbForceIp4";
            this.rbForceIp4.Size = new System.Drawing.Size(76, 17);
            this.rbForceIp4.TabIndex = 1;
            this.rbForceIp4.Tag = "forceip4";
            this.rbForceIp4.Text = "Force IPv4";
            this.toolTip.SetToolTip(this.rbForceIp4, "Make all connections via IPv4.");
            this.rbForceIp4.UseVisualStyleBackColor = true;
            // 
            // rbForceIp6
            // 
            this.rbForceIp6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbForceIp6.AutoSize = true;
            this.rbForceIp6.Location = new System.Drawing.Point(135, 3);
            this.rbForceIp6.Name = "rbForceIp6";
            this.rbForceIp6.Size = new System.Drawing.Size(76, 17);
            this.rbForceIp6.TabIndex = 2;
            this.rbForceIp6.Tag = "forceip6";
            this.rbForceIp6.Text = "Force IPv6";
            this.toolTip.SetToolTip(this.rbForceIp6, "Make all connections via IPv6");
            this.rbForceIp6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.cbProxy, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbSocketTimeout, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cbSourceAddress, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtSourceAddress, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.nudSocketTimeout, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtProxy, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(275, 85);
            this.tableLayoutPanel6.TabIndex = 0;
            this.tableLayoutPanel6.Tag = "#$";
            // 
            // cbProxy
            // 
            this.cbProxy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbProxy.AutoSize = true;
            this.cbProxy.Location = new System.Drawing.Point(3, 5);
            this.cbProxy.Name = "cbProxy";
            this.cbProxy.Size = new System.Drawing.Size(56, 17);
            this.cbProxy.TabIndex = 0;
            this.cbProxy.Tag = "proxy";
            this.cbProxy.Text = "Proxy:";
            this.toolTip.SetToolTip(this.cbProxy, "Use the specified HTTP/HTTPS/SOCKS proxy.\r\nTo enable SOCKS proxy, specify a prope" +
        "r scheme (e.g. socks5://127.0.0.1:1080/).\r\nLeave blank for direct connection.");
            this.cbProxy.UseVisualStyleBackColor = true;
            // 
            // cbSocketTimeout
            // 
            this.cbSocketTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSocketTimeout.AutoSize = true;
            this.cbSocketTimeout.Location = new System.Drawing.Point(3, 33);
            this.cbSocketTimeout.Name = "cbSocketTimeout";
            this.cbSocketTimeout.Size = new System.Drawing.Size(107, 17);
            this.cbSocketTimeout.TabIndex = 2;
            this.cbSocketTimeout.Tag = "socket_timeout";
            this.cbSocketTimeout.Text = "Socket Timeout:";
            this.toolTip.SetToolTip(this.cbSocketTimeout, "Time to wait before giving up, in seconds.");
            this.cbSocketTimeout.UseVisualStyleBackColor = true;
            // 
            // cbSourceAddress
            // 
            this.cbSourceAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSourceAddress.AutoSize = true;
            this.cbSourceAddress.Location = new System.Drawing.Point(3, 62);
            this.cbSourceAddress.Name = "cbSourceAddress";
            this.cbSourceAddress.Size = new System.Drawing.Size(108, 17);
            this.cbSourceAddress.TabIndex = 4;
            this.cbSourceAddress.Tag = "src_address";
            this.cbSourceAddress.Text = "Source Address:";
            this.toolTip.SetToolTip(this.cbSourceAddress, "Client side IP address to bind to.");
            this.cbSourceAddress.UseVisualStyleBackColor = true;
            // 
            // txtSourceAddress
            // 
            this.txtSourceAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceAddress.Location = new System.Drawing.Point(117, 59);
            this.txtSourceAddress.Name = "txtSourceAddress";
            this.txtSourceAddress.Size = new System.Drawing.Size(155, 22);
            this.txtSourceAddress.TabIndex = 5;
            this.txtSourceAddress.Tag = "src_address.value";
            this.toolTip.SetToolTip(this.txtSourceAddress, "Client side IP address to bind to.");
            // 
            // nudSocketTimeout
            // 
            this.nudSocketTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSocketTimeout.Location = new System.Drawing.Point(117, 31);
            this.nudSocketTimeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudSocketTimeout.Name = "nudSocketTimeout";
            this.nudSocketTimeout.Size = new System.Drawing.Size(155, 22);
            this.nudSocketTimeout.TabIndex = 3;
            this.nudSocketTimeout.Tag = "socket_timeout.value";
            this.toolTip.SetToolTip(this.nudSocketTimeout, "Time to wait before giving up, in seconds.");
            // 
            // txtProxy
            // 
            this.txtProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxy.Location = new System.Drawing.Point(117, 3);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(155, 22);
            this.txtProxy.TabIndex = 1;
            this.txtProxy.Tag = "proxy.value";
            this.toolTip.SetToolTip(this.txtProxy, "Use the specified HTTP/HTTPS/SOCKS proxy.\r\nTo enable SOCKS proxy, specify a prope" +
        "r scheme (e.g. socks5://127.0.0.1:1080/).\r\nLeave blank for direct connection.");
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserAgent.AutoCompleteCustomSource.AddRange(new string[] {
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3" +
                "440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.12; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.1 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.75 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67." +
                "0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299",
            "Mozilla/5.0 (iPad; CPU OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.0 Mobile/15E148 Safari/604.1",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chr" +
                "omium/68.0.3440.75 Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14) AppleWebKit/605.1.15 (KHTML, like G" +
                "ecko) Version/12.0 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3" +
                "396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.11; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/604.5.6 (KHTML, like " +
                "Gecko) Version/11.0.3 Safari/604.5.6",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36 OPR/54.0.2952.64",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:56.0) Gecko/20100101 Firefox/56.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51." +
                "0.2704.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0",
            "Mozilla/5.0 (Windows NT 6.1; rv:52.0) Gecko/20100101 Firefox/52.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chr" +
                "omium/68.0.3440.106 Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:55.0) Gecko/20100101 Firefox/55.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36 OPR/54.0.2952.71",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65." +
                "0.3325.181 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:62.0) Gecko/20100101 Firefox/62." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/67.0.3396.103 YaBrowser/18.7.0.2695 Yowser/2.5 Safari/537.36",
            "Mozilla/5.0 (X11; CrOS x86_64 10575.58.0) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67." +
                "0.3396.87 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:60.0) Gecko/20100101 Firefox/60." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0." +
                "3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Fedora; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0"});
            this.txtUserAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel1.SetColumnSpan(this.txtUserAgent, 2);
            this.txtUserAgent.Location = new System.Drawing.Point(95, 31);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(680, 22);
            this.txtUserAgent.TabIndex = 3;
            this.txtUserAgent.Tag = "user_agent.value";
            this.toolTip.SetToolTip(this.txtUserAgent, "A custom user agent.");
            // 
            // cbUserAgent
            // 
            this.cbUserAgent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUserAgent.AutoSize = true;
            this.cbUserAgent.Location = new System.Drawing.Point(3, 33);
            this.cbUserAgent.Name = "cbUserAgent";
            this.cbUserAgent.Size = new System.Drawing.Size(86, 17);
            this.cbUserAgent.TabIndex = 2;
            this.cbUserAgent.Tag = "user_agent";
            this.cbUserAgent.Text = "User Agent:";
            this.toolTip.SetToolTip(this.cbUserAgent, "A custom user agent.");
            this.cbUserAgent.UseVisualStyleBackColor = true;
            // 
            // txtReferer
            // 
            this.txtReferer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtReferer, 2);
            this.txtReferer.Location = new System.Drawing.Point(95, 3);
            this.txtReferer.Name = "txtReferer";
            this.txtReferer.Size = new System.Drawing.Size(680, 22);
            this.txtReferer.TabIndex = 1;
            this.txtReferer.Tag = "referer.value";
            this.toolTip.SetToolTip(this.txtReferer, "Custom referer, use if the video access is restricted to one domain.");
            // 
            // cbReferer
            // 
            this.cbReferer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbReferer.AutoSize = true;
            this.cbReferer.Location = new System.Drawing.Point(3, 5);
            this.cbReferer.Name = "cbReferer";
            this.cbReferer.Size = new System.Drawing.Size(66, 17);
            this.cbReferer.TabIndex = 0;
            this.cbReferer.Tag = "referer";
            this.cbReferer.Text = "Referer:";
            this.toolTip.SetToolTip(this.cbReferer, "Custom referer, use if the video access is restricted to one domain.");
            this.cbReferer.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // txtCookies
            // 
            this.txtCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCookies.AutoCompleteCustomSource.AddRange(new string[] {
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3" +
                "440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.12; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_5) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.1 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68." +
                "0.3440.75 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67." +
                "0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" +
                "hrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299",
            "Mozilla/5.0 (iPad; CPU OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.0 Mobile/15E148 Safari/604.1",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chr" +
                "omium/68.0.3440.75 Chrome/68.0.3440.75 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14) AppleWebKit/605.1.15 (KHTML, like G" +
                "ecko) Version/12.0 Safari/605.1.15",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3" +
                "396.99 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/11.1.2 Safari/605.1.15",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.11; rv:61.0) Gecko/20100101 Firefox/61." +
                "0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/604.5.6 (KHTML, like " +
                "Gecko) Version/11.0.3 Safari/604.5.6",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36 OPR/54.0.2952.64",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:56.0) Gecko/20100101 Firefox/56.0",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51." +
                "0.2704.106 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like G" +
                "ecko) Chrome/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0",
            "Mozilla/5.0 (Windows NT 6.1; rv:52.0) Gecko/20100101 Firefox/52.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chr" +
                "omium/68.0.3440.106 Chrome/68.0.3440.106 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; rv:61.0) Gecko/20100101 Firefox/61.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:55.0) Gecko/20100101 Firefox/55.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.87 Safari/537.36 OPR/54.0.2952.71",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65." +
                "0.3325.181 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:62.0) Gecko/20100101 Firefox/62." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrom" +
                "e/68.0.3440.84 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; Trident/7.0; rv:11.0) like Gecko",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome" +
                "/67.0.3396.103 YaBrowser/18.7.0.2695 Yowser/2.5 Safari/537.36",
            "Mozilla/5.0 (X11; CrOS x86_64 10575.58.0) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/67.0.3396.99 Safari/537.36",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67." +
                "0.3396.87 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:60.0) Gecko/20100101 Firefox/60." +
                "0",
            "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0." +
                "3440.106 Safari/537.36",
            "Mozilla/5.0 (X11; Fedora; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0"});
            this.txtCookies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCookies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCookies.Location = new System.Drawing.Point(95, 59);
            this.txtCookies.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtCookies.Name = "txtCookies";
            this.txtCookies.ReadOnly = true;
            this.txtCookies.Size = new System.Drawing.Size(641, 22);
            this.txtCookies.TabIndex = 5;
            this.txtCookies.Tag = "cookies.value";
            this.toolTip.SetToolTip(this.txtCookies, "A filepath to read cookies.");
            // 
            // cbCookies
            // 
            this.cbCookies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCookies.AutoSize = true;
            this.cbCookies.Location = new System.Drawing.Point(3, 62);
            this.cbCookies.Name = "cbCookies";
            this.cbCookies.Size = new System.Drawing.Size(70, 17);
            this.cbCookies.TabIndex = 4;
            this.cbCookies.Tag = "cookies";
            this.cbCookies.Text = "Cookies:";
            this.toolTip.SetToolTip(this.cbCookies, "A filepath to read cookies.");
            this.cbCookies.UseVisualStyleBackColor = true;
            // 
            // btnBrowseCookies
            // 
            this.btnBrowseCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCookies.Location = new System.Drawing.Point(739, 59);
            this.btnBrowseCookies.Name = "btnBrowseCookies";
            this.btnBrowseCookies.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseCookies.TabIndex = 6;
            this.btnBrowseCookies.Tag = "@browse";
            this.btnBrowseCookies.Text = "...";
            this.btnBrowseCookies.UseVisualStyleBackColor = true;
            this.btnBrowseCookies.Click += new System.EventHandler(this.btnBrowseCookies_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.cbReferer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseCookies, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbUserAgent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCookies, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCookies, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReferer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserAgent, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // TabWorkarounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlp);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabWorkarounds";
            this.Size = new System.Drawing.Size(784, 373);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.TabWorkarounds_Load);
            this.tlp.ResumeLayout(false);
            this.gbDownload.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).EndInit();
            this.gbAuthentication.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
            this.gbSleepInterval.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepInterval)).EndInit();
            this.gbNetwork.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.GroupBox gbDownload;
        private System.Windows.Forms.ComboBox cbxLimitRateUnit;
        private System.Windows.Forms.CheckBox cbRetriesInf;
        private System.Windows.Forms.CheckBox cbFragmentRetriesInf;
        private System.Windows.Forms.NumericUpDown nudFragmentRetries;
        private System.Windows.Forms.CheckBox cbFragmentRetries;
        private System.Windows.Forms.NumericUpDown nudRetries;
        private System.Windows.Forms.CheckBox cbRetries;
        private System.Windows.Forms.NumericUpDown nudLimitRate;
        private System.Windows.Forms.CheckBox cbLimitRate;
        private System.Windows.Forms.GroupBox gbAuthentication;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbVideoPassword;
        private System.Windows.Forms.CheckBox cbTwoFactorCode;
        private System.Windows.Forms.TextBox txtVideoPassword;
        private System.Windows.Forms.TextBox txtTwoFactorCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox cbUsername;
        private System.Windows.Forms.GroupBox gbSleepInterval;
        private System.Windows.Forms.NumericUpDown nudSleepIntervalMin;
        private System.Windows.Forms.NumericUpDown nudSleepIntervalMax;
        private System.Windows.Forms.NumericUpDown nudSleepInterval;
        private System.Windows.Forms.RadioButton rbSleepIntervalRange;
        private System.Windows.Forms.RadioButton rbSleepIntervalValue;
        private System.Windows.Forms.RadioButton rbSleepIntervalDefault;
        private System.Windows.Forms.GroupBox gbNetwork;
        private System.Windows.Forms.RadioButton rbForceIp6;
        private System.Windows.Forms.RadioButton rbForceIp4;
        private System.Windows.Forms.RadioButton rbAnyIp;
        private System.Windows.Forms.NumericUpDown nudSocketTimeout;
        private System.Windows.Forms.CheckBox cbSocketTimeout;
        private System.Windows.Forms.TextBox txtSourceAddress;
        private System.Windows.Forms.CheckBox cbSourceAddress;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.CheckBox cbProxy;
        private System.Windows.Forms.GroupBox gbHeaders;
        private System.Windows.Forms.DataGridView dgvHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.CheckBox cbUserAgent;
        private System.Windows.Forms.TextBox txtReferer;
        private System.Windows.Forms.CheckBox cbReferer;
        private System.Windows.Forms.TextBox txtCookies;
        private System.Windows.Forms.CheckBox cbCookies;
        private System.Windows.Forms.Button btnBrowseCookies;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSleepIntervalRangeSeperator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}
