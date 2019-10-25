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
            this.SuspendLayout();
            // 
            // txtYdlPath
            // 
            this.txtYdlPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYdlPath.Location = new System.Drawing.Point(77, 12);
            this.txtYdlPath.Name = "txtYdlPath";
            this.txtYdlPath.Size = new System.Drawing.Size(432, 20);
            this.txtYdlPath.TabIndex = 1;
            this.txtYdlPath.Tag = "youtube-dl.value";
            // 
            // txtFfmpegPath
            // 
            this.txtFfmpegPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFfmpegPath.Location = new System.Drawing.Point(77, 38);
            this.txtFfmpegPath.Name = "txtFfmpegPath";
            this.txtFfmpegPath.Size = new System.Drawing.Size(432, 20);
            this.txtFfmpegPath.TabIndex = 4;
            this.txtFfmpegPath.Tag = "ffmpeg.value";
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.Location = new System.Drawing.Point(395, 80);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(476, 80);
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
            this.btnBrowseFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFfmpeg.Location = new System.Drawing.Point(515, 37);
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
            this.btnBrowseYdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseYdl.Location = new System.Drawing.Point(515, 10);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "youtube-dl";
            this.label1.Text = "youtube-dl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
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
            this.lblNote.Location = new System.Drawing.Point(12, 70);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(377, 41);
            this.lblNote.TabIndex = 8;
            this.lblNote.Tag = "note";
            this.lblNote.Text = "Cancelling this dialog will close the application, as these binaries are required" +
    " for {ProductName} to run.";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormUpdateBinaryLocations
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(563, 124);
            this.ControlBox = false;
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseYdl);
            this.Controls.Add(this.btnBrowseFfmpeg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtFfmpegPath);
            this.Controls.Add(this.txtYdlPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(662, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 163);
            this.Name = "FormUpdateBinaryLocations";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "binary_location_dialog";
            this.Text = "Specify binary locations...";
            this.Load += new System.EventHandler(this.FormUpdateBinaryLocations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}