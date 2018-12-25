namespace Maxstupo.YdlUi.Forms {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.queuedDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.failedDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitingDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatusLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatusRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDownloads = new System.Windows.Forms.DataGridView();
            this.colUrl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPercent = new Maxstupo.YdlUi.Controls.DataGridViewProgressColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDownloadDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDownloadLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.removeDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownloads)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.wikiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click_1);
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wikiToolStripMenuItem.Text = "&Wiki...";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.wikiToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addURLToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectToolStripMenuItem});
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.downloadToolStripMenuItem.Text = "&Download";
            // 
            // addURLToolStripMenuItem
            // 
            this.addURLToolStripMenuItem.Name = "addURLToolStripMenuItem";
            this.addURLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addURLToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addURLToolStripMenuItem.Text = "Add URL...";
            this.addURLToolStripMenuItem.Click += new System.EventHandler(this.addURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completedDownloadsToolStripMenuItem,
            this.toolStripSeparator6,
            this.queuedDownloadsToolStripMenuItem,
            this.failedDownloadsToolStripMenuItem,
            this.waitingDownloadsToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.selectToolStripMenuItem_DropDownItemClicked);
            // 
            // completedDownloadsToolStripMenuItem
            // 
            this.completedDownloadsToolStripMenuItem.Name = "completedDownloadsToolStripMenuItem";
            this.completedDownloadsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.completedDownloadsToolStripMenuItem.Text = "Completed Download(s)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(200, 6);
            // 
            // queuedDownloadsToolStripMenuItem
            // 
            this.queuedDownloadsToolStripMenuItem.Name = "queuedDownloadsToolStripMenuItem";
            this.queuedDownloadsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.queuedDownloadsToolStripMenuItem.Text = "Queued Download(s)";
            // 
            // failedDownloadsToolStripMenuItem
            // 
            this.failedDownloadsToolStripMenuItem.Name = "failedDownloadsToolStripMenuItem";
            this.failedDownloadsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.failedDownloadsToolStripMenuItem.Text = "Failed Download(s)";
            // 
            // waitingDownloadsToolStripMenuItem
            // 
            this.waitingDownloadsToolStripMenuItem.Name = "waitingDownloadsToolStripMenuItem";
            this.waitingDownloadsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.waitingDownloadsToolStripMenuItem.Text = "Waiting Download(s)";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusLeft,
            this.tsslSpring,
            this.tsslStatusRight});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslStatusLeft
            // 
            this.tsslStatusLeft.Name = "tsslStatusLeft";
            this.tsslStatusLeft.Size = new System.Drawing.Size(167, 17);
            this.tsslStatusLeft.Text = "Downloading 0 of 0, 0 running";
            // 
            // tsslSpring
            // 
            this.tsslSpring.Name = "tsslSpring";
            this.tsslSpring.Size = new System.Drawing.Size(618, 17);
            this.tsslSpring.Spring = true;
            this.tsslSpring.Text = "  ";
            // 
            // tsslStatusRight
            // 
            this.tsslStatusRight.Name = "tsslStatusRight";
            this.tsslStatusRight.Size = new System.Drawing.Size(33, 17);
            this.tsslStatusRight.Text = "0 b/s";
            this.tsslStatusRight.Visible = false;
            // 
            // dgvDownloads
            // 
            this.dgvDownloads.AllowUserToAddRows = false;
            this.dgvDownloads.AllowUserToDeleteRows = false;
            this.dgvDownloads.AllowUserToOrderColumns = true;
            this.dgvDownloads.AllowUserToResizeRows = false;
            this.dgvDownloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDownloads.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownloads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUrl,
            this.colPercent,
            this.colSize,
            this.colSpeed,
            this.colEta,
            this.colStatus});
            this.dgvDownloads.ContextMenuStrip = this.contextMenuStrip;
            this.dgvDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDownloads.Location = new System.Drawing.Point(0, 24);
            this.dgvDownloads.Name = "dgvDownloads";
            this.dgvDownloads.ReadOnly = true;
            this.dgvDownloads.RowHeadersVisible = false;
            this.dgvDownloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDownloads.Size = new System.Drawing.Size(800, 404);
            this.dgvDownloads.TabIndex = 1;
            this.dgvDownloads.SelectionChanged += new System.EventHandler(this.dgvDownloads_SelectionChanged);
            // 
            // colUrl
            // 
            this.colUrl.DataPropertyName = "Url";
            this.colUrl.FillWeight = 50F;
            this.colUrl.HeaderText = "URL";
            this.colUrl.Name = "colUrl";
            this.colUrl.ReadOnly = true;
            this.colUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPercent
            // 
            this.colPercent.DataPropertyName = "Progress";
            this.colPercent.FillWeight = 40F;
            this.colPercent.HeaderText = "Progress";
            this.colPercent.Name = "colPercent";
            this.colPercent.ReadOnly = true;
            this.colPercent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "Size";
            this.colSize.FillWeight = 20F;
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // colSpeed
            // 
            this.colSpeed.DataPropertyName = "Speed";
            this.colSpeed.FillWeight = 20F;
            this.colSpeed.HeaderText = "Speed";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.ReadOnly = true;
            // 
            // colEta
            // 
            this.colEta.DataPropertyName = "Eta";
            this.colEta.FillWeight = 20F;
            this.colEta.HeaderText = "ETA";
            this.colEta.Name = "colEta";
            this.colEta.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.FillWeight = 20F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDownloadDirectoryToolStripMenuItem,
            this.copyDownloadLinkToolStripMenuItem,
            this.toolStripSeparator3,
            this.viewLogToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator4,
            this.removeDownloadToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(264, 170);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // openDownloadDirectoryToolStripMenuItem
            // 
            this.openDownloadDirectoryToolStripMenuItem.Name = "openDownloadDirectoryToolStripMenuItem";
            this.openDownloadDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openDownloadDirectoryToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.openDownloadDirectoryToolStripMenuItem.Text = "Open Download Directory...";
            this.openDownloadDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDownloadDirectoryToolStripMenuItem_Click);
            // 
            // copyDownloadLinkToolStripMenuItem
            // 
            this.copyDownloadLinkToolStripMenuItem.Name = "copyDownloadLinkToolStripMenuItem";
            this.copyDownloadLinkToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.copyDownloadLinkToolStripMenuItem.Text = "Copy Download Link";
            this.copyDownloadLinkToolStripMenuItem.Click += new System.EventHandler(this.copyDownloadLinkToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(260, 6);
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.viewLogToolStripMenuItem.Text = "View Log";
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(260, 6);
            // 
            // removeDownloadToolStripMenuItem
            // 
            this.removeDownloadToolStripMenuItem.Name = "removeDownloadToolStripMenuItem";
            this.removeDownloadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeDownloadToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.removeDownloadToolStripMenuItem.Text = "Remove";
            this.removeDownloadToolStripMenuItem.Click += new System.EventHandler(this.removeDownloadToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDownloads);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YDL-UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownloads)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addURLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridView dgvDownloads;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusLeft;
        private System.Windows.Forms.ToolStripStatusLabel tsslSpring;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedDownloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queuedDownloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem failedDownloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitingDownloadsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openDownloadDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDownloadLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewLinkColumn colUrl;
        private Controls.DataGridViewProgressColumn colPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}