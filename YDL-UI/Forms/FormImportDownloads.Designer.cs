namespace Maxstupo.YdlUi.Forms {
    partial class FormImportDownloads {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportDownloads));
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbSeparateOptions = new System.Windows.Forms.CheckBox();
            this.cbAllowPresets = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDupes = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(268, 106);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(349, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbSeparateOptions
            // 
            this.cbSeparateOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSeparateOptions.AutoSize = true;
            this.cbSeparateOptions.Location = new System.Drawing.Point(12, 110);
            this.cbSeparateOptions.Name = "cbSeparateOptions";
            this.cbSeparateOptions.Size = new System.Drawing.Size(116, 17);
            this.cbSeparateOptions.TabIndex = 2;
            this.cbSeparateOptions.Text = "Separate Options";
            this.toolTip1.SetToolTip(this.cbSeparateOptions, "If checked, download options will be available for each url.");
            this.cbSeparateOptions.UseVisualStyleBackColor = true;
            // 
            // cbAllowPresets
            // 
            this.cbAllowPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAllowPresets.AutoSize = true;
            this.cbAllowPresets.Checked = true;
            this.cbAllowPresets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowPresets.Location = new System.Drawing.Point(12, 87);
            this.cbAllowPresets.Name = "cbAllowPresets";
            this.cbAllowPresets.Size = new System.Drawing.Size(122, 17);
            this.cbAllowPresets.TabIndex = 3;
            this.cbAllowPresets.Text = "Allow Auto Presets";
            this.toolTip1.SetToolTip(this.cbAllowPresets, "If checked, urls that match a preset will be added automatically.");
            this.cbAllowPresets.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Found {0} url(s)...";
            // 
            // lblTotalDupes
            // 
            this.lblTotalDupes.AutoSize = true;
            this.lblTotalDupes.Location = new System.Drawing.Point(9, 33);
            this.lblTotalDupes.Name = "lblTotalDupes";
            this.lblTotalDupes.Size = new System.Drawing.Size(140, 13);
            this.lblTotalDupes.TabIndex = 6;
            this.lblTotalDupes.Text = "{0} url(s) already imported.";
            // 
            // FormImportDownloads
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 141);
            this.Controls.Add(this.lblTotalDupes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbAllowPresets);
            this.Controls.Add(this.cbSeparateOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 171);
            this.Name = "FormImportDownloads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Downloads";
            this.Load += new System.EventHandler(this.FormImportDownloads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbSeparateOptions;
        private System.Windows.Forms.CheckBox cbAllowPresets;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDupes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}