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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDownload));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbImmediateStart = new System.Windows.Forms.CheckBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtDownloadDirectory = new System.Windows.Forms.TextBox();
            this.lblDownloadDirectory = new System.Windows.Forms.Label();
            this.btnBrowseDownloadDirectory = new System.Windows.Forms.Button();
            this.txtFilenameTemplate = new System.Windows.Forms.TextBox();
            this.txtDownloadArchive = new System.Windows.Forms.TextBox();
            this.btnDownloadArchiveBrowse = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpQuality = new System.Windows.Forms.TabPage();
            this.cbCustomFormatSelector = new System.Windows.Forms.CheckBox();
            this.txtCustomFormatSelector = new System.Windows.Forms.TextBox();
            this.tpVideoSelection = new System.Windows.Forms.TabPage();
            this.tpPostProcessing = new System.Windows.Forms.TabPage();
            this.tpWorkarounds = new System.Windows.Forms.TabPage();
            this.cbDownloadArchive = new System.Windows.Forms.CheckBox();
            this.cbFilenameTemplate = new System.Windows.Forms.CheckBox();
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.tabQuality = new Maxstupo.YdlUi.Forms.Tab.TabQuality();
            this.tabVideoSelection1 = new Maxstupo.YdlUi.Forms.Tab.TabVideoSelection();
            this.tabPostProcessing = new Maxstupo.YdlUi.Forms.Tab.TabPostProcessing();
            this.tabWorkarounds = new Maxstupo.YdlUi.Forms.Tab.TabWorkarounds();
            this.tabControl.SuspendLayout();
            this.tpQuality.SuspendLayout();
            this.tpVideoSelection.SuspendLayout();
            this.tpPostProcessing.SuspendLayout();
            this.tpWorkarounds.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(711, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(630, 531);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
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
            this.cbImmediateStart.Location = new System.Drawing.Point(513, 534);
            this.cbImmediateStart.Name = "cbImmediateStart";
            this.cbImmediateStart.Size = new System.Drawing.Size(111, 17);
            this.cbImmediateStart.TabIndex = 11;
            this.cbImmediateStart.Text = "&Immediate Start?";
            this.cbImmediateStart.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "&URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(141, 9);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(645, 22);
            this.txtUrl.TabIndex = 1;
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDirectory.Location = new System.Drawing.Point(141, 37);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.ReadOnly = true;
            this.txtDownloadDirectory.Size = new System.Drawing.Size(564, 22);
            this.txtDownloadDirectory.TabIndex = 3;
            // 
            // lblDownloadDirectory
            // 
            this.lblDownloadDirectory.AutoSize = true;
            this.lblDownloadDirectory.Location = new System.Drawing.Point(12, 40);
            this.lblDownloadDirectory.Name = "lblDownloadDirectory";
            this.lblDownloadDirectory.Size = new System.Drawing.Size(113, 13);
            this.lblDownloadDirectory.TabIndex = 2;
            this.lblDownloadDirectory.Text = "&Download Directory:";
            // 
            // btnBrowseDownloadDirectory
            // 
            this.btnBrowseDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadDirectory.Location = new System.Drawing.Point(711, 36);
            this.btnBrowseDownloadDirectory.Name = "btnBrowseDownloadDirectory";
            this.btnBrowseDownloadDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDownloadDirectory.TabIndex = 4;
            this.btnBrowseDownloadDirectory.Text = "&Browse";
            this.btnBrowseDownloadDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadDirectory.Click += new System.EventHandler(this.btnBrowseDownloadDirectory_Click);
            // 
            // txtFilenameTemplate
            // 
            this.txtFilenameTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilenameTemplate.Location = new System.Drawing.Point(141, 65);
            this.txtFilenameTemplate.Name = "txtFilenameTemplate";
            this.txtFilenameTemplate.Size = new System.Drawing.Size(645, 22);
            this.txtFilenameTemplate.TabIndex = 6;
            // 
            // txtDownloadArchive
            // 
            this.txtDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadArchive.Location = new System.Drawing.Point(141, 93);
            this.txtDownloadArchive.Name = "txtDownloadArchive";
            this.txtDownloadArchive.ReadOnly = true;
            this.txtDownloadArchive.Size = new System.Drawing.Size(564, 22);
            this.txtDownloadArchive.TabIndex = 8;
            // 
            // btnDownloadArchiveBrowse
            // 
            this.btnDownloadArchiveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadArchiveBrowse.Location = new System.Drawing.Point(711, 92);
            this.btnDownloadArchiveBrowse.Name = "btnDownloadArchiveBrowse";
            this.btnDownloadArchiveBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadArchiveBrowse.TabIndex = 9;
            this.btnDownloadArchiveBrowse.Text = "&Browse";
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
            // 
            // tpQuality
            // 
            this.tpQuality.BackColor = System.Drawing.Color.White;
            this.tpQuality.Controls.Add(this.tabQuality);
            this.tpQuality.Controls.Add(this.cbCustomFormatSelector);
            this.tpQuality.Controls.Add(this.txtCustomFormatSelector);
            this.tpQuality.Location = new System.Drawing.Point(4, 22);
            this.tpQuality.Name = "tpQuality";
            this.tpQuality.Size = new System.Drawing.Size(766, 376);
            this.tpQuality.TabIndex = 3;
            this.tpQuality.Text = "Quality";
            // 
            // cbCustomFormatSelector
            // 
            this.cbCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCustomFormatSelector.AutoSize = true;
            this.cbCustomFormatSelector.Location = new System.Drawing.Point(3, 354);
            this.cbCustomFormatSelector.Name = "cbCustomFormatSelector";
            this.cbCustomFormatSelector.Size = new System.Drawing.Size(151, 17);
            this.cbCustomFormatSelector.TabIndex = 8;
            this.cbCustomFormatSelector.Text = "Custom Format Selector:";
            this.cbCustomFormatSelector.UseVisualStyleBackColor = true;
            // 
            // txtCustomFormatSelector
            // 
            this.txtCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomFormatSelector.Location = new System.Drawing.Point(160, 351);
            this.txtCustomFormatSelector.Name = "txtCustomFormatSelector";
            this.txtCustomFormatSelector.Size = new System.Drawing.Size(603, 22);
            this.txtCustomFormatSelector.TabIndex = 7;
            // 
            // tpVideoSelection
            // 
            this.tpVideoSelection.BackColor = System.Drawing.Color.White;
            this.tpVideoSelection.Controls.Add(this.tabVideoSelection1);
            this.tpVideoSelection.Location = new System.Drawing.Point(4, 22);
            this.tpVideoSelection.Name = "tpVideoSelection";
            this.tpVideoSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tpVideoSelection.Size = new System.Drawing.Size(766, 376);
            this.tpVideoSelection.TabIndex = 0;
            this.tpVideoSelection.Text = "Video Selection";
            // 
            // tpPostProcessing
            // 
            this.tpPostProcessing.BackColor = System.Drawing.Color.White;
            this.tpPostProcessing.Controls.Add(this.tabPostProcessing);
            this.tpPostProcessing.Location = new System.Drawing.Point(4, 22);
            this.tpPostProcessing.Name = "tpPostProcessing";
            this.tpPostProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostProcessing.Size = new System.Drawing.Size(766, 376);
            this.tpPostProcessing.TabIndex = 1;
            this.tpPostProcessing.Text = "Post Processing";
            // 
            // tpWorkarounds
            // 
            this.tpWorkarounds.BackColor = System.Drawing.Color.White;
            this.tpWorkarounds.Controls.Add(this.tabWorkarounds);
            this.tpWorkarounds.Location = new System.Drawing.Point(4, 22);
            this.tpWorkarounds.Name = "tpWorkarounds";
            this.tpWorkarounds.Size = new System.Drawing.Size(766, 376);
            this.tpWorkarounds.TabIndex = 2;
            this.tpWorkarounds.Text = "Workarounds";
            // 
            // cbDownloadArchive
            // 
            this.cbDownloadArchive.AutoSize = true;
            this.cbDownloadArchive.Location = new System.Drawing.Point(12, 96);
            this.cbDownloadArchive.Name = "cbDownloadArchive";
            this.cbDownloadArchive.Size = new System.Drawing.Size(123, 17);
            this.cbDownloadArchive.TabIndex = 7;
            this.cbDownloadArchive.Text = "Download Archive:";
            this.cbDownloadArchive.UseVisualStyleBackColor = true;
            // 
            // cbFilenameTemplate
            // 
            this.cbFilenameTemplate.AutoSize = true;
            this.cbFilenameTemplate.Location = new System.Drawing.Point(12, 67);
            this.cbFilenameTemplate.Name = "cbFilenameTemplate";
            this.cbFilenameTemplate.Size = new System.Drawing.Size(123, 17);
            this.cbFilenameTemplate.TabIndex = 5;
            this.cbFilenameTemplate.Text = "Filename Template:";
            this.cbFilenameTemplate.UseVisualStyleBackColor = true;
            // 
            // cbBasicMode
            // 
            this.cbBasicMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(12, 534);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(85, 17);
            this.cbBasicMode.TabIndex = 14;
            this.cbBasicMode.Text = "Basic Mode";
            this.cbBasicMode.UseVisualStyleBackColor = true;
            this.cbBasicMode.CheckedChanged += new System.EventHandler(this.cbBasicMode_CheckedChanged);
            // 
            // tabQuality
            // 
            this.tabQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuality.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuality.Location = new System.Drawing.Point(0, 0);
            this.tabQuality.Name = "tabQuality";
            this.tabQuality.Size = new System.Drawing.Size(766, 376);
            this.tabQuality.TabIndex = 9;
            // 
            // tabVideoSelection1
            // 
            this.tabVideoSelection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVideoSelection1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVideoSelection1.Location = new System.Drawing.Point(3, 3);
            this.tabVideoSelection1.Name = "tabVideoSelection1";
            this.tabVideoSelection1.Size = new System.Drawing.Size(760, 370);
            this.tabVideoSelection1.TabIndex = 0;
            // 
            // tabPostProcessing
            // 
            this.tabPostProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPostProcessing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPostProcessing.Location = new System.Drawing.Point(3, 3);
            this.tabPostProcessing.Name = "tabPostProcessing";
            this.tabPostProcessing.Size = new System.Drawing.Size(760, 370);
            this.tabPostProcessing.TabIndex = 0;
            // 
            // tabWorkarounds
            // 
            this.tabWorkarounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWorkarounds.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWorkarounds.Location = new System.Drawing.Point(0, 0);
            this.tabWorkarounds.Name = "tabWorkarounds";
            this.tabWorkarounds.Size = new System.Drawing.Size(766, 376);
            this.tabWorkarounds.TabIndex = 0;
            // 
            // FormAddDownload
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(798, 564);
            this.Controls.Add(this.cbBasicMode);
            this.Controls.Add(this.cbFilenameTemplate);
            this.Controls.Add(this.cbDownloadArchive);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDownloadArchiveBrowse);
            this.Controls.Add(this.txtDownloadArchive);
            this.Controls.Add(this.txtFilenameTemplate);
            this.Controls.Add(this.btnBrowseDownloadDirectory);
            this.Controls.Add(this.lblDownloadDirectory);
            this.Controls.Add(this.txtDownloadDirectory);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cbImmediateStart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(814, 603);
            this.Name = "FormAddDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Download...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddDownload_FormClosing);
            this.Load += new System.EventHandler(this.FormAddDownload_Load);
            this.ResizeBegin += new System.EventHandler(this.FormAddDownload_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormAddDownload_ResizeEnd);
            this.tabControl.ResumeLayout(false);
            this.tpQuality.ResumeLayout(false);
            this.tpQuality.PerformLayout();
            this.tpVideoSelection.ResumeLayout(false);
            this.tpPostProcessing.ResumeLayout(false);
            this.tpWorkarounds.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtFilenameTemplate;
        private System.Windows.Forms.TextBox txtDownloadArchive;
        private System.Windows.Forms.Button btnDownloadArchiveBrowse;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpQuality;
        private System.Windows.Forms.TabPage tpVideoSelection;
        private System.Windows.Forms.TabPage tpPostProcessing;
        private System.Windows.Forms.TabPage tpWorkarounds;
        private System.Windows.Forms.CheckBox cbCustomFormatSelector;
        private System.Windows.Forms.TextBox txtCustomFormatSelector;
        private System.Windows.Forms.CheckBox cbDownloadArchive;
        private System.Windows.Forms.CheckBox cbFilenameTemplate;
        private Tab.TabVideoSelection tabVideoSelection1;
        private Tab.TabWorkarounds tabWorkarounds;
        private Tab.TabPostProcessing tabPostProcessing;
        private Tab.TabQuality tabQuality;
        private System.Windows.Forms.CheckBox cbBasicMode;
    }
}