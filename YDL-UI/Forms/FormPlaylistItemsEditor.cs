using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Forms {


    public partial class FormPlaylistItemsEditor : Form {

        private BindingList<PlaylistItem> list = new BindingList<PlaylistItem>();

        public string PlaylistItemSelector {
            get {
                StringBuilder sb = new StringBuilder();

                foreach (PlaylistItem item in list) {
                    if (item.IsRange) {
                        sb.Append(item.Start).Append('-').Append(item.End);
                    } else {
                        sb.Append(item.Index);
                    }
                    sb.Append(',');
                }

                if (sb.Length > 0 && list.Count > 0)
                    sb.Remove(sb.Length - 1, 1);

                return sb.ToString();
            }
        }

        public FormPlaylistItemsEditor(string input = null) {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(input)) {
                foreach (string token in input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)) {
                    string[] values = token.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                    if (values.Length > 1) {
                        if (int.TryParse(values[0], out int value1) && int.TryParse(values[1], out int value2))
                            list.Add(new PlaylistItem(value1, value2));
                    } else if (values.Length == 1) {
                        if (int.TryParse(values[0], out int index))
                            list.Add(new PlaylistItem(index));
                    }
                }
            }
        }

        private void FormPlaylistItemsEditor_Load(object sender, EventArgs e) {
            lbxPlaylistItems.DataSource = list;
            lbxPlaylistItems.DisplayMember = "Formatted";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (FormPromptNumber dialog = new FormPromptNumber("Add Index...", "Index")) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PlaylistItem item = new PlaylistItem(dialog.Value1);
                    if (!list.Contains(item))
                        list.Add(item);
                }
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e) {
            using (FormPromptNumber dialog = new FormPromptNumber("Add Index Range...", "Start")) {
                dialog.SetInput2("End");
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PlaylistItem item = new PlaylistItem(dialog.Value1, dialog.Value2);
                    if (!list.Contains(item))
                        list.Add(item);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lbxPlaylistItems.SelectedItem is PlaylistItem item)
                list.Remove(item);
        }



        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            btnAdd.PerformClick();
        }

        private void newRangeToolStripMenuItem_Click(object sender, EventArgs e) {
            btnAddRange.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            btnDelete.PerformClick();
        }

        private void lbxPlaylistItems_SelectedValueChanged(object sender, EventArgs e) {
            btnDelete.Enabled = (lbxPlaylistItems.SelectedItem as PlaylistItem) != null;
            deleteToolStripMenuItem.Enabled = btnDelete.Enabled;
        }

        private void lbxPlaylistItems_MouseDown(object sender, MouseEventArgs e) {
            if (sender is ListBox lbx)
                lbx.SelectedIndex = lbx.IndexFromPoint(e.X, e.Y);
        }
    }

    public class PlaylistItem : IEquatable<PlaylistItem> {
        public int Start { get; }
        public int End { get; }

        public int Index { get { return Start; } }

        public bool IsRange { get { return Start != End; } }
        public string Formatted { get { return IsRange ? string.Format("{0} - {1}", Start, End) : Index.ToString(); } }

        public PlaylistItem(int start, int end) {
            this.Start = start;
            this.End = end;
        }

        public PlaylistItem(int index) : this(index, index) {
        }

        public override bool Equals(object obj) {
            return Equals(obj as PlaylistItem);
        }

        public bool Equals(PlaylistItem other) {
            return other != null &&
                   Start == other.Start &&
                   End == other.End;
        }

        public override int GetHashCode() {
            var hashCode = -1676728671;
            hashCode = hashCode * -1521134295 + Start.GetHashCode();
            hashCode = hashCode * -1521134295 + End.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(PlaylistItem item1, PlaylistItem item2) {
            return EqualityComparer<PlaylistItem>.Default.Equals(item1, item2);
        }

        public static bool operator !=(PlaylistItem item1, PlaylistItem item2) {
            return !(item1 == item2);
        }
    }
}
