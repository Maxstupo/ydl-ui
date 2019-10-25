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
            this.components = new System.ComponentModel.Container();
            this.cbxAudioOnly = new System.Windows.Forms.ComboBox();
            this.cbAudioOnly = new System.Windows.Forms.CheckBox();
            this.frameRateSelector = new Maxstupo.YdlUi.Controls.FrameRateSelector();
            this.gbFileSystem = new System.Windows.Forms.GroupBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.videoQualitySelector = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.cbxAudioOnly.TabIndex = 4;
            this.toolTip.SetToolTip(this.cbxAudioOnly, "Convert video file to audio-only file.");
            // 
            // cbAudioOnly
            // 
            this.cbAudioOnly.AutoSize = true;
            this.cbAudioOnly.Location = new System.Drawing.Point(6, 88);
            this.cbAudioOnly.Name = "cbAudioOnly";
            this.cbAudioOnly.Size = new System.Drawing.Size(80, 17);
            this.cbAudioOnly.TabIndex = 3;
            this.cbAudioOnly.Tag = "@download_dialog.post_processing.audio_only";
            this.cbAudioOnly.Text = "Audio Only:";
            this.toolTip.SetToolTip(this.cbAudioOnly, "Convert video file to audio-only file.");
            this.cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // frameRateSelector
            // 
            this.frameRateSelector.Location = new System.Drawing.Point(182, 3);
            this.frameRateSelector.Name = "frameRateSelector";
            this.frameRateSelector.OnChange = null;
            this.frameRateSelector.Size = new System.Drawing.Size(173, 115);
            this.frameRateSelector.TabIndex = 1;
            this.frameRateSelector.Tag = "quality";
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
            this.gbFileSystem.TabIndex = 2;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Tag = "@download_dialog.options";
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
            this.cbNoOverwrites.TabIndex = 2;
            this.cbNoOverwrites.Tag = "@download_dialog.quality.file_system.no_overwrites";
            this.cbNoOverwrites.Text = "No Overwrites";
            this.toolTip.SetToolTip(this.cbNoOverwrites, "Don\'t overwrite files.");
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 42);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(112, 17);
            this.cbRestrictFilenames.TabIndex = 1;
            this.cbRestrictFilenames.Tag = "@download_dialog.quality.file_system.restrict_filenames";
            this.cbRestrictFilenames.Text = "Restrict Filenames";
            this.toolTip.SetToolTip(this.cbRestrictFilenames, "Restrict filenames to only ASCII characters, and avoid \"&\" and spaces in filename" +
        "s.");
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 19);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(103, 17);
            this.cbWriteThumbnail.TabIndex = 0;
            this.cbWriteThumbnail.Tag = "@download_dialog.quality.file_system.write_thumbnail";
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.toolTip.SetToolTip(this.cbWriteThumbnail, "Write thumbnail to disk.");
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // videoQualitySelector
            // 
            this.videoQualitySelector.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector.Name = "videoQualitySelector";
            this.videoQualitySelector.OnChange = null;
            this.videoQualitySelector.Size = new System.Drawing.Size(173, 115);
            this.videoQualitySelector.TabIndex = 0;
            this.videoQualitySelector.Tag = "quality";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // BasicAddDownloadPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoQualitySelector);
            this.Controls.Add(this.frameRateSelector);
            this.Controls.Add(this.gbFileSystem);
            this.Name = "BasicAddDownloadPanel";
            this.Size = new System.Drawing.Size(557, 124);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.BasicAddDownloadPanel_Load);
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFileSystem;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ComboBox cbxAudioOnly;
        public System.Windows.Forms.CheckBox cbAudioOnly;
        public FrameRateSelector frameRateSelector;
        public System.Windows.Forms.CheckBox cbNoOverwrites;
        public System.Windows.Forms.CheckBox cbRestrictFilenames;
        public System.Windows.Forms.CheckBox cbWriteThumbnail;
        public VideoQualitySelector videoQualitySelector;
    }
}
