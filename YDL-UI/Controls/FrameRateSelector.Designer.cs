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
            this.gb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudCustomFrameRate = new System.Windows.Forms.NumericUpDown();
            this.cbFallback = new System.Windows.Forms.CheckBox();
            this.cbPreferred = new System.Windows.Forms.CheckBox();
            this.cbxFrameRate = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomFrameRate)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.tableLayoutPanel1);
            this.gb.Controls.Add(this.cbxFrameRate);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(204, 96);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Tag = "fr";
            this.gb.Text = "Frame Rate";
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
            this.tableLayoutPanel1.Controls.Add(this.nudCustomFrameRate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFallback, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPreferred, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // nudCustomFrameRate
            // 
            this.nudCustomFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.nudCustomFrameRate, 3);
            this.nudCustomFrameRate.Location = new System.Drawing.Point(0, 0);
            this.nudCustomFrameRate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.nudCustomFrameRate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCustomFrameRate.Name = "nudCustomFrameRate";
            this.nudCustomFrameRate.Size = new System.Drawing.Size(192, 20);
            this.nudCustomFrameRate.TabIndex = 0;
            this.nudCustomFrameRate.Value = new decimal(new int[] {
            244,
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
            this.cbFallback.Location = new System.Drawing.Point(120, 27);
            this.cbFallback.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbFallback.Name = "cbFallback";
            this.cbFallback.Size = new System.Drawing.Size(72, 17);
            this.cbFallback.TabIndex = 2;
            this.cbFallback.Tag = "fallback";
            this.cbFallback.Text = "Fallback?";
            this.toolTip.SetToolTip(this.cbFallback, "If frame rate metadata isn\'t available, ignore frame rate check.");
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
            this.cbPreferred.Size = new System.Drawing.Size(73, 17);
            this.cbPreferred.TabIndex = 1;
            this.cbPreferred.Tag = "preferred";
            this.cbPreferred.Text = "Preferred?";
            this.toolTip.SetToolTip(this.cbPreferred, "Select video with the highest frame rate up to the selected frame rate.");
            this.cbPreferred.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.gb);
            this.Name = "FrameRateSelector";
            this.Size = new System.Drawing.Size(204, 96);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.FrameRateSelector_Load);
            this.gb.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomFrameRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckBox cbFallback;
        private System.Windows.Forms.CheckBox cbPreferred;
        private System.Windows.Forms.ComboBox cbxFrameRate;
        private System.Windows.Forms.NumericUpDown nudCustomFrameRate;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
