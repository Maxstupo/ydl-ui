namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabVideoSelection {
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
            this.gbRegexFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMatchTitle = new System.Windows.Forms.CheckBox();
            this.txtMatchFilter = new System.Windows.Forms.TextBox();
            this.txtMatchTitle = new System.Windows.Forms.TextBox();
            this.cbMatchFilter = new System.Windows.Forms.CheckBox();
            this.cbRejectTitle = new System.Windows.Forms.CheckBox();
            this.txtRejectTitle = new System.Windows.Forms.TextBox();
            this.gbPlaylistFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPlaylistStart = new System.Windows.Forms.CheckBox();
            this.btnPlaylistRangeEditor = new System.Windows.Forms.Button();
            this.cbPlaylistEnd = new System.Windows.Forms.CheckBox();
            this.txtPlaylistRange = new System.Windows.Forms.TextBox();
            this.cbPlaylistRange = new System.Windows.Forms.CheckBox();
            this.nudPlaylistEnd = new System.Windows.Forms.NumericUpDown();
            this.nudPlaylistStart = new System.Windows.Forms.NumericUpDown();
            this.cbPlaylistReversed = new System.Windows.Forms.CheckBox();
            this.cbPlaylistRandom = new System.Windows.Forms.CheckBox();
            this.gbSelectionType = new System.Windows.Forms.GroupBox();
            this.rbSelectionVideo = new System.Windows.Forms.RadioButton();
            this.rbSelectionPlaylist = new System.Windows.Forms.RadioButton();
            this.rbSelectionBoth = new System.Windows.Forms.RadioButton();
            this.gbViewCountFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMinViews = new System.Windows.Forms.CheckBox();
            this.nudMaxViews = new System.Windows.Forms.NumericUpDown();
            this.nudMinViews = new System.Windows.Forms.NumericUpDown();
            this.cbMaxViews = new System.Windows.Forms.CheckBox();
            this.gbFilesizeFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMinSize = new System.Windows.Forms.CheckBox();
            this.nudMaxSize = new System.Windows.Forms.NumericUpDown();
            this.cbxMaxSizeUnit = new System.Windows.Forms.ComboBox();
            this.nudMinSize = new System.Windows.Forms.NumericUpDown();
            this.cbxMinSizeUnit = new System.Windows.Forms.ComboBox();
            this.cbMaxSize = new System.Windows.Forms.CheckBox();
            this.gbDateFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbDateBefore = new System.Windows.Forms.CheckBox();
            this.dtpDateBefore = new System.Windows.Forms.DateTimePicker();
            this.cbDateAfter = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateAfter = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbRegexFilters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbPlaylistFilters.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).BeginInit();
            this.gbSelectionType.SuspendLayout();
            this.gbViewCountFilters.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinViews)).BeginInit();
            this.gbFilesizeFilters.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSize)).BeginInit();
            this.gbDateFilters.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegexFilters
            // 
            this.gbRegexFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegexFilters.Controls.Add(this.tableLayoutPanel2);
            this.gbRegexFilters.Location = new System.Drawing.Point(272, 143);
            this.gbRegexFilters.Name = "gbRegexFilters";
            this.tableLayoutPanel1.SetRowSpan(this.gbRegexFilters, 3);
            this.gbRegexFilters.Size = new System.Drawing.Size(496, 105);
            this.gbRegexFilters.TabIndex = 5;
            this.gbRegexFilters.TabStop = false;
            this.gbRegexFilters.Tag = "text_regex_filters";
            this.gbRegexFilters.Text = "Text / Regex Filters";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbMatchTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMatchFilter, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMatchTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbMatchFilter, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbRejectTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRejectTitle, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Tag = "#$";
            // 
            // cbMatchTitle
            // 
            this.cbMatchTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMatchTitle.AutoSize = true;
            this.cbMatchTitle.Location = new System.Drawing.Point(3, 5);
            this.cbMatchTitle.Name = "cbMatchTitle";
            this.cbMatchTitle.Size = new System.Drawing.Size(85, 17);
            this.cbMatchTitle.TabIndex = 0;
            this.cbMatchTitle.Tag = "match_title";
            this.cbMatchTitle.Text = "Match Title:";
            this.toolTip.SetToolTip(this.cbMatchTitle, "Download only matching titles (regex or caseless sub-string)");
            this.cbMatchTitle.UseVisualStyleBackColor = true;
            // 
            // txtMatchFilter
            // 
            this.txtMatchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchFilter.Location = new System.Drawing.Point(99, 59);
            this.txtMatchFilter.Name = "txtMatchFilter";
            this.txtMatchFilter.Size = new System.Drawing.Size(388, 22);
            this.txtMatchFilter.TabIndex = 5;
            this.txtMatchFilter.Tag = "match_filter.value";
            this.toolTip.SetToolTip(this.txtMatchFilter, "Generic video filter (Refer to Help > Wiki).");
            // 
            // txtMatchTitle
            // 
            this.txtMatchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchTitle.Location = new System.Drawing.Point(99, 3);
            this.txtMatchTitle.Name = "txtMatchTitle";
            this.txtMatchTitle.Size = new System.Drawing.Size(388, 22);
            this.txtMatchTitle.TabIndex = 1;
            this.txtMatchTitle.Tag = "match_title.value";
            this.toolTip.SetToolTip(this.txtMatchTitle, "Download only matching titles (regex or caseless sub-string)");
            // 
            // cbMatchFilter
            // 
            this.cbMatchFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMatchFilter.AutoSize = true;
            this.cbMatchFilter.Location = new System.Drawing.Point(3, 61);
            this.cbMatchFilter.Name = "cbMatchFilter";
            this.cbMatchFilter.Size = new System.Drawing.Size(90, 17);
            this.cbMatchFilter.TabIndex = 4;
            this.cbMatchFilter.Tag = "match_filter";
            this.cbMatchFilter.Text = "Match Filter:";
            this.toolTip.SetToolTip(this.cbMatchFilter, "Generic video filter (Refer to Help > Wiki).");
            this.cbMatchFilter.UseVisualStyleBackColor = true;
            // 
            // cbRejectTitle
            // 
            this.cbRejectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRejectTitle.AutoSize = true;
            this.cbRejectTitle.Location = new System.Drawing.Point(3, 33);
            this.cbRejectTitle.Name = "cbRejectTitle";
            this.cbRejectTitle.Size = new System.Drawing.Size(84, 17);
            this.cbRejectTitle.TabIndex = 2;
            this.cbRejectTitle.Tag = "reject_title";
            this.cbRejectTitle.Text = "Reject Title:";
            this.toolTip.SetToolTip(this.cbRejectTitle, "Skip download for matching titles (regex or caseless sub-string)");
            this.cbRejectTitle.UseVisualStyleBackColor = true;
            // 
            // txtRejectTitle
            // 
            this.txtRejectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRejectTitle.Location = new System.Drawing.Point(99, 31);
            this.txtRejectTitle.Name = "txtRejectTitle";
            this.txtRejectTitle.Size = new System.Drawing.Size(388, 22);
            this.txtRejectTitle.TabIndex = 3;
            this.txtRejectTitle.Tag = "reject_title.value";
            this.toolTip.SetToolTip(this.txtRejectTitle, "Skip download for matching titles (regex or caseless sub-string)");
            // 
            // gbPlaylistFilters
            // 
            this.gbPlaylistFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlaylistFilters.Controls.Add(this.tableLayoutPanel3);
            this.gbPlaylistFilters.Location = new System.Drawing.Point(272, 3);
            this.gbPlaylistFilters.MaximumSize = new System.Drawing.Size(9999, 134);
            this.gbPlaylistFilters.Name = "gbPlaylistFilters";
            this.tableLayoutPanel1.SetRowSpan(this.gbPlaylistFilters, 2);
            this.gbPlaylistFilters.Size = new System.Drawing.Size(496, 134);
            this.gbPlaylistFilters.TabIndex = 4;
            this.gbPlaylistFilters.TabStop = false;
            this.gbPlaylistFilters.Tag = "playlist_filters";
            this.gbPlaylistFilters.Text = "Playlist Filters";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Controls.Add(this.cbPlaylistStart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPlaylistRangeEditor, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbPlaylistEnd, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtPlaylistRange, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbPlaylistRange, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.nudPlaylistEnd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudPlaylistStart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbPlaylistReversed, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbPlaylistRandom, 2, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 113);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Tag = "#$";
            // 
            // cbPlaylistStart
            // 
            this.cbPlaylistStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlaylistStart.AutoSize = true;
            this.cbPlaylistStart.Location = new System.Drawing.Point(3, 5);
            this.cbPlaylistStart.Name = "cbPlaylistStart";
            this.cbPlaylistStart.Size = new System.Drawing.Size(53, 17);
            this.cbPlaylistStart.TabIndex = 0;
            this.cbPlaylistStart.Tag = "start";
            this.cbPlaylistStart.Text = "Start:";
            this.toolTip.SetToolTip(this.cbPlaylistStart, "Playlist video to start at (default is 1).");
            this.cbPlaylistStart.UseVisualStyleBackColor = true;
            // 
            // btnPlaylistRangeEditor
            // 
            this.btnPlaylistRangeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaylistRangeEditor.Location = new System.Drawing.Point(449, 59);
            this.btnPlaylistRangeEditor.Name = "btnPlaylistRangeEditor";
            this.btnPlaylistRangeEditor.Size = new System.Drawing.Size(38, 22);
            this.btnPlaylistRangeEditor.TabIndex = 6;
            this.btnPlaylistRangeEditor.Tag = "@browse";
            this.btnPlaylistRangeEditor.Text = "...";
            this.btnPlaylistRangeEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPlaylistRangeEditor, "Playlist items editor.");
            this.btnPlaylistRangeEditor.UseVisualStyleBackColor = true;
            this.btnPlaylistRangeEditor.Click += new System.EventHandler(this.btnPlaylistRangeEditor_Click);
            // 
            // cbPlaylistEnd
            // 
            this.cbPlaylistEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlaylistEnd.AutoSize = true;
            this.cbPlaylistEnd.Location = new System.Drawing.Point(3, 33);
            this.cbPlaylistEnd.Name = "cbPlaylistEnd";
            this.cbPlaylistEnd.Size = new System.Drawing.Size(49, 17);
            this.cbPlaylistEnd.TabIndex = 2;
            this.cbPlaylistEnd.Tag = "end";
            this.cbPlaylistEnd.Text = "End:";
            this.toolTip.SetToolTip(this.cbPlaylistEnd, "Playlist video to end at (default is last).");
            this.cbPlaylistEnd.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistRange
            // 
            this.txtPlaylistRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtPlaylistRange, 2);
            this.txtPlaylistRange.Location = new System.Drawing.Point(71, 59);
            this.txtPlaylistRange.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtPlaylistRange.Name = "txtPlaylistRange";
            this.txtPlaylistRange.Size = new System.Drawing.Size(375, 22);
            this.txtPlaylistRange.TabIndex = 5;
            this.txtPlaylistRange.Tag = "range.value";
            this.toolTip.SetToolTip(this.txtPlaylistRange, "Playlist video items to download.\r\nComma seperated indices and/or ranges using hy" +
        "pen.");
            this.txtPlaylistRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaylistRange_KeyPress);
            // 
            // cbPlaylistRange
            // 
            this.cbPlaylistRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlaylistRange.AutoSize = true;
            this.cbPlaylistRange.Location = new System.Drawing.Point(3, 61);
            this.cbPlaylistRange.Name = "cbPlaylistRange";
            this.cbPlaylistRange.Size = new System.Drawing.Size(62, 17);
            this.cbPlaylistRange.TabIndex = 4;
            this.cbPlaylistRange.Tag = "range";
            this.cbPlaylistRange.Text = "Range:";
            this.toolTip.SetToolTip(this.cbPlaylistRange, "Playlist video items to download.\r\nComma seperated indices and/or ranges using hy" +
        "pen.");
            this.cbPlaylistRange.UseVisualStyleBackColor = true;
            // 
            // nudPlaylistEnd
            // 
            this.nudPlaylistEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.nudPlaylistEnd, 3);
            this.nudPlaylistEnd.Location = new System.Drawing.Point(71, 31);
            this.nudPlaylistEnd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPlaylistEnd.Name = "nudPlaylistEnd";
            this.nudPlaylistEnd.Size = new System.Drawing.Size(416, 22);
            this.nudPlaylistEnd.TabIndex = 3;
            this.nudPlaylistEnd.Tag = "end.value";
            this.toolTip.SetToolTip(this.nudPlaylistEnd, "Playlist video to end at (default is last).");
            // 
            // nudPlaylistStart
            // 
            this.nudPlaylistStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.nudPlaylistStart, 3);
            this.nudPlaylistStart.Location = new System.Drawing.Point(71, 3);
            this.nudPlaylistStart.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPlaylistStart.Name = "nudPlaylistStart";
            this.nudPlaylistStart.Size = new System.Drawing.Size(416, 22);
            this.nudPlaylistStart.TabIndex = 1;
            this.nudPlaylistStart.Tag = "start.value";
            this.toolTip.SetToolTip(this.nudPlaylistStart, "Playlist video to start at (default is 1).");
            // 
            // cbPlaylistReversed
            // 
            this.cbPlaylistReversed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlaylistReversed.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.cbPlaylistReversed, 2);
            this.cbPlaylistReversed.Location = new System.Drawing.Point(3, 90);
            this.cbPlaylistReversed.Name = "cbPlaylistReversed";
            this.cbPlaylistReversed.Size = new System.Drawing.Size(72, 17);
            this.cbPlaylistReversed.TabIndex = 7;
            this.cbPlaylistReversed.Tag = "reversed";
            this.cbPlaylistReversed.Text = "Reversed";
            this.toolTip.SetToolTip(this.cbPlaylistReversed, "Download playlist videos in a reversed order.");
            this.cbPlaylistReversed.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistRandom
            // 
            this.cbPlaylistRandom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlaylistRandom.AutoSize = true;
            this.cbPlaylistRandom.Location = new System.Drawing.Point(81, 90);
            this.cbPlaylistRandom.Name = "cbPlaylistRandom";
            this.cbPlaylistRandom.Size = new System.Drawing.Size(69, 17);
            this.cbPlaylistRandom.TabIndex = 8;
            this.cbPlaylistRandom.Tag = "random";
            this.cbPlaylistRandom.Text = "Random";
            this.toolTip.SetToolTip(this.cbPlaylistRandom, "Download playlist videos in a random order.");
            this.cbPlaylistRandom.UseVisualStyleBackColor = true;
            // 
            // gbSelectionType
            // 
            this.gbSelectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectionType.Controls.Add(this.rbSelectionVideo);
            this.gbSelectionType.Controls.Add(this.rbSelectionPlaylist);
            this.gbSelectionType.Controls.Add(this.rbSelectionBoth);
            this.gbSelectionType.Location = new System.Drawing.Point(3, 3);
            this.gbSelectionType.MinimumSize = new System.Drawing.Size(1, 93);
            this.gbSelectionType.Name = "gbSelectionType";
            this.gbSelectionType.Size = new System.Drawing.Size(263, 94);
            this.gbSelectionType.TabIndex = 0;
            this.gbSelectionType.TabStop = false;
            this.gbSelectionType.Tag = "selection_type";
            this.gbSelectionType.Text = "Selection Type";
            // 
            // rbSelectionVideo
            // 
            this.rbSelectionVideo.AutoSize = true;
            this.rbSelectionVideo.Location = new System.Drawing.Point(6, 67);
            this.rbSelectionVideo.Name = "rbSelectionVideo";
            this.rbSelectionVideo.Size = new System.Drawing.Size(82, 17);
            this.rbSelectionVideo.TabIndex = 2;
            this.rbSelectionVideo.Tag = "video_only";
            this.rbSelectionVideo.Text = "Video Only";
            this.toolTip.SetToolTip(this.rbSelectionVideo, "Download only the video, if the URL refers to a video and a playlist.");
            this.rbSelectionVideo.UseVisualStyleBackColor = true;
            // 
            // rbSelectionPlaylist
            // 
            this.rbSelectionPlaylist.AutoSize = true;
            this.rbSelectionPlaylist.Location = new System.Drawing.Point(6, 44);
            this.rbSelectionPlaylist.Name = "rbSelectionPlaylist";
            this.rbSelectionPlaylist.Size = new System.Drawing.Size(87, 17);
            this.rbSelectionPlaylist.TabIndex = 1;
            this.rbSelectionPlaylist.Tag = "playlist_only";
            this.rbSelectionPlaylist.Text = "Playlist Only";
            this.toolTip.SetToolTip(this.rbSelectionPlaylist, "Download the playlist, if the URL refers to a video and a playlist.");
            this.rbSelectionPlaylist.UseVisualStyleBackColor = true;
            // 
            // rbSelectionBoth
            // 
            this.rbSelectionBoth.AutoSize = true;
            this.rbSelectionBoth.Checked = true;
            this.rbSelectionBoth.Location = new System.Drawing.Point(6, 21);
            this.rbSelectionBoth.Name = "rbSelectionBoth";
            this.rbSelectionBoth.Size = new System.Drawing.Size(50, 17);
            this.rbSelectionBoth.TabIndex = 0;
            this.rbSelectionBoth.TabStop = true;
            this.rbSelectionBoth.Tag = "both";
            this.rbSelectionBoth.Text = "Both";
            this.toolTip.SetToolTip(this.rbSelectionBoth, "Download both the video and playlist, if the URL refers to a video and a playlist" +
        ".");
            this.rbSelectionBoth.UseVisualStyleBackColor = true;
            // 
            // gbViewCountFilters
            // 
            this.gbViewCountFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbViewCountFilters.Controls.Add(this.tableLayoutPanel4);
            this.gbViewCountFilters.Location = new System.Drawing.Point(3, 215);
            this.gbViewCountFilters.MinimumSize = new System.Drawing.Size(1, 79);
            this.gbViewCountFilters.Name = "gbViewCountFilters";
            this.gbViewCountFilters.Size = new System.Drawing.Size(263, 79);
            this.gbViewCountFilters.TabIndex = 2;
            this.gbViewCountFilters.TabStop = false;
            this.gbViewCountFilters.Tag = "view_count_filters";
            this.gbViewCountFilters.Text = "View Count Filters";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cbMinViews, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nudMaxViews, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudMinViews, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbMaxViews, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 58);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Tag = "#$";
            // 
            // cbMinViews
            // 
            this.cbMinViews.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMinViews.AutoSize = true;
            this.cbMinViews.Location = new System.Drawing.Point(3, 5);
            this.cbMinViews.Name = "cbMinViews";
            this.cbMinViews.Size = new System.Drawing.Size(82, 17);
            this.cbMinViews.TabIndex = 0;
            this.cbMinViews.Tag = "min_views";
            this.cbMinViews.Text = "Min Views:";
            this.toolTip.SetToolTip(this.cbMinViews, "Don\'t download any videos with less than # views.");
            this.cbMinViews.UseVisualStyleBackColor = true;
            // 
            // nudMaxViews
            // 
            this.nudMaxViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxViews.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxViews.Location = new System.Drawing.Point(92, 32);
            this.nudMaxViews.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMaxViews.Name = "nudMaxViews";
            this.nudMaxViews.Size = new System.Drawing.Size(162, 22);
            this.nudMaxViews.TabIndex = 3;
            this.nudMaxViews.Tag = "max_views.value";
            this.nudMaxViews.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.nudMaxViews, "Don\'t download any videos with more than # views.");
            // 
            // nudMinViews
            // 
            this.nudMinViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinViews.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinViews.Location = new System.Drawing.Point(92, 3);
            this.nudMinViews.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMinViews.Name = "nudMinViews";
            this.nudMinViews.Size = new System.Drawing.Size(162, 22);
            this.nudMinViews.TabIndex = 1;
            this.nudMinViews.Tag = "min_views.value";
            this.nudMinViews.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.nudMinViews, "Don\'t download any videos with less than # views.");
            // 
            // cbMaxViews
            // 
            this.cbMaxViews.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMaxViews.AutoSize = true;
            this.cbMaxViews.Location = new System.Drawing.Point(3, 34);
            this.cbMaxViews.Name = "cbMaxViews";
            this.cbMaxViews.Size = new System.Drawing.Size(83, 17);
            this.cbMaxViews.TabIndex = 2;
            this.cbMaxViews.Tag = "max_views";
            this.cbMaxViews.Text = "Max Views:";
            this.toolTip.SetToolTip(this.cbMaxViews, "Don\'t download any videos with more than # views.");
            this.cbMaxViews.UseVisualStyleBackColor = true;
            // 
            // gbFilesizeFilters
            // 
            this.gbFilesizeFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilesizeFilters.Controls.Add(this.tableLayoutPanel6);
            this.gbFilesizeFilters.Location = new System.Drawing.Point(3, 300);
            this.gbFilesizeFilters.MinimumSize = new System.Drawing.Size(1, 77);
            this.gbFilesizeFilters.Name = "gbFilesizeFilters";
            this.gbFilesizeFilters.Size = new System.Drawing.Size(263, 77);
            this.gbFilesizeFilters.TabIndex = 3;
            this.gbFilesizeFilters.TabStop = false;
            this.gbFilesizeFilters.Tag = "filesize_filters";
            this.gbFilesizeFilters.Text = "Filesize Filters";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Controls.Add(this.cbMinSize, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.nudMaxSize, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cbxMaxSizeUnit, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.nudMinSize, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbxMinSizeUnit, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbMaxSize, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(257, 56);
            this.tableLayoutPanel6.TabIndex = 0;
            this.tableLayoutPanel6.Tag = "#$";
            // 
            // cbMinSize
            // 
            this.cbMinSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMinSize.AutoSize = true;
            this.cbMinSize.Location = new System.Drawing.Point(3, 5);
            this.cbMinSize.Name = "cbMinSize";
            this.cbMinSize.Size = new System.Drawing.Size(72, 17);
            this.cbMinSize.TabIndex = 0;
            this.cbMinSize.Tag = "min_size";
            this.cbMinSize.Text = "Min Size:";
            this.toolTip.SetToolTip(this.cbMinSize, "Don\'t download any videos smaller than # size.");
            this.cbMinSize.UseVisualStyleBackColor = true;
            // 
            // nudMaxSize
            // 
            this.nudMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxSize.DecimalPlaces = 1;
            this.nudMaxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxSize.Location = new System.Drawing.Point(82, 31);
            this.nudMaxSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMaxSize.Name = "nudMaxSize";
            this.nudMaxSize.Size = new System.Drawing.Size(122, 22);
            this.nudMaxSize.TabIndex = 4;
            this.nudMaxSize.Tag = "max_size.value";
            this.toolTip.SetToolTip(this.nudMaxSize, "Don\'t download any videos larger than # size.");
            // 
            // cbxMaxSizeUnit
            // 
            this.cbxMaxSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMaxSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaxSizeUnit.FormattingEnabled = true;
            this.cbxMaxSizeUnit.Location = new System.Drawing.Point(210, 31);
            this.cbxMaxSizeUnit.Name = "cbxMaxSizeUnit";
            this.cbxMaxSizeUnit.Size = new System.Drawing.Size(44, 21);
            this.cbxMaxSizeUnit.TabIndex = 5;
            // 
            // nudMinSize
            // 
            this.nudMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinSize.DecimalPlaces = 1;
            this.nudMinSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinSize.Location = new System.Drawing.Point(82, 3);
            this.nudMinSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinSize.Name = "nudMinSize";
            this.nudMinSize.Size = new System.Drawing.Size(122, 22);
            this.nudMinSize.TabIndex = 1;
            this.nudMinSize.Tag = "min_size.value";
            this.toolTip.SetToolTip(this.nudMinSize, "Don\'t download any videos smaller than # size.");
            // 
            // cbxMinSizeUnit
            // 
            this.cbxMinSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMinSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinSizeUnit.FormattingEnabled = true;
            this.cbxMinSizeUnit.Location = new System.Drawing.Point(210, 3);
            this.cbxMinSizeUnit.Name = "cbxMinSizeUnit";
            this.cbxMinSizeUnit.Size = new System.Drawing.Size(44, 21);
            this.cbxMinSizeUnit.TabIndex = 2;
            // 
            // cbMaxSize
            // 
            this.cbMaxSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMaxSize.AutoSize = true;
            this.cbMaxSize.Location = new System.Drawing.Point(3, 33);
            this.cbMaxSize.Name = "cbMaxSize";
            this.cbMaxSize.Size = new System.Drawing.Size(73, 17);
            this.cbMaxSize.TabIndex = 3;
            this.cbMaxSize.Tag = "max_size";
            this.cbMaxSize.Text = "Max Size:";
            this.toolTip.SetToolTip(this.cbMaxSize, "Don\'t download any videos larger than # size.");
            this.cbMaxSize.UseVisualStyleBackColor = true;
            // 
            // gbDateFilters
            // 
            this.gbDateFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateFilters.Controls.Add(this.tableLayoutPanel5);
            this.gbDateFilters.Location = new System.Drawing.Point(3, 103);
            this.gbDateFilters.MinimumSize = new System.Drawing.Size(1, 106);
            this.gbDateFilters.Name = "gbDateFilters";
            this.tableLayoutPanel1.SetRowSpan(this.gbDateFilters, 2);
            this.gbDateFilters.Size = new System.Drawing.Size(263, 106);
            this.gbDateFilters.TabIndex = 1;
            this.gbDateFilters.TabStop = false;
            this.gbDateFilters.Tag = "date_filters";
            this.gbDateFilters.Text = "Date Filters";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cbDate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbDateBefore, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.dtpDateBefore, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbDateAfter, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtpDate, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtpDateAfter, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(257, 85);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Tag = "#$";
            // 
            // cbDate
            // 
            this.cbDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(3, 5);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(53, 17);
            this.cbDate.TabIndex = 0;
            this.cbDate.Tag = "date";
            this.cbDate.Text = "Date:";
            this.toolTip.SetToolTip(this.cbDate, "Download videos uploaded on this date.");
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // cbDateBefore
            // 
            this.cbDateBefore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDateBefore.AutoSize = true;
            this.cbDateBefore.Location = new System.Drawing.Point(3, 62);
            this.cbDateBefore.Name = "cbDateBefore";
            this.cbDateBefore.Size = new System.Drawing.Size(90, 17);
            this.cbDateBefore.TabIndex = 4;
            this.cbDateBefore.Tag = "date_before";
            this.cbDateBefore.Text = "Date Before:";
            this.toolTip.SetToolTip(this.cbDateBefore, "Download videos uploaded before or on this date.");
            this.cbDateBefore.UseVisualStyleBackColor = true;
            // 
            // dtpDateBefore
            // 
            this.dtpDateBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateBefore.CustomFormat = "dd/MM/yyyy";
            this.dtpDateBefore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBefore.Location = new System.Drawing.Point(99, 59);
            this.dtpDateBefore.Name = "dtpDateBefore";
            this.dtpDateBefore.Size = new System.Drawing.Size(155, 22);
            this.dtpDateBefore.TabIndex = 5;
            this.dtpDateBefore.Tag = "date_before.value";
            this.toolTip.SetToolTip(this.dtpDateBefore, "Download videos uploaded before or on this date.");
            // 
            // cbDateAfter
            // 
            this.cbDateAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDateAfter.AutoSize = true;
            this.cbDateAfter.Location = new System.Drawing.Point(3, 33);
            this.cbDateAfter.Name = "cbDateAfter";
            this.cbDateAfter.Size = new System.Drawing.Size(81, 17);
            this.cbDateAfter.TabIndex = 2;
            this.cbDateAfter.Tag = "date_after";
            this.cbDateAfter.Text = "Date After:";
            this.toolTip.SetToolTip(this.cbDateAfter, "Download videos uploaded after or on this date.");
            this.cbDateAfter.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(99, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(155, 22);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Tag = "date.value";
            this.toolTip.SetToolTip(this.dtpDate, "Download videos uploaded on this date.");
            // 
            // dtpDateAfter
            // 
            this.dtpDateAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateAfter.CustomFormat = "dd/MM/yyyy";
            this.dtpDateAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAfter.Location = new System.Drawing.Point(99, 31);
            this.dtpDateAfter.Name = "dtpDateAfter";
            this.dtpDateAfter.Size = new System.Drawing.Size(155, 22);
            this.dtpDateAfter.TabIndex = 3;
            this.dtpDateAfter.Tag = "date_after.value";
            this.toolTip.SetToolTip(this.dtpDateAfter, "Download videos uploaded after or on this date.");
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.gbSelectionType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDateFilters, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbViewCountFilters, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gbFilesizeFilters, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.gbRegexFilters, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbPlaylistFilters, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 388);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // TabVideoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabVideoSelection";
            this.Size = new System.Drawing.Size(771, 388);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.TabVideoSelection_Load);
            this.gbRegexFilters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbPlaylistFilters.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).EndInit();
            this.gbSelectionType.ResumeLayout(false);
            this.gbSelectionType.PerformLayout();
            this.gbViewCountFilters.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinViews)).EndInit();
            this.gbFilesizeFilters.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSize)).EndInit();
            this.gbDateFilters.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegexFilters;
        private System.Windows.Forms.TextBox txtMatchFilter;
        private System.Windows.Forms.CheckBox cbMatchFilter;
        private System.Windows.Forms.TextBox txtRejectTitle;
        private System.Windows.Forms.CheckBox cbRejectTitle;
        private System.Windows.Forms.TextBox txtMatchTitle;
        private System.Windows.Forms.CheckBox cbMatchTitle;
        private System.Windows.Forms.GroupBox gbPlaylistFilters;
        private System.Windows.Forms.Button btnPlaylistRangeEditor;
        private System.Windows.Forms.TextBox txtPlaylistRange;
        private System.Windows.Forms.NumericUpDown nudPlaylistEnd;
        private System.Windows.Forms.NumericUpDown nudPlaylistStart;
        private System.Windows.Forms.CheckBox cbPlaylistRandom;
        private System.Windows.Forms.CheckBox cbPlaylistReversed;
        private System.Windows.Forms.CheckBox cbPlaylistRange;
        private System.Windows.Forms.CheckBox cbPlaylistEnd;
        private System.Windows.Forms.CheckBox cbPlaylistStart;
        private System.Windows.Forms.GroupBox gbSelectionType;
        private System.Windows.Forms.RadioButton rbSelectionVideo;
        private System.Windows.Forms.RadioButton rbSelectionPlaylist;
        private System.Windows.Forms.RadioButton rbSelectionBoth;
        private System.Windows.Forms.GroupBox gbViewCountFilters;
        private System.Windows.Forms.NumericUpDown nudMaxViews;
        private System.Windows.Forms.CheckBox cbMaxViews;
        private System.Windows.Forms.NumericUpDown nudMinViews;
        private System.Windows.Forms.CheckBox cbMinViews;
        private System.Windows.Forms.GroupBox gbFilesizeFilters;
        private System.Windows.Forms.ComboBox cbxMaxSizeUnit;
        private System.Windows.Forms.NumericUpDown nudMaxSize;
        private System.Windows.Forms.CheckBox cbMaxSize;
        private System.Windows.Forms.ComboBox cbxMinSizeUnit;
        private System.Windows.Forms.NumericUpDown nudMinSize;
        private System.Windows.Forms.CheckBox cbMinSize;
        private System.Windows.Forms.GroupBox gbDateFilters;
        private System.Windows.Forms.DateTimePicker dtpDateBefore;
        private System.Windows.Forms.CheckBox cbDateBefore;
        private System.Windows.Forms.DateTimePicker dtpDateAfter;
        private System.Windows.Forms.CheckBox cbDateAfter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox cbDate;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}
