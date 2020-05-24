namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabPostProcessing {
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
            this.cbxRecodeFormat = new System.Windows.Forms.ComboBox();
            this.cbRecodeFormat = new System.Windows.Forms.CheckBox();
            this.cbAudioOnly = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbEmbedThumbnail = new System.Windows.Forms.CheckBox();
            this.cbAddMetadata = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAudioOnly
            // 
            this.cbxAudioOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxAudioOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioOnly.FormattingEnabled = true;
            this.cbxAudioOnly.Location = new System.Drawing.Point(127, 3);
            this.cbxAudioOnly.Name = "cbxAudioOnly";
            this.cbxAudioOnly.Size = new System.Drawing.Size(116, 21);
            this.cbxAudioOnly.TabIndex = 1;
            this.cbxAudioOnly.Tag = "audio_only.dropdown";
            this.toolTip.SetToolTip(this.cbxAudioOnly, "Convert video file to audio-only file.");
            // 
            // cbxRecodeFormat
            // 
            this.cbxRecodeFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxRecodeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecodeFormat.FormattingEnabled = true;
            this.cbxRecodeFormat.Location = new System.Drawing.Point(127, 30);
            this.cbxRecodeFormat.Name = "cbxRecodeFormat";
            this.cbxRecodeFormat.Size = new System.Drawing.Size(116, 21);
            this.cbxRecodeFormat.TabIndex = 3;
            this.cbxRecodeFormat.Tag = "recode_format.value";
            this.toolTip.SetToolTip(this.cbxRecodeFormat, "Encode the video to another format if necessary.");
            // 
            // cbRecodeFormat
            // 
            this.cbRecodeFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRecodeFormat.AutoSize = true;
            this.cbRecodeFormat.Location = new System.Drawing.Point(3, 32);
            this.cbRecodeFormat.Name = "cbRecodeFormat";
            this.cbRecodeFormat.Size = new System.Drawing.Size(106, 17);
            this.cbRecodeFormat.TabIndex = 2;
            this.cbRecodeFormat.Tag = "recode_format";
            this.cbRecodeFormat.Text = "Recode Format:";
            this.toolTip.SetToolTip(this.cbRecodeFormat, "Encode the video to another format if necessary.");
            this.cbRecodeFormat.UseVisualStyleBackColor = true;
            // 
            // cbAudioOnly
            // 
            this.cbAudioOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAudioOnly.AutoSize = true;
            this.cbAudioOnly.Location = new System.Drawing.Point(3, 5);
            this.cbAudioOnly.Name = "cbAudioOnly";
            this.cbAudioOnly.Size = new System.Drawing.Size(87, 17);
            this.cbAudioOnly.TabIndex = 0;
            this.cbAudioOnly.Tag = "audio_only";
            this.cbAudioOnly.Text = "Audio Only:";
            this.toolTip.SetToolTip(this.cbAudioOnly, "Convert video file to audio-only file.");
            this.cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // cbEmbedThumbnail
            // 
            this.cbEmbedThumbnail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEmbedThumbnail.AutoSize = true;
            this.cbEmbedThumbnail.Location = new System.Drawing.Point(3, 57);
            this.cbEmbedThumbnail.Name = "cbEmbedThumbnail";
            this.cbEmbedThumbnail.Size = new System.Drawing.Size(118, 17);
            this.cbEmbedThumbnail.TabIndex = 4;
            this.cbEmbedThumbnail.Tag = "embed_thumbnail";
            this.cbEmbedThumbnail.Text = "Embed Thumbnail";
            this.toolTip.SetToolTip(this.cbEmbedThumbnail, "Embed thumbnail in the audio as cover art.");
            this.cbEmbedThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbAddMetadata
            // 
            this.cbAddMetadata.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAddMetadata.AutoSize = true;
            this.cbAddMetadata.Location = new System.Drawing.Point(3, 80);
            this.cbAddMetadata.Name = "cbAddMetadata";
            this.cbAddMetadata.Size = new System.Drawing.Size(99, 17);
            this.cbAddMetadata.TabIndex = 5;
            this.cbAddMetadata.Tag = "add_metadata";
            this.cbAddMetadata.Text = "Add Metadata";
            this.toolTip.SetToolTip(this.cbAddMetadata, "Write metadata to the video file.");
            this.cbAddMetadata.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cbAddMetadata, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbEmbedThumbnail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxAudioOnly, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAudioOnly, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRecodeFormat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxRecodeFormat, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // TabPostProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabPostProcessing";
            this.Size = new System.Drawing.Size(712, 287);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.TabPostProcessing_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxRecodeFormat;
        private System.Windows.Forms.CheckBox cbRecodeFormat;
        public System.Windows.Forms.ComboBox cbxAudioOnly;
        public System.Windows.Forms.CheckBox cbAudioOnly;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbEmbedThumbnail;
        private System.Windows.Forms.CheckBox cbAddMetadata;
    }
}
