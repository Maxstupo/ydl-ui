using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Maxstupo.YdlUi.YoutubeDL;
using Maxstupo.YdlUi.Forms;
using Maxstupo.YdlUi.YoutubeDL.Model;

namespace Maxstupo.YdlUi.Controls {
    public partial class KeywordTextBox : TextBox {


        public bool KeywordMatchingEnabled { get; set; } = true;


        public bool HasMatch { get; private set; }

        private List<Match> matches;

        public KeywordTextBox() {
            InitializeComponent();


            ContextMenu = new ContextMenu();

            MenuItem insertButton = new MenuItem("Insert...");

            insertButton.Click += InsertButton_Click;

            ContextMenu.MenuItems.Add(insertButton);



            KeyUp += KeywordTextbox_KeyUp;
            KeyDown += KeywordTextbox_KeyDown;
            MouseUp += (s, e) => FindAndSelectMatch();
            TextChanged += (s, e) => FindMatches();
            FindMatches();

        }
              
        public void ShowKeywordDialog() {
            using (FormKeyword dialog = new FormKeyword()) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string keyword = Keyword.Template.Replace("{keyword}", dialog.SelectedKeyword.Value);
                    InsertKeyword(keyword);
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e) {
            ShowKeywordDialog();
        }

        private void KeywordTextbox_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                FindAndSelectMatch();
        }

        private void KeywordTextbox_KeyDown(object sender, KeyEventArgs e) {
            if (!HasMatch || !KeywordMatchingEnabled)
                return;

            if (e.KeyCode == Keys.Left) {
                int start = SelectionStart - SelectionLength;
                if (start < 0)
                    SelectionLength = 0;
                SelectionStart = Math.Max(0, start + 1);

            } else if (e.KeyCode == Keys.Right) {
                SelectionStart = (SelectionStart + SelectionLength) - 1;
                SelectionLength = 0;
            }
        }

        public void FindMatches() {
            if (!KeywordMatchingEnabled)
                return;
            matches = Regex.Matches(Text, Keyword.Regex).Cast<Match>().ToList();
        }

        private void FindAndSelectMatch() {
            if (matches == null || !KeywordMatchingEnabled)
                return;
            HasMatch = false;

            foreach (Match match in matches) {
                int matchStart = match.Index;
                int matchLength = match.Length;
                int matchEnd = matchStart + matchLength;

                int selectionStart = SelectionStart;
                int selectionLength = SelectionLength;
                int selectionEnd = selectionStart + selectionLength;

                if (selectionStart > matchStart && selectionEnd < matchEnd) {
                    HasMatch = true;
                    Select(matchStart, matchLength);
                    break;
                }
            }
        }

        public void InsertKeyword(string text) {
            if (!KeywordMatchingEnabled)
                return;

            text = text ?? string.Empty;

            int start = SelectionStart;
            int length = SelectionLength;

            if (SelectionLength > 0)
                Text = Text.Remove(start, length);

            Text = Text.Insert(start, text);
            Select(Text.Length, 0);
        }
    }


}
