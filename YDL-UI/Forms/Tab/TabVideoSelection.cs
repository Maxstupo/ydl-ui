using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms.Tab {
    public partial class TabVideoSelection : UserControl {

        public TabVideoSelection() {
            InitializeComponent();
        }

        private void TabVideoSelection_Load(object sender, EventArgs e) {
            cbxMaxSizeUnit.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxMaxSizeUnit.SelectedItem = FilesizeUnit.MB;

            cbxMinSizeUnit.DataSource = Enum.GetValues(typeof(FilesizeUnit));
            cbxMinSizeUnit.SelectedItem = FilesizeUnit.MB;

            GuiUtil.MakeRangeNumericUpDown(nudPlaylistStart, nudPlaylistEnd, 1);
            GuiUtil.MakeRangeNumericUpDown(nudMinSize, nudMaxSize, 0.1M);
            GuiUtil.MakeRangeNumericUpDown(nudMinViews, nudMaxViews, 1);

            // Date Filters
            dtpDate.BindEnabledTo(cbDate);
            dtpDateAfter.BindEnabledTo(cbDateAfter);
            dtpDateBefore.BindEnabledTo(cbDateBefore);

            // Filesize Filters
            nudMaxSize.BindEnabledTo(cbMaxSize);
            cbxMaxSizeUnit.BindEnabledTo(cbMaxSize);

            nudMinSize.BindEnabledTo(cbMinSize);
            cbxMinSizeUnit.BindEnabledTo(cbMinSize);

            // View Count Filters
            nudMaxViews.BindEnabledTo(cbMaxViews);
            nudMinViews.BindEnabledTo(cbMinViews);

            // Playlist Filters
            nudPlaylistStart.BindEnabledTo(cbPlaylistStart);
            nudPlaylistEnd.BindEnabledTo(cbPlaylistEnd);

            txtPlaylistRange.BindEnabledTo(cbPlaylistRange);
            btnPlaylistRangeEditor.BindEnabledTo(cbPlaylistRange);

            // Text / Regex Filters
            txtMatchTitle.BindEnabledTo(cbMatchTitle);
            txtRejectTitle.BindEnabledTo(cbRejectTitle);
            txtMatchFilter.BindEnabledTo(cbMatchFilter);
        }

        public void SetArguments(YdlArguments arguments) {
            if (arguments == null)
                return;

            // Selection Type
            arguments.VideoSelection.NoPlaylist = rbSelectionVideo.Checked;
            arguments.VideoSelection.YesPlaylist = rbSelectionPlaylist.Checked;

            // Date Filters
            arguments.VideoSelection.Date = dtpDate.GetValue();
            arguments.VideoSelection.DateAfter = dtpDateAfter.GetValue();
            arguments.VideoSelection.DateBefore = dtpDateBefore.GetValue();

            // Filesize Filters
            arguments.VideoSelection.MinFilesize = nudMinSize.GetUnitValue(cbxMinSizeUnit);
            arguments.VideoSelection.MaxFilesize = nudMaxSize.GetUnitValue(cbxMaxSizeUnit);

            // View Count
            arguments.VideoSelection.MinViews = (int?)nudMinViews.GetValue();
            arguments.VideoSelection.MaxViews = (int?)nudMaxViews.GetValue();

            // Playlist Filters
            arguments.VideoSelection.PlaylistStart = (int?)nudPlaylistStart.GetValue();
            arguments.VideoSelection.PlaylistEnd = (int?)nudPlaylistEnd.GetValue();
            arguments.VideoSelection.PlaylistItems = txtPlaylistRange.GetText();

            arguments.Download.PlaylistRandom = cbPlaylistRandom.Checked;
            arguments.Download.PlaylistReverse = cbPlaylistReversed.Checked;

            // Text / Regex Filters
            arguments.VideoSelection.MatchTitle = txtMatchTitle.GetText();
            arguments.VideoSelection.RejectTitle = txtRejectTitle.GetText();
            arguments.VideoSelection.MatchFilter = txtMatchFilter.GetText();
        }

        // Only allow numbers, commas, and hyphens for playlist range.
        private void txtPlaylistRange_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && !char.IsControl(e.KeyChar);
        }

        private void btnPlaylistRangeEditor_Click(object sender, EventArgs e) {
            using (FormPlaylistRangeEditor dialog = new FormPlaylistRangeEditor(txtPlaylistRange.Text)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) 
                    txtPlaylistRange.Text = dialog.Selector;
            }
        }
    }
}
