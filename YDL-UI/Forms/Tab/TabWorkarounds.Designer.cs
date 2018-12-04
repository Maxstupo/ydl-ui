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
            this.cbxLimitRateUnit = new System.Windows.Forms.ComboBox();
            this.cbRetriesInf = new System.Windows.Forms.CheckBox();
            this.cbFragmentRetriesInf = new System.Windows.Forms.CheckBox();
            this.nudFragmentRetries = new System.Windows.Forms.NumericUpDown();
            this.cbFragmentRetries = new System.Windows.Forms.CheckBox();
            this.nudRetries = new System.Windows.Forms.NumericUpDown();
            this.cbRetries = new System.Windows.Forms.CheckBox();
            this.nudLimitRate = new System.Windows.Forms.NumericUpDown();
            this.cbLimitRate = new System.Windows.Forms.CheckBox();
            this.gbAuthentication = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbVideoPassword = new System.Windows.Forms.CheckBox();
            this.cbTwoFactorCode = new System.Windows.Forms.CheckBox();
            this.txtVideoPassword = new System.Windows.Forms.TextBox();
            this.txtTwoFactorCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbUsername = new System.Windows.Forms.CheckBox();
            this.gbSleepInterval = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudSleepIntervalMin = new System.Windows.Forms.NumericUpDown();
            this.nudSleepIntervalMax = new System.Windows.Forms.NumericUpDown();
            this.lblSleepIntervalRangeSeperator = new System.Windows.Forms.Label();
            this.nudSleepInterval = new System.Windows.Forms.NumericUpDown();
            this.rbSleepIntervalRange = new System.Windows.Forms.RadioButton();
            this.rbSleepIntervalValue = new System.Windows.Forms.RadioButton();
            this.rbSleepIntervalDefault = new System.Windows.Forms.RadioButton();
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.rbForceIp6 = new System.Windows.Forms.RadioButton();
            this.rbForceIp4 = new System.Windows.Forms.RadioButton();
            this.rbAnyIp = new System.Windows.Forms.RadioButton();
            this.nudSocketTimeout = new System.Windows.Forms.NumericUpDown();
            this.cbSocketTimeout = new System.Windows.Forms.CheckBox();
            this.txtSourceAddress = new System.Windows.Forms.TextBox();
            this.cbSourceAddress = new System.Windows.Forms.CheckBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.cbProxy = new System.Windows.Forms.CheckBox();
            this.gbHeaders = new System.Windows.Forms.GroupBox();
            this.dgvHeaders = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.cbUserAgent = new System.Windows.Forms.CheckBox();
            this.txtReferer = new System.Windows.Forms.TextBox();
            this.cbReferer = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlp.SuspendLayout();
            this.gbDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).BeginInit();
            this.gbAuthentication.SuspendLayout();
            this.gbSleepInterval.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepInterval)).BeginInit();
            this.gbNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).BeginInit();
            this.gbHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Controls.Add(this.gbDownload, 1, 0);
            this.tlp.Controls.Add(this.gbAuthentication, 0, 1);
            this.tlp.Controls.Add(this.gbSleepInterval, 1, 1);
            this.tlp.Controls.Add(this.gbNetwork, 0, 0);
            this.tlp.Controls.Add(this.gbHeaders, 2, 0);
            this.tlp.Location = new System.Drawing.Point(3, 59);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(778, 340);
            this.tlp.TabIndex = 4;
            // 
            // gbDownload
            // 
            this.gbDownload.Controls.Add(this.cbxLimitRateUnit);
            this.gbDownload.Controls.Add(this.cbRetriesInf);
            this.gbDownload.Controls.Add(this.cbFragmentRetriesInf);
            this.gbDownload.Controls.Add(this.nudFragmentRetries);
            this.gbDownload.Controls.Add(this.cbFragmentRetries);
            this.gbDownload.Controls.Add(this.nudRetries);
            this.gbDownload.Controls.Add(this.cbRetries);
            this.gbDownload.Controls.Add(this.nudLimitRate);
            this.gbDownload.Controls.Add(this.cbLimitRate);
            this.gbDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDownload.Location = new System.Drawing.Point(231, 3);
            this.gbDownload.MinimumSize = new System.Drawing.Size(259, 125);
            this.gbDownload.Name = "gbDownload";
            this.gbDownload.Size = new System.Drawing.Size(268, 164);
            this.gbDownload.TabIndex = 1;
            this.gbDownload.TabStop = false;
            this.gbDownload.Text = "Download";
            // 
            // cbxLimitRateUnit
            // 
            this.cbxLimitRateUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLimitRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLimitRateUnit.FormattingEnabled = true;
            this.cbxLimitRateUnit.Location = new System.Drawing.Point(200, 20);
            this.cbxLimitRateUnit.Name = "cbxLimitRateUnit";
            this.cbxLimitRateUnit.Size = new System.Drawing.Size(62, 21);
            this.cbxLimitRateUnit.TabIndex = 2;
            // 
            // cbRetriesInf
            // 
            this.cbRetriesInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRetriesInf.AutoSize = true;
            this.cbRetriesInf.Location = new System.Drawing.Point(200, 51);
            this.cbRetriesInf.Name = "cbRetriesInf";
            this.cbRetriesInf.Size = new System.Drawing.Size(63, 17);
            this.cbRetriesInf.TabIndex = 5;
            this.cbRetriesInf.Text = "Infinite";
            this.toolTip.SetToolTip(this.cbRetriesInf, "Infinite retries.");
            this.cbRetriesInf.UseVisualStyleBackColor = true;
            // 
            // cbFragmentRetriesInf
            // 
            this.cbFragmentRetriesInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFragmentRetriesInf.AutoSize = true;
            this.cbFragmentRetriesInf.Location = new System.Drawing.Point(200, 79);
            this.cbFragmentRetriesInf.Name = "cbFragmentRetriesInf";
            this.cbFragmentRetriesInf.Size = new System.Drawing.Size(63, 17);
            this.cbFragmentRetriesInf.TabIndex = 8;
            this.cbFragmentRetriesInf.Text = "Infinite";
            this.toolTip.SetToolTip(this.cbFragmentRetriesInf, "Infinite fragment retries.");
            this.cbFragmentRetriesInf.UseVisualStyleBackColor = true;
            // 
            // nudFragmentRetries
            // 
            this.nudFragmentRetries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFragmentRetries.Location = new System.Drawing.Point(128, 76);
            this.nudFragmentRetries.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFragmentRetries.Name = "nudFragmentRetries";
            this.nudFragmentRetries.Size = new System.Drawing.Size(66, 22);
            this.nudFragmentRetries.TabIndex = 7;
            this.toolTip.SetToolTip(this.nudFragmentRetries, "Number of retries for a fragment (default is 10) (DASH, hlsnative and ISM)");
            // 
            // cbFragmentRetries
            // 
            this.cbFragmentRetries.AutoSize = true;
            this.cbFragmentRetries.Location = new System.Drawing.Point(6, 77);
            this.cbFragmentRetries.Name = "cbFragmentRetries";
            this.cbFragmentRetries.Size = new System.Drawing.Size(116, 17);
            this.cbFragmentRetries.TabIndex = 6;
            this.cbFragmentRetries.Text = "Fragment Retries:";
            this.toolTip.SetToolTip(this.cbFragmentRetries, "Number of retries for a fragment (default is 10) (DASH, hlsnative and ISM)");
            this.cbFragmentRetries.UseVisualStyleBackColor = true;
            // 
            // nudRetries
            // 
            this.nudRetries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRetries.Location = new System.Drawing.Point(128, 48);
            this.nudRetries.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudRetries.Name = "nudRetries";
            this.nudRetries.Size = new System.Drawing.Size(66, 22);
            this.nudRetries.TabIndex = 4;
            this.toolTip.SetToolTip(this.nudRetries, "Number of retries (default is 10).");
            // 
            // cbRetries
            // 
            this.cbRetries.AutoSize = true;
            this.cbRetries.Location = new System.Drawing.Point(6, 49);
            this.cbRetries.Name = "cbRetries";
            this.cbRetries.Size = new System.Drawing.Size(64, 17);
            this.cbRetries.TabIndex = 3;
            this.cbRetries.Text = "Retries:";
            this.toolTip.SetToolTip(this.cbRetries, "Number of retries (default is 10).");
            this.cbRetries.UseVisualStyleBackColor = true;
            // 
            // nudLimitRate
            // 
            this.nudLimitRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLimitRate.DecimalPlaces = 1;
            this.nudLimitRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLimitRate.Location = new System.Drawing.Point(128, 20);
            this.nudLimitRate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLimitRate.Name = "nudLimitRate";
            this.nudLimitRate.Size = new System.Drawing.Size(66, 22);
            this.nudLimitRate.TabIndex = 1;
            this.toolTip.SetToolTip(this.nudLimitRate, "Maximum download rate per second.");
            // 
            // cbLimitRate
            // 
            this.cbLimitRate.AutoSize = true;
            this.cbLimitRate.Location = new System.Drawing.Point(6, 21);
            this.cbLimitRate.Name = "cbLimitRate";
            this.cbLimitRate.Size = new System.Drawing.Size(79, 17);
            this.cbLimitRate.TabIndex = 0;
            this.cbLimitRate.Text = "Limit Rate:";
            this.toolTip.SetToolTip(this.cbLimitRate, "Maximum download rate per second.");
            this.cbLimitRate.UseVisualStyleBackColor = true;
            // 
            // gbAuthentication
            // 
            this.gbAuthentication.Controls.Add(this.lblPassword);
            this.gbAuthentication.Controls.Add(this.cbVideoPassword);
            this.gbAuthentication.Controls.Add(this.cbTwoFactorCode);
            this.gbAuthentication.Controls.Add(this.txtVideoPassword);
            this.gbAuthentication.Controls.Add(this.txtTwoFactorCode);
            this.gbAuthentication.Controls.Add(this.txtPassword);
            this.gbAuthentication.Controls.Add(this.txtUsername);
            this.gbAuthentication.Controls.Add(this.cbUsername);
            this.gbAuthentication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAuthentication.Location = new System.Drawing.Point(3, 173);
            this.gbAuthentication.MinimumSize = new System.Drawing.Size(218, 134);
            this.gbAuthentication.Name = "gbAuthentication";
            this.gbAuthentication.Size = new System.Drawing.Size(222, 164);
            this.gbAuthentication.TabIndex = 2;
            this.gbAuthentication.TabStop = false;
            this.gbAuthentication.Text = "Authentication";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            this.toolTip.SetToolTip(this.lblPassword, "Account password.");
            // 
            // cbVideoPassword
            // 
            this.cbVideoPassword.AutoSize = true;
            this.cbVideoPassword.Location = new System.Drawing.Point(5, 107);
            this.cbVideoPassword.Name = "cbVideoPassword";
            this.cbVideoPassword.Size = new System.Drawing.Size(111, 17);
            this.cbVideoPassword.TabIndex = 6;
            this.cbVideoPassword.Text = "Video Password:";
            this.toolTip.SetToolTip(this.cbVideoPassword, "Video password (vimeo, smotri, youku)");
            this.cbVideoPassword.UseVisualStyleBackColor = true;
            // 
            // cbTwoFactorCode
            // 
            this.cbTwoFactorCode.AutoSize = true;
            this.cbTwoFactorCode.Location = new System.Drawing.Point(5, 80);
            this.cbTwoFactorCode.Name = "cbTwoFactorCode";
            this.cbTwoFactorCode.Size = new System.Drawing.Size(114, 17);
            this.cbTwoFactorCode.TabIndex = 4;
            this.cbTwoFactorCode.Text = "Two Factor Code:";
            this.toolTip.SetToolTip(this.cbTwoFactorCode, "Two-factor authentication code.");
            this.cbTwoFactorCode.UseVisualStyleBackColor = true;
            // 
            // txtVideoPassword
            // 
            this.txtVideoPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoPassword.Location = new System.Drawing.Point(119, 105);
            this.txtVideoPassword.Name = "txtVideoPassword";
            this.txtVideoPassword.PasswordChar = '•';
            this.txtVideoPassword.Size = new System.Drawing.Size(96, 22);
            this.txtVideoPassword.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtVideoPassword, "Video password (vimeo, smotri, youku)");
            // 
            // txtTwoFactorCode
            // 
            this.txtTwoFactorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTwoFactorCode.Location = new System.Drawing.Point(119, 77);
            this.txtTwoFactorCode.Name = "txtTwoFactorCode";
            this.txtTwoFactorCode.Size = new System.Drawing.Size(96, 22);
            this.txtTwoFactorCode.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtTwoFactorCode, "Two-factor authentication code.");
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(119, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(96, 22);
            this.txtPassword.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtPassword, "Account password.");
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(119, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(96, 22);
            this.txtUsername.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtUsername, "Login with this account ID.");
            // 
            // cbUsername
            // 
            this.cbUsername.AutoSize = true;
            this.cbUsername.Location = new System.Drawing.Point(5, 23);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(80, 17);
            this.cbUsername.TabIndex = 0;
            this.cbUsername.Text = "Username:";
            this.toolTip.SetToolTip(this.cbUsername, "Login with this account ID.");
            this.cbUsername.UseVisualStyleBackColor = true;
            // 
            // gbSleepInterval
            // 
            this.gbSleepInterval.Controls.Add(this.tableLayoutPanel2);
            this.gbSleepInterval.Controls.Add(this.nudSleepInterval);
            this.gbSleepInterval.Controls.Add(this.rbSleepIntervalRange);
            this.gbSleepInterval.Controls.Add(this.rbSleepIntervalValue);
            this.gbSleepInterval.Controls.Add(this.rbSleepIntervalDefault);
            this.gbSleepInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSleepInterval.Location = new System.Drawing.Point(231, 173);
            this.gbSleepInterval.MinimumSize = new System.Drawing.Size(262, 123);
            this.gbSleepInterval.Name = "gbSleepInterval";
            this.gbSleepInterval.Size = new System.Drawing.Size(268, 164);
            this.gbSleepInterval.TabIndex = 3;
            this.gbSleepInterval.TabStop = false;
            this.gbSleepInterval.Text = "Sleep Interval";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.nudSleepIntervalMin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudSleepIntervalMax, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSleepIntervalRangeSeperator, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(73, 74);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 28);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // nudSleepIntervalMin
            // 
            this.nudSleepIntervalMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepIntervalMin.Location = new System.Drawing.Point(3, 3);
            this.nudSleepIntervalMin.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepIntervalMin.Name = "nudSleepIntervalMin";
            this.nudSleepIntervalMin.Size = new System.Drawing.Size(78, 22);
            this.nudSleepIntervalMin.TabIndex = 0;
            this.toolTip.SetToolTip(this.nudSleepIntervalMin, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            // 
            // nudSleepIntervalMax
            // 
            this.nudSleepIntervalMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepIntervalMax.Location = new System.Drawing.Point(104, 3);
            this.nudSleepIntervalMax.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepIntervalMax.Name = "nudSleepIntervalMax";
            this.nudSleepIntervalMax.Size = new System.Drawing.Size(79, 22);
            this.nudSleepIntervalMax.TabIndex = 2;
            this.toolTip.SetToolTip(this.nudSleepIntervalMax, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            // 
            // lblSleepIntervalRangeSeperator
            // 
            this.lblSleepIntervalRangeSeperator.AutoSize = true;
            this.lblSleepIntervalRangeSeperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSleepIntervalRangeSeperator.Location = new System.Drawing.Point(87, 0);
            this.lblSleepIntervalRangeSeperator.Name = "lblSleepIntervalRangeSeperator";
            this.lblSleepIntervalRangeSeperator.Size = new System.Drawing.Size(11, 28);
            this.lblSleepIntervalRangeSeperator.TabIndex = 1;
            this.lblSleepIntervalRangeSeperator.Text = "-";
            this.lblSleepIntervalRangeSeperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSleepInterval
            // 
            this.nudSleepInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepInterval.Location = new System.Drawing.Point(76, 46);
            this.nudSleepInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSleepInterval.Name = "nudSleepInterval";
            this.nudSleepInterval.Size = new System.Drawing.Size(183, 22);
            this.nudSleepInterval.TabIndex = 2;
            this.toolTip.SetToolTip(this.nudSleepInterval, "The number of seconds to sleep before each download.");
            // 
            // rbSleepIntervalRange
            // 
            this.rbSleepIntervalRange.AutoSize = true;
            this.rbSleepIntervalRange.Location = new System.Drawing.Point(6, 79);
            this.rbSleepIntervalRange.Name = "rbSleepIntervalRange";
            this.rbSleepIntervalRange.Size = new System.Drawing.Size(61, 17);
            this.rbSleepIntervalRange.TabIndex = 3;
            this.rbSleepIntervalRange.Text = "Range:";
            this.toolTip.SetToolTip(this.rbSleepIntervalRange, "Sleep by a random interval before each download, between the specified lower and " +
        "upper bounds.");
            this.rbSleepIntervalRange.UseVisualStyleBackColor = true;
            // 
            // rbSleepIntervalValue
            // 
            this.rbSleepIntervalValue.AutoSize = true;
            this.rbSleepIntervalValue.Location = new System.Drawing.Point(6, 48);
            this.rbSleepIntervalValue.Name = "rbSleepIntervalValue";
            this.rbSleepIntervalValue.Size = new System.Drawing.Size(56, 17);
            this.rbSleepIntervalValue.TabIndex = 1;
            this.rbSleepIntervalValue.Text = "Value:";
            this.toolTip.SetToolTip(this.rbSleepIntervalValue, "The number of seconds to sleep before each download.");
            this.rbSleepIntervalValue.UseVisualStyleBackColor = true;
            // 
            // rbSleepIntervalDefault
            // 
            this.rbSleepIntervalDefault.AutoSize = true;
            this.rbSleepIntervalDefault.Checked = true;
            this.rbSleepIntervalDefault.Location = new System.Drawing.Point(6, 21);
            this.rbSleepIntervalDefault.Name = "rbSleepIntervalDefault";
            this.rbSleepIntervalDefault.Size = new System.Drawing.Size(63, 17);
            this.rbSleepIntervalDefault.TabIndex = 0;
            this.rbSleepIntervalDefault.TabStop = true;
            this.rbSleepIntervalDefault.Text = "Default";
            this.toolTip.SetToolTip(this.rbSleepIntervalDefault, "Don\'t sleep before each download.");
            this.rbSleepIntervalDefault.UseVisualStyleBackColor = true;
            // 
            // gbNetwork
            // 
            this.gbNetwork.Controls.Add(this.rbForceIp6);
            this.gbNetwork.Controls.Add(this.rbForceIp4);
            this.gbNetwork.Controls.Add(this.rbAnyIp);
            this.gbNetwork.Controls.Add(this.nudSocketTimeout);
            this.gbNetwork.Controls.Add(this.cbSocketTimeout);
            this.gbNetwork.Controls.Add(this.txtSourceAddress);
            this.gbNetwork.Controls.Add(this.cbSourceAddress);
            this.gbNetwork.Controls.Add(this.txtProxy);
            this.gbNetwork.Controls.Add(this.cbProxy);
            this.gbNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNetwork.Location = new System.Drawing.Point(3, 3);
            this.gbNetwork.MinimumSize = new System.Drawing.Size(218, 125);
            this.gbNetwork.Name = "gbNetwork";
            this.gbNetwork.Size = new System.Drawing.Size(222, 164);
            this.gbNetwork.TabIndex = 0;
            this.gbNetwork.TabStop = false;
            this.gbNetwork.Text = "Network";
            // 
            // rbForceIp6
            // 
            this.rbForceIp6.AutoSize = true;
            this.rbForceIp6.Location = new System.Drawing.Point(137, 103);
            this.rbForceIp6.Name = "rbForceIp6";
            this.rbForceIp6.Size = new System.Drawing.Size(76, 17);
            this.rbForceIp6.TabIndex = 8;
            this.rbForceIp6.Text = "Force IPv6";
            this.toolTip.SetToolTip(this.rbForceIp6, "Make all connections via IPv6");
            this.rbForceIp6.UseVisualStyleBackColor = true;
            // 
            // rbForceIp4
            // 
            this.rbForceIp4.AutoSize = true;
            this.rbForceIp4.Location = new System.Drawing.Point(55, 103);
            this.rbForceIp4.Name = "rbForceIp4";
            this.rbForceIp4.Size = new System.Drawing.Size(76, 17);
            this.rbForceIp4.TabIndex = 7;
            this.rbForceIp4.Text = "Force IPv4";
            this.toolTip.SetToolTip(this.rbForceIp4, "Make all connections via IPv4.");
            this.rbForceIp4.UseVisualStyleBackColor = true;
            // 
            // rbAnyIp
            // 
            this.rbAnyIp.AutoSize = true;
            this.rbAnyIp.Checked = true;
            this.rbAnyIp.Location = new System.Drawing.Point(5, 103);
            this.rbAnyIp.Name = "rbAnyIp";
            this.rbAnyIp.Size = new System.Drawing.Size(44, 17);
            this.rbAnyIp.TabIndex = 6;
            this.rbAnyIp.TabStop = true;
            this.rbAnyIp.Text = "Any";
            this.toolTip.SetToolTip(this.rbAnyIp, "Use either IPv4 or IPv6.");
            this.rbAnyIp.UseVisualStyleBackColor = true;
            // 
            // nudSocketTimeout
            // 
            this.nudSocketTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSocketTimeout.Location = new System.Drawing.Point(119, 47);
            this.nudSocketTimeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudSocketTimeout.Name = "nudSocketTimeout";
            this.nudSocketTimeout.Size = new System.Drawing.Size(96, 22);
            this.nudSocketTimeout.TabIndex = 3;
            this.toolTip.SetToolTip(this.nudSocketTimeout, "Time to wait before giving up, in seconds.");
            // 
            // cbSocketTimeout
            // 
            this.cbSocketTimeout.AutoSize = true;
            this.cbSocketTimeout.Location = new System.Drawing.Point(5, 48);
            this.cbSocketTimeout.Name = "cbSocketTimeout";
            this.cbSocketTimeout.Size = new System.Drawing.Size(107, 17);
            this.cbSocketTimeout.TabIndex = 2;
            this.cbSocketTimeout.Text = "Socket Timeout:";
            this.toolTip.SetToolTip(this.cbSocketTimeout, "Time to wait before giving up, in seconds.");
            this.cbSocketTimeout.UseVisualStyleBackColor = true;
            // 
            // txtSourceAddress
            // 
            this.txtSourceAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceAddress.Location = new System.Drawing.Point(119, 75);
            this.txtSourceAddress.Name = "txtSourceAddress";
            this.txtSourceAddress.Size = new System.Drawing.Size(96, 22);
            this.txtSourceAddress.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtSourceAddress, "Client side IP address to bind to.");
            // 
            // cbSourceAddress
            // 
            this.cbSourceAddress.AutoSize = true;
            this.cbSourceAddress.Location = new System.Drawing.Point(5, 77);
            this.cbSourceAddress.Name = "cbSourceAddress";
            this.cbSourceAddress.Size = new System.Drawing.Size(108, 17);
            this.cbSourceAddress.TabIndex = 4;
            this.cbSourceAddress.Text = "Source Address:";
            this.toolTip.SetToolTip(this.cbSourceAddress, "Client side IP address to bind to.");
            this.cbSourceAddress.UseVisualStyleBackColor = true;
            // 
            // txtProxy
            // 
            this.txtProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxy.Location = new System.Drawing.Point(119, 19);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(96, 22);
            this.txtProxy.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtProxy, "Use the specified HTTP/HTTPS/SOCKS proxy.\r\nTo enable SOCKS proxy, specify a prope" +
        "r scheme (e.g. socks5://127.0.0.1:1080/).\r\nLeave blank for direct connection.");
            // 
            // cbProxy
            // 
            this.cbProxy.AutoSize = true;
            this.cbProxy.Location = new System.Drawing.Point(5, 21);
            this.cbProxy.Name = "cbProxy";
            this.cbProxy.Size = new System.Drawing.Size(56, 17);
            this.cbProxy.TabIndex = 0;
            this.cbProxy.Text = "Proxy:";
            this.toolTip.SetToolTip(this.cbProxy, "Use the specified HTTP/HTTPS/SOCKS proxy.\r\nTo enable SOCKS proxy, specify a prope" +
        "r scheme (e.g. socks5://127.0.0.1:1080/).\r\nLeave blank for direct connection.");
            this.cbProxy.UseVisualStyleBackColor = true;
            // 
            // gbHeaders
            // 
            this.gbHeaders.Controls.Add(this.dgvHeaders);
            this.gbHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHeaders.Location = new System.Drawing.Point(505, 3);
            this.gbHeaders.Name = "gbHeaders";
            this.tlp.SetRowSpan(this.gbHeaders, 2);
            this.gbHeaders.Size = new System.Drawing.Size(270, 334);
            this.gbHeaders.TabIndex = 4;
            this.gbHeaders.TabStop = false;
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
            this.dgvHeaders.Size = new System.Drawing.Size(264, 313);
            this.dgvHeaders.TabIndex = 0;
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
            // txtUserAgent
            // 
            this.txtUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtUserAgent.Location = new System.Drawing.Point(95, 31);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(686, 22);
            this.txtUserAgent.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtUserAgent, "Custom user agent");
            // 
            // cbUserAgent
            // 
            this.cbUserAgent.AutoSize = true;
            this.cbUserAgent.Location = new System.Drawing.Point(3, 34);
            this.cbUserAgent.Name = "cbUserAgent";
            this.cbUserAgent.Size = new System.Drawing.Size(86, 17);
            this.cbUserAgent.TabIndex = 2;
            this.cbUserAgent.Text = "User Agent:";
            this.toolTip.SetToolTip(this.cbUserAgent, "Custom user agent");
            this.cbUserAgent.UseVisualStyleBackColor = true;
            // 
            // txtReferer
            // 
            this.txtReferer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferer.Location = new System.Drawing.Point(95, 3);
            this.txtReferer.Name = "txtReferer";
            this.txtReferer.Size = new System.Drawing.Size(687, 22);
            this.txtReferer.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtReferer, "Custom referer, use if the video access is restricted to one domain.");
            // 
            // cbReferer
            // 
            this.cbReferer.AutoSize = true;
            this.cbReferer.Location = new System.Drawing.Point(3, 6);
            this.cbReferer.Name = "cbReferer";
            this.cbReferer.Size = new System.Drawing.Size(66, 17);
            this.cbReferer.TabIndex = 0;
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
            // TabWorkarounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.txtUserAgent);
            this.Controls.Add(this.cbUserAgent);
            this.Controls.Add(this.txtReferer);
            this.Controls.Add(this.cbReferer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabWorkarounds";
            this.Size = new System.Drawing.Size(784, 402);
            this.Load += new System.EventHandler(this.TabWorkarounds_Load);
            this.tlp.ResumeLayout(false);
            this.gbDownload.ResumeLayout(false);
            this.gbDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).EndInit();
            this.gbAuthentication.ResumeLayout(false);
            this.gbAuthentication.PerformLayout();
            this.gbSleepInterval.ResumeLayout(false);
            this.gbSleepInterval.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepIntervalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepInterval)).EndInit();
            this.gbNetwork.ResumeLayout(false);
            this.gbNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).EndInit();
            this.gbHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nudSleepIntervalMin;
        private System.Windows.Forms.NumericUpDown nudSleepIntervalMax;
        private System.Windows.Forms.Label lblSleepIntervalRangeSeperator;
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
        private System.Windows.Forms.ToolTip toolTip;
    }
}
