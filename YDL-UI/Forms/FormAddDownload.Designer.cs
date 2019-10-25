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
            this.tpQuality = new System.Windows.Forms.TabPage();
            this.quality = new Maxstupo.YdlUi.Forms.Tab.TabQuality();
            this.tpVideoSelection = new System.Windows.Forms.TabPage();
            this.videoSelection = new Maxstupo.YdlUi.Forms.Tab.TabVideoSelection();
            this.tpPostProcessing = new System.Windows.Forms.TabPage();
            this.postProcessing = new Maxstupo.YdlUi.Forms.Tab.TabPostProcessing();
            this.tpWorkarounds = new System.Windows.Forms.TabPage();
            this.workarounds = new Maxstupo.YdlUi.Forms.Tab.TabWorkarounds();
            this.cbDownloadArchive = new System.Windows.Forms.CheckBox();
            this.cbFilenameTemplate = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.cbxPreset = new System.Windows.Forms.ComboBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.txtFilenameTemplate = new Maxstupo.YdlUi.Controls.KeywordTextBox();
            this.tabControl.SuspendLayout();
            this.tpQuality.SuspendLayout();
            this.tpVideoSelection.SuspendLayout();
            this.tpPostProcessing.SuspendLayout();
            this.tpWorkarounds.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(711, 9);
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
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(630, 9);
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
            this.cbImmediateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbImmediateStart.AutoSize = true;
            this.cbImmediateStart.Checked = true;
            this.cbImmediateStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbImmediateStart.Location = new System.Drawing.Point(513, 13);
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
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Tag = "url";
            this.lblUrl.Text = "&URL:";
            this.toolTip.SetToolTip(this.lblUrl, "The URL to download.");
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(141, 9);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(645, 22);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Tag = "url.value";
            this.toolTip.SetToolTip(this.txtUrl, "The URL to download.");
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDirectory.Location = new System.Drawing.Point(141, 37);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.ReadOnly = true;
            this.txtDownloadDirectory.Size = new System.Drawing.Size(603, 22);
            this.txtDownloadDirectory.TabIndex = 3;
            this.txtDownloadDirectory.Tag = "directory.value";
            this.toolTip.SetToolTip(this.txtDownloadDirectory, "The directory to download the video to.");
            // 
            // lblDownloadDirectory
            // 
            this.lblDownloadDirectory.AutoSize = true;
            this.lblDownloadDirectory.Location = new System.Drawing.Point(12, 40);
            this.lblDownloadDirectory.Name = "lblDownloadDirectory";
            this.lblDownloadDirectory.Size = new System.Drawing.Size(113, 13);
            this.lblDownloadDirectory.TabIndex = 2;
            this.lblDownloadDirectory.Tag = "directory";
            this.lblDownloadDirectory.Text = "&Download Directory:";
            this.toolTip.SetToolTip(this.lblDownloadDirectory, "The directory to download the video to.");
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(750, 37);
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
            this.txtDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadArchive.Location = new System.Drawing.Point(141, 93);
            this.txtDownloadArchive.Name = "txtDownloadArchive";
            this.txtDownloadArchive.ReadOnly = true;
            this.txtDownloadArchive.Size = new System.Drawing.Size(603, 22);
            this.txtDownloadArchive.TabIndex = 8;
            this.txtDownloadArchive.Tag = "download_archive.value";
            this.toolTip.SetToolTip(this.txtDownloadArchive, "Download the video only if it\'s not listed in the archive file. \r\nUpon successful" +
        " download, the video ID will be added to the archive file.");
            // 
            // btnDownloadArchiveBrowse
            // 
            this.btnDownloadArchiveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadArchiveBrowse.Location = new System.Drawing.Point(750, 93);
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
            this.tabControl.Controls.Add(this.tpQuality);
            this.tabControl.Controls.Add(this.tpVideoSelection);
            this.tabControl.Controls.Add(this.tpPostProcessing);
            this.tabControl.Controls.Add(this.tpWorkarounds);
            this.tabControl.Location = new System.Drawing.Point(12, 121);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 402);
            this.tabControl.TabIndex = 10;
            this.tabControl.Tag = "#";
            // 
            // tpQuality
            // 
            this.tpQuality.BackColor = System.Drawing.Color.White;
            this.tpQuality.Controls.Add(this.quality);
            this.tpQuality.Location = new System.Drawing.Point(4, 22);
            this.tpQuality.Name = "tpQuality";
            this.tpQuality.Size = new System.Drawing.Size(766, 376);
            this.tpQuality.TabIndex = 3;
            this.tpQuality.Tag = "quality";
            this.tpQuality.Text = "Quality";
            // 
            // quality
            // 
            this.quality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quality.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quality.Location = new System.Drawing.Point(0, 0);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(766, 376);
            this.quality.TabIndex = 0;
            this.quality.Tag = "#";
            // 
            // tpVideoSelection
            // 
            this.tpVideoSelection.BackColor = System.Drawing.Color.White;
            this.tpVideoSelection.Controls.Add(this.videoSelection);
            this.tpVideoSelection.Location = new System.Drawing.Point(4, 22);
            this.tpVideoSelection.Name = "tpVideoSelection";
            this.tpVideoSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tpVideoSelection.Size = new System.Drawing.Size(766, 376);
            this.tpVideoSelection.TabIndex = 0;
            this.tpVideoSelection.Tag = "video_selection";
            this.tpVideoSelection.Text = "Video Selection";
            // 
            // videoSelection
            // 
            this.videoSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSelection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoSelection.Location = new System.Drawing.Point(3, 3);
            this.videoSelection.Name = "videoSelection";
            this.videoSelection.Size = new System.Drawing.Size(760, 370);
            this.videoSelection.TabIndex = 0;
            this.videoSelection.Tag = "#";
            // 
            // tpPostProcessing
            // 
            this.tpPostProcessing.BackColor = System.Drawing.Color.White;
            this.tpPostProcessing.Controls.Add(this.postProcessing);
            this.tpPostProcessing.Location = new System.Drawing.Point(4, 22);
            this.tpPostProcessing.Name = "tpPostProcessing";
            this.tpPostProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostProcessing.Size = new System.Drawing.Size(766, 376);
            this.tpPostProcessing.TabIndex = 1;
            this.tpPostProcessing.Tag = "post_processing";
            this.tpPostProcessing.Text = "Post Processing";
            // 
            // postProcessing
            // 
            this.postProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postProcessing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postProcessing.Location = new System.Drawing.Point(3, 3);
            this.postProcessing.Name = "postProcessing";
            this.postProcessing.Size = new System.Drawing.Size(760, 370);
            this.postProcessing.TabIndex = 0;
            this.postProcessing.Tag = "#";
            // 
            // tpWorkarounds
            // 
            this.tpWorkarounds.BackColor = System.Drawing.Color.White;
            this.tpWorkarounds.Controls.Add(this.workarounds);
            this.tpWorkarounds.Location = new System.Drawing.Point(4, 22);
            this.tpWorkarounds.Name = "tpWorkarounds";
            this.tpWorkarounds.Size = new System.Drawing.Size(766, 376);
            this.tpWorkarounds.TabIndex = 2;
            this.tpWorkarounds.Tag = "workarounds";
            this.tpWorkarounds.Text = "Workarounds";
            // 
            // workarounds
            // 
            this.workarounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workarounds.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workarounds.Location = new System.Drawing.Point(0, 0);
            this.workarounds.Name = "workarounds";
            this.workarounds.Size = new System.Drawing.Size(766, 376);
            this.workarounds.TabIndex = 0;
            this.workarounds.Tag = "#";
            // 
            // cbDownloadArchive
            // 
            this.cbDownloadArchive.AutoSize = true;
            this.cbDownloadArchive.Location = new System.Drawing.Point(12, 96);
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
            this.cbFilenameTemplate.AutoSize = true;
            this.cbFilenameTemplate.Location = new System.Drawing.Point(12, 67);
            this.cbFilenameTemplate.Name = "cbFilenameTemplate";
            this.cbFilenameTemplate.Size = new System.Drawing.Size(123, 17);
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
            this.cbBasicMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(12, 13);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(85, 17);
            this.cbBasicMode.TabIndex = 0;
            this.cbBasicMode.Tag = "mode";
            this.cbBasicMode.Text = "Basic Mode";
            this.toolTip.SetToolTip(this.cbBasicMode, "Use a basic interface for simple downloads.");
            this.cbBasicMode.UseVisualStyleBackColor = true;
            this.cbBasicMode.CheckedChanged += new System.EventHandler(this.cbBasicMode_CheckedChanged);
            // 
            // cbxPreset
            // 
            this.cbxPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreset.FormattingEnabled = true;
            this.cbxPreset.Location = new System.Drawing.Point(111, 11);
            this.cbxPreset.Name = "cbxPreset";
            this.cbxPreset.Size = new System.Drawing.Size(121, 21);
            this.cbxPreset.TabIndex = 1;
            this.cbxPreset.Tag = "!_ignore";
            this.cbxPreset.SelectedIndexChanged += new System.EventHandler(this.cbxPreset_SelectedIndexChanged);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.cbBasicMode);
            this.panelActions.Controls.Add(this.cbxPreset);
            this.panelActions.Controls.Add(this.btnCancel);
            this.panelActions.Controls.Add(this.btnAdd);
            this.panelActions.Controls.Add(this.cbImmediateStart);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 526);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(798, 40);
            this.panelActions.TabIndex = 11;
            this.panelActions.Tag = "#";
            // 
            // txtFilenameTemplate
            // 
            this.txtFilenameTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilenameTemplate.AutoCompleteCustomSource.AddRange(new string[] {
            "%(title)s.%(ext)s",
            "%(title)s - %(id)s.%(ext)s",
            "%(playlist)s/%(playlist_index)s - %(title)s.%(ext)s",
            "%(uploader)s/%(playlist)s/%(playlist_index)s - %(title)s.%(ext)s"});
            this.txtFilenameTemplate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilenameTemplate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilenameTemplate.KeywordMatchingEnabled = true;
            this.txtFilenameTemplate.Location = new System.Drawing.Point(141, 65);
            this.txtFilenameTemplate.Name = "txtFilenameTemplate";
            this.txtFilenameTemplate.Size = new System.Drawing.Size(645, 22);
            this.txtFilenameTemplate.TabIndex = 6;
            this.txtFilenameTemplate.Tag = "filename_template.value";
            this.toolTip.SetToolTip(this.txtFilenameTemplate, "Output filename template.");
            // 
            // FormAddDownload
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(798, 566);
            this.Controls.Add(this.txtFilenameTemplate);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.cbFilenameTemplate);
            this.Controls.Add(this.cbDownloadArchive);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDownloadArchiveBrowse);
            this.Controls.Add(this.txtDownloadArchive);
            this.Controls.Add(this.btnBrowseDownloadDirectory);
            this.Controls.Add(this.lblDownloadDirectory);
            this.Controls.Add(this.txtDownloadDirectory);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 605);
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
            this.tpQuality.ResumeLayout(false);
            this.tpVideoSelection.ResumeLayout(false);
            this.tpPostProcessing.ResumeLayout(false);
            this.tpWorkarounds.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
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
        private System.Windows.Forms.TabPage tpQuality;
        private System.Windows.Forms.TabPage tpVideoSelection;
        private System.Windows.Forms.TabPage tpPostProcessing;
        private System.Windows.Forms.TabPage tpWorkarounds;
        private System.Windows.Forms.CheckBox cbDownloadArchive;
        private System.Windows.Forms.CheckBox cbFilenameTemplate;
        private Tab.TabVideoSelection videoSelection;
        private Tab.TabWorkarounds workarounds;
        private Tab.TabPostProcessing postProcessing;
        private Tab.TabQuality quality;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbxPreset;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.CheckBox cbBasicMode;
        private Controls.KeywordTextBox txtFilenameTemplate;
    }
}