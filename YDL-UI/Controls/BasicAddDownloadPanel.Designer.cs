namespace Maxstupo.YdlUi.Controls {
    partial class BasicAddDownloadPanel {
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
            this.cbxAudioOnly = new System.Windows.Forms.ComboBox();
            this.cbAudioOnly = new System.Windows.Forms.CheckBox();
            this.frameRateSelector1 = new Maxstupo.YdlUi.Controls.FrameRateSelector();
            this.gbFileSystem = new System.Windows.Forms.GroupBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.videoQualitySelector1 = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.gbFileSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAudioOnly
            // 
            this.cbxAudioOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAudioOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioOnly.FormattingEnabled = true;
            this.cbxAudioOnly.Location = new System.Drawing.Point(92, 86);
            this.cbxAudioOnly.Name = "cbxAudioOnly";
            this.cbxAudioOnly.Size = new System.Drawing.Size(88, 21);
            this.cbxAudioOnly.TabIndex = 9;
            // 
            // cbAudioOnly
            // 
            this.cbAudioOnly.AutoSize = true;
            this.cbAudioOnly.Location = new System.Drawing.Point(6, 88);
            this.cbAudioOnly.Name = "cbAudioOnly";
            this.cbAudioOnly.Size = new System.Drawing.Size(80, 17);
            this.cbAudioOnly.TabIndex = 8;
            this.cbAudioOnly.Text = "Audio Only:";
            this.cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // frameRateSelector1
            // 
            this.frameRateSelector1.Location = new System.Drawing.Point(182, 3);
            this.frameRateSelector1.Name = "frameRateSelector1";
            this.frameRateSelector1.Size = new System.Drawing.Size(173, 115);
            this.frameRateSelector1.TabIndex = 25;
            // 
            // gbFileSystem
            // 
            this.gbFileSystem.Controls.Add(this.cbxAudioOnly);
            this.gbFileSystem.Controls.Add(this.cbNoOverwrites);
            this.gbFileSystem.Controls.Add(this.cbAudioOnly);
            this.gbFileSystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFileSystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFileSystem.Location = new System.Drawing.Point(361, 3);
            this.gbFileSystem.Name = "gbFileSystem";
            this.gbFileSystem.Size = new System.Drawing.Size(188, 115);
            this.gbFileSystem.TabIndex = 27;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Text = "Options";
            // 
            // cbNoOverwrites
            // 
            this.cbNoOverwrites.AutoSize = true;
            this.cbNoOverwrites.Checked = true;
            this.cbNoOverwrites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoOverwrites.Location = new System.Drawing.Point(6, 65);
            this.cbNoOverwrites.Name = "cbNoOverwrites";
            this.cbNoOverwrites.Size = new System.Drawing.Size(93, 17);
            this.cbNoOverwrites.TabIndex = 4;
            this.cbNoOverwrites.Text = "No Overwrites";
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 42);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(112, 17);
            this.cbRestrictFilenames.TabIndex = 3;
            this.cbRestrictFilenames.Text = "Restrict Filenames";
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 19);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(103, 17);
            this.cbWriteThumbnail.TabIndex = 2;
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // videoQualitySelector1
            // 
            this.videoQualitySelector1.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector1.Name = "videoQualitySelector1";
            this.videoQualitySelector1.Size = new System.Drawing.Size(173, 115);
            this.videoQualitySelector1.TabIndex = 28;
            // 
            // BasicAddDownloadPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoQualitySelector1);
            this.Controls.Add(this.frameRateSelector1);
            this.Controls.Add(this.gbFileSystem);
            this.Name = "BasicAddDownloadPanel";
            this.Size = new System.Drawing.Size(557, 124);
            this.Load += new System.EventHandler(this.BasicAddDownloadPanel_Load);
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxAudioOnly;
        private System.Windows.Forms.CheckBox cbAudioOnly;
        private FrameRateSelector frameRateSelector1;
        private System.Windows.Forms.GroupBox gbFileSystem;
        private System.Windows.Forms.CheckBox cbNoOverwrites;
        private System.Windows.Forms.CheckBox cbRestrictFilenames;
        private System.Windows.Forms.CheckBox cbWriteThumbnail;
        private VideoQualitySelector videoQualitySelector1;
    }
}
