using Maxstupo.YdlUi.Utility;
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
    public partial class FormPlaylistRangeEditor : Form {


        private readonly BindingList<PlaylistItem> list = new BindingList<PlaylistItem>();


        public string Selector {
            get {
                StringBuilder sb = new StringBuilder();

                foreach (PlaylistItem item in list) {
                    if (item.IsRange) {
                        sb.Append(item.Start).Append('-').Append(item.End);
                    } else {
                        sb.Append(item.Start);
                    }
                    sb.Append(',');
                }

                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);

                return sb.ToString();

            }
        }

        public FormPlaylistRangeEditor(string items = null) {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(items)) {
                foreach (string token in items.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)) {
                    string[] values = token.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                    if (values.Length > 1) {
                        if (int.TryParse(values[0], out int start) && int.TryParse(values[1], out int end))
                            list.Add(new PlaylistItem(start, end));

                    } else if (values.Length == 1) {
                        if (int.TryParse(values[0], out int index))
                            list.Add(new PlaylistItem(index));
                    }
                }
            }
        }

        private void FormPlaylistRangeEditor_Load(object sender, EventArgs e) {
            lbxPlaylistItems.DataSource = list;
            lbxPlaylistItems.DisplayMember = nameof(PlaylistItem.Formatted);

            Localization.ApplyLocaleText(this);
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (FormPromptNumber dialog = new FormPromptNumber( false)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PlaylistItem item = new PlaylistItem(dialog.Value1);

                    if (!list.Contains(item))
                        list.Add(item);
                }
            }

            DialogResult = DialogResult.None;
        }

        private void btnAddRange_Click(object sender, EventArgs e) {
            using (FormPromptNumber dialog = new FormPromptNumber(true)) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    PlaylistItem item = new PlaylistItem(dialog.Value1, dialog.Value2);

                    if (!list.Contains(item))
                        list.Add(item);
                }
            }

            DialogResult = DialogResult.None;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lbxPlaylistItems.SelectedItem is PlaylistItem item)
                list.Remove(item);
        }

        private void lbxPlaylistItems_SelectedValueChanged(object sender, EventArgs e) {
            btnDelete.Enabled = lbxPlaylistItems.SelectedItem != null;
        }
    }

    public class PlaylistItem : IEquatable<PlaylistItem> {
        public int Start { get; }
        public int End { get; }

        public bool IsRange { get => Start != End; }
        public string Formatted { get => IsRange ? $"{Start} - {End}" : Start.ToString(); }

        public PlaylistItem(int index) : this(index, index) { }

        public PlaylistItem(int start, int end) {
            Start = start;
            End = end;
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
