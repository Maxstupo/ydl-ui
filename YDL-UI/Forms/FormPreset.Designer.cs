namespace Maxstupo.YdlUi.Forms {
    partial class FormPreset {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreset));
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDefaultPreset = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPresetName = new System.Windows.Forms.TextBox();
            this.txtUrlMatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModeSimple = new System.Windows.Forms.RadioButton();
            this.rbModeRegex = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOkay.Location = new System.Drawing.Point(370, 8);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 1;
            this.btnOkay.Tag = "okay";
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(456, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Tag = "@dialog.cancel";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.tableLayoutPanel3);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 121);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(551, 40);
            this.panelActions.TabIndex = 4;
            this.panelActions.Tag = "#";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(270, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "delete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbDefaultPreset
            // 
            this.cbDefaultPreset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDefaultPreset.AutoSize = true;
            this.cbDefaultPreset.Location = new System.Drawing.Point(3, 11);
            this.cbDefaultPreset.Name = "cbDefaultPreset";
            this.cbDefaultPreset.Size = new System.Drawing.Size(93, 17);
            this.cbDefaultPreset.TabIndex = 0;
            this.cbDefaultPreset.Tag = "default_preset";
            this.cbDefaultPreset.Text = "Default Preset";
            this.toolTip.SetToolTip(this.cbDefaultPreset, "Selected by default in the Download dialog.");
            this.cbDefaultPreset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "name";
            this.label1.Text = "Preset Name:";
            this.toolTip.SetToolTip(this.label1, "The name of the preset.");
            // 
            // txtPresetName
            // 
            this.txtPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPresetName.Location = new System.Drawing.Point(80, 3);
            this.txtPresetName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(447, 20);
            this.txtPresetName.TabIndex = 1;
            this.txtPresetName.Tag = "name.value";
            this.toolTip.SetToolTip(this.txtPresetName, "The name of the preset.");
            // 
            // txtUrlMatch
            // 
            this.txtUrlMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlMatch.Location = new System.Drawing.Point(80, 29);
            this.txtUrlMatch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtUrlMatch.Name = "txtUrlMatch";
            this.txtUrlMatch.Size = new System.Drawing.Size(447, 20);
            this.txtUrlMatch.TabIndex = 3;
            this.txtUrlMatch.Tag = "url_match.value";
            this.toolTip.SetToolTip(this.txtUrlMatch, "If this regex matches the download URL, this preset will be selected automaticall" +
        "y.\r\nLeave blank to disable URL matching.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "url_match";
            this.label2.Text = "URL Match:";
            this.toolTip.SetToolTip(this.label2, "If this regex matches the download URL, this preset will be selected automaticall" +
        "y.\r\nLeave blank to disable URL matching.");
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "mode";
            this.groupBox1.Text = "Pattern Matching Mode";
            // 
            // rbModeSimple
            // 
            this.rbModeSimple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModeSimple.AutoSize = true;
            this.rbModeSimple.Location = new System.Drawing.Point(65, 3);
            this.rbModeSimple.Name = "rbModeSimple";
            this.rbModeSimple.Size = new System.Drawing.Size(56, 17);
            this.rbModeSimple.TabIndex = 1;
            this.rbModeSimple.Tag = "simple";
            this.rbModeSimple.Text = "Simple";
            this.rbModeSimple.UseVisualStyleBackColor = true;
            // 
            // rbModeRegex
            // 
            this.rbModeRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModeRegex.AutoSize = true;
            this.rbModeRegex.Checked = true;
            this.rbModeRegex.Location = new System.Drawing.Point(3, 3);
            this.rbModeRegex.Name = "rbModeRegex";
            this.rbModeRegex.Size = new System.Drawing.Size(56, 17);
            this.rbModeRegex.TabIndex = 0;
            this.rbModeRegex.TabStop = true;
            this.rbModeRegex.Tag = "regex";
            this.rbModeRegex.Text = "Regex";
            this.rbModeRegex.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPresetName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUrlMatch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.rbModeSimple, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbModeRegex, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 21);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Tag = "#$";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cbDefaultPreset, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOkay, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(534, 40);
            this.tableLayoutPanel3.TabIndex = 4;
            this.tableLayoutPanel3.Tag = "#$";
            // 
            // FormPreset
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(551, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 200);
            this.MinimumSize = new System.Drawing.Size(406, 200);
            this.Name = "FormPreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "preset_dialog";
            this.Text = "New Download Preset";
            this.Load += new System.EventHandler(this.FormPreset_Load);
            this.panelActions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.CheckBox cbDefaultPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPresetName;
        private System.Windows.Forms.TextBox txtUrlMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModeSimple;
        private System.Windows.Forms.RadioButton rbModeRegex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}