namespace Maxstupo.YdlUi.Forms {
    partial class FormPreferences {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreferences));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.cbPromptOnClose = new System.Windows.Forms.CheckBox();
            this.nudMaxConcurrentDownloads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResumeDownload = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tablessTabControl = new Maxstupo.YdlUi.Controls.TablessTabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.cbStayTop = new System.Windows.Forms.CheckBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.tpDownload = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDefaultDownloadDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDownloadDirectory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefaultDownloadArchive = new System.Windows.Forms.TextBox();
            this.btnBrowseDownloadArchive = new System.Windows.Forms.Button();
            this.tpBinaries = new System.Windows.Forms.TabPage();
            this.lblBlankEmbeddedNote = new System.Windows.Forms.Label();
            this.lblRestartNote = new System.Windows.Forms.Label();
            this.btnBinaryBrowseYdl = new System.Windows.Forms.Button();
            this.txtBinaryFfmpeg = new System.Windows.Forms.TextBox();
            this.btnBinaryBrowseFfmpeg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBinaryYdl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPresets = new System.Windows.Forms.TabPage();
            this.btnPresetEdit = new System.Windows.Forms.Button();
            this.btnPresetAdd = new System.Windows.Forms.Button();
            this.lbxPresets = new System.Windows.Forms.ListBox();
            this.tpInformation = new System.Windows.Forms.TabPage();
            this.llblFfmpegDirectory = new System.Windows.Forms.LinkLabel();
            this.llblYdlDirectory = new System.Windows.Forms.LinkLabel();
            this.llblPreferencesLocation = new System.Windows.Forms.LinkLabel();
            this.panelActions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tablessTabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpDownload.SuspendLayout();
            this.tpBinaries.SuspendLayout();
            this.tpPresets.SuspendLayout();
            this.tpInformation.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(573, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.Location = new System.Drawing.Point(492, 9);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "O&kay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // cbBasicMode
            // 
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(6, 29);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(85, 17);
            this.cbBasicMode.TabIndex = 1;
            this.cbBasicMode.Text = "Basic Mode";
            this.toolTip.SetToolTip(this.cbBasicMode, "Use a basic interface for the Download dialog.");
            this.cbBasicMode.UseVisualStyleBackColor = true;
            // 
            // cbPromptOnClose
            // 
            this.cbPromptOnClose.AutoSize = true;
            this.cbPromptOnClose.Location = new System.Drawing.Point(6, 6);
            this.cbPromptOnClose.Name = "cbPromptOnClose";
            this.cbPromptOnClose.Size = new System.Drawing.Size(111, 17);
            this.cbPromptOnClose.TabIndex = 0;
            this.cbPromptOnClose.Text = "Prompt on Close";
            this.toolTip.SetToolTip(this.cbPromptOnClose, "If any downloads are still running, prompt for confirmation when closing.");
            this.cbPromptOnClose.UseVisualStyleBackColor = true;
            // 
            // nudMaxConcurrentDownloads
            // 
            this.nudMaxConcurrentDownloads.Location = new System.Drawing.Point(163, 82);
            this.nudMaxConcurrentDownloads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxConcurrentDownloads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxConcurrentDownloads.Name = "nudMaxConcurrentDownloads";
            this.nudMaxConcurrentDownloads.Size = new System.Drawing.Size(79, 22);
            this.nudMaxConcurrentDownloads.TabIndex = 4;
            this.toolTip.SetToolTip(this.nudMaxConcurrentDownloads, "The max simultaneous downloads allowed to download at once.");
            this.nudMaxConcurrentDownloads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Concurrent Downloads:";
            this.toolTip.SetToolTip(this.label1, "The max simultaneous downloads allowed to download at once.");
            // 
            // cbResumeDownload
            // 
            this.cbResumeDownload.AutoSize = true;
            this.cbResumeDownload.Location = new System.Drawing.Point(6, 52);
            this.cbResumeDownload.Name = "cbResumeDownload";
            this.cbResumeDownload.Size = new System.Drawing.Size(186, 17);
            this.cbResumeDownload.TabIndex = 2;
            this.cbResumeDownload.Text = "Resume Downloads on Startup";
            this.toolTip.SetToolTip(this.cbResumeDownload, "Resume incomplete downloads on startup.");
            this.cbResumeDownload.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbxCategories);
            this.splitContainer1.Panel1MinSize = 75;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCategory);
            this.splitContainer1.Panel2.Controls.Add(this.tablessTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(642, 347);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbxCategories
            // 
            this.lbxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.IntegralHeight = false;
            this.lbxCategories.ItemHeight = 20;
            this.lbxCategories.Location = new System.Drawing.Point(0, 0);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(169, 347);
            this.lbxCategories.TabIndex = 0;
            this.lbxCategories.SelectedIndexChanged += new System.EventHandler(this.lbxCategories_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(2, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 21);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // tablessTabControl
            // 
            this.tablessTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablessTabControl.Controls.Add(this.tpGeneral);
            this.tablessTabControl.Controls.Add(this.tpDownload);
            this.tablessTabControl.Controls.Add(this.tpBinaries);
            this.tablessTabControl.Controls.Add(this.tpPresets);
            this.tablessTabControl.Controls.Add(this.tpInformation);
            this.tablessTabControl.Location = new System.Drawing.Point(2, 25);
            this.tablessTabControl.Name = "tablessTabControl";
            this.tablessTabControl.SelectedIndex = 0;
            this.tablessTabControl.Size = new System.Drawing.Size(464, 322);
            this.tablessTabControl.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.cbStayTop);
            this.tpGeneral.Controls.Add(this.cbCheckForUpdates);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(456, 296);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            // 
            // cbStayTop
            // 
            this.cbStayTop.AutoSize = true;
            this.cbStayTop.Location = new System.Drawing.Point(6, 29);
            this.cbStayTop.Name = "cbStayTop";
            this.cbStayTop.Size = new System.Drawing.Size(85, 17);
            this.cbStayTop.TabIndex = 1;
            this.cbStayTop.Text = "Stay on top";
            this.cbStayTop.UseVisualStyleBackColor = true;
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(6, 6);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(121, 17);
            this.cbCheckForUpdates.TabIndex = 0;
            this.cbCheckForUpdates.Text = "Check for Updates";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // tpDownload
            // 
            this.tpDownload.Controls.Add(this.cbResumeDownload);
            this.tpDownload.Controls.Add(this.label6);
            this.tpDownload.Controls.Add(this.txtDefaultDownloadDirectory);
            this.tpDownload.Controls.Add(this.btnBrowseDownloadDirectory);
            this.tpDownload.Controls.Add(this.label5);
            this.tpDownload.Controls.Add(this.txtDefaultDownloadArchive);
            this.tpDownload.Controls.Add(this.btnBrowseDownloadArchive);
            this.tpDownload.Controls.Add(this.cbBasicMode);
            this.tpDownload.Controls.Add(this.cbPromptOnClose);
            this.tpDownload.Controls.Add(this.nudMaxConcurrentDownloads);
            this.tpDownload.Controls.Add(this.label1);
            this.tpDownload.Location = new System.Drawing.Point(4, 22);
            this.tpDownload.Name = "tpDownload";
            this.tpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownload.Size = new System.Drawing.Size(456, 296);
            this.tpDownload.TabIndex = 1;
            this.tpDownload.Text = "Download";
            this.tpDownload.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Default Download Directory";
            // 
            // txtDefaultDownloadDirectory
            // 
            this.txtDefaultDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadDirectory.Location = new System.Drawing.Point(6, 198);
            this.txtDefaultDownloadDirectory.Name = "txtDefaultDownloadDirectory";
            this.txtDefaultDownloadDirectory.Size = new System.Drawing.Size(408, 22);
            this.txtDefaultDownloadDirectory.TabIndex = 9;
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(420, 198);
            this.btnBrowseDownloadDirectory.Name = "btnBrowseDownloadDirectory";
            this.btnBrowseDownloadDirectory.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseDownloadDirectory.TabIndex = 10;
            this.btnBrowseDownloadDirectory.Text = "...";
            this.btnBrowseDownloadDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadDirectory.Click += new System.EventHandler(this.btnDefaultDownloadDirectoryBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Default Download Archive";
            // 
            // txtDefaultDownloadArchive
            // 
            this.txtDefaultDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadArchive.Location = new System.Drawing.Point(6, 141);
            this.txtDefaultDownloadArchive.Name = "txtDefaultDownloadArchive";
            this.txtDefaultDownloadArchive.Size = new System.Drawing.Size(408, 22);
            this.txtDefaultDownloadArchive.TabIndex = 6;
            // 
            // btnBrowseDownloadArchive
            // 
            this.btnBrowseDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadArchive.Location = new System.Drawing.Point(420, 141);
            this.btnBrowseDownloadArchive.Name = "btnBrowseDownloadArchive";
            this.btnBrowseDownloadArchive.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseDownloadArchive.TabIndex = 7;
            this.btnBrowseDownloadArchive.Text = "...";
            this.btnBrowseDownloadArchive.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadArchive.Click += new System.EventHandler(this.btnDefaultDownloadArchiveBrowse_Click);
            // 
            // tpBinaries
            // 
            this.tpBinaries.Controls.Add(this.lblBlankEmbeddedNote);
            this.tpBinaries.Controls.Add(this.lblRestartNote);
            this.tpBinaries.Controls.Add(this.btnBinaryBrowseYdl);
            this.tpBinaries.Controls.Add(this.txtBinaryFfmpeg);
            this.tpBinaries.Controls.Add(this.btnBinaryBrowseFfmpeg);
            this.tpBinaries.Controls.Add(this.label3);
            this.tpBinaries.Controls.Add(this.txtBinaryYdl);
            this.tpBinaries.Controls.Add(this.label2);
            this.tpBinaries.Location = new System.Drawing.Point(4, 22);
            this.tpBinaries.Name = "tpBinaries";
            this.tpBinaries.Padding = new System.Windows.Forms.Padding(3);
            this.tpBinaries.Size = new System.Drawing.Size(456, 296);
            this.tpBinaries.TabIndex = 2;
            this.tpBinaries.Text = "Binaries";
            this.tpBinaries.UseVisualStyleBackColor = true;
            // 
            // lblBlankEmbeddedNote
            // 
            this.lblBlankEmbeddedNote.AutoSize = true;
            this.lblBlankEmbeddedNote.Location = new System.Drawing.Point(3, 101);
            this.lblBlankEmbeddedNote.Name = "lblBlankEmbeddedNote";
            this.lblBlankEmbeddedNote.Size = new System.Drawing.Size(238, 13);
            this.lblBlankEmbeddedNote.TabIndex = 7;
            this.lblBlankEmbeddedNote.Text = "Note: Leave blank to use embedded binaries.";
            // 
            // lblRestartNote
            // 
            this.lblRestartNote.AutoSize = true;
            this.lblRestartNote.Location = new System.Drawing.Point(3, 73);
            this.lblRestartNote.Name = "lblRestartNote";
            this.lblRestartNote.Size = new System.Drawing.Size(301, 13);
            this.lblRestartNote.TabIndex = 6;
            this.lblRestartNote.Text = "Changing binary paths requires {ProductName} to restart.";
            // 
            // btnBinaryBrowseYdl
            // 
            this.btnBinaryBrowseYdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBinaryBrowseYdl.Location = new System.Drawing.Point(420, 5);
            this.btnBinaryBrowseYdl.Name = "btnBinaryBrowseYdl";
            this.btnBinaryBrowseYdl.Size = new System.Drawing.Size(36, 23);
            this.btnBinaryBrowseYdl.TabIndex = 2;
            this.btnBinaryBrowseYdl.Text = "...";
            this.btnBinaryBrowseYdl.UseVisualStyleBackColor = true;
            this.btnBinaryBrowseYdl.Click += new System.EventHandler(this.btnBrowseYdl_Click);
            // 
            // txtBinaryFfmpeg
            // 
            this.txtBinaryFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryFfmpeg.Location = new System.Drawing.Point(75, 37);
            this.txtBinaryFfmpeg.Name = "txtBinaryFfmpeg";
            this.txtBinaryFfmpeg.Size = new System.Drawing.Size(339, 22);
            this.txtBinaryFfmpeg.TabIndex = 4;
            // 
            // btnBinaryBrowseFfmpeg
            // 
            this.btnBinaryBrowseFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBinaryBrowseFfmpeg.Location = new System.Drawing.Point(420, 37);
            this.btnBinaryBrowseFfmpeg.Name = "btnBinaryBrowseFfmpeg";
            this.btnBinaryBrowseFfmpeg.Size = new System.Drawing.Size(36, 23);
            this.btnBinaryBrowseFfmpeg.TabIndex = 5;
            this.btnBinaryBrowseFfmpeg.Text = "...";
            this.btnBinaryBrowseFfmpeg.UseVisualStyleBackColor = true;
            this.btnBinaryBrowseFfmpeg.Click += new System.EventHandler(this.btnBrowseFfmpeg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ffmpeg:";
            // 
            // txtBinaryYdl
            // 
            this.txtBinaryYdl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryYdl.Location = new System.Drawing.Point(75, 6);
            this.txtBinaryYdl.Name = "txtBinaryYdl";
            this.txtBinaryYdl.Size = new System.Drawing.Size(339, 22);
            this.txtBinaryYdl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "youtube-dl:";
            // 
            // tpPresets
            // 
            this.tpPresets.Controls.Add(this.btnPresetEdit);
            this.tpPresets.Controls.Add(this.btnPresetAdd);
            this.tpPresets.Controls.Add(this.lbxPresets);
            this.tpPresets.Location = new System.Drawing.Point(4, 22);
            this.tpPresets.Name = "tpPresets";
            this.tpPresets.Padding = new System.Windows.Forms.Padding(3);
            this.tpPresets.Size = new System.Drawing.Size(456, 296);
            this.tpPresets.TabIndex = 3;
            this.tpPresets.Text = "Presets";
            this.tpPresets.UseVisualStyleBackColor = true;
            // 
            // btnPresetEdit
            // 
            this.btnPresetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresetEdit.Location = new System.Drawing.Point(381, 274);
            this.btnPresetEdit.Name = "btnPresetEdit";
            this.btnPresetEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPresetEdit.TabIndex = 2;
            this.btnPresetEdit.Text = "Edit...";
            this.btnPresetEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPresetEdit.UseVisualStyleBackColor = true;
            this.btnPresetEdit.Click += new System.EventHandler(this.btnPresetEdit_Click);
            // 
            // btnPresetAdd
            // 
            this.btnPresetAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresetAdd.Location = new System.Drawing.Point(300, 274);
            this.btnPresetAdd.Name = "btnPresetAdd";
            this.btnPresetAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPresetAdd.TabIndex = 1;
            this.btnPresetAdd.Text = "Add...";
            this.btnPresetAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPresetAdd.UseVisualStyleBackColor = true;
            this.btnPresetAdd.Click += new System.EventHandler(this.btnPresetAdd_Click);
            // 
            // lbxPresets
            // 
            this.lbxPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPresets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPresets.FormattingEnabled = true;
            this.lbxPresets.IntegralHeight = false;
            this.lbxPresets.ItemHeight = 17;
            this.lbxPresets.Location = new System.Drawing.Point(0, 0);
            this.lbxPresets.Name = "lbxPresets";
            this.lbxPresets.Size = new System.Drawing.Size(456, 268);
            this.lbxPresets.TabIndex = 0;
            // 
            // tpInformation
            // 
            this.tpInformation.Controls.Add(this.llblFfmpegDirectory);
            this.tpInformation.Controls.Add(this.llblYdlDirectory);
            this.tpInformation.Controls.Add(this.llblPreferencesLocation);
            this.tpInformation.Location = new System.Drawing.Point(4, 22);
            this.tpInformation.Name = "tpInformation";
            this.tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpInformation.Size = new System.Drawing.Size(456, 296);
            this.tpInformation.TabIndex = 4;
            this.tpInformation.Text = "Information";
            this.tpInformation.UseVisualStyleBackColor = true;
            // 
            // llblFfmpegDirectory
            // 
            this.llblFfmpegDirectory.AutoSize = true;
            this.llblFfmpegDirectory.Location = new System.Drawing.Point(3, 65);
            this.llblFfmpegDirectory.Name = "llblFfmpegDirectory";
            this.llblFfmpegDirectory.Size = new System.Drawing.Size(134, 13);
            this.llblFfmpegDirectory.TabIndex = 2;
            this.llblFfmpegDirectory.TabStop = true;
            this.llblFfmpegDirectory.Text = "Open ffmpeg Directory...";
            this.llblFfmpegDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLink_Clicked);
            // 
            // llblYdlDirectory
            // 
            this.llblYdlDirectory.AutoSize = true;
            this.llblYdlDirectory.Location = new System.Drawing.Point(3, 43);
            this.llblYdlDirectory.Name = "llblYdlDirectory";
            this.llblYdlDirectory.Size = new System.Drawing.Size(154, 13);
            this.llblYdlDirectory.TabIndex = 1;
            this.llblYdlDirectory.TabStop = true;
            this.llblYdlDirectory.Text = "Open youtube-dl Directory...";
            this.llblYdlDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLink_Clicked);
            // 
            // llblPreferencesLocation
            // 
            this.llblPreferencesLocation.AutoSize = true;
            this.llblPreferencesLocation.Location = new System.Drawing.Point(3, 11);
            this.llblPreferencesLocation.Name = "llblPreferencesLocation";
            this.llblPreferencesLocation.Size = new System.Drawing.Size(128, 13);
            this.llblPreferencesLocation.TabIndex = 0;
            this.llblPreferencesLocation.TabStop = true;
            this.llblPreferencesLocation.Text = "Open Preferences File...";
            this.llblPreferencesLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLink_Clicked);
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelActions.Controls.Add(this.btnOkay);
            this.panelActions.Controls.Add(this.btnCancel);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 371);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(654, 40);
            this.panelActions.TabIndex = 1;
            // 
            // FormPreferences
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(561, 414);
            this.Name = "FormPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormPreferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tablessTabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpDownload.ResumeLayout(false);
            this.tpDownload.PerformLayout();
            this.tpBinaries.ResumeLayout(false);
            this.tpBinaries.PerformLayout();
            this.tpPresets.ResumeLayout(false);
            this.tpInformation.ResumeLayout(false);
            this.tpInformation.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.LinkLabel llblPreferencesLocation;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbxCategories;
        private System.Windows.Forms.Panel panelActions;
        private Controls.TablessTabControl tablessTabControl;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpDownload;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.NumericUpDown nudMaxConcurrentDownloads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpBinaries;
        private System.Windows.Forms.TextBox txtBinaryFfmpeg;
        private System.Windows.Forms.Button btnBinaryBrowseFfmpeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBinaryYdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinaryBrowseYdl;
        private System.Windows.Forms.Label lblRestartNote;
        private System.Windows.Forms.CheckBox cbPromptOnClose;
        private System.Windows.Forms.TabPage tpPresets;
        private System.Windows.Forms.ListBox lbxPresets;
        private System.Windows.Forms.Button btnPresetAdd;
        private System.Windows.Forms.Button btnPresetEdit;
        private System.Windows.Forms.TabPage tpInformation;
        private System.Windows.Forms.LinkLabel llblYdlDirectory;
        private System.Windows.Forms.CheckBox cbBasicMode;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.CheckBox cbStayTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDefaultDownloadDirectory;
        private System.Windows.Forms.Button btnBrowseDownloadDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefaultDownloadArchive;
        private System.Windows.Forms.Button btnBrowseDownloadArchive;
        private System.Windows.Forms.Label lblBlankEmbeddedNote;
        private System.Windows.Forms.LinkLabel llblFfmpegDirectory;
        private System.Windows.Forms.CheckBox cbResumeDownload;
    }
}