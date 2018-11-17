namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabQuality {
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.cbAbortOnErrors = new System.Windows.Forms.CheckBox();
            this.gbFileSystem = new System.Windows.Forms.GroupBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.cbWriteAnnotations = new System.Windows.Forms.CheckBox();
            this.cbWriteDescription = new System.Windows.Forms.CheckBox();
            this.videoQualitySelector = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.frameRateSelector = new Maxstupo.YdlUi.Controls.FrameRateSelector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbGeneral.SuspendLayout();
            this.gbFileSystem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.cbIgnoreErrors);
            this.gbGeneral.Controls.Add(this.cbAbortOnErrors);
            this.gbGeneral.Location = new System.Drawing.Point(359, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(131, 96);
            this.gbGeneral.TabIndex = 23;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // cbIgnoreErrors
            // 
            this.cbIgnoreErrors.AutoSize = true;
            this.cbIgnoreErrors.Checked = true;
            this.cbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreErrors.Location = new System.Drawing.Point(6, 21);
            this.cbIgnoreErrors.Name = "cbIgnoreErrors";
            this.cbIgnoreErrors.Size = new System.Drawing.Size(93, 17);
            this.cbIgnoreErrors.TabIndex = 1;
            this.cbIgnoreErrors.Text = "Ignore Errors";
            this.cbIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // cbAbortOnErrors
            // 
            this.cbAbortOnErrors.AutoSize = true;
            this.cbAbortOnErrors.Location = new System.Drawing.Point(6, 44);
            this.cbAbortOnErrors.Name = "cbAbortOnErrors";
            this.cbAbortOnErrors.Size = new System.Drawing.Size(107, 17);
            this.cbAbortOnErrors.TabIndex = 0;
            this.cbAbortOnErrors.Text = "Abort On Errors";
            this.cbAbortOnErrors.UseVisualStyleBackColor = true;
            // 
            // gbFileSystem
            // 
            this.gbFileSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFileSystem.Controls.Add(this.cbNoOverwrites);
            this.gbFileSystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFileSystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFileSystem.Controls.Add(this.cbWriteAnnotations);
            this.gbFileSystem.Controls.Add(this.cbWriteDescription);
            this.gbFileSystem.Location = new System.Drawing.Point(584, 3);
            this.gbFileSystem.Name = "gbFileSystem";
            this.gbFileSystem.Size = new System.Drawing.Size(131, 138);
            this.gbFileSystem.TabIndex = 22;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Text = "File System";
            // 
            // cbNoOverwrites
            // 
            this.cbNoOverwrites.AutoSize = true;
            this.cbNoOverwrites.Checked = true;
            this.cbNoOverwrites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoOverwrites.Location = new System.Drawing.Point(6, 113);
            this.cbNoOverwrites.Name = "cbNoOverwrites";
            this.cbNoOverwrites.Size = new System.Drawing.Size(99, 17);
            this.cbNoOverwrites.TabIndex = 4;
            this.cbNoOverwrites.Text = "No Overwrites";
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 90);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(118, 17);
            this.cbRestrictFilenames.TabIndex = 3;
            this.cbRestrictFilenames.Text = "Restrict Filenames";
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 67);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(111, 17);
            this.cbWriteThumbnail.TabIndex = 2;
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbWriteAnnotations
            // 
            this.cbWriteAnnotations.AutoSize = true;
            this.cbWriteAnnotations.Location = new System.Drawing.Point(6, 44);
            this.cbWriteAnnotations.Name = "cbWriteAnnotations";
            this.cbWriteAnnotations.Size = new System.Drawing.Size(121, 17);
            this.cbWriteAnnotations.TabIndex = 1;
            this.cbWriteAnnotations.Text = "Write Annotations";
            this.cbWriteAnnotations.UseVisualStyleBackColor = true;
            // 
            // cbWriteDescription
            // 
            this.cbWriteDescription.AutoSize = true;
            this.cbWriteDescription.Location = new System.Drawing.Point(6, 21);
            this.cbWriteDescription.Name = "cbWriteDescription";
            this.cbWriteDescription.Size = new System.Drawing.Size(116, 17);
            this.cbWriteDescription.TabIndex = 0;
            this.cbWriteDescription.Text = "Write Description";
            this.cbWriteDescription.UseVisualStyleBackColor = true;
            // 
            // videoQualitySelector
            // 
            this.videoQualitySelector.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector.Name = "videoQualitySelector";
            this.videoQualitySelector.Size = new System.Drawing.Size(170, 95);
            this.videoQualitySelector.TabIndex = 20;
            // 
            // frameRateSelector
            // 
            this.frameRateSelector.Location = new System.Drawing.Point(179, 3);
            this.frameRateSelector.Name = "frameRateSelector";
            this.frameRateSelector.Size = new System.Drawing.Size(174, 96);
            this.frameRateSelector.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 104);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subtitles";
            this.groupBox1.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 71);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(123, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Subtitle Language:";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 44);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Subtitle Format:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Write Subtitles";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TabQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoQualitySelector);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.gbFileSystem);
            this.Controls.Add(this.frameRateSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabQuality";
            this.Size = new System.Drawing.Size(718, 276);
            this.Load += new System.EventHandler(this.TabQuality_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbIgnoreErrors;
        private System.Windows.Forms.CheckBox cbAbortOnErrors;
        private System.Windows.Forms.GroupBox gbFileSystem;
        private System.Windows.Forms.CheckBox cbNoOverwrites;
        private System.Windows.Forms.CheckBox cbRestrictFilenames;
        private System.Windows.Forms.CheckBox cbWriteThumbnail;
        private System.Windows.Forms.CheckBox cbWriteAnnotations;
        private System.Windows.Forms.CheckBox cbWriteDescription;
        public Controls.FrameRateSelector frameRateSelector;
        public Controls.VideoQualitySelector videoQualitySelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
