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
            this.components = new System.ComponentModel.Container();
            this.gb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudCustomWidth = new System.Windows.Forms.NumericUpDown();
            this.nudCustomHeight = new System.Windows.Forms.NumericUpDown();
            this.cbFallback = new System.Windows.Forms.CheckBox();
            this.cbPreferred = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxQuality = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.tableLayoutPanel1);
            this.gb.Controls.Add(this.cbxQuality);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(207, 95);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Tag = "vq";
            this.gb.Text = "Video Quality";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nudCustomWidth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudCustomHeight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFallback, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPreferred, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 46);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // nudCustomWidth
            // 
            this.nudCustomWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCustomWidth.Location = new System.Drawing.Point(0, 0);
            this.nudCustomWidth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
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
            this.nudCustomWidth.Size = new System.Drawing.Size(88, 20);
            this.nudCustomWidth.TabIndex = 0;
            this.nudCustomWidth.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudCustomHeight
            // 
            this.nudCustomHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCustomHeight.Location = new System.Drawing.Point(107, 0);
            this.nudCustomHeight.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
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
            this.nudCustomHeight.Size = new System.Drawing.Size(88, 20);
            this.nudCustomHeight.TabIndex = 2;
            this.nudCustomHeight.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // cbFallback
            // 
            this.cbFallback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFallback.AutoSize = true;
            this.cbFallback.Checked = true;
            this.cbFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFallback.Location = new System.Drawing.Point(123, 27);
            this.cbFallback.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbFallback.Name = "cbFallback";
            this.cbFallback.Size = new System.Drawing.Size(72, 16);
            this.cbFallback.TabIndex = 4;
            this.cbFallback.Tag = "fallback";
            this.cbFallback.Text = "Fallback?";
            this.toolTip.SetToolTip(this.cbFallback, "If resolution metadata isn\'t available, ignore resolution check.");
            this.cbFallback.UseVisualStyleBackColor = true;
            // 
            // cbPreferred
            // 
            this.cbPreferred.AutoSize = true;
            this.cbPreferred.Checked = true;
            this.cbPreferred.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreferred.Location = new System.Drawing.Point(0, 27);
            this.cbPreferred.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbPreferred.Name = "cbPreferred";
            this.cbPreferred.Size = new System.Drawing.Size(75, 16);
            this.cbPreferred.TabIndex = 3;
            this.cbPreferred.Tag = "preferred";
            this.cbPreferred.Text = "Preferred?";
            this.toolTip.SetToolTip(this.cbPreferred, "Select video with the highest resolution up to the selected resolution.");
            this.cbPreferred.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "!ignore";
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxQuality
            // 
            this.cbxQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuality.FormattingEnabled = true;
            this.cbxQuality.Location = new System.Drawing.Point(6, 19);
            this.cbxQuality.Name = "cbxQuality";
            this.cbxQuality.Size = new System.Drawing.Size(195, 21);
            this.cbxQuality.TabIndex = 0;
            this.cbxQuality.SelectionChangeCommitted += new System.EventHandler(this.cbxQuality_SelectionChangeCommitted);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // VideoQualitySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.MinimumSize = new System.Drawing.Size(150, 20);
            this.Name = "VideoQualitySelector";
            this.Size = new System.Drawing.Size(207, 95);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.VideoQualitySelector_Load);
            this.gb.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckBox cbPreferred;
        private System.Windows.Forms.CheckBox cbFallback;
        private System.Windows.Forms.ComboBox cbxQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCustomHeight;
        private System.Windows.Forms.NumericUpDown nudCustomWidth;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
