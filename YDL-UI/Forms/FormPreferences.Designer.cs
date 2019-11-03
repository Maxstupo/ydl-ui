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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.tablessTabControl = new Maxstupo.YdlUi.Controls.TablessTabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.cbPromptOnClose = new System.Windows.Forms.CheckBox();
            this.cbUseBasicFolderPicker = new System.Windows.Forms.CheckBox();
            this.cbStayTop = new System.Windows.Forms.CheckBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.tpDownload = new System.Windows.Forms.TabPage();
            this.cbAutoStartDragDropDownloads = new System.Windows.Forms.CheckBox();
            this.cbRememberDownloadSettings = new System.Windows.Forms.CheckBox();
            this.cbResumeDownload = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDefaultDownloadDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDownloadDirectory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefaultDownloadArchive = new System.Windows.Forms.TextBox();
            this.btnBrowseDownloadArchive = new System.Windows.Forms.Button();
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.nudMaxConcurrentDownloads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBinaries = new System.Windows.Forms.TabPage();
            this.gbManualUpdate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateYoutubeDl = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.tablessTabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).BeginInit();
            this.tpBinaries.SuspendLayout();
            this.gbManualUpdate.SuspendLayout();
            this.tpPresets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.btnCancel.Tag = "@dialog.cancel";
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
            this.btnOkay.Tag = "okay";
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
            this.splitContainer1.Panel1.Tag = "!ignore";
            this.splitContainer1.Panel1MinSize = 75;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCategory);
            this.splitContainer1.Panel2.Controls.Add(this.tablessTabControl);
            this.splitContainer1.Panel2.Tag = "#";
            this.splitContainer1.Size = new System.Drawing.Size(642, 347);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Tag = "#";
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
            this.lblCategory.Tag = "!ignore";
            this.lblCategory.Text = "Category";
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
            this.panelActions.Tag = "#";
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
            this.tablessTabControl.Location = new System.Drawing.Point(2, 25);
            this.tablessTabControl.Name = "tablessTabControl";
            this.tablessTabControl.SelectedIndex = 0;
            this.tablessTabControl.Size = new System.Drawing.Size(464, 322);
            this.tablessTabControl.TabIndex = 0;
            this.tablessTabControl.Tag = "#";
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.tableLayoutPanel1);
            this.tpGeneral.Controls.Add(this.cbPromptOnClose);
            this.tpGeneral.Controls.Add(this.cbUseBasicFolderPicker);
            this.tpGeneral.Controls.Add(this.cbStayTop);
            this.tpGeneral.Controls.Add(this.cbCheckForUpdates);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(456, 296);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Tag = "general";
            this.tpGeneral.Text = "General";
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(0, 7);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Tag = "language";
            this.lblLanguage.Text = "Language:";
            this.toolTip.SetToolTip(this.lblLanguage, "The user interface language.");
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Location = new System.Drawing.Point(64, 3);
            this.cbxLanguage.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(148, 21);
            this.cbxLanguage.TabIndex = 4;
            this.cbxLanguage.Tag = "language.dropdown";
            this.toolTip.SetToolTip(this.cbxLanguage, "The user interface language.");
            // 
            // cbPromptOnClose
            // 
            this.cbPromptOnClose.AutoSize = true;
            this.cbPromptOnClose.Location = new System.Drawing.Point(6, 90);
            this.cbPromptOnClose.Name = "cbPromptOnClose";
            this.cbPromptOnClose.Size = new System.Drawing.Size(111, 17);
            this.cbPromptOnClose.TabIndex = 3;
            this.cbPromptOnClose.Tag = "prompt_on_close";
            this.cbPromptOnClose.Text = "Prompt on Close";
            this.toolTip.SetToolTip(this.cbPromptOnClose, "If any downloads are still running, prompt for confirmation when closing.");
            this.cbPromptOnClose.UseVisualStyleBackColor = true;
            // 
            // cbUseBasicFolderPicker
            // 
            this.cbUseBasicFolderPicker.AutoSize = true;
            this.cbUseBasicFolderPicker.Location = new System.Drawing.Point(6, 123);
            this.cbUseBasicFolderPicker.Name = "cbUseBasicFolderPicker";
            this.cbUseBasicFolderPicker.Size = new System.Drawing.Size(143, 17);
            this.cbUseBasicFolderPicker.TabIndex = 2;
            this.cbUseBasicFolderPicker.Tag = "use_basic_folder_picker";
            this.cbUseBasicFolderPicker.Text = "Use Basic Folder Picker";
            this.toolTip.SetToolTip(this.cbUseBasicFolderPicker, "If checked, the basic folder picker will be used. Potentially fixes certain DPI s" +
        "caling issues.");
            this.cbUseBasicFolderPicker.UseVisualStyleBackColor = true;
            // 
            // cbStayTop
            // 
            this.cbStayTop.AutoSize = true;
            this.cbStayTop.Location = new System.Drawing.Point(6, 67);
            this.cbStayTop.Name = "cbStayTop";
            this.cbStayTop.Size = new System.Drawing.Size(85, 17);
            this.cbStayTop.TabIndex = 1;
            this.cbStayTop.Tag = "stay_on_top";
            this.cbStayTop.Text = "Stay on top";
            this.toolTip.SetToolTip(this.cbStayTop, "Keep application in front of other windows.");
            this.cbStayTop.UseVisualStyleBackColor = true;
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(6, 44);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(121, 17);
            this.cbCheckForUpdates.TabIndex = 0;
            this.cbCheckForUpdates.Tag = "updates";
            this.cbCheckForUpdates.Text = "Check for Updates";
            this.toolTip.SetToolTip(this.cbCheckForUpdates, "Check for updates on start, prompt only if new updates are available.");
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // tpDownload
            // 
            this.tpDownload.Controls.Add(this.tableLayoutPanel2);
            this.tpDownload.Controls.Add(this.cbAutoStartDragDropDownloads);
            this.tpDownload.Controls.Add(this.cbRememberDownloadSettings);
            this.tpDownload.Controls.Add(this.cbResumeDownload);
            this.tpDownload.Controls.Add(this.label6);
            this.tpDownload.Controls.Add(this.txtDefaultDownloadDirectory);
            this.tpDownload.Controls.Add(this.btnBrowseDownloadDirectory);
            this.tpDownload.Controls.Add(this.label5);
            this.tpDownload.Controls.Add(this.txtDefaultDownloadArchive);
            this.tpDownload.Controls.Add(this.btnBrowseDownloadArchive);
            this.tpDownload.Controls.Add(this.cbBasicMode);
            this.tpDownload.Location = new System.Drawing.Point(4, 22);
            this.tpDownload.Name = "tpDownload";
            this.tpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownload.Size = new System.Drawing.Size(456, 296);
            this.tpDownload.TabIndex = 1;
            this.tpDownload.Tag = "download";
            this.tpDownload.Text = "Download";
            this.tpDownload.UseVisualStyleBackColor = true;
            // 
            // cbAutoStartDragDropDownloads
            // 
            this.cbAutoStartDragDropDownloads.AutoSize = true;
            this.cbAutoStartDragDropDownloads.Location = new System.Drawing.Point(6, 75);
            this.cbAutoStartDragDropDownloads.Name = "cbAutoStartDragDropDownloads";
            this.cbAutoStartDragDropDownloads.Size = new System.Drawing.Size(209, 17);
            this.cbAutoStartDragDropDownloads.TabIndex = 12;
            this.cbAutoStartDragDropDownloads.Tag = "auto_dragdrop_downloads";
            this.cbAutoStartDragDropDownloads.Text = "Auto confirm DragDrop Downloads";
            this.toolTip.SetToolTip(this.cbAutoStartDragDropDownloads, "Auto-confirms the download dialog for downloads that were dragged and dropped.");
            this.cbAutoStartDragDropDownloads.UseVisualStyleBackColor = true;
            // 
            // cbRememberDownloadSettings
            // 
            this.cbRememberDownloadSettings.AutoSize = true;
            this.cbRememberDownloadSettings.Location = new System.Drawing.Point(6, 52);
            this.cbRememberDownloadSettings.Name = "cbRememberDownloadSettings";
            this.cbRememberDownloadSettings.Size = new System.Drawing.Size(182, 17);
            this.cbRememberDownloadSettings.TabIndex = 11;
            this.cbRememberDownloadSettings.Tag = "remember_download_settings";
            this.cbRememberDownloadSettings.Text = "Remember Download Settings";
            this.toolTip.SetToolTip(this.cbRememberDownloadSettings, "Provides access to a preset that remembers the previous download settings.");
            this.cbRememberDownloadSettings.UseVisualStyleBackColor = true;
            // 
            // cbResumeDownload
            // 
            this.cbResumeDownload.AutoSize = true;
            this.cbResumeDownload.Location = new System.Drawing.Point(6, 29);
            this.cbResumeDownload.Name = "cbResumeDownload";
            this.cbResumeDownload.Size = new System.Drawing.Size(186, 17);
            this.cbResumeDownload.TabIndex = 2;
            this.cbResumeDownload.Tag = "resume_downloads_on_startup";
            this.cbResumeDownload.Text = "Resume Downloads on Startup";
            this.toolTip.SetToolTip(this.cbResumeDownload, "Resume incomplete downloads on startup.");
            this.cbResumeDownload.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 8;
            this.label6.Tag = "default_download_directory";
            this.label6.Text = "Default Download Directory";
            this.toolTip.SetToolTip(this.label6, "The default download directory path when adding a download.");
            // 
            // txtDefaultDownloadDirectory
            // 
            this.txtDefaultDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadDirectory.Location = new System.Drawing.Point(6, 233);
            this.txtDefaultDownloadDirectory.Name = "txtDefaultDownloadDirectory";
            this.txtDefaultDownloadDirectory.Size = new System.Drawing.Size(408, 22);
            this.txtDefaultDownloadDirectory.TabIndex = 9;
            this.txtDefaultDownloadDirectory.Tag = "default_download_directory.value";
            this.toolTip.SetToolTip(this.txtDefaultDownloadDirectory, "The default download directory path when adding a download.");
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(420, 233);
            this.btnBrowseDownloadDirectory.Name = "btnBrowseDownloadDirectory";
            this.btnBrowseDownloadDirectory.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseDownloadDirectory.TabIndex = 10;
            this.btnBrowseDownloadDirectory.Tag = "@browse";
            this.btnBrowseDownloadDirectory.Text = "...";
            this.btnBrowseDownloadDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadDirectory.Click += new System.EventHandler(this.btnDefaultDownloadDirectoryBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 5;
            this.label5.Tag = "default_download_archive";
            this.label5.Text = "Default Download Archive";
            this.toolTip.SetToolTip(this.label5, "The default download archive filepath when adding a download.");
            // 
            // txtDefaultDownloadArchive
            // 
            this.txtDefaultDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadArchive.Location = new System.Drawing.Point(6, 176);
            this.txtDefaultDownloadArchive.Name = "txtDefaultDownloadArchive";
            this.txtDefaultDownloadArchive.Size = new System.Drawing.Size(408, 22);
            this.txtDefaultDownloadArchive.TabIndex = 6;
            this.txtDefaultDownloadArchive.Tag = "default_download_archive.value";
            this.toolTip.SetToolTip(this.txtDefaultDownloadArchive, "The default download archive filepath when adding a download.");
            // 
            // btnBrowseDownloadArchive
            // 
            this.btnBrowseDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadArchive.Location = new System.Drawing.Point(420, 176);
            this.btnBrowseDownloadArchive.Name = "btnBrowseDownloadArchive";
            this.btnBrowseDownloadArchive.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseDownloadArchive.TabIndex = 7;
            this.btnBrowseDownloadArchive.Tag = "@browse";
            this.btnBrowseDownloadArchive.Text = "...";
            this.btnBrowseDownloadArchive.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadArchive.Click += new System.EventHandler(this.btnDefaultDownloadArchiveBrowse_Click);
            // 
            // cbBasicMode
            // 
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(6, 6);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(85, 17);
            this.cbBasicMode.TabIndex = 1;
            this.cbBasicMode.Tag = "mode";
            this.cbBasicMode.Text = "Basic Mode";
            this.toolTip.SetToolTip(this.cbBasicMode, "Use a basic interface for the Download dialog.");
            this.cbBasicMode.UseVisualStyleBackColor = true;
            // 
            // nudMaxConcurrentDownloads
            // 
            this.nudMaxConcurrentDownloads.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudMaxConcurrentDownloads.Location = new System.Drawing.Point(157, 3);
            this.nudMaxConcurrentDownloads.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
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
            this.nudMaxConcurrentDownloads.Tag = "max_concurrent_downloads.value";
            this.toolTip.SetToolTip(this.nudMaxConcurrentDownloads, "The max simultaneous downloads allowed to download at once.");
            this.nudMaxConcurrentDownloads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "max_concurrent_downloads";
            this.label1.Text = "Max Concurrent Downloads:";
            this.toolTip.SetToolTip(this.label1, "The max simultaneous downloads allowed to download at once.");
            // 
            // tpBinaries
            // 
            this.tpBinaries.Controls.Add(this.tableLayoutPanel3);
            this.tpBinaries.Controls.Add(this.gbManualUpdate);
            this.tpBinaries.Location = new System.Drawing.Point(4, 22);
            this.tpBinaries.Name = "tpBinaries";
            this.tpBinaries.Padding = new System.Windows.Forms.Padding(3);
            this.tpBinaries.Size = new System.Drawing.Size(456, 296);
            this.tpBinaries.TabIndex = 2;
            this.tpBinaries.Tag = "binaries";
            this.tpBinaries.Text = "Binaries";
            this.tpBinaries.UseVisualStyleBackColor = true;
            // 
            // gbManualUpdate
            // 
            this.gbManualUpdate.Controls.Add(this.label4);
            this.gbManualUpdate.Controls.Add(this.btnUpdateYoutubeDl);
            this.gbManualUpdate.Location = new System.Drawing.Point(1, 149);
            this.gbManualUpdate.Name = "gbManualUpdate";
            this.gbManualUpdate.Size = new System.Drawing.Size(171, 83);
            this.gbManualUpdate.TabIndex = 8;
            this.gbManualUpdate.TabStop = false;
            this.gbManualUpdate.Tag = "manual_update";
            this.gbManualUpdate.Text = "Manual Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Tag = "youtube-dl";
            this.label4.Text = "youtube-dl:";
            // 
            // btnUpdateYoutubeDl
            // 
            this.btnUpdateYoutubeDl.Location = new System.Drawing.Point(79, 20);
            this.btnUpdateYoutubeDl.Name = "btnUpdateYoutubeDl";
            this.btnUpdateYoutubeDl.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateYoutubeDl.TabIndex = 0;
            this.btnUpdateYoutubeDl.Tag = "update";
            this.btnUpdateYoutubeDl.Text = "Update";
            this.btnUpdateYoutubeDl.UseVisualStyleBackColor = true;
            this.btnUpdateYoutubeDl.Click += new System.EventHandler(this.btnUpdateYoutubeDl_Click);
            // 
            // lblRestartNote
            // 
            this.lblRestartNote.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.lblRestartNote, 3);
            this.lblRestartNote.Location = new System.Drawing.Point(2, 64);
            this.lblRestartNote.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.lblRestartNote.Name = "lblRestartNote";
            this.lblRestartNote.Size = new System.Drawing.Size(301, 13);
            this.lblRestartNote.TabIndex = 6;
            this.lblRestartNote.Tag = "note_restart";
            this.lblRestartNote.Text = "Changing binary paths requires {ProductName} to restart.";
            // 
            // btnBinaryBrowseYdl
            // 
            this.btnBinaryBrowseYdl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBinaryBrowseYdl.Location = new System.Drawing.Point(419, 3);
            this.btnBinaryBrowseYdl.Name = "btnBinaryBrowseYdl";
            this.btnBinaryBrowseYdl.Size = new System.Drawing.Size(36, 23);
            this.btnBinaryBrowseYdl.TabIndex = 2;
            this.btnBinaryBrowseYdl.Tag = "@browse";
            this.btnBinaryBrowseYdl.Text = "...";
            this.btnBinaryBrowseYdl.UseVisualStyleBackColor = true;
            this.btnBinaryBrowseYdl.Click += new System.EventHandler(this.btnBrowseYdl_Click);
            // 
            // txtBinaryFfmpeg
            // 
            this.txtBinaryFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryFfmpeg.Location = new System.Drawing.Point(76, 32);
            this.txtBinaryFfmpeg.Name = "txtBinaryFfmpeg";
            this.txtBinaryFfmpeg.Size = new System.Drawing.Size(337, 22);
            this.txtBinaryFfmpeg.TabIndex = 4;
            this.txtBinaryFfmpeg.Tag = "ffmpeg.value";
            this.toolTip.SetToolTip(this.txtBinaryFfmpeg, "The filepath to ffmpeg.");
            // 
            // btnBinaryBrowseFfmpeg
            // 
            this.btnBinaryBrowseFfmpeg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBinaryBrowseFfmpeg.Location = new System.Drawing.Point(419, 32);
            this.btnBinaryBrowseFfmpeg.Name = "btnBinaryBrowseFfmpeg";
            this.btnBinaryBrowseFfmpeg.Size = new System.Drawing.Size(36, 23);
            this.btnBinaryBrowseFfmpeg.TabIndex = 5;
            this.btnBinaryBrowseFfmpeg.Tag = "@browse";
            this.btnBinaryBrowseFfmpeg.Text = "...";
            this.btnBinaryBrowseFfmpeg.UseVisualStyleBackColor = true;
            this.btnBinaryBrowseFfmpeg.Click += new System.EventHandler(this.btnBrowseFfmpeg_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Tag = "ffmpeg";
            this.label3.Text = "ffmpeg:";
            this.toolTip.SetToolTip(this.label3, "The filepath to ffmpeg.");
            // 
            // txtBinaryYdl
            // 
            this.txtBinaryYdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryYdl.Location = new System.Drawing.Point(76, 3);
            this.txtBinaryYdl.Name = "txtBinaryYdl";
            this.txtBinaryYdl.Size = new System.Drawing.Size(337, 22);
            this.txtBinaryYdl.TabIndex = 1;
            this.txtBinaryYdl.Tag = "youtube-dl.value";
            this.toolTip.SetToolTip(this.txtBinaryYdl, "The filepath to youtube-dl.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Tag = "youtube-dl";
            this.label2.Text = "youtube-dl:";
            this.toolTip.SetToolTip(this.label2, "The filepath to youtube-dl.");
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
            this.tpPresets.Tag = "presets";
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
            this.btnPresetEdit.Tag = "edit";
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
            this.btnPresetAdd.Tag = "add";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblLanguage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxLanguage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 27);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudMaxConcurrentDownloads, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 28);
            this.tableLayoutPanel2.TabIndex = 13;
            this.tableLayoutPanel2.Tag = "#$";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblRestartNote, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBinaryFfmpeg, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBinaryBrowseFfmpeg, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBinaryBrowseYdl, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtBinaryYdl, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(458, 124);
            this.tableLayoutPanel3.TabIndex = 9;
            this.tableLayoutPanel3.Tag = "#$";
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
            this.Tag = "settings_dialog";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormPreferences_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.tablessTabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpDownload.ResumeLayout(false);
            this.tpDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).EndInit();
            this.tpBinaries.ResumeLayout(false);
            this.gbManualUpdate.ResumeLayout(false);
            this.gbManualUpdate.PerformLayout();
            this.tpPresets.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
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
        private System.Windows.Forms.TabPage tpPresets;
        private System.Windows.Forms.ListBox lbxPresets;
        private System.Windows.Forms.Button btnPresetAdd;
        private System.Windows.Forms.Button btnPresetEdit;
        private System.Windows.Forms.CheckBox cbBasicMode;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.CheckBox cbStayTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDefaultDownloadDirectory;
        private System.Windows.Forms.Button btnBrowseDownloadDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefaultDownloadArchive;
        private System.Windows.Forms.Button btnBrowseDownloadArchive;
        private System.Windows.Forms.CheckBox cbResumeDownload;
        private System.Windows.Forms.GroupBox gbManualUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateYoutubeDl;
        private System.Windows.Forms.CheckBox cbRememberDownloadSettings;
        private System.Windows.Forms.CheckBox cbUseBasicFolderPicker;
        private System.Windows.Forms.CheckBox cbPromptOnClose;
        private System.Windows.Forms.CheckBox cbAutoStartDragDropDownloads;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}