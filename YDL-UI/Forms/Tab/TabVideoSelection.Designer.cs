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
            this.gbRegexFilters = new System.Windows.Forms.GroupBox();
            this.txtMatchFilter = new System.Windows.Forms.TextBox();
            this.cbMatchFilter = new System.Windows.Forms.CheckBox();
            this.txtRejectTitle = new System.Windows.Forms.TextBox();
            this.cbRejectTitle = new System.Windows.Forms.CheckBox();
            this.txtMatchTitle = new System.Windows.Forms.TextBox();
            this.cbMatchTitle = new System.Windows.Forms.CheckBox();
            this.gbPlaylistFilters = new System.Windows.Forms.GroupBox();
            this.btnPlaylistRangeEditor = new System.Windows.Forms.Button();
            this.txtPlaylistRange = new System.Windows.Forms.TextBox();
            this.nudPlaylistEnd = new System.Windows.Forms.NumericUpDown();
            this.nudPlaylistStart = new System.Windows.Forms.NumericUpDown();
            this.cbPlaylistRandom = new System.Windows.Forms.CheckBox();
            this.cbPlaylistReversed = new System.Windows.Forms.CheckBox();
            this.cbPlaylistRange = new System.Windows.Forms.CheckBox();
            this.cbPlaylistEnd = new System.Windows.Forms.CheckBox();
            this.cbPlaylistStart = new System.Windows.Forms.CheckBox();
            this.gbSelectionType = new System.Windows.Forms.GroupBox();
            this.rbSelectionVideo = new System.Windows.Forms.RadioButton();
            this.rbSelectionPlaylist = new System.Windows.Forms.RadioButton();
            this.rbSelectionBoth = new System.Windows.Forms.RadioButton();
            this.gbViewCountFilters = new System.Windows.Forms.GroupBox();
            this.nudMaxViews = new System.Windows.Forms.NumericUpDown();
            this.cbMaxViews = new System.Windows.Forms.CheckBox();
            this.nudMinViews = new System.Windows.Forms.NumericUpDown();
            this.cbMinViews = new System.Windows.Forms.CheckBox();
            this.gbFilesizeFilters = new System.Windows.Forms.GroupBox();
            this.cbxMaxSizeUnit = new System.Windows.Forms.ComboBox();
            this.nudMaxSize = new System.Windows.Forms.NumericUpDown();
            this.cbMaxSize = new System.Windows.Forms.CheckBox();
            this.cbxMinSizeUnit = new System.Windows.Forms.ComboBox();
            this.nudMinSize = new System.Windows.Forms.NumericUpDown();
            this.cbMinSize = new System.Windows.Forms.CheckBox();
            this.gbDateFilters = new System.Windows.Forms.GroupBox();
            this.dtpDateBefore = new System.Windows.Forms.DateTimePicker();
            this.cbDateBefore = new System.Windows.Forms.CheckBox();
            this.dtpDateAfter = new System.Windows.Forms.DateTimePicker();
            this.cbDateAfter = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.gbRegexFilters.SuspendLayout();
            this.gbPlaylistFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).BeginInit();
            this.gbSelectionType.SuspendLayout();
            this.gbViewCountFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinViews)).BeginInit();
            this.gbFilesizeFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSize)).BeginInit();
            this.gbDateFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegexFilters
            // 
            this.gbRegexFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegexFilters.Controls.Add(this.txtMatchFilter);
            this.gbRegexFilters.Controls.Add(this.cbMatchFilter);
            this.gbRegexFilters.Controls.Add(this.txtRejectTitle);
            this.gbRegexFilters.Controls.Add(this.cbRejectTitle);
            this.gbRegexFilters.Controls.Add(this.txtMatchTitle);
            this.gbRegexFilters.Controls.Add(this.cbMatchTitle);
            this.gbRegexFilters.Location = new System.Drawing.Point(234, 140);
            this.gbRegexFilters.Name = "gbRegexFilters";
            this.gbRegexFilters.Size = new System.Drawing.Size(401, 105);
            this.gbRegexFilters.TabIndex = 5;
            this.gbRegexFilters.TabStop = false;
            this.gbRegexFilters.Text = "Text / Regex Filters";
            // 
            // txtMatchFilter
            // 
            this.txtMatchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchFilter.Location = new System.Drawing.Point(97, 75);
            this.txtMatchFilter.Name = "txtMatchFilter";
            this.txtMatchFilter.Size = new System.Drawing.Size(298, 22);
            this.txtMatchFilter.TabIndex = 5;
            // 
            // cbMatchFilter
            // 
            this.cbMatchFilter.AutoSize = true;
            this.cbMatchFilter.Location = new System.Drawing.Point(6, 77);
            this.cbMatchFilter.Name = "cbMatchFilter";
            this.cbMatchFilter.Size = new System.Drawing.Size(90, 17);
            this.cbMatchFilter.TabIndex = 4;
            this.cbMatchFilter.Text = "Match Filter:";
            this.cbMatchFilter.UseVisualStyleBackColor = true;
            // 
            // txtRejectTitle
            // 
            this.txtRejectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRejectTitle.Location = new System.Drawing.Point(97, 47);
            this.txtRejectTitle.Name = "txtRejectTitle";
            this.txtRejectTitle.Size = new System.Drawing.Size(298, 22);
            this.txtRejectTitle.TabIndex = 3;
            // 
            // cbRejectTitle
            // 
            this.cbRejectTitle.AutoSize = true;
            this.cbRejectTitle.Location = new System.Drawing.Point(6, 49);
            this.cbRejectTitle.Name = "cbRejectTitle";
            this.cbRejectTitle.Size = new System.Drawing.Size(84, 17);
            this.cbRejectTitle.TabIndex = 2;
            this.cbRejectTitle.Text = "Reject Title:";
            this.cbRejectTitle.UseVisualStyleBackColor = true;
            // 
            // txtMatchTitle
            // 
            this.txtMatchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchTitle.Location = new System.Drawing.Point(97, 19);
            this.txtMatchTitle.Name = "txtMatchTitle";
            this.txtMatchTitle.Size = new System.Drawing.Size(298, 22);
            this.txtMatchTitle.TabIndex = 1;
            // 
            // cbMatchTitle
            // 
            this.cbMatchTitle.AutoSize = true;
            this.cbMatchTitle.Location = new System.Drawing.Point(6, 21);
            this.cbMatchTitle.Name = "cbMatchTitle";
            this.cbMatchTitle.Size = new System.Drawing.Size(85, 17);
            this.cbMatchTitle.TabIndex = 0;
            this.cbMatchTitle.Text = "Match Title:";
            this.cbMatchTitle.UseVisualStyleBackColor = true;
            // 
            // gbPlaylistFilters
            // 
            this.gbPlaylistFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlaylistFilters.Controls.Add(this.btnPlaylistRangeEditor);
            this.gbPlaylistFilters.Controls.Add(this.txtPlaylistRange);
            this.gbPlaylistFilters.Controls.Add(this.nudPlaylistEnd);
            this.gbPlaylistFilters.Controls.Add(this.nudPlaylistStart);
            this.gbPlaylistFilters.Controls.Add(this.cbPlaylistRandom);
            this.gbPlaylistFilters.Controls.Add(this.cbPlaylistReversed);
            this.gbPlaylistFilters.Controls.Add(this.cbPlaylistRange);
            this.gbPlaylistFilters.Controls.Add(this.cbPlaylistEnd);
            this.gbPlaylistFilters.Controls.Add(this.cbPlaylistStart);
            this.gbPlaylistFilters.Location = new System.Drawing.Point(234, 3);
            this.gbPlaylistFilters.Name = "gbPlaylistFilters";
            this.gbPlaylistFilters.Size = new System.Drawing.Size(401, 134);
            this.gbPlaylistFilters.TabIndex = 4;
            this.gbPlaylistFilters.TabStop = false;
            this.gbPlaylistFilters.Text = "Playlist Filters";
            // 
            // btnPlaylistRangeEditor
            // 
            this.btnPlaylistRangeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaylistRangeEditor.Location = new System.Drawing.Point(361, 75);
            this.btnPlaylistRangeEditor.Name = "btnPlaylistRangeEditor";
            this.btnPlaylistRangeEditor.Size = new System.Drawing.Size(34, 22);
            this.btnPlaylistRangeEditor.TabIndex = 6;
            this.btnPlaylistRangeEditor.Text = "...";
            this.btnPlaylistRangeEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlaylistRangeEditor.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistRange
            // 
            this.txtPlaylistRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaylistRange.Location = new System.Drawing.Point(74, 75);
            this.txtPlaylistRange.Name = "txtPlaylistRange";
            this.txtPlaylistRange.Size = new System.Drawing.Size(281, 22);
            this.txtPlaylistRange.TabIndex = 5;
            this.txtPlaylistRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaylistRange_KeyPress);
            // 
            // nudPlaylistEnd
            // 
            this.nudPlaylistEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPlaylistEnd.Location = new System.Drawing.Point(74, 48);
            this.nudPlaylistEnd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPlaylistEnd.Name = "nudPlaylistEnd";
            this.nudPlaylistEnd.Size = new System.Drawing.Size(321, 22);
            this.nudPlaylistEnd.TabIndex = 3;
            // 
            // nudPlaylistStart
            // 
            this.nudPlaylistStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPlaylistStart.Location = new System.Drawing.Point(74, 20);
            this.nudPlaylistStart.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPlaylistStart.Name = "nudPlaylistStart";
            this.nudPlaylistStart.Size = new System.Drawing.Size(321, 22);
            this.nudPlaylistStart.TabIndex = 1;
            // 
            // cbPlaylistRandom
            // 
            this.cbPlaylistRandom.AutoSize = true;
            this.cbPlaylistRandom.Location = new System.Drawing.Point(84, 108);
            this.cbPlaylistRandom.Name = "cbPlaylistRandom";
            this.cbPlaylistRandom.Size = new System.Drawing.Size(69, 17);
            this.cbPlaylistRandom.TabIndex = 8;
            this.cbPlaylistRandom.Text = "Random";
            this.cbPlaylistRandom.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistReversed
            // 
            this.cbPlaylistReversed.AutoSize = true;
            this.cbPlaylistReversed.Location = new System.Drawing.Point(6, 108);
            this.cbPlaylistReversed.Name = "cbPlaylistReversed";
            this.cbPlaylistReversed.Size = new System.Drawing.Size(72, 17);
            this.cbPlaylistReversed.TabIndex = 7;
            this.cbPlaylistReversed.Text = "Reversed";
            this.cbPlaylistReversed.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistRange
            // 
            this.cbPlaylistRange.AutoSize = true;
            this.cbPlaylistRange.Location = new System.Drawing.Point(6, 79);
            this.cbPlaylistRange.Name = "cbPlaylistRange";
            this.cbPlaylistRange.Size = new System.Drawing.Size(62, 17);
            this.cbPlaylistRange.TabIndex = 4;
            this.cbPlaylistRange.Text = "Range:";
            this.cbPlaylistRange.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistEnd
            // 
            this.cbPlaylistEnd.AutoSize = true;
            this.cbPlaylistEnd.Location = new System.Drawing.Point(6, 50);
            this.cbPlaylistEnd.Name = "cbPlaylistEnd";
            this.cbPlaylistEnd.Size = new System.Drawing.Size(49, 17);
            this.cbPlaylistEnd.TabIndex = 2;
            this.cbPlaylistEnd.Text = "End:";
            this.cbPlaylistEnd.UseVisualStyleBackColor = true;
            // 
            // cbPlaylistStart
            // 
            this.cbPlaylistStart.AutoSize = true;
            this.cbPlaylistStart.Location = new System.Drawing.Point(6, 21);
            this.cbPlaylistStart.Name = "cbPlaylistStart";
            this.cbPlaylistStart.Size = new System.Drawing.Size(53, 17);
            this.cbPlaylistStart.TabIndex = 0;
            this.cbPlaylistStart.Text = "Start:";
            this.cbPlaylistStart.UseVisualStyleBackColor = true;
            // 
            // gbSelectionType
            // 
            this.gbSelectionType.Controls.Add(this.rbSelectionVideo);
            this.gbSelectionType.Controls.Add(this.rbSelectionPlaylist);
            this.gbSelectionType.Controls.Add(this.rbSelectionBoth);
            this.gbSelectionType.Location = new System.Drawing.Point(3, 3);
            this.gbSelectionType.Name = "gbSelectionType";
            this.gbSelectionType.Size = new System.Drawing.Size(223, 93);
            this.gbSelectionType.TabIndex = 0;
            this.gbSelectionType.TabStop = false;
            this.gbSelectionType.Text = "Selection Type";
            // 
            // rbSelectionVideo
            // 
            this.rbSelectionVideo.AutoSize = true;
            this.rbSelectionVideo.Location = new System.Drawing.Point(6, 67);
            this.rbSelectionVideo.Name = "rbSelectionVideo";
            this.rbSelectionVideo.Size = new System.Drawing.Size(82, 17);
            this.rbSelectionVideo.TabIndex = 2;
            this.rbSelectionVideo.Text = "Video Only";
            this.rbSelectionVideo.UseVisualStyleBackColor = true;
            // 
            // rbSelectionPlaylist
            // 
            this.rbSelectionPlaylist.AutoSize = true;
            this.rbSelectionPlaylist.Location = new System.Drawing.Point(6, 44);
            this.rbSelectionPlaylist.Name = "rbSelectionPlaylist";
            this.rbSelectionPlaylist.Size = new System.Drawing.Size(87, 17);
            this.rbSelectionPlaylist.TabIndex = 1;
            this.rbSelectionPlaylist.Text = "Playlist Only";
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
            this.rbSelectionBoth.Text = "Both";
            this.rbSelectionBoth.UseVisualStyleBackColor = true;
            // 
            // gbViewCountFilters
            // 
            this.gbViewCountFilters.Controls.Add(this.nudMaxViews);
            this.gbViewCountFilters.Controls.Add(this.cbMaxViews);
            this.gbViewCountFilters.Controls.Add(this.nudMinViews);
            this.gbViewCountFilters.Controls.Add(this.cbMinViews);
            this.gbViewCountFilters.Location = new System.Drawing.Point(3, 293);
            this.gbViewCountFilters.Name = "gbViewCountFilters";
            this.gbViewCountFilters.Size = new System.Drawing.Size(220, 77);
            this.gbViewCountFilters.TabIndex = 3;
            this.gbViewCountFilters.TabStop = false;
            this.gbViewCountFilters.Text = "View Count Filters";
            // 
            // nudMaxViews
            // 
            this.nudMaxViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxViews.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxViews.Location = new System.Drawing.Point(93, 46);
            this.nudMaxViews.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMaxViews.Name = "nudMaxViews";
            this.nudMaxViews.Size = new System.Drawing.Size(121, 22);
            this.nudMaxViews.TabIndex = 3;
            this.nudMaxViews.ThousandsSeparator = true;
            // 
            // cbMaxViews
            // 
            this.cbMaxViews.AutoSize = true;
            this.cbMaxViews.Location = new System.Drawing.Point(6, 49);
            this.cbMaxViews.Name = "cbMaxViews";
            this.cbMaxViews.Size = new System.Drawing.Size(83, 17);
            this.cbMaxViews.TabIndex = 2;
            this.cbMaxViews.Text = "Max Views:";
            this.cbMaxViews.UseVisualStyleBackColor = true;
            // 
            // nudMinViews
            // 
            this.nudMinViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinViews.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinViews.Location = new System.Drawing.Point(93, 18);
            this.nudMinViews.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMinViews.Name = "nudMinViews";
            this.nudMinViews.Size = new System.Drawing.Size(121, 22);
            this.nudMinViews.TabIndex = 1;
            this.nudMinViews.ThousandsSeparator = true;
            // 
            // cbMinViews
            // 
            this.cbMinViews.AutoSize = true;
            this.cbMinViews.Location = new System.Drawing.Point(6, 21);
            this.cbMinViews.Name = "cbMinViews";
            this.cbMinViews.Size = new System.Drawing.Size(82, 17);
            this.cbMinViews.TabIndex = 0;
            this.cbMinViews.Text = "Min Views:";
            this.cbMinViews.UseVisualStyleBackColor = true;
            // 
            // gbFilesizeFilters
            // 
            this.gbFilesizeFilters.Controls.Add(this.cbxMaxSizeUnit);
            this.gbFilesizeFilters.Controls.Add(this.nudMaxSize);
            this.gbFilesizeFilters.Controls.Add(this.cbMaxSize);
            this.gbFilesizeFilters.Controls.Add(this.cbxMinSizeUnit);
            this.gbFilesizeFilters.Controls.Add(this.nudMinSize);
            this.gbFilesizeFilters.Controls.Add(this.cbMinSize);
            this.gbFilesizeFilters.Location = new System.Drawing.Point(3, 210);
            this.gbFilesizeFilters.Name = "gbFilesizeFilters";
            this.gbFilesizeFilters.Size = new System.Drawing.Size(220, 77);
            this.gbFilesizeFilters.TabIndex = 2;
            this.gbFilesizeFilters.TabStop = false;
            this.gbFilesizeFilters.Text = "Filesize Filters";
            // 
            // cbxMaxSizeUnit
            // 
            this.cbxMaxSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMaxSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaxSizeUnit.FormattingEnabled = true;
            this.cbxMaxSizeUnit.Location = new System.Drawing.Point(161, 47);
            this.cbxMaxSizeUnit.Name = "cbxMaxSizeUnit";
            this.cbxMaxSizeUnit.Size = new System.Drawing.Size(53, 21);
            this.cbxMaxSizeUnit.TabIndex = 5;
            // 
            // nudMaxSize
            // 
            this.nudMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxSize.DecimalPlaces = 1;
            this.nudMaxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxSize.Location = new System.Drawing.Point(93, 46);
            this.nudMaxSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMaxSize.Name = "nudMaxSize";
            this.nudMaxSize.Size = new System.Drawing.Size(62, 22);
            this.nudMaxSize.TabIndex = 4;
            // 
            // cbMaxSize
            // 
            this.cbMaxSize.AutoSize = true;
            this.cbMaxSize.Location = new System.Drawing.Point(6, 49);
            this.cbMaxSize.Name = "cbMaxSize";
            this.cbMaxSize.Size = new System.Drawing.Size(73, 17);
            this.cbMaxSize.TabIndex = 3;
            this.cbMaxSize.Text = "Max Size:";
            this.cbMaxSize.UseVisualStyleBackColor = true;
            // 
            // cbxMinSizeUnit
            // 
            this.cbxMinSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMinSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinSizeUnit.FormattingEnabled = true;
            this.cbxMinSizeUnit.Location = new System.Drawing.Point(161, 19);
            this.cbxMinSizeUnit.Name = "cbxMinSizeUnit";
            this.cbxMinSizeUnit.Size = new System.Drawing.Size(53, 21);
            this.cbxMinSizeUnit.TabIndex = 2;
            // 
            // nudMinSize
            // 
            this.nudMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinSize.DecimalPlaces = 1;
            this.nudMinSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinSize.Location = new System.Drawing.Point(93, 18);
            this.nudMinSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinSize.Name = "nudMinSize";
            this.nudMinSize.Size = new System.Drawing.Size(62, 22);
            this.nudMinSize.TabIndex = 1;
            // 
            // cbMinSize
            // 
            this.cbMinSize.AutoSize = true;
            this.cbMinSize.Location = new System.Drawing.Point(6, 21);
            this.cbMinSize.Name = "cbMinSize";
            this.cbMinSize.Size = new System.Drawing.Size(72, 17);
            this.cbMinSize.TabIndex = 0;
            this.cbMinSize.Text = "Min Size:";
            this.cbMinSize.UseVisualStyleBackColor = true;
            // 
            // gbDateFilters
            // 
            this.gbDateFilters.Controls.Add(this.dtpDateBefore);
            this.gbDateFilters.Controls.Add(this.cbDateBefore);
            this.gbDateFilters.Controls.Add(this.dtpDateAfter);
            this.gbDateFilters.Controls.Add(this.cbDateAfter);
            this.gbDateFilters.Controls.Add(this.dtpDate);
            this.gbDateFilters.Controls.Add(this.cbDate);
            this.gbDateFilters.Location = new System.Drawing.Point(3, 102);
            this.gbDateFilters.Name = "gbDateFilters";
            this.gbDateFilters.Size = new System.Drawing.Size(220, 102);
            this.gbDateFilters.TabIndex = 1;
            this.gbDateFilters.TabStop = false;
            this.gbDateFilters.Text = "Date Filters";
            // 
            // dtpDateBefore
            // 
            this.dtpDateBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateBefore.CustomFormat = "dd/MM/yyyy";
            this.dtpDateBefore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBefore.Location = new System.Drawing.Point(102, 73);
            this.dtpDateBefore.Name = "dtpDateBefore";
            this.dtpDateBefore.Size = new System.Drawing.Size(112, 22);
            this.dtpDateBefore.TabIndex = 5;
            // 
            // cbDateBefore
            // 
            this.cbDateBefore.AutoSize = true;
            this.cbDateBefore.Location = new System.Drawing.Point(6, 77);
            this.cbDateBefore.Name = "cbDateBefore";
            this.cbDateBefore.Size = new System.Drawing.Size(90, 17);
            this.cbDateBefore.TabIndex = 4;
            this.cbDateBefore.Text = "Date Before:";
            this.cbDateBefore.UseVisualStyleBackColor = true;
            // 
            // dtpDateAfter
            // 
            this.dtpDateAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateAfter.CustomFormat = "dd/MM/yyyy";
            this.dtpDateAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAfter.Location = new System.Drawing.Point(102, 45);
            this.dtpDateAfter.Name = "dtpDateAfter";
            this.dtpDateAfter.Size = new System.Drawing.Size(112, 22);
            this.dtpDateAfter.TabIndex = 3;
            // 
            // cbDateAfter
            // 
            this.cbDateAfter.AutoSize = true;
            this.cbDateAfter.Location = new System.Drawing.Point(6, 49);
            this.cbDateAfter.Name = "cbDateAfter";
            this.cbDateAfter.Size = new System.Drawing.Size(81, 17);
            this.cbDateAfter.TabIndex = 2;
            this.cbDateAfter.Text = "Date After:";
            this.cbDateAfter.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(102, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(112, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(6, 21);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(53, 17);
            this.cbDate.TabIndex = 0;
            this.cbDate.Text = "Date:";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // TabVideoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbRegexFilters);
            this.Controls.Add(this.gbPlaylistFilters);
            this.Controls.Add(this.gbSelectionType);
            this.Controls.Add(this.gbViewCountFilters);
            this.Controls.Add(this.gbFilesizeFilters);
            this.Controls.Add(this.gbDateFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabVideoSelection";
            this.Size = new System.Drawing.Size(638, 373);
            this.Load += new System.EventHandler(this.TabVideoSelection_Load);
            this.gbRegexFilters.ResumeLayout(false);
            this.gbRegexFilters.PerformLayout();
            this.gbPlaylistFilters.ResumeLayout(false);
            this.gbPlaylistFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaylistStart)).EndInit();
            this.gbSelectionType.ResumeLayout(false);
            this.gbSelectionType.PerformLayout();
            this.gbViewCountFilters.ResumeLayout(false);
            this.gbViewCountFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinViews)).EndInit();
            this.gbFilesizeFilters.ResumeLayout(false);
            this.gbFilesizeFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSize)).EndInit();
            this.gbDateFilters.ResumeLayout(false);
            this.gbDateFilters.PerformLayout();
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
    }
}
