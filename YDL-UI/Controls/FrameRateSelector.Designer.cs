namespace Maxstupo.YdlUi.Controls {
    partial class FrameRateSelector {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCustomFrameRate = new System.Windows.Forms.NumericUpDown();
            this.cbxFrameRate = new System.Windows.Forms.ComboBox();
            this.cbFallback = new System.Windows.Forms.CheckBox();
            this.cbPreferred = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomFrameRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCustomFrameRate);
            this.groupBox1.Controls.Add(this.cbxFrameRate);
            this.groupBox1.Controls.Add(this.cbFallback);
            this.groupBox1.Controls.Add(this.cbPreferred);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame Rate";
            // 
            // nudCustomFrameRate
            // 
            this.nudCustomFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCustomFrameRate.Location = new System.Drawing.Point(6, 46);
            this.nudCustomFrameRate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCustomFrameRate.Name = "nudCustomFrameRate";
            this.nudCustomFrameRate.Size = new System.Drawing.Size(192, 20);
            this.nudCustomFrameRate.TabIndex = 1;
            this.nudCustomFrameRate.Value = new decimal(new int[] {
            244,
            0,
            0,
            0});
            // 
            // cbxFrameRate
            // 
            this.cbxFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFrameRate.FormattingEnabled = true;
            this.cbxFrameRate.Items.AddRange(new object[] {
            "144",
            "120",
            "60",
            "30",
            "25",
            "Custom"});
            this.cbxFrameRate.Location = new System.Drawing.Point(6, 19);
            this.cbxFrameRate.Name = "cbxFrameRate";
            this.cbxFrameRate.Size = new System.Drawing.Size(192, 21);
            this.cbxFrameRate.TabIndex = 0;
            this.cbxFrameRate.SelectionChangeCommitted += new System.EventHandler(this.cbxFrameRate_SelectionChangeCommitted);
            // 
            // cbFallback
            // 
            this.cbFallback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFallback.AutoSize = true;
            this.cbFallback.Checked = true;
            this.cbFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFallback.Location = new System.Drawing.Point(126, 73);
            this.cbFallback.Name = "cbFallback";
            this.cbFallback.Size = new System.Drawing.Size(72, 17);
            this.cbFallback.TabIndex = 3;
            this.cbFallback.Text = "Fallback?";
            this.toolTip.SetToolTip(this.cbFallback, "If frame rate metadata isn\'t available, ignore frame rate check.");
            this.cbFallback.UseVisualStyleBackColor = true;
            // 
            // cbPreferred
            // 
            this.cbPreferred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPreferred.AutoSize = true;
            this.cbPreferred.Checked = true;
            this.cbPreferred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreferred.Location = new System.Drawing.Point(6, 73);
            this.cbPreferred.Name = "cbPreferred";
            this.cbPreferred.Size = new System.Drawing.Size(75, 17);
            this.cbPreferred.TabIndex = 2;
            this.cbPreferred.Text = "Preferred?";
            this.toolTip.SetToolTip(this.cbPreferred, "Select video with the highest frame rate up to the selected frame rate.");
            this.cbPreferred.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // FrameRateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FrameRateSelector";
            this.Size = new System.Drawing.Size(204, 96);
            this.Load += new System.EventHandler(this.FrameRateSelector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomFrameRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFallback;
        private System.Windows.Forms.CheckBox cbPreferred;
        private System.Windows.Forms.ComboBox cbxFrameRate;
        private System.Windows.Forms.NumericUpDown nudCustomFrameRate;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
