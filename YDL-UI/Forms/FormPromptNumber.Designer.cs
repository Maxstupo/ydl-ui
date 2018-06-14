namespace Maxstupo.YdlUi.Forms {
    partial class FormPromptNumber {
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudValue1 = new System.Windows.Forms.NumericUpDown();
            this.lblName1 = new System.Windows.Forms.Label();
            this.nudValue2 = new System.Windows.Forms.NumericUpDown();
            this.lblName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(121, 64);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudValue1
            // 
            this.nudValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudValue1.Location = new System.Drawing.Point(50, 12);
            this.nudValue1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudValue1.Name = "nudValue1";
            this.nudValue1.Size = new System.Drawing.Size(227, 20);
            this.nudValue1.TabIndex = 1;
            this.nudValue1.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            this.nudValue1.Enter += new System.EventHandler(this.nudValue_Enter);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(12, 14);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(32, 13);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Start:";
            // 
            // nudValue2
            // 
            this.nudValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudValue2.Location = new System.Drawing.Point(50, 38);
            this.nudValue2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudValue2.Name = "nudValue2";
            this.nudValue2.Size = new System.Drawing.Size(227, 20);
            this.nudValue2.TabIndex = 3;
            this.nudValue2.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            this.nudValue2.Enter += new System.EventHandler(this.nudValue_Enter);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(12, 40);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(29, 13);
            this.lblName2.TabIndex = 2;
            this.lblName2.Text = "End:";
            // 
            // FormPromptNumber
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(289, 99);
            this.ControlBox = false;
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.nudValue2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.nudValue1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.MaximumSize = new System.Drawing.Size(960, 138);
            this.MinimumSize = new System.Drawing.Size(200, 138);
            this.Name = "FormPromptNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Index Range...";
            this.Load += new System.EventHandler(this.FormPromptNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudValue1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.NumericUpDown nudValue2;
        private System.Windows.Forms.Label lblName2;
    }
}