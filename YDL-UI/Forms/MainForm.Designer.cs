namespace Maxstupo.YdlUi.Forms {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.cbDownloadArchive = new System.Windows.Forms.CheckBox();
            this.btnOpenUrlEditor = new System.Windows.Forms.Button();
            this.btnBrowseDownloadArchive = new System.Windows.Forms.Button();
            this.cbRecodeFormat = new System.Windows.Forms.CheckBox();
            this.gbVideoSelectionPlaylistSelection = new System.Windows.Forms.GroupBox();
            this.rbPlaylistAndVideo = new System.Windows.Forms.RadioButton();
            this.rbVideoOnly = new System.Windows.Forms.RadioButton();
            this.rbPlaylistOnly = new System.Windows.Forms.RadioButton();
            this.txtDownloadArchive = new System.Windows.Forms.TextBox();
            this.cbxRecodeFormat = new System.Windows.Forms.ComboBox();
            this.txtFileTemplate = new Maxstupo.YdlUi.Controls.KeywordTextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.cbOutputFormat = new System.Windows.Forms.CheckBox();
            this.cbxOutputFormat = new System.Windows.Forms.ComboBox();
            this.txtCustomFormatSelector = new System.Windows.Forms.TextBox();
            this.cbCustomFormatSelector = new System.Windows.Forms.CheckBox();
            this.cbMarkWatched = new System.Windows.Forms.CheckBox();
            this.cbAbortOnErrors = new System.Windows.Forms.CheckBox();
            this.gbFilesystem = new System.Windows.Forms.GroupBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.cbWriteAnnotations = new System.Windows.Forms.CheckBox();
            this.cbWriteDescription = new System.Windows.Forms.CheckBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.gbVideoSelection = new System.Windows.Forms.GroupBox();
            this.cbMatchFilter = new System.Windows.Forms.CheckBox();
            this.txtMatchFilter = new System.Windows.Forms.TextBox();
            this.cbFilesizeMax = new System.Windows.Forms.CheckBox();
            this.nudFilesizeMax = new System.Windows.Forms.NumericUpDown();
            this.nudFilesizeMin = new System.Windows.Forms.NumericUpDown();
            this.nudViewRangeMax = new System.Windows.Forms.NumericUpDown();
            this.cbMaxViews = new System.Windows.Forms.CheckBox();
            this.nudViewRangeMin = new System.Windows.Forms.NumericUpDown();
            this.nudAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.nudMaxDownloads = new System.Windows.Forms.NumericUpDown();
            this.cbxFilesizeMinUnits = new System.Windows.Forms.ComboBox();
            this.cbxFilesizeMaxUnits = new System.Windows.Forms.ComboBox();
            this.cbAgeLimit = new System.Windows.Forms.CheckBox();
            this.cbMinViews = new System.Windows.Forms.CheckBox();
            this.cbFilesizeMin = new System.Windows.Forms.CheckBox();
            this.cbDateBefore = new System.Windows.Forms.CheckBox();
            this.dtpDateBefore = new System.Windows.Forms.DateTimePicker();
            this.cbDateAfter = new System.Windows.Forms.CheckBox();
            this.dtpDateAfter = new System.Windows.Forms.DateTimePicker();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbVideoSelectionPlaylist = new System.Windows.Forms.GroupBox();
            this.btnOpenPlaylistItemsEditor = new System.Windows.Forms.Button();
            this.nudPlaylistEnd = new System.Windows.Forms.NumericUpDown();
            this.nudPlaylistStart = new System.Windows.Forms.NumericUpDown();
            this.txtPlaylistRange = new Maxstupo.YdlUi.Controls.NumberTextBox();
            this.cbPlaylistRange = new System.Windows.Forms.CheckBox();
            this.cbPlaylistReversed = new System.Windows.Forms.CheckBox();
            this.cbPlaylistRandom = new System.Windows.Forms.CheckBox();
            this.cbPlaylistStart = new System.Windows.Forms.CheckBox();
            this.cbPlaylistEnd = new System.Windows.Forms.CheckBox();
            this.cbMaxDownloads = new System.Windows.Forms.CheckBox();
            this.cbRejectTitle = new System.Windows.Forms.CheckBox();
            this.cbMatchTitle = new System.Windows.Forms.CheckBox();
            this.txtRejectTitle = new System.Windows.Forms.TextBox();
            this.txtMatchTitle = new System.Windows.Forms.TextBox();
            this.gbFrameRate = new System.Windows.Forms.GroupBox();
            this.nudFpsCustom = new System.Windows.Forms.NumericUpDown();
            this.cbFpsFallback = new System.Windows.Forms.CheckBox();
            this.rbFpsCustom = new System.Windows.Forms.RadioButton();
            this.cbFpsPreferred = new System.Windows.Forms.CheckBox();
            this.rbFps25 = new System.Windows.Forms.RadioButton();
            this.rbFps30 = new System.Windows.Forms.RadioButton();
            this.rbFps60 = new System.Windows.Forms.RadioButton();
            this.rbFps120 = new System.Windows.Forms.RadioButton();
            this.rbFps144 = new System.Windows.Forms.RadioButton();
            this.txtDownloadDirectory = new System.Windows.Forms.TextBox();
            this.gbVideoQuality = new System.Windows.Forms.GroupBox();
            this.rbVq240p = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudVideoQualityHeight = new System.Windows.Forms.NumericUpDown();
            this.nudVideoQualityWidth = new System.Windows.Forms.NumericUpDown();
            this.rbVqCustom = new System.Windows.Forms.RadioButton();
            this.cbVqFallback = new System.Windows.Forms.CheckBox();
            this.cbVqPreferred = new System.Windows.Forms.CheckBox();
            this.rbVq360p = new System.Windows.Forms.RadioButton();
            this.rbVq480p = new System.Windows.Forms.RadioButton();
            this.rbVq720p = new System.Windows.Forms.RadioButton();
            this.rbVq1080p = new System.Windows.Forms.RadioButton();
            this.rbVq1440p = new System.Windows.Forms.RadioButton();
            this.rbVq2160p = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFileTemplate = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseDownloadDirectory = new System.Windows.Forms.Button();
            this.tpWorkarounds = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsernamePassword = new System.Windows.Forms.CheckBox();
            this.txtTwoFactor = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbTwoFactor = new System.Windows.Forms.CheckBox();
            this.cbVideoPassword = new System.Windows.Forms.CheckBox();
            this.txtVideoPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHeaders = new System.Windows.Forms.DataGridView();
            this.cKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSourceAddress = new System.Windows.Forms.TextBox();
            this.cbSourceAddress = new System.Windows.Forms.CheckBox();
            this.rbAny = new System.Windows.Forms.RadioButton();
            this.rbForceIpv6 = new System.Windows.Forms.RadioButton();
            this.rbForceIpv4 = new System.Windows.Forms.RadioButton();
            this.cbSocketTimeout = new System.Windows.Forms.CheckBox();
            this.nudSocketTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.cbProxy = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudSleepValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSleepRangeMax = new System.Windows.Forms.NumericUpDown();
            this.nudSleepRangeMin = new System.Windows.Forms.NumericUpDown();
            this.rbSleepRange = new System.Windows.Forms.RadioButton();
            this.rbSleepValue = new System.Windows.Forms.RadioButton();
            this.rbSleepDefault = new System.Windows.Forms.RadioButton();
            this.gbDownload = new System.Windows.Forms.GroupBox();
            this.nudFragmentRetries = new System.Windows.Forms.NumericUpDown();
            this.cbFragmentRetries = new System.Windows.Forms.CheckBox();
            this.cbFragmentRetriesInf = new System.Windows.Forms.CheckBox();
            this.nudLimitRate = new System.Windows.Forms.NumericUpDown();
            this.nudRetries = new System.Windows.Forms.NumericUpDown();
            this.cbRetries = new System.Windows.Forms.CheckBox();
            this.cbRetriesInf = new System.Windows.Forms.CheckBox();
            this.cbLimitRate = new System.Windows.Forms.CheckBox();
            this.cbxLimitRateUnits = new System.Windows.Forms.ComboBox();
            this.cbUserAgent = new System.Windows.Forms.CheckBox();
            this.txtReferer = new System.Windows.Forms.TextBox();
            this.cbReferer = new System.Windows.Forms.CheckBox();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gbVideoSelectionPlaylistSelection.SuspendLayout();
            this.gbFilesystem.SuspendLayout();
            this.gbVideoSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilesizeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilesizeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDownloads)).BeginInit();
            this.gbVideoSelectionPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).BeginInit();
            this.gbFrameRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFpsCustom)).BeginInit();
            this.gbVideoQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityWidth)).BeginInit();
            this.tpWorkarounds.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepRangeMin)).BeginInit();
            this.gbDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpGeneral);
            this.tabControl.Controls.Add(this.tpWorkarounds);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1131, 508);
            this.tabControl.TabIndex = 1;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.cbDownloadArchive);
            this.tpGeneral.Controls.Add(this.btnOpenUrlEditor);
            this.tpGeneral.Controls.Add(this.btnBrowseDownloadArchive);
            this.tpGeneral.Controls.Add(this.cbRecodeFormat);
            this.tpGeneral.Controls.Add(this.gbVideoSelectionPlaylistSelection);
            this.tpGeneral.Controls.Add(this.txtDownloadArchive);
            this.tpGeneral.Controls.Add(this.cbxRecodeFormat);
            this.tpGeneral.Controls.Add(this.txtFileTemplate);
            this.tpGeneral.Controls.Add(this.txtCommand);
            this.tpGeneral.Controls.Add(this.btnStartDownload);
            this.tpGeneral.Controls.Add(this.cbOutputFormat);
            this.tpGeneral.Controls.Add(this.cbxOutputFormat);
            this.tpGeneral.Controls.Add(this.txtCustomFormatSelector);
            this.tpGeneral.Controls.Add(this.cbCustomFormatSelector);
            this.tpGeneral.Controls.Add(this.cbMarkWatched);
            this.tpGeneral.Controls.Add(this.cbAbortOnErrors);
            this.tpGeneral.Controls.Add(this.gbFilesystem);
            this.tpGeneral.Controls.Add(this.cbIgnoreErrors);
            this.tpGeneral.Controls.Add(this.gbVideoSelection);
            this.tpGeneral.Controls.Add(this.gbFrameRate);
            this.tpGeneral.Controls.Add(this.txtDownloadDirectory);
            this.tpGeneral.Controls.Add(this.gbVideoQuality);
            this.tpGeneral.Controls.Add(this.label2);
            this.tpGeneral.Controls.Add(this.cbFileTemplate);
            this.tpGeneral.Controls.Add(this.txtUrl);
            this.tpGeneral.Controls.Add(this.label1);
            this.tpGeneral.Controls.Add(this.btnBrowseDownloadDirectory);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(1123, 482);
            this.tpGeneral.TabIndex = 3;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // cbDownloadArchive
            // 
            this.cbDownloadArchive.AutoSize = true;
            this.cbDownloadArchive.Location = new System.Drawing.Point(9, 93);
            this.cbDownloadArchive.Name = "cbDownloadArchive";
            this.cbDownloadArchive.Size = new System.Drawing.Size(123, 17);
            this.cbDownloadArchive.TabIndex = 86;
            this.cbDownloadArchive.Text = "Download Archive:";
            this.toolTip.SetToolTip(this.cbDownloadArchive, "Download only videos not listed in the archive file. Record the IDs of all downlo" +
        "aded videos in it.");
            this.cbDownloadArchive.UseVisualStyleBackColor = true;
            // 
            // btnOpenUrlEditor
            // 
            this.btnOpenUrlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenUrlEditor.Location = new System.Drawing.Point(1082, 6);
            this.btnOpenUrlEditor.Name = "btnOpenUrlEditor";
            this.btnOpenUrlEditor.Size = new System.Drawing.Size(33, 23);
            this.btnOpenUrlEditor.TabIndex = 86;
            this.btnOpenUrlEditor.Text = "...";
            this.btnOpenUrlEditor.UseVisualStyleBackColor = true;
            this.btnOpenUrlEditor.Click += new System.EventHandler(this.btnOpenUrlEditor_Click);
            // 
            // btnBrowseDownloadArchive
            // 
            this.btnBrowseDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadArchive.Location = new System.Drawing.Point(1040, 90);
            this.btnBrowseDownloadArchive.Name = "btnBrowseDownloadArchive";
            this.btnBrowseDownloadArchive.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDownloadArchive.TabIndex = 84;
            this.btnBrowseDownloadArchive.Text = "Browse";
            this.btnBrowseDownloadArchive.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadArchive.Click += new System.EventHandler(this.btnBrowseDownloadArchive_Click_1);
            // 
            // cbRecodeFormat
            // 
            this.cbRecodeFormat.AutoSize = true;
            this.cbRecodeFormat.Location = new System.Drawing.Point(880, 396);
            this.cbRecodeFormat.Name = "cbRecodeFormat";
            this.cbRecodeFormat.Size = new System.Drawing.Size(106, 17);
            this.cbRecodeFormat.TabIndex = 86;
            this.cbRecodeFormat.Text = "Recode Format:";
            this.toolTip.SetToolTip(this.cbRecodeFormat, "Encode the video to another format if necessary");
            this.cbRecodeFormat.UseVisualStyleBackColor = true;
            // 
            // gbVideoSelectionPlaylistSelection
            // 
            this.gbVideoSelectionPlaylistSelection.Controls.Add(this.rbPlaylistAndVideo);
            this.gbVideoSelectionPlaylistSelection.Controls.Add(this.rbVideoOnly);
            this.gbVideoSelectionPlaylistSelection.Controls.Add(this.rbPlaylistOnly);
            this.gbVideoSelectionPlaylistSelection.Location = new System.Drawing.Point(874, 123);
            this.gbVideoSelectionPlaylistSelection.Name = "gbVideoSelectionPlaylistSelection";
            this.gbVideoSelectionPlaylistSelection.Size = new System.Drawing.Size(97, 140);
            this.gbVideoSelectionPlaylistSelection.TabIndex = 60;
            this.gbVideoSelectionPlaylistSelection.TabStop = false;
            this.gbVideoSelectionPlaylistSelection.Text = "Selection";
            // 
            // rbPlaylistAndVideo
            // 
            this.rbPlaylistAndVideo.AutoSize = true;
            this.rbPlaylistAndVideo.Checked = true;
            this.rbPlaylistAndVideo.Location = new System.Drawing.Point(6, 19);
            this.rbPlaylistAndVideo.Name = "rbPlaylistAndVideo";
            this.rbPlaylistAndVideo.Size = new System.Drawing.Size(50, 17);
            this.rbPlaylistAndVideo.TabIndex = 12;
            this.rbPlaylistAndVideo.TabStop = true;
            this.rbPlaylistAndVideo.Text = "Both";
            this.toolTip.SetToolTip(this.rbPlaylistAndVideo, "Download both the video and playlist, if the URl refers to a video and a playlist" +
        "");
            this.rbPlaylistAndVideo.UseVisualStyleBackColor = true;
            // 
            // rbVideoOnly
            // 
            this.rbVideoOnly.AutoSize = true;
            this.rbVideoOnly.Location = new System.Drawing.Point(6, 65);
            this.rbVideoOnly.Name = "rbVideoOnly";
            this.rbVideoOnly.Size = new System.Drawing.Size(82, 17);
            this.rbVideoOnly.TabIndex = 11;
            this.rbVideoOnly.Text = "Video Only";
            this.toolTip.SetToolTip(this.rbVideoOnly, "Download only the video, if the URL refers to a video and a playlist");
            this.rbVideoOnly.UseVisualStyleBackColor = true;
            // 
            // rbPlaylistOnly
            // 
            this.rbPlaylistOnly.AutoSize = true;
            this.rbPlaylistOnly.Location = new System.Drawing.Point(6, 42);
            this.rbPlaylistOnly.Name = "rbPlaylistOnly";
            this.rbPlaylistOnly.Size = new System.Drawing.Size(87, 17);
            this.rbPlaylistOnly.TabIndex = 10;
            this.rbPlaylistOnly.Text = "Playlist Only";
            this.toolTip.SetToolTip(this.rbPlaylistOnly, "Download the playlist, if the URL refers to a video and a playlist");
            this.rbPlaylistOnly.UseVisualStyleBackColor = true;
            // 
            // txtDownloadArchive
            // 
            this.txtDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadArchive.Location = new System.Drawing.Point(138, 91);
            this.txtDownloadArchive.Name = "txtDownloadArchive";
            this.txtDownloadArchive.Size = new System.Drawing.Size(896, 22);
            this.txtDownloadArchive.TabIndex = 85;
            // 
            // cbxRecodeFormat
            // 
            this.cbxRecodeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecodeFormat.FormattingEnabled = true;
            this.cbxRecodeFormat.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cbxRecodeFormat.Location = new System.Drawing.Point(992, 394);
            this.cbxRecodeFormat.Name = "cbxRecodeFormat";
            this.cbxRecodeFormat.Size = new System.Drawing.Size(125, 21);
            this.cbxRecodeFormat.TabIndex = 85;
            // 
            // txtFileTemplate
            // 
            this.txtFileTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileTemplate.KeywordMatchingEnabled = true;
            this.txtFileTemplate.Location = new System.Drawing.Point(138, 62);
            this.txtFileTemplate.Name = "txtFileTemplate";
            this.txtFileTemplate.Size = new System.Drawing.Size(977, 22);
            this.txtFileTemplate.TabIndex = 84;
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.AutoCompleteCustomSource.AddRange(new string[] {
            "best",
            "worst",
            "bestvideo",
            "worstvideo",
            "bestaudio",
            "worstaudio",
            "+",
            "mp4",
            "3gp",
            "aac",
            "flv",
            "m4a",
            "mp3",
            "mp4",
            "ogg",
            "wav",
            "webm",
            "/",
            "filesize",
            "width",
            "height",
            "tbr",
            "abr",
            "vbr",
            "asr",
            "fps",
            "ext",
            "acodec",
            "vcodec",
            "container",
            "protocol",
            "format_id",
            "http",
            "https",
            "rtsp",
            "rtmp",
            "rtmpe",
            "mms",
            "f4m",
            "ism",
            "http_dash_segments",
            "m3u8",
            "m3u8_native",
            "<",
            ">",
            "?",
            "=",
            "<=",
            ">=",
            "!=",
            "^=",
            "$=",
            "*=",
            "(",
            ")"});
            this.txtCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCommand.Location = new System.Drawing.Point(6, 454);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(1001, 22);
            this.txtCommand.TabIndex = 83;
            this.txtCommand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCommand_MouseClick);
            this.txtCommand.Enter += new System.EventHandler(this.txtCommand_Enter);
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDownload.Location = new System.Drawing.Point(1013, 453);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(104, 23);
            this.btnStartDownload.TabIndex = 82;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click_1);
            // 
            // cbOutputFormat
            // 
            this.cbOutputFormat.AutoSize = true;
            this.cbOutputFormat.Enabled = false;
            this.cbOutputFormat.Location = new System.Drawing.Point(880, 369);
            this.cbOutputFormat.Name = "cbOutputFormat";
            this.cbOutputFormat.Size = new System.Drawing.Size(106, 17);
            this.cbOutputFormat.TabIndex = 81;
            this.cbOutputFormat.Text = "Output Format:";
            this.toolTip.SetToolTip(this.cbOutputFormat, "If merge is required, output to given container format. Ignore if no merge is req" +
        "uired");
            this.cbOutputFormat.UseVisualStyleBackColor = true;
            // 
            // cbxOutputFormat
            // 
            this.cbxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputFormat.FormattingEnabled = true;
            this.cbxOutputFormat.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cbxOutputFormat.Location = new System.Drawing.Point(992, 367);
            this.cbxOutputFormat.Name = "cbxOutputFormat";
            this.cbxOutputFormat.Size = new System.Drawing.Size(125, 21);
            this.cbxOutputFormat.TabIndex = 80;
            // 
            // txtCustomFormatSelector
            // 
            this.txtCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomFormatSelector.Location = new System.Drawing.Point(168, 423);
            this.txtCustomFormatSelector.Name = "txtCustomFormatSelector";
            this.txtCustomFormatSelector.Size = new System.Drawing.Size(949, 22);
            this.txtCustomFormatSelector.TabIndex = 76;
            this.txtCustomFormatSelector.Text = "bestvideo+bestaudio/best";
            // 
            // cbCustomFormatSelector
            // 
            this.cbCustomFormatSelector.AutoSize = true;
            this.cbCustomFormatSelector.Location = new System.Drawing.Point(11, 425);
            this.cbCustomFormatSelector.Name = "cbCustomFormatSelector";
            this.cbCustomFormatSelector.Size = new System.Drawing.Size(151, 17);
            this.cbCustomFormatSelector.TabIndex = 77;
            this.cbCustomFormatSelector.Text = "Custom Format Selector:";
            this.toolTip.SetToolTip(this.cbCustomFormatSelector, "Specify custom video format selector");
            this.cbCustomFormatSelector.UseVisualStyleBackColor = true;
            // 
            // cbMarkWatched
            // 
            this.cbMarkWatched.AutoSize = true;
            this.cbMarkWatched.Location = new System.Drawing.Point(880, 279);
            this.cbMarkWatched.Name = "cbMarkWatched";
            this.cbMarkWatched.Size = new System.Drawing.Size(106, 17);
            this.cbMarkWatched.TabIndex = 75;
            this.cbMarkWatched.Text = "Mark Watched?";
            this.toolTip.SetToolTip(this.cbMarkWatched, "Mark videos watched (YouTube only)");
            this.cbMarkWatched.UseVisualStyleBackColor = true;
            // 
            // cbAbortOnErrors
            // 
            this.cbAbortOnErrors.AutoSize = true;
            this.cbAbortOnErrors.Location = new System.Drawing.Point(880, 341);
            this.cbAbortOnErrors.Name = "cbAbortOnErrors";
            this.cbAbortOnErrors.Size = new System.Drawing.Size(112, 17);
            this.cbAbortOnErrors.TabIndex = 18;
            this.cbAbortOnErrors.Text = "Abort On Errors?";
            this.toolTip.SetToolTip(this.cbAbortOnErrors, "Abort downloading of further videos (in the playlist) if an error occurs");
            this.cbAbortOnErrors.UseVisualStyleBackColor = true;
            // 
            // gbFilesystem
            // 
            this.gbFilesystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFilesystem.Controls.Add(this.cbWriteAnnotations);
            this.gbFilesystem.Controls.Add(this.cbWriteDescription);
            this.gbFilesystem.Controls.Add(this.cbNoOverwrites);
            this.gbFilesystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFilesystem.Location = new System.Drawing.Point(979, 119);
            this.gbFilesystem.Name = "gbFilesystem";
            this.gbFilesystem.Size = new System.Drawing.Size(136, 144);
            this.gbFilesystem.TabIndex = 62;
            this.gbFilesystem.TabStop = false;
            this.gbFilesystem.Text = "Filesystem";
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 66);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(116, 17);
            this.cbWriteThumbnail.TabIndex = 65;
            this.cbWriteThumbnail.Text = "Write Thumbnail?";
            this.toolTip.SetToolTip(this.cbWriteThumbnail, "Write thumbnail image to disk");
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbWriteAnnotations
            // 
            this.cbWriteAnnotations.AutoSize = true;
            this.cbWriteAnnotations.Location = new System.Drawing.Point(6, 44);
            this.cbWriteAnnotations.Name = "cbWriteAnnotations";
            this.cbWriteAnnotations.Size = new System.Drawing.Size(126, 17);
            this.cbWriteAnnotations.TabIndex = 64;
            this.cbWriteAnnotations.Text = "Write Annotations?";
            this.toolTip.SetToolTip(this.cbWriteAnnotations, "Write video annotations");
            this.cbWriteAnnotations.UseVisualStyleBackColor = true;
            // 
            // cbWriteDescription
            // 
            this.cbWriteDescription.AutoSize = true;
            this.cbWriteDescription.Location = new System.Drawing.Point(6, 21);
            this.cbWriteDescription.Name = "cbWriteDescription";
            this.cbWriteDescription.Size = new System.Drawing.Size(121, 17);
            this.cbWriteDescription.TabIndex = 62;
            this.cbWriteDescription.Text = "Write Description?";
            this.toolTip.SetToolTip(this.cbWriteDescription, "Write video description to a .description");
            this.cbWriteDescription.UseVisualStyleBackColor = true;
            // 
            // cbNoOverwrites
            // 
            this.cbNoOverwrites.AutoSize = true;
            this.cbNoOverwrites.Checked = true;
            this.cbNoOverwrites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoOverwrites.Location = new System.Drawing.Point(6, 112);
            this.cbNoOverwrites.Name = "cbNoOverwrites";
            this.cbNoOverwrites.Size = new System.Drawing.Size(104, 17);
            this.cbNoOverwrites.TabIndex = 61;
            this.cbNoOverwrites.Text = "No Overwrites?";
            this.toolTip.SetToolTip(this.cbNoOverwrites, "Do not overwrite files");
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 89);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(123, 17);
            this.cbRestrictFilenames.TabIndex = 60;
            this.cbRestrictFilenames.Text = "Restrict Filenames?";
            this.toolTip.SetToolTip(this.cbRestrictFilenames, "Restrict filenames to only ASCII");
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreErrors
            // 
            this.cbIgnoreErrors.AutoSize = true;
            this.cbIgnoreErrors.Checked = true;
            this.cbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreErrors.Location = new System.Drawing.Point(880, 319);
            this.cbIgnoreErrors.Name = "cbIgnoreErrors";
            this.cbIgnoreErrors.Size = new System.Drawing.Size(98, 17);
            this.cbIgnoreErrors.TabIndex = 17;
            this.cbIgnoreErrors.Text = "Ignore Errors?";
            this.toolTip.SetToolTip(this.cbIgnoreErrors, "Continue on download errors, for example to skip unavailable videos in a playlist" +
        "");
            this.cbIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // gbVideoSelection
            // 
            this.gbVideoSelection.Controls.Add(this.cbMatchFilter);
            this.gbVideoSelection.Controls.Add(this.txtMatchFilter);
            this.gbVideoSelection.Controls.Add(this.cbFilesizeMax);
            this.gbVideoSelection.Controls.Add(this.nudFilesizeMax);
            this.gbVideoSelection.Controls.Add(this.nudFilesizeMin);
            this.gbVideoSelection.Controls.Add(this.nudViewRangeMax);
            this.gbVideoSelection.Controls.Add(this.cbMaxViews);
            this.gbVideoSelection.Controls.Add(this.nudViewRangeMin);
            this.gbVideoSelection.Controls.Add(this.nudAgeLimit);
            this.gbVideoSelection.Controls.Add(this.nudMaxDownloads);
            this.gbVideoSelection.Controls.Add(this.cbxFilesizeMinUnits);
            this.gbVideoSelection.Controls.Add(this.cbxFilesizeMaxUnits);
            this.gbVideoSelection.Controls.Add(this.cbAgeLimit);
            this.gbVideoSelection.Controls.Add(this.cbMinViews);
            this.gbVideoSelection.Controls.Add(this.cbFilesizeMin);
            this.gbVideoSelection.Controls.Add(this.cbDateBefore);
            this.gbVideoSelection.Controls.Add(this.dtpDateBefore);
            this.gbVideoSelection.Controls.Add(this.cbDateAfter);
            this.gbVideoSelection.Controls.Add(this.dtpDateAfter);
            this.gbVideoSelection.Controls.Add(this.cbDate);
            this.gbVideoSelection.Controls.Add(this.dtpDate);
            this.gbVideoSelection.Controls.Add(this.gbVideoSelectionPlaylist);
            this.gbVideoSelection.Controls.Add(this.cbMaxDownloads);
            this.gbVideoSelection.Controls.Add(this.cbRejectTitle);
            this.gbVideoSelection.Controls.Add(this.cbMatchTitle);
            this.gbVideoSelection.Controls.Add(this.txtRejectTitle);
            this.gbVideoSelection.Controls.Add(this.txtMatchTitle);
            this.gbVideoSelection.Location = new System.Drawing.Point(254, 119);
            this.gbVideoSelection.Name = "gbVideoSelection";
            this.gbVideoSelection.Size = new System.Drawing.Size(614, 297);
            this.gbVideoSelection.TabIndex = 21;
            this.gbVideoSelection.TabStop = false;
            this.gbVideoSelection.Text = "Video Selection";
            // 
            // cbMatchFilter
            // 
            this.cbMatchFilter.AutoSize = true;
            this.cbMatchFilter.Location = new System.Drawing.Point(219, 104);
            this.cbMatchFilter.Name = "cbMatchFilter";
            this.cbMatchFilter.Size = new System.Drawing.Size(90, 17);
            this.cbMatchFilter.TabIndex = 81;
            this.cbMatchFilter.Text = "Match Filter:";
            this.toolTip.SetToolTip(this.cbMatchFilter, "Generic video filter. Specify any key.");
            this.cbMatchFilter.UseVisualStyleBackColor = true;
            // 
            // txtMatchFilter
            // 
            this.txtMatchFilter.Location = new System.Drawing.Point(337, 102);
            this.txtMatchFilter.Name = "txtMatchFilter";
            this.txtMatchFilter.Size = new System.Drawing.Size(257, 22);
            this.txtMatchFilter.TabIndex = 80;
            this.toolTip.SetToolTip(this.txtMatchFilter, "Skip download for matching titles (regex or caseless sub-string)");
            // 
            // cbFilesizeMax
            // 
            this.cbFilesizeMax.AutoSize = true;
            this.cbFilesizeMax.Location = new System.Drawing.Point(6, 136);
            this.cbFilesizeMax.Name = "cbFilesizeMax";
            this.cbFilesizeMax.Size = new System.Drawing.Size(90, 17);
            this.cbFilesizeMax.TabIndex = 79;
            this.cbFilesizeMax.Text = "Max Filesize:";
            this.toolTip.SetToolTip(this.cbFilesizeMax, "Do not download any videos large than # size");
            this.cbFilesizeMax.UseVisualStyleBackColor = true;
            // 
            // nudFilesizeMax
            // 
            this.nudFilesizeMax.DecimalPlaces = 1;
            this.nudFilesizeMax.Location = new System.Drawing.Point(102, 135);
            this.nudFilesizeMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudFilesizeMax.Name = "nudFilesizeMax";
            this.nudFilesizeMax.Size = new System.Drawing.Size(48, 22);
            this.nudFilesizeMax.TabIndex = 78;
            this.nudFilesizeMax.ThousandsSeparator = true;
            // 
            // nudFilesizeMin
            // 
            this.nudFilesizeMin.DecimalPlaces = 1;
            this.nudFilesizeMin.Location = new System.Drawing.Point(101, 107);
            this.nudFilesizeMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudFilesizeMin.Name = "nudFilesizeMin";
            this.nudFilesizeMin.Size = new System.Drawing.Size(48, 22);
            this.nudFilesizeMin.TabIndex = 73;
            this.nudFilesizeMin.ThousandsSeparator = true;
            // 
            // nudViewRangeMax
            // 
            this.nudViewRangeMax.Location = new System.Drawing.Point(102, 198);
            this.nudViewRangeMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudViewRangeMax.Name = "nudViewRangeMax";
            this.nudViewRangeMax.Size = new System.Drawing.Size(96, 22);
            this.nudViewRangeMax.TabIndex = 77;
            this.nudViewRangeMax.ThousandsSeparator = true;
            // 
            // cbMaxViews
            // 
            this.cbMaxViews.AutoSize = true;
            this.cbMaxViews.Location = new System.Drawing.Point(6, 199);
            this.cbMaxViews.Name = "cbMaxViews";
            this.cbMaxViews.Size = new System.Drawing.Size(83, 17);
            this.cbMaxViews.TabIndex = 76;
            this.cbMaxViews.Text = "Max Views:";
            this.toolTip.SetToolTip(this.cbMaxViews, "Do not download any videos with more than # views");
            this.cbMaxViews.UseVisualStyleBackColor = true;
            // 
            // nudViewRangeMin
            // 
            this.nudViewRangeMin.Location = new System.Drawing.Point(102, 172);
            this.nudViewRangeMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudViewRangeMin.Name = "nudViewRangeMin";
            this.nudViewRangeMin.Size = new System.Drawing.Size(96, 22);
            this.nudViewRangeMin.TabIndex = 74;
            this.nudViewRangeMin.ThousandsSeparator = true;
            // 
            // nudAgeLimit
            // 
            this.nudAgeLimit.Location = new System.Drawing.Point(102, 234);
            this.nudAgeLimit.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudAgeLimit.Name = "nudAgeLimit";
            this.nudAgeLimit.Size = new System.Drawing.Size(96, 22);
            this.nudAgeLimit.TabIndex = 73;
            this.nudAgeLimit.ThousandsSeparator = true;
            // 
            // nudMaxDownloads
            // 
            this.nudMaxDownloads.Location = new System.Drawing.Point(337, 74);
            this.nudMaxDownloads.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMaxDownloads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDownloads.Name = "nudMaxDownloads";
            this.nudMaxDownloads.Size = new System.Drawing.Size(257, 22);
            this.nudMaxDownloads.TabIndex = 73;
            this.nudMaxDownloads.ThousandsSeparator = true;
            this.nudMaxDownloads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxFilesizeMinUnits
            // 
            this.cbxFilesizeMinUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilesizeMinUnits.FormattingEnabled = true;
            this.cbxFilesizeMinUnits.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cbxFilesizeMinUnits.Location = new System.Drawing.Point(155, 107);
            this.cbxFilesizeMinUnits.Name = "cbxFilesizeMinUnits";
            this.cbxFilesizeMinUnits.Size = new System.Drawing.Size(42, 21);
            this.cbxFilesizeMinUnits.TabIndex = 58;
            // 
            // cbxFilesizeMaxUnits
            // 
            this.cbxFilesizeMaxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilesizeMaxUnits.FormattingEnabled = true;
            this.cbxFilesizeMaxUnits.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cbxFilesizeMaxUnits.Location = new System.Drawing.Point(156, 135);
            this.cbxFilesizeMaxUnits.Name = "cbxFilesizeMaxUnits";
            this.cbxFilesizeMaxUnits.Size = new System.Drawing.Size(42, 21);
            this.cbxFilesizeMaxUnits.TabIndex = 46;
            // 
            // cbAgeLimit
            // 
            this.cbAgeLimit.AutoSize = true;
            this.cbAgeLimit.Location = new System.Drawing.Point(6, 235);
            this.cbAgeLimit.Name = "cbAgeLimit";
            this.cbAgeLimit.Size = new System.Drawing.Size(76, 17);
            this.cbAgeLimit.TabIndex = 54;
            this.cbAgeLimit.Text = "Age Limit:";
            this.toolTip.SetToolTip(this.cbAgeLimit, "Download only videos suitable for the given age");
            this.cbAgeLimit.UseVisualStyleBackColor = true;
            // 
            // cbMinViews
            // 
            this.cbMinViews.AutoSize = true;
            this.cbMinViews.Location = new System.Drawing.Point(6, 173);
            this.cbMinViews.Name = "cbMinViews";
            this.cbMinViews.Size = new System.Drawing.Size(82, 17);
            this.cbMinViews.TabIndex = 53;
            this.cbMinViews.Text = "Min Views:";
            this.toolTip.SetToolTip(this.cbMinViews, "Do not download any videos with less than # views");
            this.cbMinViews.UseVisualStyleBackColor = true;
            // 
            // cbFilesizeMin
            // 
            this.cbFilesizeMin.AutoSize = true;
            this.cbFilesizeMin.Location = new System.Drawing.Point(6, 111);
            this.cbFilesizeMin.Name = "cbFilesizeMin";
            this.cbFilesizeMin.Size = new System.Drawing.Size(89, 17);
            this.cbFilesizeMin.TabIndex = 52;
            this.cbFilesizeMin.Text = "Min Filesize:";
            this.toolTip.SetToolTip(this.cbFilesizeMin, "Do not download any videos smaller than # size");
            this.cbFilesizeMin.UseVisualStyleBackColor = true;
            // 
            // cbDateBefore
            // 
            this.cbDateBefore.AutoSize = true;
            this.cbDateBefore.Location = new System.Drawing.Point(6, 75);
            this.cbDateBefore.Name = "cbDateBefore";
            this.cbDateBefore.Size = new System.Drawing.Size(90, 17);
            this.cbDateBefore.TabIndex = 41;
            this.cbDateBefore.Text = "Date Before:";
            this.toolTip.SetToolTip(this.cbDateBefore, "Download only videos uploaded on or before this date");
            this.cbDateBefore.UseVisualStyleBackColor = true;
            // 
            // dtpDateBefore
            // 
            this.dtpDateBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBefore.Location = new System.Drawing.Point(101, 73);
            this.dtpDateBefore.Name = "dtpDateBefore";
            this.dtpDateBefore.Size = new System.Drawing.Size(93, 22);
            this.dtpDateBefore.TabIndex = 40;
            // 
            // cbDateAfter
            // 
            this.cbDateAfter.AutoSize = true;
            this.cbDateAfter.Location = new System.Drawing.Point(6, 49);
            this.cbDateAfter.Name = "cbDateAfter";
            this.cbDateAfter.Size = new System.Drawing.Size(81, 17);
            this.cbDateAfter.TabIndex = 39;
            this.cbDateAfter.Text = "Date After:";
            this.toolTip.SetToolTip(this.cbDateAfter, "Download only videos uploaded on or after this date");
            this.cbDateAfter.UseVisualStyleBackColor = true;
            // 
            // dtpDateAfter
            // 
            this.dtpDateAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAfter.Location = new System.Drawing.Point(101, 47);
            this.dtpDateAfter.Name = "dtpDateAfter";
            this.dtpDateAfter.Size = new System.Drawing.Size(93, 22);
            this.dtpDateAfter.TabIndex = 38;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(6, 23);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(53, 17);
            this.cbDate.TabIndex = 37;
            this.cbDate.Text = "Date:";
            this.toolTip.SetToolTip(this.cbDate, "Download only videos uploaded on this date");
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(101, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(93, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // gbVideoSelectionPlaylist
            // 
            this.gbVideoSelectionPlaylist.Controls.Add(this.btnOpenPlaylistItemsEditor);
            this.gbVideoSelectionPlaylist.Controls.Add(this.nudPlaylistEnd);
            this.gbVideoSelectionPlaylist.Controls.Add(this.nudPlaylistStart);
            this.gbVideoSelectionPlaylist.Controls.Add(this.txtPlaylistRange);
            this.gbVideoSelectionPlaylist.Controls.Add(this.cbPlaylistRange);
            this.gbVideoSelectionPlaylist.Controls.Add(this.cbPlaylistReversed);
            this.gbVideoSelectionPlaylist.Controls.Add(this.cbPlaylistRandom);
            this.gbVideoSelectionPlaylist.Controls.Add(this.cbPlaylistStart);
            this.gbVideoSelectionPlaylist.Controls.Add(this.cbPlaylistEnd);
            this.gbVideoSelectionPlaylist.Location = new System.Drawing.Point(214, 139);
            this.gbVideoSelectionPlaylist.Name = "gbVideoSelectionPlaylist";
            this.gbVideoSelectionPlaylist.Size = new System.Drawing.Size(386, 147);
            this.gbVideoSelectionPlaylist.TabIndex = 17;
            this.gbVideoSelectionPlaylist.TabStop = false;
            this.gbVideoSelectionPlaylist.Text = "Playlist";
            // 
            // btnOpenPlaylistItemsEditor
            // 
            this.btnOpenPlaylistItemsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPlaylistItemsEditor.Location = new System.Drawing.Point(347, 68);
            this.btnOpenPlaylistItemsEditor.Name = "btnOpenPlaylistItemsEditor";
            this.btnOpenPlaylistItemsEditor.Size = new System.Drawing.Size(33, 23);
            this.btnOpenPlaylistItemsEditor.TabIndex = 85;
            this.btnOpenPlaylistItemsEditor.Text = "...";
            this.btnOpenPlaylistItemsEditor.UseVisualStyleBackColor = true;
            this.btnOpenPlaylistItemsEditor.Click += new System.EventHandler(this.btnOpenPlaylistItemsEditor_Click);
            // 
            // nudPlaylistEnd
            // 
            this.nudPlaylistEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPlaylistEnd.Location = new System.Drawing.Point(70, 42);
            this.nudPlaylistEnd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPlaylistEnd.Name = "nudPlaylistEnd";
            this.nudPlaylistEnd.Size = new System.Drawing.Size(310, 22);
            this.nudPlaylistEnd.TabIndex = 70;
            this.nudPlaylistEnd.ThousandsSeparator = true;
            // 
            // nudPlaylistStart
            // 
            this.nudPlaylistStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPlaylistStart.Location = new System.Drawing.Point(70, 16);
            this.nudPlaylistStart.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPlaylistStart.Name = "nudPlaylistStart";
            this.nudPlaylistStart.Size = new System.Drawing.Size(310, 22);
            this.nudPlaylistStart.TabIndex = 69;
            this.nudPlaylistStart.ThousandsSeparator = true;
            // 
            // txtPlaylistRange
            // 
            this.txtPlaylistRange.AllowDecimal = false;
            this.txtPlaylistRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaylistRange.Location = new System.Drawing.Point(70, 68);
            this.txtPlaylistRange.Name = "txtPlaylistRange";
            this.txtPlaylistRange.Size = new System.Drawing.Size(271, 22);
            this.txtPlaylistRange.TabIndex = 22;
            this.txtPlaylistRange.WhitelistedChars = new char[] {
        '-',
        ','};
            // 
            // cbPlaylistRange
            // 
            this.cbPlaylistRange.AutoSize = true;
            this.cbPlaylistRange.Location = new System.Drawing.Point(6, 72);
            this.cbPlaylistRange.Name = "cbPlaylistRange";
            this.cbPlaylistRange.Size = new System.Drawing.Size(62, 17);
            this.cbPlaylistRange.TabIndex = 21;
            this.cbPlaylistRange.Text = "Range:";
            this.toolTip.SetToolTip(this.cbPlaylistRange, "Playlist video items to download. Sperated by commas, or range by hypens");
            this.cbPlaylistRange.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistReversed
            // 
            this.cbPlaylistReversed.AutoSize = true;
            this.cbPlaylistReversed.Location = new System.Drawing.Point(6, 98);
            this.cbPlaylistReversed.Name = "cbPlaylistReversed";
            this.cbPlaylistReversed.Size = new System.Drawing.Size(77, 17);
            this.cbPlaylistReversed.TabIndex = 42;
            this.cbPlaylistReversed.Text = "Reversed?";
            this.toolTip.SetToolTip(this.cbPlaylistReversed, "Download playlist videos in reverse order");
            this.cbPlaylistReversed.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistRandom
            // 
            this.cbPlaylistRandom.AutoSize = true;
            this.cbPlaylistRandom.Location = new System.Drawing.Point(6, 122);
            this.cbPlaylistRandom.Name = "cbPlaylistRandom";
            this.cbPlaylistRandom.Size = new System.Drawing.Size(74, 17);
            this.cbPlaylistRandom.TabIndex = 43;
            this.cbPlaylistRandom.Text = "Random?";
            this.toolTip.SetToolTip(this.cbPlaylistRandom, "Download playlist videos in random order");
            this.cbPlaylistRandom.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistStart
            // 
            this.cbPlaylistStart.AutoSize = true;
            this.cbPlaylistStart.Location = new System.Drawing.Point(6, 19);
            this.cbPlaylistStart.Name = "cbPlaylistStart";
            this.cbPlaylistStart.Size = new System.Drawing.Size(53, 17);
            this.cbPlaylistStart.TabIndex = 18;
            this.cbPlaylistStart.Text = "Start:";
            this.toolTip.SetToolTip(this.cbPlaylistStart, "Playlist video to start at");
            this.cbPlaylistStart.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistEnd
            // 
            this.cbPlaylistEnd.AutoSize = true;
            this.cbPlaylistEnd.Location = new System.Drawing.Point(6, 44);
            this.cbPlaylistEnd.Name = "cbPlaylistEnd";
            this.cbPlaylistEnd.Size = new System.Drawing.Size(49, 17);
            this.cbPlaylistEnd.TabIndex = 20;
            this.cbPlaylistEnd.Text = "End:";
            this.toolTip.SetToolTip(this.cbPlaylistEnd, "Playlist video to end at");
            this.cbPlaylistEnd.UseVisualStyleBackColor = true;
            // 
            // cbMaxDownloads
            // 
            this.cbMaxDownloads.AutoSize = true;
            this.cbMaxDownloads.Location = new System.Drawing.Point(219, 75);
            this.cbMaxDownloads.Name = "cbMaxDownloads";
            this.cbMaxDownloads.Size = new System.Drawing.Size(112, 17);
            this.cbMaxDownloads.TabIndex = 24;
            this.cbMaxDownloads.Text = "Max Downloads:";
            this.toolTip.SetToolTip(this.cbMaxDownloads, "Abort after downloading # downloads");
            this.cbMaxDownloads.UseVisualStyleBackColor = true;
            // 
            // cbRejectTitle
            // 
            this.cbRejectTitle.AutoSize = true;
            this.cbRejectTitle.Location = new System.Drawing.Point(219, 49);
            this.cbRejectTitle.Name = "cbRejectTitle";
            this.cbRejectTitle.Size = new System.Drawing.Size(84, 17);
            this.cbRejectTitle.TabIndex = 21;
            this.cbRejectTitle.Text = "Reject Title:";
            this.toolTip.SetToolTip(this.cbRejectTitle, "Skip download for matching titles (regex or caseless sub-string)");
            this.cbRejectTitle.UseVisualStyleBackColor = true;
            // 
            // cbMatchTitle
            // 
            this.cbMatchTitle.AutoSize = true;
            this.cbMatchTitle.Location = new System.Drawing.Point(219, 23);
            this.cbMatchTitle.Name = "cbMatchTitle";
            this.cbMatchTitle.Size = new System.Drawing.Size(85, 17);
            this.cbMatchTitle.TabIndex = 20;
            this.cbMatchTitle.Text = "Match Title:";
            this.toolTip.SetToolTip(this.cbMatchTitle, "Download only matching titles (regex or caseless sub-string)");
            this.cbMatchTitle.UseVisualStyleBackColor = true;
            // 
            // txtRejectTitle
            // 
            this.txtRejectTitle.Location = new System.Drawing.Point(337, 47);
            this.txtRejectTitle.Name = "txtRejectTitle";
            this.txtRejectTitle.Size = new System.Drawing.Size(257, 22);
            this.txtRejectTitle.TabIndex = 19;
            this.toolTip.SetToolTip(this.txtRejectTitle, "Skip download for matching titles (regex or caseless sub-string)");
            // 
            // txtMatchTitle
            // 
            this.txtMatchTitle.Location = new System.Drawing.Point(337, 21);
            this.txtMatchTitle.Name = "txtMatchTitle";
            this.txtMatchTitle.Size = new System.Drawing.Size(257, 22);
            this.txtMatchTitle.TabIndex = 18;
            this.toolTip.SetToolTip(this.txtMatchTitle, "Download only matching titles (regex or caseless sub-string)");
            // 
            // gbFrameRate
            // 
            this.gbFrameRate.Controls.Add(this.nudFpsCustom);
            this.gbFrameRate.Controls.Add(this.cbFpsFallback);
            this.gbFrameRate.Controls.Add(this.rbFpsCustom);
            this.gbFrameRate.Controls.Add(this.cbFpsPreferred);
            this.gbFrameRate.Controls.Add(this.rbFps25);
            this.gbFrameRate.Controls.Add(this.rbFps30);
            this.gbFrameRate.Controls.Add(this.rbFps60);
            this.gbFrameRate.Controls.Add(this.rbFps120);
            this.gbFrameRate.Controls.Add(this.rbFps144);
            this.gbFrameRate.Location = new System.Drawing.Point(162, 119);
            this.gbFrameRate.Name = "gbFrameRate";
            this.gbFrameRate.Size = new System.Drawing.Size(86, 297);
            this.gbFrameRate.TabIndex = 8;
            this.gbFrameRate.TabStop = false;
            this.gbFrameRate.Text = "Frame Rate";
            // 
            // nudFpsCustom
            // 
            this.nudFpsCustom.Location = new System.Drawing.Point(26, 138);
            this.nudFpsCustom.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudFpsCustom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFpsCustom.Name = "nudFpsCustom";
            this.nudFpsCustom.Size = new System.Drawing.Size(50, 22);
            this.nudFpsCustom.TabIndex = 8;
            this.nudFpsCustom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFpsFallback
            // 
            this.cbFpsFallback.AutoSize = true;
            this.cbFpsFallback.Checked = true;
            this.cbFpsFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFpsFallback.Location = new System.Drawing.Point(6, 269);
            this.cbFpsFallback.Name = "cbFpsFallback";
            this.cbFpsFallback.Size = new System.Drawing.Size(73, 17);
            this.cbFpsFallback.TabIndex = 10;
            this.cbFpsFallback.Text = "Fallback?";
            this.toolTip.SetToolTip(this.cbFpsFallback, "If fps metadata isn\'t available ignore fps check");
            this.cbFpsFallback.UseVisualStyleBackColor = true;
            // 
            // rbFpsCustom
            // 
            this.rbFpsCustom.AutoSize = true;
            this.rbFpsCustom.Location = new System.Drawing.Point(6, 143);
            this.rbFpsCustom.Name = "rbFpsCustom";
            this.rbFpsCustom.Size = new System.Drawing.Size(14, 13);
            this.rbFpsCustom.TabIndex = 5;
            this.rbFpsCustom.UseVisualStyleBackColor = true;
            // 
            // cbFpsPreferred
            // 
            this.cbFpsPreferred.AutoSize = true;
            this.cbFpsPreferred.Checked = true;
            this.cbFpsPreferred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFpsPreferred.Location = new System.Drawing.Point(6, 246);
            this.cbFpsPreferred.Name = "cbFpsPreferred";
            this.cbFpsPreferred.Size = new System.Drawing.Size(78, 17);
            this.cbFpsPreferred.TabIndex = 9;
            this.cbFpsPreferred.Text = "Preferred?";
            this.toolTip.SetToolTip(this.cbFpsPreferred, "If checked select best video with the highest fps up to the specified fps");
            this.cbFpsPreferred.UseVisualStyleBackColor = true;
            // 
            // rbFps25
            // 
            this.rbFps25.AutoSize = true;
            this.rbFps25.Location = new System.Drawing.Point(6, 111);
            this.rbFps25.Name = "rbFps25";
            this.rbFps25.Size = new System.Drawing.Size(37, 17);
            this.rbFps25.TabIndex = 4;
            this.rbFps25.Text = "25";
            this.rbFps25.UseVisualStyleBackColor = true;
            // 
            // rbFps30
            // 
            this.rbFps30.AutoSize = true;
            this.rbFps30.Location = new System.Drawing.Point(6, 88);
            this.rbFps30.Name = "rbFps30";
            this.rbFps30.Size = new System.Drawing.Size(37, 17);
            this.rbFps30.TabIndex = 3;
            this.rbFps30.Text = "30";
            this.rbFps30.UseVisualStyleBackColor = true;
            // 
            // rbFps60
            // 
            this.rbFps60.AutoSize = true;
            this.rbFps60.Location = new System.Drawing.Point(6, 65);
            this.rbFps60.Name = "rbFps60";
            this.rbFps60.Size = new System.Drawing.Size(37, 17);
            this.rbFps60.TabIndex = 2;
            this.rbFps60.Text = "60";
            this.rbFps60.UseVisualStyleBackColor = true;
            // 
            // rbFps120
            // 
            this.rbFps120.AutoSize = true;
            this.rbFps120.Location = new System.Drawing.Point(6, 42);
            this.rbFps120.Name = "rbFps120";
            this.rbFps120.Size = new System.Drawing.Size(43, 17);
            this.rbFps120.TabIndex = 1;
            this.rbFps120.Text = "120";
            this.rbFps120.UseVisualStyleBackColor = true;
            // 
            // rbFps144
            // 
            this.rbFps144.AutoSize = true;
            this.rbFps144.Checked = true;
            this.rbFps144.Location = new System.Drawing.Point(6, 19);
            this.rbFps144.Name = "rbFps144";
            this.rbFps144.Size = new System.Drawing.Size(43, 17);
            this.rbFps144.TabIndex = 0;
            this.rbFps144.TabStop = true;
            this.rbFps144.Text = "144";
            this.rbFps144.UseVisualStyleBackColor = true;
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDirectory.Location = new System.Drawing.Point(138, 34);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.Size = new System.Drawing.Size(896, 22);
            this.txtDownloadDirectory.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtDownloadDirectory, "The base directory for downloaded videos");
            // 
            // gbVideoQuality
            // 
            this.gbVideoQuality.Controls.Add(this.rbVq240p);
            this.gbVideoQuality.Controls.Add(this.label3);
            this.gbVideoQuality.Controls.Add(this.nudVideoQualityHeight);
            this.gbVideoQuality.Controls.Add(this.nudVideoQualityWidth);
            this.gbVideoQuality.Controls.Add(this.rbVqCustom);
            this.gbVideoQuality.Controls.Add(this.cbVqFallback);
            this.gbVideoQuality.Controls.Add(this.cbVqPreferred);
            this.gbVideoQuality.Controls.Add(this.rbVq360p);
            this.gbVideoQuality.Controls.Add(this.rbVq480p);
            this.gbVideoQuality.Controls.Add(this.rbVq720p);
            this.gbVideoQuality.Controls.Add(this.rbVq1080p);
            this.gbVideoQuality.Controls.Add(this.rbVq1440p);
            this.gbVideoQuality.Controls.Add(this.rbVq2160p);
            this.gbVideoQuality.Location = new System.Drawing.Point(10, 119);
            this.gbVideoQuality.Name = "gbVideoQuality";
            this.gbVideoQuality.Size = new System.Drawing.Size(146, 297);
            this.gbVideoQuality.TabIndex = 6;
            this.gbVideoQuality.TabStop = false;
            this.gbVideoQuality.Text = "Video Quality";
            // 
            // rbVq240p
            // 
            this.rbVq240p.AutoSize = true;
            this.rbVq240p.Location = new System.Drawing.Point(6, 157);
            this.rbVq240p.Name = "rbVq240p";
            this.rbVq240p.Size = new System.Drawing.Size(50, 17);
            this.rbVq240p.TabIndex = 6;
            this.rbVq240p.Text = "240p";
            this.rbVq240p.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            // 
            // nudVideoQualityHeight
            // 
            this.nudVideoQualityHeight.Location = new System.Drawing.Point(90, 183);
            this.nudVideoQualityHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudVideoQualityHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVideoQualityHeight.Name = "nudVideoQualityHeight";
            this.nudVideoQualityHeight.Size = new System.Drawing.Size(50, 22);
            this.nudVideoQualityHeight.TabIndex = 10;
            this.nudVideoQualityHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudVideoQualityWidth
            // 
            this.nudVideoQualityWidth.Location = new System.Drawing.Point(26, 183);
            this.nudVideoQualityWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudVideoQualityWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVideoQualityWidth.Name = "nudVideoQualityWidth";
            this.nudVideoQualityWidth.Size = new System.Drawing.Size(50, 22);
            this.nudVideoQualityWidth.TabIndex = 8;
            this.nudVideoQualityWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbVqCustom
            // 
            this.rbVqCustom.AutoSize = true;
            this.rbVqCustom.Location = new System.Drawing.Point(6, 188);
            this.rbVqCustom.Name = "rbVqCustom";
            this.rbVqCustom.Size = new System.Drawing.Size(14, 13);
            this.rbVqCustom.TabIndex = 7;
            this.rbVqCustom.UseVisualStyleBackColor = true;
            // 
            // cbVqFallback
            // 
            this.cbVqFallback.AutoSize = true;
            this.cbVqFallback.Checked = true;
            this.cbVqFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVqFallback.Location = new System.Drawing.Point(6, 269);
            this.cbVqFallback.Name = "cbVqFallback";
            this.cbVqFallback.Size = new System.Drawing.Size(73, 17);
            this.cbVqFallback.TabIndex = 12;
            this.cbVqFallback.Text = "Fallback?";
            this.toolTip.SetToolTip(this.cbVqFallback, "If resolution metadata isn\'t available ignore resolution check");
            this.cbVqFallback.UseVisualStyleBackColor = true;
            // 
            // cbVqPreferred
            // 
            this.cbVqPreferred.AutoSize = true;
            this.cbVqPreferred.Checked = true;
            this.cbVqPreferred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVqPreferred.Location = new System.Drawing.Point(6, 246);
            this.cbVqPreferred.Name = "cbVqPreferred";
            this.cbVqPreferred.Size = new System.Drawing.Size(78, 17);
            this.cbVqPreferred.TabIndex = 11;
            this.cbVqPreferred.Text = "Preferred?";
            this.toolTip.SetToolTip(this.cbVqPreferred, "If checked select best video quality up to the specified resolution");
            this.cbVqPreferred.UseVisualStyleBackColor = true;
            // 
            // rbVq360p
            // 
            this.rbVq360p.AutoSize = true;
            this.rbVq360p.Location = new System.Drawing.Point(6, 134);
            this.rbVq360p.Name = "rbVq360p";
            this.rbVq360p.Size = new System.Drawing.Size(50, 17);
            this.rbVq360p.TabIndex = 5;
            this.rbVq360p.Text = "360p";
            this.rbVq360p.UseVisualStyleBackColor = true;
            // 
            // rbVq480p
            // 
            this.rbVq480p.AutoSize = true;
            this.rbVq480p.Location = new System.Drawing.Point(6, 111);
            this.rbVq480p.Name = "rbVq480p";
            this.rbVq480p.Size = new System.Drawing.Size(50, 17);
            this.rbVq480p.TabIndex = 4;
            this.rbVq480p.Text = "480p";
            this.rbVq480p.UseVisualStyleBackColor = true;
            // 
            // rbVq720p
            // 
            this.rbVq720p.AutoSize = true;
            this.rbVq720p.Location = new System.Drawing.Point(6, 88);
            this.rbVq720p.Name = "rbVq720p";
            this.rbVq720p.Size = new System.Drawing.Size(99, 17);
            this.rbVq720p.TabIndex = 3;
            this.rbVq720p.Text = "720p (Half HD)";
            this.rbVq720p.UseVisualStyleBackColor = true;
            // 
            // rbVq1080p
            // 
            this.rbVq1080p.AutoSize = true;
            this.rbVq1080p.Location = new System.Drawing.Point(6, 65);
            this.rbVq1080p.Name = "rbVq1080p";
            this.rbVq1080p.Size = new System.Drawing.Size(103, 17);
            this.rbVq1080p.TabIndex = 2;
            this.rbVq1080p.Text = "1080p (Full HD)";
            this.rbVq1080p.UseVisualStyleBackColor = true;
            // 
            // rbVq1440p
            // 
            this.rbVq1440p.AutoSize = true;
            this.rbVq1440p.Location = new System.Drawing.Point(6, 42);
            this.rbVq1440p.Name = "rbVq1440p";
            this.rbVq1440p.Size = new System.Drawing.Size(56, 17);
            this.rbVq1440p.TabIndex = 1;
            this.rbVq1440p.Text = "1440p";
            this.rbVq1440p.UseVisualStyleBackColor = true;
            // 
            // rbVq2160p
            // 
            this.rbVq2160p.AutoSize = true;
            this.rbVq2160p.Checked = true;
            this.rbVq2160p.Location = new System.Drawing.Point(6, 19);
            this.rbVq2160p.Name = "rbVq2160p";
            this.rbVq2160p.Size = new System.Drawing.Size(131, 17);
            this.rbVq2160p.TabIndex = 0;
            this.rbVq2160p.TabStop = true;
            this.rbVq2160p.Text = "2160p (4K) (Ultra-HD)";
            this.rbVq2160p.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Download Directory:";
            this.toolTip.SetToolTip(this.label2, "The base directory for downloaded videos");
            // 
            // cbFileTemplate
            // 
            this.cbFileTemplate.AutoSize = true;
            this.cbFileTemplate.Location = new System.Drawing.Point(9, 65);
            this.cbFileTemplate.Name = "cbFileTemplate";
            this.cbFileTemplate.Size = new System.Drawing.Size(123, 17);
            this.cbFileTemplate.TabIndex = 4;
            this.cbFileTemplate.Text = "Filename Template:";
            this.toolTip.SetToolTip(this.cbFileTemplate, "Output filename template.");
            this.cbFileTemplate.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(138, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(938, 22);
            this.txtUrl.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtUrl, "The url(s) to download");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            this.toolTip.SetToolTip(this.label1, "The url(s) to download");
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(1040, 34);
            this.btnBrowseDownloadDirectory.Name = "btnBrowseDownloadDirectory";
            this.btnBrowseDownloadDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDownloadDirectory.TabIndex = 3;
            this.btnBrowseDownloadDirectory.Text = "Browse";
            this.btnBrowseDownloadDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadDirectory.Click += new System.EventHandler(this.btnBrowseDownloadDirectory_Click_1);
            // 
            // tpWorkarounds
            // 
            this.tpWorkarounds.Controls.Add(this.groupBox4);
            this.tpWorkarounds.Controls.Add(this.groupBox3);
            this.tpWorkarounds.Controls.Add(this.groupBox2);
            this.tpWorkarounds.Controls.Add(this.groupBox1);
            this.tpWorkarounds.Controls.Add(this.gbDownload);
            this.tpWorkarounds.Controls.Add(this.cbUserAgent);
            this.tpWorkarounds.Controls.Add(this.txtReferer);
            this.tpWorkarounds.Controls.Add(this.cbReferer);
            this.tpWorkarounds.Controls.Add(this.txtUserAgent);
            this.tpWorkarounds.Location = new System.Drawing.Point(4, 22);
            this.tpWorkarounds.Name = "tpWorkarounds";
            this.tpWorkarounds.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkarounds.Size = new System.Drawing.Size(1123, 482);
            this.tpWorkarounds.TabIndex = 2;
            this.tpWorkarounds.Text = "Workarounds";
            this.tpWorkarounds.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUsername);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbUsernamePassword);
            this.groupBox4.Controls.Add(this.txtTwoFactor);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.cbTwoFactor);
            this.groupBox4.Controls.Add(this.cbVideoPassword);
            this.groupBox4.Controls.Add(this.txtVideoPassword);
            this.groupBox4.Location = new System.Drawing.Point(6, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 134);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Authentication";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(119, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 22);
            this.txtUsername.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Password:";
            // 
            // cbUsernamePassword
            // 
            this.cbUsernamePassword.AutoSize = true;
            this.cbUsernamePassword.Location = new System.Drawing.Point(6, 21);
            this.cbUsernamePassword.Name = "cbUsernamePassword";
            this.cbUsernamePassword.Size = new System.Drawing.Size(80, 17);
            this.cbUsernamePassword.TabIndex = 89;
            this.cbUsernamePassword.Text = "Username:";
            this.cbUsernamePassword.UseVisualStyleBackColor = true;
            // 
            // txtTwoFactor
            // 
            this.txtTwoFactor.Location = new System.Drawing.Point(119, 75);
            this.txtTwoFactor.Name = "txtTwoFactor";
            this.txtTwoFactor.Size = new System.Drawing.Size(224, 22);
            this.txtTwoFactor.TabIndex = 96;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(224, 22);
            this.txtPassword.TabIndex = 92;
            // 
            // cbTwoFactor
            // 
            this.cbTwoFactor.AutoSize = true;
            this.cbTwoFactor.Location = new System.Drawing.Point(6, 77);
            this.cbTwoFactor.Name = "cbTwoFactor";
            this.cbTwoFactor.Size = new System.Drawing.Size(114, 17);
            this.cbTwoFactor.TabIndex = 95;
            this.cbTwoFactor.Text = "Two Factor Code:";
            this.cbTwoFactor.UseVisualStyleBackColor = true;
            // 
            // cbVideoPassword
            // 
            this.cbVideoPassword.AutoSize = true;
            this.cbVideoPassword.Location = new System.Drawing.Point(6, 105);
            this.cbVideoPassword.Name = "cbVideoPassword";
            this.cbVideoPassword.Size = new System.Drawing.Size(111, 17);
            this.cbVideoPassword.TabIndex = 93;
            this.cbVideoPassword.Text = "Video Password:";
            this.cbVideoPassword.UseVisualStyleBackColor = true;
            // 
            // txtVideoPassword
            // 
            this.txtVideoPassword.Location = new System.Drawing.Point(119, 103);
            this.txtVideoPassword.Name = "txtVideoPassword";
            this.txtVideoPassword.PasswordChar = '*';
            this.txtVideoPassword.Size = new System.Drawing.Size(224, 22);
            this.txtVideoPassword.TabIndex = 94;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHeaders);
            this.groupBox3.Location = new System.Drawing.Point(658, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 390);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Headers";
            // 
            // dgvHeaders
            // 
            this.dgvHeaders.AllowUserToOrderColumns = true;
            this.dgvHeaders.AllowUserToResizeRows = false;
            this.dgvHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKey,
            this.cValue});
            this.dgvHeaders.Location = new System.Drawing.Point(6, 21);
            this.dgvHeaders.MultiSelect = false;
            this.dgvHeaders.Name = "dgvHeaders";
            this.dgvHeaders.RowHeadersVisible = false;
            this.dgvHeaders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeaders.Size = new System.Drawing.Size(447, 363);
            this.dgvHeaders.TabIndex = 14;
            // 
            // cKey
            // 
            this.cKey.HeaderText = "Key";
            this.cKey.Name = "cKey";
            // 
            // cValue
            // 
            this.cValue.HeaderText = "Value";
            this.cValue.Name = "cValue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSourceAddress);
            this.groupBox2.Controls.Add(this.cbSourceAddress);
            this.groupBox2.Controls.Add(this.rbAny);
            this.groupBox2.Controls.Add(this.rbForceIpv6);
            this.groupBox2.Controls.Add(this.rbForceIpv4);
            this.groupBox2.Controls.Add(this.cbSocketTimeout);
            this.groupBox2.Controls.Add(this.nudSocketTimeout);
            this.groupBox2.Controls.Add(this.txtProxy);
            this.groupBox2.Controls.Add(this.cbProxy);
            this.groupBox2.Location = new System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 134);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network";
            // 
            // txtSourceAddress
            // 
            this.txtSourceAddress.Location = new System.Drawing.Point(119, 75);
            this.txtSourceAddress.Name = "txtSourceAddress";
            this.txtSourceAddress.Size = new System.Drawing.Size(224, 22);
            this.txtSourceAddress.TabIndex = 88;
            // 
            // cbSourceAddress
            // 
            this.cbSourceAddress.AutoSize = true;
            this.cbSourceAddress.Location = new System.Drawing.Point(6, 77);
            this.cbSourceAddress.Name = "cbSourceAddress";
            this.cbSourceAddress.Size = new System.Drawing.Size(108, 17);
            this.cbSourceAddress.TabIndex = 87;
            this.cbSourceAddress.Text = "Source Address:";
            this.cbSourceAddress.UseVisualStyleBackColor = true;
            // 
            // rbAny
            // 
            this.rbAny.AutoSize = true;
            this.rbAny.Checked = true;
            this.rbAny.Location = new System.Drawing.Point(6, 110);
            this.rbAny.Name = "rbAny";
            this.rbAny.Size = new System.Drawing.Size(44, 17);
            this.rbAny.TabIndex = 86;
            this.rbAny.TabStop = true;
            this.rbAny.Text = "Any";
            this.rbAny.UseVisualStyleBackColor = true;
            // 
            // rbForceIpv6
            // 
            this.rbForceIpv6.AutoSize = true;
            this.rbForceIpv6.Location = new System.Drawing.Point(138, 110);
            this.rbForceIpv6.Name = "rbForceIpv6";
            this.rbForceIpv6.Size = new System.Drawing.Size(76, 17);
            this.rbForceIpv6.TabIndex = 85;
            this.rbForceIpv6.Text = "Force IPv6";
            this.rbForceIpv6.UseVisualStyleBackColor = true;
            // 
            // rbForceIpv4
            // 
            this.rbForceIpv4.AutoSize = true;
            this.rbForceIpv4.Location = new System.Drawing.Point(56, 110);
            this.rbForceIpv4.Name = "rbForceIpv4";
            this.rbForceIpv4.Size = new System.Drawing.Size(76, 17);
            this.rbForceIpv4.TabIndex = 83;
            this.rbForceIpv4.Text = "Force IPv4";
            this.rbForceIpv4.UseVisualStyleBackColor = true;
            // 
            // cbSocketTimeout
            // 
            this.cbSocketTimeout.AutoSize = true;
            this.cbSocketTimeout.Location = new System.Drawing.Point(6, 48);
            this.cbSocketTimeout.Name = "cbSocketTimeout";
            this.cbSocketTimeout.Size = new System.Drawing.Size(107, 17);
            this.cbSocketTimeout.TabIndex = 84;
            this.cbSocketTimeout.Text = "Socket Timeout:";
            this.cbSocketTimeout.UseVisualStyleBackColor = true;
            // 
            // nudSocketTimeout
            // 
            this.nudSocketTimeout.Location = new System.Drawing.Point(119, 47);
            this.nudSocketTimeout.Name = "nudSocketTimeout";
            this.nudSocketTimeout.Size = new System.Drawing.Size(224, 22);
            this.nudSocketTimeout.TabIndex = 83;
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(119, 19);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(224, 22);
            this.txtProxy.TabIndex = 80;
            // 
            // cbProxy
            // 
            this.cbProxy.AutoSize = true;
            this.cbProxy.Location = new System.Drawing.Point(6, 21);
            this.cbProxy.Name = "cbProxy";
            this.cbProxy.Size = new System.Drawing.Size(56, 17);
            this.cbProxy.TabIndex = 79;
            this.cbProxy.Text = "Proxy:";
            this.cbProxy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSleepValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudSleepRangeMax);
            this.groupBox1.Controls.Add(this.nudSleepRangeMin);
            this.groupBox1.Controls.Add(this.rbSleepRange);
            this.groupBox1.Controls.Add(this.rbSleepValue);
            this.groupBox1.Controls.Add(this.rbSleepDefault);
            this.groupBox1.Location = new System.Drawing.Point(361, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 95);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sleep Interval";
            // 
            // nudSleepValue
            // 
            this.nudSleepValue.Location = new System.Drawing.Point(73, 41);
            this.nudSleepValue.Name = "nudSleepValue";
            this.nudSleepValue.Size = new System.Drawing.Size(212, 22);
            this.nudSleepValue.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "-";
            // 
            // nudSleepRangeMax
            // 
            this.nudSleepRangeMax.Location = new System.Drawing.Point(191, 67);
            this.nudSleepRangeMax.Name = "nudSleepRangeMax";
            this.nudSleepRangeMax.Size = new System.Drawing.Size(94, 22);
            this.nudSleepRangeMax.TabIndex = 81;
            // 
            // nudSleepRangeMin
            // 
            this.nudSleepRangeMin.Location = new System.Drawing.Point(73, 67);
            this.nudSleepRangeMin.Name = "nudSleepRangeMin";
            this.nudSleepRangeMin.Size = new System.Drawing.Size(94, 22);
            this.nudSleepRangeMin.TabIndex = 80;
            // 
            // rbSleepRange
            // 
            this.rbSleepRange.AutoSize = true;
            this.rbSleepRange.Location = new System.Drawing.Point(6, 68);
            this.rbSleepRange.Name = "rbSleepRange";
            this.rbSleepRange.Size = new System.Drawing.Size(61, 17);
            this.rbSleepRange.TabIndex = 79;
            this.rbSleepRange.Text = "Range:";
            this.rbSleepRange.UseVisualStyleBackColor = true;
            // 
            // rbSleepValue
            // 
            this.rbSleepValue.AutoSize = true;
            this.rbSleepValue.Location = new System.Drawing.Point(6, 44);
            this.rbSleepValue.Name = "rbSleepValue";
            this.rbSleepValue.Size = new System.Drawing.Size(56, 17);
            this.rbSleepValue.TabIndex = 78;
            this.rbSleepValue.Text = "Value:";
            this.rbSleepValue.UseVisualStyleBackColor = true;
            // 
            // rbSleepDefault
            // 
            this.rbSleepDefault.AutoSize = true;
            this.rbSleepDefault.Checked = true;
            this.rbSleepDefault.Location = new System.Drawing.Point(6, 21);
            this.rbSleepDefault.Name = "rbSleepDefault";
            this.rbSleepDefault.Size = new System.Drawing.Size(63, 17);
            this.rbSleepDefault.TabIndex = 77;
            this.rbSleepDefault.TabStop = true;
            this.rbSleepDefault.Text = "Default";
            this.rbSleepDefault.UseVisualStyleBackColor = true;
            // 
            // gbDownload
            // 
            this.gbDownload.Controls.Add(this.nudFragmentRetries);
            this.gbDownload.Controls.Add(this.cbFragmentRetries);
            this.gbDownload.Controls.Add(this.cbFragmentRetriesInf);
            this.gbDownload.Controls.Add(this.nudLimitRate);
            this.gbDownload.Controls.Add(this.nudRetries);
            this.gbDownload.Controls.Add(this.cbRetries);
            this.gbDownload.Controls.Add(this.cbRetriesInf);
            this.gbDownload.Controls.Add(this.cbLimitRate);
            this.gbDownload.Controls.Add(this.cbxLimitRateUnits);
            this.gbDownload.Location = new System.Drawing.Point(361, 83);
            this.gbDownload.Name = "gbDownload";
            this.gbDownload.Size = new System.Drawing.Size(291, 134);
            this.gbDownload.TabIndex = 46;
            this.gbDownload.TabStop = false;
            this.gbDownload.Text = "Download";
            // 
            // nudFragmentRetries
            // 
            this.nudFragmentRetries.Location = new System.Drawing.Point(131, 73);
            this.nudFragmentRetries.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudFragmentRetries.Name = "nudFragmentRetries";
            this.nudFragmentRetries.Size = new System.Drawing.Size(82, 22);
            this.nudFragmentRetries.TabIndex = 75;
            this.nudFragmentRetries.ThousandsSeparator = true;
            // 
            // cbFragmentRetries
            // 
            this.cbFragmentRetries.AutoSize = true;
            this.cbFragmentRetries.Location = new System.Drawing.Point(9, 74);
            this.cbFragmentRetries.Name = "cbFragmentRetries";
            this.cbFragmentRetries.Size = new System.Drawing.Size(116, 17);
            this.cbFragmentRetries.TabIndex = 74;
            this.cbFragmentRetries.Text = "Fragment Retries:";
            this.cbFragmentRetries.UseVisualStyleBackColor = true;
            // 
            // cbFragmentRetriesInf
            // 
            this.cbFragmentRetriesInf.AutoSize = true;
            this.cbFragmentRetriesInf.Location = new System.Drawing.Point(219, 75);
            this.cbFragmentRetriesInf.Name = "cbFragmentRetriesInf";
            this.cbFragmentRetriesInf.Size = new System.Drawing.Size(68, 17);
            this.cbFragmentRetriesInf.TabIndex = 73;
            this.cbFragmentRetriesInf.Text = "Infinite?";
            this.cbFragmentRetriesInf.UseVisualStyleBackColor = true;
            // 
            // nudLimitRate
            // 
            this.nudLimitRate.DecimalPlaces = 1;
            this.nudLimitRate.Location = new System.Drawing.Point(131, 19);
            this.nudLimitRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudLimitRate.Name = "nudLimitRate";
            this.nudLimitRate.Size = new System.Drawing.Size(82, 22);
            this.nudLimitRate.TabIndex = 69;
            this.nudLimitRate.ThousandsSeparator = true;
            // 
            // nudRetries
            // 
            this.nudRetries.Location = new System.Drawing.Point(131, 45);
            this.nudRetries.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudRetries.Name = "nudRetries";
            this.nudRetries.Size = new System.Drawing.Size(82, 22);
            this.nudRetries.TabIndex = 72;
            this.nudRetries.ThousandsSeparator = true;
            // 
            // cbRetries
            // 
            this.cbRetries.AutoSize = true;
            this.cbRetries.Location = new System.Drawing.Point(9, 46);
            this.cbRetries.Name = "cbRetries";
            this.cbRetries.Size = new System.Drawing.Size(64, 17);
            this.cbRetries.TabIndex = 68;
            this.cbRetries.Text = "Retries:";
            this.cbRetries.UseVisualStyleBackColor = true;
            // 
            // cbRetriesInf
            // 
            this.cbRetriesInf.AutoSize = true;
            this.cbRetriesInf.Location = new System.Drawing.Point(219, 47);
            this.cbRetriesInf.Name = "cbRetriesInf";
            this.cbRetriesInf.Size = new System.Drawing.Size(68, 17);
            this.cbRetriesInf.TabIndex = 67;
            this.cbRetriesInf.Text = "Infinite?";
            this.cbRetriesInf.UseVisualStyleBackColor = true;
            // 
            // cbLimitRate
            // 
            this.cbLimitRate.AutoSize = true;
            this.cbLimitRate.Location = new System.Drawing.Point(9, 20);
            this.cbLimitRate.Name = "cbLimitRate";
            this.cbLimitRate.Size = new System.Drawing.Size(79, 17);
            this.cbLimitRate.TabIndex = 60;
            this.cbLimitRate.Text = "Limit Rate:";
            this.cbLimitRate.UseVisualStyleBackColor = true;
            // 
            // cbxLimitRateUnits
            // 
            this.cbxLimitRateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLimitRateUnits.FormattingEnabled = true;
            this.cbxLimitRateUnits.Location = new System.Drawing.Point(219, 18);
            this.cbxLimitRateUnits.Name = "cbxLimitRateUnits";
            this.cbxLimitRateUnits.Size = new System.Drawing.Size(42, 21);
            this.cbxLimitRateUnits.TabIndex = 60;
            // 
            // cbUserAgent
            // 
            this.cbUserAgent.AutoSize = true;
            this.cbUserAgent.Location = new System.Drawing.Point(6, 36);
            this.cbUserAgent.Name = "cbUserAgent";
            this.cbUserAgent.Size = new System.Drawing.Size(86, 17);
            this.cbUserAgent.TabIndex = 70;
            this.cbUserAgent.Text = "User Agent:";
            this.cbUserAgent.UseVisualStyleBackColor = true;
            // 
            // txtReferer
            // 
            this.txtReferer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferer.Location = new System.Drawing.Point(135, 6);
            this.txtReferer.Name = "txtReferer";
            this.txtReferer.Size = new System.Drawing.Size(982, 22);
            this.txtReferer.TabIndex = 68;
            // 
            // cbReferer
            // 
            this.cbReferer.AutoSize = true;
            this.cbReferer.Location = new System.Drawing.Point(6, 8);
            this.cbReferer.Name = "cbReferer";
            this.cbReferer.Size = new System.Drawing.Size(66, 17);
            this.cbReferer.TabIndex = 67;
            this.cbReferer.Text = "Referer:";
            this.cbReferer.UseVisualStyleBackColor = true;
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserAgent.Location = new System.Drawing.Point(135, 34);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(982, 22);
            this.txtUserAgent.TabIndex = 69;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newToolStripMenuItem.Text = "New preset...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.openToolStripMenuItem.Text = "Open preset...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveToolStripMenuItem.Text = "Save preset";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveAsToolStripMenuItem.Text = "Save preset as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.optionsToolStripMenuItem.Text = "Preferences";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.optionsToolStripMenuItem1.Text = "Options...";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.wikiToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Enabled = false;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates...";
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wikiToolStripMenuItem.Text = "Wiki...";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.wikiToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 534);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1145, 573);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YDL v1.3.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.tabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.gbVideoSelectionPlaylistSelection.ResumeLayout(false);
            this.gbVideoSelectionPlaylistSelection.PerformLayout();
            this.gbFilesystem.ResumeLayout(false);
            this.gbFilesystem.PerformLayout();
            this.gbVideoSelection.ResumeLayout(false);
            this.gbVideoSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilesizeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilesizeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDownloads)).EndInit();
            this.gbVideoSelectionPlaylist.ResumeLayout(false);
            this.gbVideoSelectionPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).EndInit();
            this.gbFrameRate.ResumeLayout(false);
            this.gbFrameRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFpsCustom)).EndInit();
            this.gbVideoQuality.ResumeLayout(false);
            this.gbVideoQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityWidth)).EndInit();
            this.tpWorkarounds.ResumeLayout(false);
            this.tpWorkarounds.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketTimeout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepRangeMin)).EndInit();
            this.gbDownload.ResumeLayout(false);
            this.gbDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFragmentRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetries)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.TabPage tpWorkarounds;
        private System.Windows.Forms.GroupBox gbDownload;
        private System.Windows.Forms.NumericUpDown nudLimitRate;
        private System.Windows.Forms.NumericUpDown nudRetries;
        private System.Windows.Forms.CheckBox cbRetries;
        private System.Windows.Forms.CheckBox cbRetriesInf;
        private System.Windows.Forms.CheckBox cbLimitRate;
        private System.Windows.Forms.ComboBox cbxLimitRateUnits;
        private System.Windows.Forms.CheckBox cbUserAgent;
        private System.Windows.Forms.TextBox txtReferer;
        private System.Windows.Forms.CheckBox cbReferer;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TextBox txtDownloadDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFileTemplate;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseDownloadDirectory;
        private System.Windows.Forms.CheckBox cbVqFallback;
        private System.Windows.Forms.GroupBox gbFrameRate;
        private System.Windows.Forms.CheckBox cbFpsFallback;
        private System.Windows.Forms.CheckBox cbFpsPreferred;
        private System.Windows.Forms.RadioButton rbFps25;
        private System.Windows.Forms.RadioButton rbFps30;
        private System.Windows.Forms.RadioButton rbFps60;
        private System.Windows.Forms.RadioButton rbFps120;
        private System.Windows.Forms.RadioButton rbFps144;
        private System.Windows.Forms.GroupBox gbVideoQuality;
        private System.Windows.Forms.CheckBox cbVqPreferred;
        private System.Windows.Forms.RadioButton rbVq360p;
        private System.Windows.Forms.RadioButton rbVq480p;
        private System.Windows.Forms.RadioButton rbVq720p;
        private System.Windows.Forms.RadioButton rbVq1080p;
        private System.Windows.Forms.RadioButton rbVq1440p;
        private System.Windows.Forms.RadioButton rbVq2160p;
        private System.Windows.Forms.NumericUpDown nudFpsCustom;
        private System.Windows.Forms.RadioButton rbFpsCustom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudVideoQualityHeight;
        private System.Windows.Forms.NumericUpDown nudVideoQualityWidth;
        private System.Windows.Forms.RadioButton rbVqCustom;
        private System.Windows.Forms.NumericUpDown nudFragmentRetries;
        private System.Windows.Forms.CheckBox cbFragmentRetries;
        private System.Windows.Forms.CheckBox cbFragmentRetriesInf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSleepRangeMax;
        private System.Windows.Forms.NumericUpDown nudSleepRangeMin;
        private System.Windows.Forms.RadioButton rbSleepRange;
        private System.Windows.Forms.RadioButton rbSleepValue;
        private System.Windows.Forms.RadioButton rbSleepDefault;
        private System.Windows.Forms.GroupBox gbVideoSelection;
        private System.Windows.Forms.CheckBox cbFilesizeMax;
        private System.Windows.Forms.NumericUpDown nudFilesizeMax;
        private System.Windows.Forms.GroupBox gbVideoSelectionPlaylistSelection;
        private System.Windows.Forms.RadioButton rbPlaylistAndVideo;
        private System.Windows.Forms.RadioButton rbVideoOnly;
        private System.Windows.Forms.RadioButton rbPlaylistOnly;
        private System.Windows.Forms.NumericUpDown nudFilesizeMin;
        private System.Windows.Forms.NumericUpDown nudViewRangeMax;
        private System.Windows.Forms.CheckBox cbMaxViews;
        private System.Windows.Forms.NumericUpDown nudViewRangeMin;
        private System.Windows.Forms.NumericUpDown nudAgeLimit;
        private System.Windows.Forms.NumericUpDown nudMaxDownloads;
        private System.Windows.Forms.ComboBox cbxFilesizeMinUnits;
        private System.Windows.Forms.ComboBox cbxFilesizeMaxUnits;
        private System.Windows.Forms.CheckBox cbAgeLimit;
        private System.Windows.Forms.CheckBox cbMinViews;
        private System.Windows.Forms.CheckBox cbFilesizeMin;
        private System.Windows.Forms.CheckBox cbDateBefore;
        private System.Windows.Forms.DateTimePicker dtpDateBefore;
        private System.Windows.Forms.CheckBox cbDateAfter;
        private System.Windows.Forms.DateTimePicker dtpDateAfter;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox gbVideoSelectionPlaylist;
        private System.Windows.Forms.NumericUpDown nudPlaylistEnd;
        private System.Windows.Forms.NumericUpDown nudPlaylistStart;
        private System.Windows.Forms.CheckBox cbPlaylistRange;
        private System.Windows.Forms.CheckBox cbPlaylistReversed;
        private System.Windows.Forms.CheckBox cbPlaylistRandom;
        private System.Windows.Forms.CheckBox cbPlaylistStart;
        private System.Windows.Forms.CheckBox cbPlaylistEnd;
        private System.Windows.Forms.CheckBox cbMaxDownloads;
        private System.Windows.Forms.CheckBox cbRejectTitle;
        private System.Windows.Forms.CheckBox cbMatchTitle;
        private System.Windows.Forms.TextBox txtRejectTitle;
        private System.Windows.Forms.TextBox txtMatchTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSocketTimeout;
        private System.Windows.Forms.NumericUpDown nudSocketTimeout;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.CheckBox cbProxy;
        private System.Windows.Forms.TextBox txtSourceAddress;
        private System.Windows.Forms.CheckBox cbSourceAddress;
        private System.Windows.Forms.RadioButton rbAny;
        private System.Windows.Forms.RadioButton rbForceIpv6;
        private System.Windows.Forms.RadioButton rbForceIpv4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbFilesystem;
        private System.Windows.Forms.CheckBox cbWriteAnnotations;
        private System.Windows.Forms.CheckBox cbWriteDescription;
        private System.Windows.Forms.CheckBox cbNoOverwrites;
        private System.Windows.Forms.CheckBox cbRestrictFilenames;
        private System.Windows.Forms.CheckBox cbAbortOnErrors;
        private System.Windows.Forms.CheckBox cbIgnoreErrors;
        private System.Windows.Forms.NumericUpDown nudSleepValue;
        private System.Windows.Forms.CheckBox cbMarkWatched;
        private System.Windows.Forms.TextBox txtCustomFormatSelector;
        private System.Windows.Forms.CheckBox cbCustomFormatSelector;
        private System.Windows.Forms.CheckBox cbOutputFormat;
        private System.Windows.Forms.ComboBox cbxOutputFormat;
        private System.Windows.Forms.TextBox txtTwoFactor;
        private System.Windows.Forms.CheckBox cbTwoFactor;
        private System.Windows.Forms.TextBox txtVideoPassword;
        private System.Windows.Forms.CheckBox cbVideoPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox cbUsernamePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.RadioButton rbVq240p;
        private System.Windows.Forms.DataGridView dgvHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbWriteThumbnail;
        private System.Windows.Forms.Button btnOpenPlaylistItemsEditor;
        private Controls.NumberTextBox txtPlaylistRange;
        private System.Windows.Forms.TextBox txtCommand;
        private Controls.KeywordTextBox txtFileTemplate;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbRecodeFormat;
        private System.Windows.Forms.ComboBox cbxRecodeFormat;
        private System.Windows.Forms.Button btnOpenUrlEditor;
        private System.Windows.Forms.CheckBox cbMatchFilter;
        private System.Windows.Forms.TextBox txtMatchFilter;
        private System.Windows.Forms.CheckBox cbDownloadArchive;
        private System.Windows.Forms.Button btnBrowseDownloadArchive;
        private System.Windows.Forms.TextBox txtDownloadArchive;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

