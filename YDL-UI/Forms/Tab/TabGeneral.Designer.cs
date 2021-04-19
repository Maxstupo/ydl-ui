namespace Maxstupo.YdlUi.Forms.Tab {
    partial class TabGeneral {
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbIgnoreErrors = new System.Windows.Forms.CheckBox();
            this.cbAbortOnErrors = new System.Windows.Forms.CheckBox();
            this.gbFileSystem = new System.Windows.Forms.GroupBox();
            this.cbNoOverwrites = new System.Windows.Forms.CheckBox();
            this.cbRestrictFilenames = new System.Windows.Forms.CheckBox();
            this.cbWriteThumbnail = new System.Windows.Forms.CheckBox();
            this.cbWriteAnnotations = new System.Windows.Forms.CheckBox();
            this.cbWriteDescription = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbAddMetadata = new System.Windows.Forms.CheckBox();
            this.cbEmbedThumbnail = new System.Windows.Forms.CheckBox();
            this.cbxAudioOnly = new System.Windows.Forms.ComboBox();
            this.cbAudioOnly = new System.Windows.Forms.CheckBox();
            this.cbRecodeFormat = new System.Windows.Forms.CheckBox();
            this.cbxRecodeFormat = new System.Windows.Forms.ComboBox();
            this.rbSubLanguages = new System.Windows.Forms.RadioButton();
            this.txtSubLanguages = new System.Windows.Forms.TextBox();
            this.rbSubAll = new System.Windows.Forms.RadioButton();
            this.rbSubDefault = new System.Windows.Forms.RadioButton();
            this.cbCustomFormatSelector = new System.Windows.Forms.CheckBox();
            this.txtCustomFormatSelector = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbPostProcessing = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSubtitles = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbNoSubtitles = new System.Windows.Forms.RadioButton();
            this.frameRateSelector = new Maxstupo.YdlUi.Controls.FrameRateSelector();
            this.videoQualitySelector = new Maxstupo.YdlUi.Controls.VideoQualitySelector();
            this.gbGeneral.SuspendLayout();
            this.gbFileSystem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbPostProcessing.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbSubtitles.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbGeneral, 2);
            this.gbGeneral.Controls.Add(this.cbIgnoreErrors);
            this.gbGeneral.Controls.Add(this.cbAbortOnErrors);
            this.gbGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGeneral.Location = new System.Drawing.Point(3, 105);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(620, 72);
            this.gbGeneral.TabIndex = 3;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Tag = "download";
            this.gbGeneral.Text = "Download";
            // 
            // cbIgnoreErrors
            // 
            this.cbIgnoreErrors.AutoSize = true;
            this.cbIgnoreErrors.Checked = true;
            this.cbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreErrors.Location = new System.Drawing.Point(6, 21);
            this.cbIgnoreErrors.Name = "cbIgnoreErrors";
            this.cbIgnoreErrors.Size = new System.Drawing.Size(93, 17);
            this.cbIgnoreErrors.TabIndex = 0;
            this.cbIgnoreErrors.Tag = "ignore_errors";
            this.cbIgnoreErrors.Text = "Ignore Errors";
            this.toolTip.SetToolTip(this.cbIgnoreErrors, "Continue downloading on download errors (e.g. Skip unavailable videos in a playli" +
        "st).");
            this.cbIgnoreErrors.UseVisualStyleBackColor = true;
            // 
            // cbAbortOnErrors
            // 
            this.cbAbortOnErrors.AutoSize = true;
            this.cbAbortOnErrors.Location = new System.Drawing.Point(6, 44);
            this.cbAbortOnErrors.Name = "cbAbortOnErrors";
            this.cbAbortOnErrors.Size = new System.Drawing.Size(107, 17);
            this.cbAbortOnErrors.TabIndex = 1;
            this.cbAbortOnErrors.Tag = "abort_on_errors";
            this.cbAbortOnErrors.Text = "Abort On Errors";
            this.toolTip.SetToolTip(this.cbAbortOnErrors, "Abort downloading of further videos (in a playlist) if an error occurs.");
            this.cbAbortOnErrors.UseVisualStyleBackColor = true;
            // 
            // gbFileSystem
            // 
            this.gbFileSystem.AutoSize = true;
            this.gbFileSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbFileSystem.Controls.Add(this.cbNoOverwrites);
            this.gbFileSystem.Controls.Add(this.cbRestrictFilenames);
            this.gbFileSystem.Controls.Add(this.cbWriteThumbnail);
            this.gbFileSystem.Controls.Add(this.cbWriteAnnotations);
            this.gbFileSystem.Controls.Add(this.cbWriteDescription);
            this.gbFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileSystem.Location = new System.Drawing.Point(629, 3);
            this.gbFileSystem.MinimumSize = new System.Drawing.Size(100, 170);
            this.gbFileSystem.Name = "gbFileSystem";
            this.tableLayoutPanel1.SetRowSpan(this.gbFileSystem, 2);
            this.gbFileSystem.Size = new System.Drawing.Size(134, 174);
            this.gbFileSystem.TabIndex = 2;
            this.gbFileSystem.TabStop = false;
            this.gbFileSystem.Tag = "file_system";
            this.gbFileSystem.Text = "File System";
            // 
            // cbNoOverwrites
            // 
            this.cbNoOverwrites.AutoSize = true;
            this.cbNoOverwrites.Checked = true;
            this.cbNoOverwrites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoOverwrites.Location = new System.Drawing.Point(6, 113);
            this.cbNoOverwrites.Name = "cbNoOverwrites";
            this.cbNoOverwrites.Size = new System.Drawing.Size(99, 17);
            this.cbNoOverwrites.TabIndex = 4;
            this.cbNoOverwrites.Tag = "no_overwrites";
            this.cbNoOverwrites.Text = "No Overwrites";
            this.toolTip.SetToolTip(this.cbNoOverwrites, "Don\'t overwrite files.");
            this.cbNoOverwrites.UseVisualStyleBackColor = true;
            // 
            // cbRestrictFilenames
            // 
            this.cbRestrictFilenames.AutoSize = true;
            this.cbRestrictFilenames.Location = new System.Drawing.Point(6, 90);
            this.cbRestrictFilenames.Name = "cbRestrictFilenames";
            this.cbRestrictFilenames.Size = new System.Drawing.Size(118, 17);
            this.cbRestrictFilenames.TabIndex = 3;
            this.cbRestrictFilenames.Tag = "restrict_filenames";
            this.cbRestrictFilenames.Text = "Restrict Filenames";
            this.toolTip.SetToolTip(this.cbRestrictFilenames, "Restrict filenames to only ASCII characters, and avoid \"&\" and spaces in filename" +
        "s.");
            this.cbRestrictFilenames.UseVisualStyleBackColor = true;
            // 
            // cbWriteThumbnail
            // 
            this.cbWriteThumbnail.AutoSize = true;
            this.cbWriteThumbnail.Location = new System.Drawing.Point(6, 67);
            this.cbWriteThumbnail.Name = "cbWriteThumbnail";
            this.cbWriteThumbnail.Size = new System.Drawing.Size(112, 17);
            this.cbWriteThumbnail.TabIndex = 2;
            this.cbWriteThumbnail.Tag = "write_thumbnail";
            this.cbWriteThumbnail.Text = "Write Thumbnail";
            this.toolTip.SetToolTip(this.cbWriteThumbnail, "Write thumbnail to disk.");
            this.cbWriteThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbWriteAnnotations
            // 
            this.cbWriteAnnotations.AutoSize = true;
            this.cbWriteAnnotations.Location = new System.Drawing.Point(6, 44);
            this.cbWriteAnnotations.Name = "cbWriteAnnotations";
            this.cbWriteAnnotations.Size = new System.Drawing.Size(121, 17);
            this.cbWriteAnnotations.TabIndex = 1;
            this.cbWriteAnnotations.Tag = "write_annotations";
            this.cbWriteAnnotations.Text = "Write Annotations";
            this.toolTip.SetToolTip(this.cbWriteAnnotations, "Write video annotations to a .annotations.xml file.");
            this.cbWriteAnnotations.UseVisualStyleBackColor = true;
            // 
            // cbWriteDescription
            // 
            this.cbWriteDescription.AutoSize = true;
            this.cbWriteDescription.Location = new System.Drawing.Point(6, 21);
            this.cbWriteDescription.Name = "cbWriteDescription";
            this.cbWriteDescription.Size = new System.Drawing.Size(116, 17);
            this.cbWriteDescription.TabIndex = 0;
            this.cbWriteDescription.Tag = "write_description";
            this.cbWriteDescription.Text = "Write Description";
            this.toolTip.SetToolTip(this.cbWriteDescription, "Write video description to a .description file.");
            this.cbWriteDescription.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 140;
            // 
            // cbAddMetadata
            // 
            this.cbAddMetadata.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAddMetadata.AutoSize = true;
            this.cbAddMetadata.Location = new System.Drawing.Point(3, 80);
            this.cbAddMetadata.Name = "cbAddMetadata";
            this.cbAddMetadata.Size = new System.Drawing.Size(99, 17);
            this.cbAddMetadata.TabIndex = 5;
            this.cbAddMetadata.Tag = "add_metadata";
            this.cbAddMetadata.Text = "Add Metadata";
            this.toolTip.SetToolTip(this.cbAddMetadata, "Write metadata to the video file.");
            this.cbAddMetadata.UseVisualStyleBackColor = true;
            // 
            // cbEmbedThumbnail
            // 
            this.cbEmbedThumbnail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEmbedThumbnail.AutoSize = true;
            this.cbEmbedThumbnail.Location = new System.Drawing.Point(3, 57);
            this.cbEmbedThumbnail.Name = "cbEmbedThumbnail";
            this.cbEmbedThumbnail.Size = new System.Drawing.Size(119, 17);
            this.cbEmbedThumbnail.TabIndex = 4;
            this.cbEmbedThumbnail.Tag = "embed_thumbnail";
            this.cbEmbedThumbnail.Text = "Embed Thumbnail";
            this.toolTip.SetToolTip(this.cbEmbedThumbnail, "Embed thumbnail in the audio as cover art.");
            this.cbEmbedThumbnail.UseVisualStyleBackColor = true;
            // 
            // cbxAudioOnly
            // 
            this.cbxAudioOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAudioOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioOnly.FormattingEnabled = true;
            this.cbxAudioOnly.Location = new System.Drawing.Point(128, 3);
            this.cbxAudioOnly.Name = "cbxAudioOnly";
            this.cbxAudioOnly.Size = new System.Drawing.Size(170, 21);
            this.cbxAudioOnly.TabIndex = 1;
            this.cbxAudioOnly.Tag = "audio_only.dropdown";
            this.toolTip.SetToolTip(this.cbxAudioOnly, "Convert video file to audio-only file.");
            // 
            // cbAudioOnly
            // 
            this.cbAudioOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAudioOnly.AutoSize = true;
            this.cbAudioOnly.Location = new System.Drawing.Point(3, 5);
            this.cbAudioOnly.Name = "cbAudioOnly";
            this.cbAudioOnly.Size = new System.Drawing.Size(87, 17);
            this.cbAudioOnly.TabIndex = 0;
            this.cbAudioOnly.Tag = "audio_only";
            this.cbAudioOnly.Text = "Audio Only:";
            this.toolTip.SetToolTip(this.cbAudioOnly, "Convert video file to audio-only file.");
            this.cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // cbRecodeFormat
            // 
            this.cbRecodeFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRecodeFormat.AutoSize = true;
            this.cbRecodeFormat.Location = new System.Drawing.Point(3, 32);
            this.cbRecodeFormat.Name = "cbRecodeFormat";
            this.cbRecodeFormat.Size = new System.Drawing.Size(106, 17);
            this.cbRecodeFormat.TabIndex = 2;
            this.cbRecodeFormat.Tag = "recode_format";
            this.cbRecodeFormat.Text = "Recode Format:";
            this.toolTip.SetToolTip(this.cbRecodeFormat, "Encode the video to another format if necessary.");
            this.cbRecodeFormat.UseVisualStyleBackColor = true;
            // 
            // cbxRecodeFormat
            // 
            this.cbxRecodeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRecodeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecodeFormat.FormattingEnabled = true;
            this.cbxRecodeFormat.Location = new System.Drawing.Point(128, 30);
            this.cbxRecodeFormat.Name = "cbxRecodeFormat";
            this.cbxRecodeFormat.Size = new System.Drawing.Size(170, 21);
            this.cbxRecodeFormat.TabIndex = 3;
            this.cbxRecodeFormat.Tag = "recode_format.value";
            this.toolTip.SetToolTip(this.cbxRecodeFormat, "Encode the video to another format if necessary.");
            // 
            // rbSubLanguages
            // 
            this.rbSubLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSubLanguages.AutoSize = true;
            this.rbSubLanguages.Location = new System.Drawing.Point(3, 49);
            this.rbSubLanguages.Name = "rbSubLanguages";
            this.rbSubLanguages.Size = new System.Drawing.Size(84, 22);
            this.rbSubLanguages.TabIndex = 1;
            this.rbSubLanguages.Tag = "languages";
            this.rbSubLanguages.Text = "Languages:";
            this.toolTip.SetToolTip(this.rbSubLanguages, "Languages of the subtitles to download. Separated by commas.");
            this.rbSubLanguages.UseVisualStyleBackColor = true;
            // 
            // txtSubLanguages
            // 
            this.txtSubLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubLanguages.Location = new System.Drawing.Point(95, 49);
            this.txtSubLanguages.Name = "txtSubLanguages";
            this.txtSubLanguages.Size = new System.Drawing.Size(343, 22);
            this.txtSubLanguages.TabIndex = 2;
            this.txtSubLanguages.Tag = "languages.value";
            this.toolTip.SetToolTip(this.txtSubLanguages, "Languages of the subtitles to download. Separated by commas. Lowercase language codes (e.g. en, de, fr-CA, zh-Hans, es-MX)");
            // 
            // rbSubAll
            // 
            this.rbSubAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSubAll.AutoSize = true;
            this.rbSubAll.Location = new System.Drawing.Point(3, 77);
            this.rbSubAll.Name = "rbSubAll";
            this.rbSubAll.Size = new System.Drawing.Size(86, 20);
            this.rbSubAll.TabIndex = 3;
            this.rbSubAll.Tag = "all_subtitles";
            this.rbSubAll.Text = "All Subtitles";
            this.toolTip.SetToolTip(this.rbSubAll, "Download all the available subtitles of the video.");
            this.rbSubAll.UseVisualStyleBackColor = true;
            // 
            // rbSubDefault
            // 
            this.rbSubDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSubDefault.AutoSize = true;
            this.rbSubDefault.Location = new System.Drawing.Point(3, 26);
            this.rbSubDefault.Name = "rbSubDefault";
            this.rbSubDefault.Size = new System.Drawing.Size(63, 17);
            this.rbSubDefault.TabIndex = 4;
            this.rbSubDefault.Tag = "default";
            this.rbSubDefault.Text = "Default";
            this.toolTip.SetToolTip(this.rbSubDefault, "Write the default subtitle file.");
            this.rbSubDefault.UseVisualStyleBackColor = true;
            // 
            // cbCustomFormatSelector
            // 
            this.cbCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCustomFormatSelector.AutoSize = true;
            this.cbCustomFormatSelector.Location = new System.Drawing.Point(6, 341);
            this.cbCustomFormatSelector.Name = "cbCustomFormatSelector";
            this.cbCustomFormatSelector.Size = new System.Drawing.Size(148, 17);
            this.cbCustomFormatSelector.TabIndex = 1;
            this.cbCustomFormatSelector.Tag = "selector";
            this.cbCustomFormatSelector.Text = "Custom Format Selector";
            this.cbCustomFormatSelector.UseVisualStyleBackColor = true;
            // 
            // txtCustomFormatSelector
            // 
            this.txtCustomFormatSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomFormatSelector.Location = new System.Drawing.Point(6, 364);
            this.txtCustomFormatSelector.Name = "txtCustomFormatSelector";
            this.txtCustomFormatSelector.ReadOnly = true;
            this.txtCustomFormatSelector.Size = new System.Drawing.Size(760, 22);
            this.txtCustomFormatSelector.TabIndex = 2;
            this.txtCustomFormatSelector.Tag = "selector.value";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.frameRateSelector, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoQualitySelector, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbGeneral, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbFileSystem, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbPostProcessing, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbSubtitles, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 332);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Tag = "#$";
            // 
            // gbPostProcessing
            // 
            this.gbPostProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPostProcessing.Controls.Add(this.tableLayoutPanel2);
            this.gbPostProcessing.Location = new System.Drawing.Point(3, 183);
            this.gbPostProcessing.Name = "gbPostProcessing";
            this.gbPostProcessing.Size = new System.Drawing.Size(307, 121);
            this.gbPostProcessing.TabIndex = 4;
            this.gbPostProcessing.TabStop = false;
            this.gbPostProcessing.Tag = "post_processing";
            this.gbPostProcessing.Text = "Post Processing";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cbAddMetadata, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbEmbedThumbnail, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxAudioOnly, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbAudioOnly, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbRecodeFormat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxRecodeFormat, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Tag = "#$";
            // 
            // gbSubtitles
            // 
            this.gbSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gbSubtitles, 2);
            this.gbSubtitles.Controls.Add(this.tableLayoutPanel3);
            this.gbSubtitles.Location = new System.Drawing.Point(316, 183);
            this.gbSubtitles.Name = "gbSubtitles";
            this.gbSubtitles.Size = new System.Drawing.Size(447, 121);
            this.gbSubtitles.TabIndex = 5;
            this.gbSubtitles.TabStop = false;
            this.gbSubtitles.Tag = "subtitles";
            this.gbSubtitles.Text = "Subtitles";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.rbSubDefault, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbNoSubtitles, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbSubLanguages, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rbSubAll, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtSubLanguages, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 100);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Tag = "#$";
            // 
            // rbNoSubtitles
            // 
            this.rbNoSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNoSubtitles.AutoSize = true;
            this.rbNoSubtitles.Checked = true;
            this.rbNoSubtitles.Location = new System.Drawing.Point(3, 3);
            this.rbNoSubtitles.Name = "rbNoSubtitles";
            this.rbNoSubtitles.Size = new System.Drawing.Size(53, 17);
            this.rbNoSubtitles.TabIndex = 0;
            this.rbNoSubtitles.TabStop = true;
            this.rbNoSubtitles.Tag = "none";
            this.rbNoSubtitles.Text = "None";
            this.rbNoSubtitles.UseVisualStyleBackColor = true;
            // 
            // frameRateSelector
            // 
            this.frameRateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameRateSelector.Location = new System.Drawing.Point(316, 3);
            this.frameRateSelector.Name = "frameRateSelector";
            this.frameRateSelector.OnChange = null;
            this.frameRateSelector.Size = new System.Drawing.Size(307, 96);
            this.frameRateSelector.TabIndex = 1;
            this.frameRateSelector.Tag = "#";
            // 
            // videoQualitySelector
            // 
            this.videoQualitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoQualitySelector.Location = new System.Drawing.Point(3, 3);
            this.videoQualitySelector.MinimumSize = new System.Drawing.Size(150, 50);
            this.videoQualitySelector.Name = "videoQualitySelector";
            this.videoQualitySelector.OnChange = null;
            this.videoQualitySelector.Size = new System.Drawing.Size(307, 96);
            this.videoQualitySelector.TabIndex = 0;
            this.videoQualitySelector.Tag = "#";
            // 
            // TabGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtCustomFormatSelector);
            this.Controls.Add(this.cbCustomFormatSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabGeneral";
            this.Size = new System.Drawing.Size(772, 395);
            this.Tag = "#";
            this.Load += new System.EventHandler(this.TabGeneral_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbFileSystem.ResumeLayout(false);
            this.gbFileSystem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbPostProcessing.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbSubtitles.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbIgnoreErrors;
        private System.Windows.Forms.CheckBox cbAbortOnErrors;
        private System.Windows.Forms.GroupBox gbFileSystem;
        private System.Windows.Forms.CheckBox cbWriteAnnotations;
        private System.Windows.Forms.CheckBox cbWriteDescription;
        public Controls.FrameRateSelector frameRateSelector;
        public Controls.VideoQualitySelector videoQualitySelector;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.CheckBox cbNoOverwrites;
        public System.Windows.Forms.CheckBox cbRestrictFilenames;
        public System.Windows.Forms.CheckBox cbWriteThumbnail;
        private System.Windows.Forms.CheckBox cbCustomFormatSelector;
        private System.Windows.Forms.TextBox txtCustomFormatSelector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbPostProcessing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cbAddMetadata;
        private System.Windows.Forms.CheckBox cbEmbedThumbnail;
        public System.Windows.Forms.ComboBox cbxAudioOnly;
        public System.Windows.Forms.CheckBox cbAudioOnly;
        private System.Windows.Forms.CheckBox cbRecodeFormat;
        private System.Windows.Forms.ComboBox cbxRecodeFormat;
        private System.Windows.Forms.GroupBox gbSubtitles;
        private System.Windows.Forms.TextBox txtSubLanguages;
        private System.Windows.Forms.RadioButton rbSubLanguages;
        private System.Windows.Forms.RadioButton rbNoSubtitles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbSubAll;
        private System.Windows.Forms.RadioButton rbSubDefault;
    }
}
