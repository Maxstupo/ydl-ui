namespace Maxstupo.YdlUi.Forms {
    partial class FormAddDownload {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDownload));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbImmediateStart = new System.Windows.Forms.CheckBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtDownloadDirectory = new System.Windows.Forms.TextBox();
            this.lblDownloadDirectory = new System.Windows.Forms.Label();
            this.btnBrowseDownloadDirectory = new System.Windows.Forms.Button();
            this.txtDownloadArchive = new System.Windows.Forms.TextBox();
            this.btnDownloadArchiveBrowse = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpVideoSelection = new System.Windows.Forms.TabPage();
            this.tpWorkarounds = new System.Windows.Forms.TabPage();
            this.tpCommandPreview = new System.Windows.Forms.TabPage();
            this.txtCommandPreview = new System.Windows.Forms.TextBox();
            this.cbDownloadArchive = new System.Windows.Forms.CheckBox();
            this.cbFilenameTemplate = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.btnInsertKeyword = new System.Windows.Forms.Button();
            this.cbxPreset = new System.Windows.Forms.ComboBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustomArguments = new System.Windows.Forms.TextBox();
            this.cbCustomArguments = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFilenameTemplate = new Maxstupo.YdlUi.Controls.KeywordTextBox();
            this.general = new Maxstupo.YdlUi.Forms.Tab.TabGeneral();
            this.videoSelection = new Maxstupo.YdlUi.Forms.Tab.TabVideoSelection();
            this.workarounds = new Maxstupo.YdlUi.Forms.Tab.TabWorkarounds();
            this.tabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpVideoSelection.SuspendLayout();
            this.tpWorkarounds.SuspendLayout();
            this.tpCommandPreview.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(700, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Tag = "@dialog.cancel";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(619, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbImmediateStart
            // 
            this.cbImmediateStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbImmediateStart.AutoSize = true;
            this.cbImmediateStart.Checked = true;
            this.cbImmediateStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbImmediateStart.Location = new System.Drawing.Point(502, 11);
            this.cbImmediateStart.Name = "cbImmediateStart";
            this.cbImmediateStart.Size = new System.Drawing.Size(111, 17);
            this.cbImmediateStart.TabIndex = 2;
            this.cbImmediateStart.Tag = "start";
            this.cbImmediateStart.Text = "&Immediate Start?";
            this.toolTip.SetToolTip(this.cbImmediateStart, "Start the download immediately upon clicking \"Add\".");
            this.cbImmediateStart.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(3, 7);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Tag = "url";
            this.lblUrl.Text = "&URL:";
            this.toolTip.SetToolTip(this.lblUrl, "The URL to download.");
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtUrl, 2);
            this.txtUrl.Location = new System.Drawing.Point(133, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(640, 22);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Tag = "url.value";
            this.toolTip.SetToolTip(this.txtUrl, "The URL to download.");
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDirectory.Location = new System.Drawing.Point(133, 31);
            this.txtDownloadDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.ReadOnly = true;
            this.txtDownloadDirectory.Size = new System.Drawing.Size(601, 22);
            this.txtDownloadDirectory.TabIndex = 3;
            this.txtDownloadDirectory.Tag = "directory.value";
            this.toolTip.SetToolTip(this.txtDownloadDirectory, "The directory to download the video to.");
            // 
            // lblDownloadDirectory
            // 
            this.lblDownloadDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDownloadDirectory.AutoSize = true;
            this.lblDownloadDirectory.Location = new System.Drawing.Point(3, 36);
            this.lblDownloadDirectory.Name = "lblDownloadDirectory";
            this.lblDownloadDirectory.Size = new System.Drawing.Size(113, 13);
            this.lblDownloadDirectory.TabIndex = 2;
            this.lblDownloadDirectory.Tag = "directory";
            this.lblDownloadDirectory.Text = "&Download Directory:";
            this.toolTip.SetToolTip(this.lblDownloadDirectory, "The directory to download the video to.");
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(737, 31);
            this.btnBrowseDownloadDirectory.Name = "btnBrowseDownloadDirectory";
            this.btnBrowseDownloadDirectory.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseDownloadDirectory.TabIndex = 4;
            this.btnBrowseDownloadDirectory.Tag = "@browse";
            this.btnBrowseDownloadDirectory.Text = "...";
            this.btnBrowseDownloadDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadDirectory.Click += new System.EventHandler(this.btnBrowseDownloadDirectory_Click);
            // 
            // txtDownloadArchive
            // 
            this.txtDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadArchive.Location = new System.Drawing.Point(133, 89);
            this.txtDownloadArchive.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtDownloadArchive.Name = "txtDownloadArchive";
            this.txtDownloadArchive.ReadOnly = true;
            this.txtDownloadArchive.Size = new System.Drawing.Size(601, 22);
            this.txtDownloadArchive.TabIndex = 8;
            this.txtDownloadArchive.Tag = "download_archive.value";
            this.toolTip.SetToolTip(this.txtDownloadArchive, "Download the video only if it\'s not listed in the archive file. \r\nUpon successful" +
        " download, the video ID will be added to the archive file.");
            // 
            // btnDownloadArchiveBrowse
            // 
            this.btnDownloadArchiveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadArchiveBrowse.Location = new System.Drawing.Point(737, 89);
            this.btnDownloadArchiveBrowse.Name = "btnDownloadArchiveBrowse";
            this.btnDownloadArchiveBrowse.Size = new System.Drawing.Size(36, 23);
            this.btnDownloadArchiveBrowse.TabIndex = 9;
            this.btnDownloadArchiveBrowse.Tag = "@browse";
            this.btnDownloadArchiveBrowse.Text = "...";
            this.btnDownloadArchiveBrowse.UseVisualStyleBackColor = true;
            this.btnDownloadArchiveBrowse.Click += new System.EventHandler(this.btnDownloadArchiveBrowse_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpGeneral);
            this.tabControl.Controls.Add(this.tpVideoSelection);
            this.tabControl.Controls.Add(this.tpWorkarounds);
            this.tabControl.Controls.Add(this.tpCommandPreview);
            this.tabControl.Location = new System.Drawing.Point(12, 121);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 409);
            this.tabControl.TabIndex = 1;
            this.tabControl.Tag = "#";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_AttemptPreviewUpdate);
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.Color.White;
            this.tpGeneral.Controls.Add(this.general);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Size = new System.Drawing.Size(766, 383);
            this.tpGeneral.TabIndex = 3;
            this.tpGeneral.Tag = "general";
            this.tpGeneral.Text = "General";
            // 
            // tpVideoSelection
            // 
            this.tpVideoSelection.BackColor = System.Drawing.Color.White;
            this.tpVideoSelection.Controls.Add(this.videoSelection);
            this.tpVideoSelection.Location = new System.Drawing.Point(4, 22);
            this.tpVideoSelection.Name = "tpVideoSelection";
            this.tpVideoSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tpVideoSelection.Size = new System.Drawing.Size(766, 383);
            this.tpVideoSelection.TabIndex = 0;
            this.tpVideoSelection.Tag = "video_selection";
            this.tpVideoSelection.Text = "Video Selection";
            // 
            // tpWorkarounds
            // 
            this.tpWorkarounds.BackColor = System.Drawing.Color.White;
            this.tpWorkarounds.Controls.Add(this.workarounds);
            this.tpWorkarounds.Location = new System.Drawing.Point(4, 22);
            this.tpWorkarounds.Name = "tpWorkarounds";
            this.tpWorkarounds.Size = new System.Drawing.Size(766, 383);
            this.tpWorkarounds.TabIndex = 2;
            this.tpWorkarounds.Tag = "workarounds";
            this.tpWorkarounds.Text = "Workarounds";
            // 
            // tpCommandPreview
            // 
            this.tpCommandPreview.Controls.Add(this.tableLayoutPanel3);
            this.tpCommandPreview.Controls.Add(this.txtCommandPreview);
            this.tpCommandPreview.Location = new System.Drawing.Point(4, 22);
            this.tpCommandPreview.Name = "tpCommandPreview";
            this.tpCommandPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tpCommandPreview.Size = new System.Drawing.Size(766, 383);
            this.tpCommandPreview.TabIndex = 4;
            this.tpCommandPreview.Tag = "preview";
            this.tpCommandPreview.Text = "Preview";
            this.tpCommandPreview.UseVisualStyleBackColor = true;
            // 
            // txtCommandPreview
            // 
            this.txtCommandPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandPreview.Location = new System.Drawing.Point(3, 3);
            this.txtCommandPreview.Multiline = true;
            this.txtCommandPreview.Name = "txtCommandPreview";
            this.txtCommandPreview.ReadOnly = true;
            this.txtCommandPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandPreview.Size = new System.Drawing.Size(760, 345);
            this.txtCommandPreview.TabIndex = 0;
            this.txtCommandPreview.Tag = "!_ignore";
            // 
            // cbDownloadArchive
            // 
            this.cbDownloadArchive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDownloadArchive.AutoSize = true;
            this.cbDownloadArchive.Location = new System.Drawing.Point(3, 92);
            this.cbDownloadArchive.Name = "cbDownloadArchive";
            this.cbDownloadArchive.Size = new System.Drawing.Size(123, 17);
            this.cbDownloadArchive.TabIndex = 7;
            this.cbDownloadArchive.Tag = "download_archive";
            this.cbDownloadArchive.Text = "Download Archive:";
            this.toolTip.SetToolTip(this.cbDownloadArchive, "Download the video only if it\'s not listed in the archive file. \r\nUpon successful" +
        " download, the video ID will be added to the archive file.");
            this.cbDownloadArchive.UseVisualStyleBackColor = true;
            // 
            // cbFilenameTemplate
            // 
            this.cbFilenameTemplate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilenameTemplate.AutoSize = true;
            this.cbFilenameTemplate.Location = new System.Drawing.Point(3, 63);
            this.cbFilenameTemplate.Name = "cbFilenameTemplate";
            this.cbFilenameTemplate.Size = new System.Drawing.Size(124, 17);
            this.cbFilenameTemplate.TabIndex = 5;
            this.cbFilenameTemplate.Tag = "filename_template";
            this.cbFilenameTemplate.Text = "Filename Template:";
            this.toolTip.SetToolTip(this.cbFilenameTemplate, "Output filename template.");
            this.cbFilenameTemplate.UseVisualStyleBackColor = true;
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
            this.cbBasicMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(3, 11);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(84, 17);
            this.cbBasicMode.TabIndex = 0;
            this.cbBasicMode.Tag = "mode";
            this.cbBasicMode.Text = "Basic Mode";
            this.toolTip.SetToolTip(this.cbBasicMode, "Use a basic interface for simple downloads.");
            this.cbBasicMode.UseVisualStyleBackColor = true;
            this.cbBasicMode.CheckedChanged += new System.EventHandler(this.cbBasicMode_CheckedChanged);
            // 
            // btnInsertKeyword
            // 
            this.btnInsertKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertKeyword.Location = new System.Drawing.Point(737, 60);
            this.btnInsertKeyword.Name = "btnInsertKeyword";
            this.btnInsertKeyword.Size = new System.Drawing.Size(36, 23);
            this.btnInsertKeyword.TabIndex = 10;
            this.btnInsertKeyword.Tag = "@insert_keyword";
            this.btnInsertKeyword.Text = "...";
            this.toolTip.SetToolTip(this.btnInsertKeyword, "Opens the keyword library...");
            this.btnInsertKeyword.UseVisualStyleBackColor = true;
            this.btnInsertKeyword.Click += new System.EventHandler(this.btnInsertKeyword_Click);
            // 
            // cbxPreset
            // 
            this.cbxPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreset.FormattingEnabled = true;
            this.cbxPreset.Location = new System.Drawing.Point(93, 9);
            this.cbxPreset.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxPreset.Name = "cbxPreset";
            this.cbxPreset.Size = new System.Drawing.Size(383, 21);
            this.cbxPreset.TabIndex = 1;
            this.cbxPreset.Tag = "!_ignore";
            this.cbxPreset.SelectedIndexChanged += new System.EventHandler(this.cbxPreset_SelectedIndexChanged);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.tableLayoutPanel2);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 533);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(798, 40);
            this.panelActions.TabIndex = 2;
            this.panelActions.Tag = "#";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbBasicMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbImmediateStart, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxPreset, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Tag = "#$";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.btnInsertKeyword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDownloadDirectory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFilenameTemplate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbFilenameTemplate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDownloadArchiveBrowse, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDownloadArchive, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseDownloadDirectory, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDownloadArchive, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUrl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDownloadDirectory, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // txtCustomArguments
            // 
            this.txtCustomArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomArguments.Location = new System.Drawing.Point(133, 3);
            this.txtCustomArguments.Name = "txtCustomArguments";
            this.txtCustomArguments.Size = new System.Drawing.Size(630, 22);
            this.txtCustomArguments.TabIndex = 2;
            this.txtCustomArguments.Tag = "custom_arguments.value";
            this.toolTip.SetToolTip(this.txtCustomArguments, "Extra command-line arguments for this download.");
            this.txtCustomArguments.TextChanged += new System.EventHandler(this.txtCustomArguments_TextChanged);
            // 
            // cbCustomArguments
            // 
            this.cbCustomArguments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCustomArguments.AutoSize = true;
            this.cbCustomArguments.Location = new System.Drawing.Point(3, 6);
            this.cbCustomArguments.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbCustomArguments.Name = "cbCustomArguments";
            this.cbCustomArguments.Size = new System.Drawing.Size(127, 17);
            this.cbCustomArguments.TabIndex = 3;
            this.cbCustomArguments.Tag = "custom_arguments";
            this.cbCustomArguments.Text = "Custom Arguments:";
            this.toolTip.SetToolTip(this.cbCustomArguments, "Extra command-line arguments for this download.");
            this.cbCustomArguments.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cbCustomArguments, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomArguments, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 354);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(766, 29);
            this.tableLayoutPanel3.TabIndex = 4;
            this.tableLayoutPanel3.Tag = "#$";
            // 
            // txtFilenameTemplate
            // 
            this.txtFilenameTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilenameTemplate.AutoCompleteCustomSource.AddRange(new string[] {
            "%(title)s.%(ext)s",
            "%(title)s - %(id)s.%(ext)s",
            "%(playlist)s/%(playlist_index)s - %(title)s.%(ext)s",
            "%(uploader)s/%(playlist)s/%(playlist_index)s - %(title)s.%(ext)s"});
            this.txtFilenameTemplate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilenameTemplate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilenameTemplate.KeywordMatchingEnabled = true;
            this.txtFilenameTemplate.Location = new System.Drawing.Point(133, 60);
            this.txtFilenameTemplate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtFilenameTemplate.Name = "txtFilenameTemplate";
            this.txtFilenameTemplate.Size = new System.Drawing.Size(601, 22);
            this.txtFilenameTemplate.TabIndex = 6;
            this.txtFilenameTemplate.Tag = "filename_template.value";
            this.toolTip.SetToolTip(this.txtFilenameTemplate, "Output filename template.");
            // 
            // general
            // 
            this.general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.general.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.general.Location = new System.Drawing.Point(0, 0);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(766, 383);
            this.general.TabIndex = 0;
            this.general.Tag = "#";
            // 
            // videoSelection
            // 
            this.videoSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSelection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoSelection.Location = new System.Drawing.Point(3, 3);
            this.videoSelection.Name = "videoSelection";
            this.videoSelection.Size = new System.Drawing.Size(760, 377);
            this.videoSelection.TabIndex = 0;
            this.videoSelection.Tag = "#";
            // 
            // workarounds
            // 
            this.workarounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workarounds.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workarounds.Location = new System.Drawing.Point(0, 0);
            this.workarounds.Name = "workarounds";
            this.workarounds.Size = new System.Drawing.Size(766, 383);
            this.workarounds.TabIndex = 0;
            this.workarounds.Tag = "#";
            // 
            // FormAddDownload
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(798, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 612);
            this.Name = "FormAddDownload";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "download_dialog";
            this.Text = "Add Download...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddDownload_FormClosing);
            this.Load += new System.EventHandler(this.FormAddDownload_Load);
            this.ResizeBegin += new System.EventHandler(this.FormAddDownload_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormAddDownload_ResizeEnd);
            this.tabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpVideoSelection.ResumeLayout(false);
            this.tpWorkarounds.ResumeLayout(false);
            this.tpCommandPreview.ResumeLayout(false);
            this.tpCommandPreview.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbImmediateStart;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtDownloadDirectory;
        private System.Windows.Forms.Label lblDownloadDirectory;
        private System.Windows.Forms.Button btnBrowseDownloadDirectory;
        private System.Windows.Forms.TextBox txtDownloadArchive;
        private System.Windows.Forms.Button btnDownloadArchiveBrowse;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpVideoSelection;
        private System.Windows.Forms.TabPage tpWorkarounds;
        private System.Windows.Forms.CheckBox cbDownloadArchive;
        private System.Windows.Forms.CheckBox cbFilenameTemplate;
        private Tab.TabVideoSelection videoSelection;
        private Tab.TabWorkarounds workarounds;
        private Tab.TabGeneral general;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbxPreset;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.CheckBox cbBasicMode;
        private Controls.KeywordTextBox txtFilenameTemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInsertKeyword;
        private System.Windows.Forms.TabPage tpCommandPreview;
        private System.Windows.Forms.TextBox txtCommandPreview;
        private System.Windows.Forms.TextBox txtCustomArguments;
        private System.Windows.Forms.CheckBox cbCustomArguments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}