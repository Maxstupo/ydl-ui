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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.videoQualitySelector = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbFileSystem.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAudioOnly
            // 
            this.cbxAudioOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAudioOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioOnly.FormattingEnabled = true;
            this.cbxAudioOnly.Location = new System.Drawing.Point(83, 2);
            this.cbxAudioOnly.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.cbxAudioOnly.Name = "cbxAudioOnly";
            this.cbxAudioOnly.Size = new System.Drawing.Size(93, 21);
            this.cbxAudioOnly.TabIndex = 4;
            this.toolTip.SetToolTip(this.cbxAudioOnly, "Convert video file to audio-only file.");
            // 
            // cbAudioOnly
            // 
            this.cbAudioOnly.AutoSize = true;
            this.cbAudioOnly.Location = new System.Drawing.Point(0, 3);
            this.cbAudioOnly.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbAudioOnly.Name = "cbAudioOnly";
            this.cbAudioOnly.Size = new System.Drawing.Size(80, 17);
            this.cbAudioOnly.TabIndex = 3;
            this.cbAudioOnly.Tag = "@download_dialog.general.post_processing.audio_only";
            this.cbAudioOnly.Text = "Audio Only:";
            this.toolTip.SetToolTip(this.cbAudioOnly, "Convert video file to audio-only file.");
            this.cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // frameRateSelector
            // 
            this.frameRateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameRateSelector.Location = new System.Drawing.Point(247, 3);
            this.frameRateSelector.Name = "frameRateSelector";
            this.frameRateSelector.OnChange = null;
            this.frameRateSelector.Size = new System.Drawing.Size(238, 118);
            this.frameRateSelector.TabIndex = 1;
            this.frameRateSelector.Tag = "general";
            // 
            // gbFileSystem
            // 
            this.gbFileSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFileSystem.Controls.Add(this.tableLayoutPanel2);
            this.gbFileSystem.Controls.Add(this.cbNoOverwrites);
            this.gbFileSystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFileSystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFileSystem.Location = new System.Drawing.Point(491, 3);
            this.gbFileSystem.Name = "gbFileSystem";
            this.gbFileSystem.Size = new System.Drawing.Size(188, 118);
            this.gbFileSystem.TabIndex = 2;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Tag = "@download_dialog.options";
            this.gbFileSystem.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbxAudioOnly, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbAudioOnly, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Tag = "#$";
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
            this.cbNoOverwrites.Tag = "@download_dialog.general.file_system.no_overwrites";
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
            this.cbRestrictFilenames.Tag = "@download_dialog.general.file_system.restrict_filenames";
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
            this.cbWriteThumbnail.Tag = "@download_dialog.general.file_system.write_thumbnail";
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.toolTip.SetToolTip(this.cbWriteThumbnail, "Write thumbnail to disk.");
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // videoQualitySelector
            // 
            this.videoQualitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoQualitySelector.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector.MinimumSize = new System.Drawing.Size(150, 20);
            this.videoQualitySelector.Name = "videoQualitySelector";
            this.videoQualitySelector.OnChange = null;
            this.videoQualitySelector.Size = new System.Drawing.Size(238, 118);
            this.videoQualitySelector.TabIndex = 0;
            this.videoQualitySelector.Tag = "general";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.videoQualitySelector, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbFileSystem, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.frameRateSelector, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 124);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // BasicAddDownloadPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicAddDownloadPanel";
            this.Size = new System.Drawing.Size(682, 124);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.BasicAddDownloadPanel_Load);
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
