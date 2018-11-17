namespace Maxstupo.YdlUi.Controls {
    partial class VideoQualitySelector {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCustomHeight = new System.Windows.Forms.NumericUpDown();
            this.nudCustomWidth = new System.Windows.Forms.NumericUpDown();
            this.cbxQuality = new System.Windows.Forms.ComboBox();
            this.cbPreferred = new System.Windows.Forms.CheckBox();
            this.cbFallback = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudCustomHeight);
            this.groupBox1.Controls.Add(this.nudCustomWidth);
            this.groupBox1.Controls.Add(this.cbxQuality);
            this.groupBox1.Controls.Add(this.cbPreferred);
            this.groupBox1.Controls.Add(this.cbFallback);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Quality";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // nudCustomHeight
            // 
            this.nudCustomHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCustomHeight.Location = new System.Drawing.Point(98, 46);
            this.nudCustomHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCustomHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomHeight.Name = "nudCustomHeight";
            this.nudCustomHeight.Size = new System.Drawing.Size(66, 20);
            this.nudCustomHeight.TabIndex = 3;
            this.nudCustomHeight.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudCustomWidth
            // 
            this.nudCustomWidth.Location = new System.Drawing.Point(6, 46);
            this.nudCustomWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCustomWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomWidth.Name = "nudCustomWidth";
            this.nudCustomWidth.Size = new System.Drawing.Size(68, 20);
            this.nudCustomWidth.TabIndex = 1;
            this.nudCustomWidth.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // cbxQuality
            // 
            this.cbxQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuality.FormattingEnabled = true;
            this.cbxQuality.Location = new System.Drawing.Point(6, 19);
            this.cbxQuality.Name = "cbxQuality";
            this.cbxQuality.Size = new System.Drawing.Size(158, 21);
            this.cbxQuality.TabIndex = 0;
            this.cbxQuality.SelectionChangeCommitted += new System.EventHandler(this.cbxQuality_SelectionChangeCommitted);
            // 
            // cbPreferred
            // 
            this.cbPreferred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPreferred.AutoSize = true;
            this.cbPreferred.Checked = true;
            this.cbPreferred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreferred.Location = new System.Drawing.Point(6, 72);
            this.cbPreferred.Name = "cbPreferred";
            this.cbPreferred.Size = new System.Drawing.Size(75, 17);
            this.cbPreferred.TabIndex = 4;
            this.cbPreferred.Text = "Preferred?";
            this.cbPreferred.UseVisualStyleBackColor = true;
            // 
            // cbFallback
            // 
            this.cbFallback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFallback.AutoSize = true;
            this.cbFallback.Checked = true;
            this.cbFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFallback.Location = new System.Drawing.Point(95, 72);
            this.cbFallback.Name = "cbFallback";
            this.cbFallback.Size = new System.Drawing.Size(72, 17);
            this.cbFallback.TabIndex = 5;
            this.cbFallback.Text = "Fallback?";
            this.cbFallback.UseVisualStyleBackColor = true;
            // 
            // VideoQualitySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "VideoQualitySelector";
            this.Size = new System.Drawing.Size(170, 95);
            this.Load += new System.EventHandler(this.VideoQualitySelector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPreferred;
        private System.Windows.Forms.CheckBox cbFallback;
        private System.Windows.Forms.ComboBox cbxQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCustomHeight;
        private System.Windows.Forms.NumericUpDown nudCustomWidth;
    }
}
