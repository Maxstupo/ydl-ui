namespace Maxstupo.YdlUi.Forms {
    partial class FormUpdateBinaryLocations {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateBinaryLocations));
            this.txtYdlPath = new System.Windows.Forms.TextBox();
            this.txtFfmpegPath = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowseFfmpeg = new System.Windows.Forms.Button();
            this.btnBrowseYdl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYdlPath
            // 
            this.txtYdlPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtYdlPath, 6);
            this.txtYdlPath.Location = new System.Drawing.Point(75, 9);
            this.txtYdlPath.Name = "txtYdlPath";
            this.txtYdlPath.Size = new System.Drawing.Size(519, 20);
            this.txtYdlPath.TabIndex = 1;
            this.txtYdlPath.Tag = "youtube-dl.value";
            // 
            // txtFfmpegPath
            // 
            this.txtFfmpegPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtFfmpegPath, 6);
            this.txtFfmpegPath.Location = new System.Drawing.Point(75, 38);
            this.txtFfmpegPath.Name = "txtFfmpegPath";
            this.txtFfmpegPath.Size = new System.Drawing.Size(519, 20);
            this.txtFfmpegPath.TabIndex = 4;
            this.txtFfmpegPath.Tag = "ffmpeg.value";
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnOkay, 2);
            this.btnOkay.Location = new System.Drawing.Point(480, 84);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 6;
            this.btnOkay.Tag = "okay";
            this.btnOkay.Text = "&Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 3);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(561, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "@dialog.cancel";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowseFfmpeg
            // 
            this.btnBrowseFfmpeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseFfmpeg.Location = new System.Drawing.Point(600, 37);
            this.btnBrowseFfmpeg.Name = "btnBrowseFfmpeg";
            this.btnBrowseFfmpeg.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseFfmpeg.TabIndex = 5;
            this.btnBrowseFfmpeg.Tag = "@browse";
            this.btnBrowseFfmpeg.Text = "...";
            this.btnBrowseFfmpeg.UseVisualStyleBackColor = true;
            this.btnBrowseFfmpeg.Click += new System.EventHandler(this.btnBrowseFfmpeg_Click);
            // 
            // btnBrowseYdl
            // 
            this.btnBrowseYdl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseYdl.Location = new System.Drawing.Point(600, 8);
            this.btnBrowseYdl.Name = "btnBrowseYdl";
            this.btnBrowseYdl.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseYdl.TabIndex = 2;
            this.btnBrowseYdl.Tag = "@browse";
            this.btnBrowseYdl.Text = "...";
            this.btnBrowseYdl.UseVisualStyleBackColor = true;
            this.btnBrowseYdl.Click += new System.EventHandler(this.btnBrowseYdl_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "youtube-dl";
            this.label1.Text = "youtube-dl:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "ffmpeg";
            this.label2.Text = "ffmpeg:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblNote, 3);
            this.lblNote.Location = new System.Drawing.Point(10, 63);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(464, 66);
            this.lblNote.TabIndex = 8;
            this.lblNote.Tag = "note";
            this.lblNote.Text = "Cancelling this dialog will close the application, as these binaries are required" +
    " for {ProductName} to run.";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseFfmpeg, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseYdl, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNote, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYdlPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFfmpegPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOkay, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 2);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 131);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // FormUpdateBinaryLocations
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(646, 131);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(662, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 170);
            this.Name = "FormUpdateBinaryLocations";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "binary_location_dialog";
            this.Text = "Specify binary locations...";
            this.Load += new System.EventHandler(this.FormUpdateBinaryLocations_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtYdlPath;
        private System.Windows.Forms.TextBox txtFfmpegPath;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowseFfmpeg;
        private System.Windows.Forms.Button btnBrowseYdl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}