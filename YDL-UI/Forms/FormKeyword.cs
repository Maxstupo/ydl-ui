using Maxstupo.YdlUi.Utility;
using Maxstupo.YdlUi.YoutubeDL.Model;
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
    public partial class FormKeyword : Form {
        private readonly SortableBindingList<Keyword> keywords;

        public Keyword SelectedKeyword { get => dgvKeywords.SelectedRow<Keyword>(); }

        public FormKeyword() {
            InitializeComponent();
            keywords = new SortableBindingList<Keyword>(Keyword.Keywords.ToList());
        }

        private void FormKeyword_Load(object sender, EventArgs e) {
            dgvKeywords.DataSource = keywords;
            dgvKeywords.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            dgvKeywords.AutoResizeColumn(2, DataGridViewAutoSizeColumnMode.AllCells);

            dgvKeywords.Sort(dgvKeywords.Columns[0], ListSortDirection.Ascending);

            Localization.ApplyLocaleText(this);
        }



        private void btnInsert_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvKeywords_SelectionChanged(object sender, EventArgs e) {
            btnInsert.Enabled = SelectedKeyword != null;
        }

        private void dgvKeywords_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                btnInsert.PerformClick();
        }
    }
}
