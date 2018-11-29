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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateYdl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFfmpeg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseFfmpeg = new System.Windows.Forms.Button();
            this.txtYdl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseYdl = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBasicMode = new System.Windows.Forms.CheckBox();
            this.txtDefaultDownloadDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDefaultDownloadDirectoryBrowse = new System.Windows.Forms.Button();
            this.txtDefaultDownloadArchive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPromptOnClose = new System.Windows.Forms.CheckBox();
            this.btnDefaultDownloadArchiveBrowse = new System.Windows.Forms.Button();
            this.nudMaxConcurrentDownloads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.llblPreferencesLocation = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdateYdl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFfmpeg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowseFfmpeg);
            this.groupBox1.Controls.Add(this.txtYdl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseYdl);
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Binaries";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Changing binary paths requires YDL-UI to restart.";
            // 
            // btnUpdateYdl
            // 
            this.btnUpdateYdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateYdl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdateYdl.Location = new System.Drawing.Point(517, 19);
            this.btnUpdateYdl.Name = "btnUpdateYdl";
            this.btnUpdateYdl.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateYdl.TabIndex = 2;
            this.btnUpdateYdl.Text = "Upda&te";
            this.toolTip.SetToolTip(this.btnUpdateYdl, "Update the custom youtube-dl binary.\r\nExecutes \"youtube-dl.exe -U\".");
            this.btnUpdateYdl.UseVisualStyleBackColor = true;
            this.btnUpdateYdl.Click += new System.EventHandler(this.btnUpdateYdl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Note: Leave blank to use embedded binaries.";
            // 
            // txtFfmpeg
            // 
            this.txtFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFfmpeg.Location = new System.Drawing.Point(79, 50);
            this.txtFfmpeg.Name = "txtFfmpeg";
            this.txtFfmpeg.Size = new System.Drawing.Size(513, 22);
            this.txtFfmpeg.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtFfmpeg, "The custom binary path to ffmpeg.exe");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&ffmpeg:";
            this.toolTip.SetToolTip(this.label2, "The custom binary path to ffmpeg.exe");
            // 
            // btnBrowseFfmpeg
            // 
            this.btnBrowseFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFfmpeg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowseFfmpeg.Location = new System.Drawing.Point(598, 50);
            this.btnBrowseFfmpeg.Name = "btnBrowseFfmpeg";
            this.btnBrowseFfmpeg.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFfmpeg.TabIndex = 6;
            this.btnBrowseFfmpeg.Text = "B&rowse";
            this.btnBrowseFfmpeg.UseVisualStyleBackColor = true;
            this.btnBrowseFfmpeg.Click += new System.EventHandler(this.btnBrowseFfmpeg_Click);
            // 
            // txtYdl
            // 
            this.txtYdl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYdl.Location = new System.Drawing.Point(79, 19);
            this.txtYdl.Name = "txtYdl";
            this.txtYdl.Size = new System.Drawing.Size(432, 22);
            this.txtYdl.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtYdl, "The custom binary path to youtube-dl.exe");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&youtube-dl:";
            this.toolTip.SetToolTip(this.label1, "The custom binary path to youtube-dl.exe");
            // 
            // btnBrowseYdl
            // 
            this.btnBrowseYdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseYdl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowseYdl.Location = new System.Drawing.Point(598, 19);
            this.btnBrowseYdl.Name = "btnBrowseYdl";
            this.btnBrowseYdl.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseYdl.TabIndex = 3;
            this.btnBrowseYdl.Text = "Br&owse";
            this.btnBrowseYdl.UseVisualStyleBackColor = true;
            this.btnBrowseYdl.Click += new System.EventHandler(this.btnBrowseYdl_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(616, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.Location = new System.Drawing.Point(535, 340);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 4;
            this.btnOkay.Text = "O&kay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbBasicMode);
            this.groupBox2.Controls.Add(this.txtDefaultDownloadDirectory);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDefaultDownloadDirectoryBrowse);
            this.groupBox2.Controls.Add(this.txtDefaultDownloadArchive);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbPromptOnClose);
            this.groupBox2.Controls.Add(this.btnDefaultDownloadArchiveBrowse);
            this.groupBox2.Controls.Add(this.nudMaxConcurrentDownloads);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Download";
            // 
            // cbBasicMode
            // 
            this.cbBasicMode.AutoSize = true;
            this.cbBasicMode.Location = new System.Drawing.Point(139, 115);
            this.cbBasicMode.Name = "cbBasicMode";
            this.cbBasicMode.Size = new System.Drawing.Size(85, 17);
            this.cbBasicMode.TabIndex = 9;
            this.cbBasicMode.Text = "Ba&sic Mode";
            this.toolTip.SetToolTip(this.cbBasicMode, "Use \"Basic Mode\" for the \"Add Download\" dialog by default.");
            this.cbBasicMode.UseVisualStyleBackColor = true;
            // 
            // txtDefaultDownloadDirectory
            // 
            this.txtDefaultDownloadDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadDirectory.Location = new System.Drawing.Point(165, 80);
            this.txtDefaultDownloadDirectory.Name = "txtDefaultDownloadDirectory";
            this.txtDefaultDownloadDirectory.Size = new System.Drawing.Size(427, 22);
            this.txtDefaultDownloadDirectory.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtDefaultDownloadDirectory, "Sets the default download directory for the \"Add Download\" dialog.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Default Down&load Directory:";
            this.toolTip.SetToolTip(this.label5, "Sets the default download directory for the \"Add Download\" dialog.");
            // 
            // btnDefaultDownloadDirectoryBrowse
            // 
            this.btnDefaultDownloadDirectoryBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultDownloadDirectoryBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDefaultDownloadDirectoryBrowse.Location = new System.Drawing.Point(598, 79);
            this.btnDefaultDownloadDirectoryBrowse.Name = "btnDefaultDownloadDirectoryBrowse";
            this.btnDefaultDownloadDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultDownloadDirectoryBrowse.TabIndex = 7;
            this.btnDefaultDownloadDirectoryBrowse.Text = "&Browse";
            this.btnDefaultDownloadDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnDefaultDownloadDirectoryBrowse.Click += new System.EventHandler(this.btnDefaultDownloadDirectoryBrowse_Click);
            // 
            // txtDefaultDownloadArchive
            // 
            this.txtDefaultDownloadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultDownloadArchive.Location = new System.Drawing.Point(165, 52);
            this.txtDefaultDownloadArchive.Name = "txtDefaultDownloadArchive";
            this.txtDefaultDownloadArchive.Size = new System.Drawing.Size(427, 22);
            this.txtDefaultDownloadArchive.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtDefaultDownloadArchive, "Sets the default download archive for the \"Add Download\" dialog.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Default Download Archive:";
            this.toolTip.SetToolTip(this.label4, "Sets the default download archive for the \"Add Download\" dialog.");
            // 
            // cbPromptOnClose
            // 
            this.cbPromptOnClose.AutoSize = true;
            this.cbPromptOnClose.Location = new System.Drawing.Point(6, 115);
            this.cbPromptOnClose.Name = "cbPromptOnClose";
            this.cbPromptOnClose.Size = new System.Drawing.Size(111, 17);
            this.cbPromptOnClose.TabIndex = 8;
            this.cbPromptOnClose.Text = "Prompt on &Close";
            this.toolTip.SetToolTip(this.cbPromptOnClose, "If any downloads are still running, prompt for confirmation when closing the appl" +
        "ication.");
            this.cbPromptOnClose.UseVisualStyleBackColor = true;
            // 
            // btnDefaultDownloadArchiveBrowse
            // 
            this.btnDefaultDownloadArchiveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultDownloadArchiveBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDefaultDownloadArchiveBrowse.Location = new System.Drawing.Point(598, 51);
            this.btnDefaultDownloadArchiveBrowse.Name = "btnDefaultDownloadArchiveBrowse";
            this.btnDefaultDownloadArchiveBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultDownloadArchiveBrowse.TabIndex = 4;
            this.btnDefaultDownloadArchiveBrowse.Text = "Bro&wse";
            this.btnDefaultDownloadArchiveBrowse.UseVisualStyleBackColor = true;
            this.btnDefaultDownloadArchiveBrowse.Click += new System.EventHandler(this.btnDefaultDownloadArchiveBrowse_Click);
            // 
            // nudMaxConcurrentDownloads
            // 
            this.nudMaxConcurrentDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxConcurrentDownloads.Location = new System.Drawing.Point(165, 21);
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
            this.nudMaxConcurrentDownloads.Size = new System.Drawing.Size(508, 22);
            this.nudMaxConcurrentDownloads.TabIndex = 1;
            this.toolTip.SetToolTip(this.nudMaxConcurrentDownloads, "The max simultaneous downloads allowed to download at once.");
            this.nudMaxConcurrentDownloads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Max Concurrent Downloads:";
            this.toolTip.SetToolTip(this.label3, "The max simultaneous downloads allowed to download at once.");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbxCheckForUpdates);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 56);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&General";
            // 
            // cbxCheckForUpdates
            // 
            this.cbxCheckForUpdates.AutoSize = true;
            this.cbxCheckForUpdates.Location = new System.Drawing.Point(8, 21);
            this.cbxCheckForUpdates.Name = "cbxCheckForUpdates";
            this.cbxCheckForUpdates.Size = new System.Drawing.Size(126, 17);
            this.cbxCheckForUpdates.TabIndex = 0;
            this.cbxCheckForUpdates.Text = "Check for &Updates?";
            this.toolTip.SetToolTip(this.cbxCheckForUpdates, "Check for updates on startup.");
            this.cbxCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // llblPreferencesLocation
            // 
            this.llblPreferencesLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblPreferencesLocation.AutoSize = true;
            this.llblPreferencesLocation.Location = new System.Drawing.Point(9, 345);
            this.llblPreferencesLocation.Name = "llblPreferencesLocation";
            this.llblPreferencesLocation.Size = new System.Drawing.Size(128, 13);
            this.llblPreferencesLocation.TabIndex = 3;
            this.llblPreferencesLocation.TabStop = true;
            this.llblPreferencesLocation.Text = "Open Preferences File...";
            this.llblPreferencesLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPreferencesLocation_LinkClicked);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // FormPreferences
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(703, 375);
            this.Controls.Add(this.llblPreferencesLocation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(461, 414);
            this.Name = "FormPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FormPreferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentDownloads)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFfmpeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseFfmpeg;
        private System.Windows.Forms.TextBox txtYdl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseYdl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMaxConcurrentDownloads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPromptOnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxCheckForUpdates;
        private System.Windows.Forms.TextBox txtDefaultDownloadArchive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefaultDownloadArchiveBrowse;
        private System.Windows.Forms.TextBox txtDefaultDownloadDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDefaultDownloadDirectoryBrowse;
        private System.Windows.Forms.LinkLabel llblPreferencesLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbBasicMode;
        private System.Windows.Forms.Button btnUpdateYdl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip;
    }
}