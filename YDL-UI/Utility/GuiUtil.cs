using ByteSizeLib;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Utility {
    public static class GuiUtil {

        #region Control Value Getters

        public static ByteSize? GetUnitValue(this NumericUpDown src, ComboBox cbxUnit, ByteSize? defaultValue = null) {
            if (cbxUnit.SelectedValue == null) return defaultValue;

            return src.Enabled && cbxUnit.Enabled ? (ByteSize?)Util.From((double)src.Value, (FilesizeUnit)cbxUnit.SelectedValue) : defaultValue;
        }

        public static void MakeRangeNumericUpDown(NumericUpDown min, NumericUpDown max, decimal minRange = 1) {
            min.ValueChanged += delegate {
                if (min.Value > max.Value - minRange)
                    max.Value = Math.Min(min.Value + minRange, max.Maximum);
            };
            max.ValueChanged += delegate {
                if (max.Value < min.Value + minRange)
                    min.Value = Math.Max(min.Value - minRange, min.Minimum);
            };
        }

        public static T GetSelectedValue<T>(this ComboBox src, T defaultValue = default(T)) {
            return src.Enabled ? (T)src.SelectedValue : defaultValue;
        }

        public static decimal? GetValue(this NumericUpDown src, decimal? defaultValue = null) {
            return src.Enabled ? src.Value : defaultValue;
        }

        public static string GetText(this TextBox src, string defaultValue = null) {
            return src.Enabled && !string.IsNullOrWhiteSpace(src.Text) ? src.Text : defaultValue;
        }

        public static DateTime? GetValue(this DateTimePicker src, DateTime? defaultValue = null) {
            return src.Enabled ? src.Value : defaultValue;
        }

        #endregion


        #region Binding Helpers

        public static void BindEnabledTo(this Control control, TextBox textBox, Func<string, bool> predicate) {
            textBox.TextChanged += (sender, e) => {
                control.Enabled = predicate((sender as TextBox).Text);
            };
        }

        public static Binding BindEnabledTo(this Control control, CheckBox checkBox) {
            return control.DataBindings.Add(nameof(control.Enabled), checkBox, nameof(checkBox.Checked), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static Binding BindEnabledTo(this Control control, RadioButton radioButton) {
            return control.DataBindings.Add(nameof(control.Enabled), radioButton, nameof(radioButton.Checked), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion

        public static void ForEachControl<T>(this Control src, Action<T> action) where T : Control {
            foreach (Control control in src.Controls) {
                control.ForEachControl<T>(action);
                if (control is T item)
                    action(item);
            }
        }

        /// <summary>
        /// Registers a new event handler that will open the cell's URL when the link is clicked with the specified <paramref name="application"/> 
        /// </summary>
        /// <param name="application">The application the URL will be opened with.</param>
        public static void OpenCellLinkOnClick(this DataGridView src, string application) {
            src.OpenCellLinkOnClick(uri => {
                Process.Start(application, uri.AbsoluteUri);
            });
        }

        public static void SelectRowOnRightClick(this DataGridView src) {
            src.CellMouseDown += (sender, e) => {
                if (e.Button == MouseButtons.Right && e.RowIndex != -1) {

                    DataGridViewRow row = (sender as DataGridView).Rows[e.RowIndex];

                    if (src.MultiSelect && !row.Selected)
                        src.ClearSelection();

                    row.Selected = true;
                }
            };
        }

        /// <summary>
        /// Registers a new event handler that will open the cell's URL when the link is clicked.
        /// </summary>
        /// <param name="action">A custom user-defined action for when the cell's link is clicked.</param>
        public static void OpenCellLinkOnClick(this DataGridView src, Action<Uri> action = null) {
            src.CellContentClick += (sender, e) => {
                if (e == null || e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                if (!(sender is DataGridView dgv))
                    return;

                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell) {
                    if (action != null) {
                        action(new Uri(cell.Value as string));
                    } else {
                        Process.Start(cell.Value as string);
                    }
                }
            };
        }

        /// <summary>
        /// Returns the selected row of the <see cref="DataGridView"/>. If more than one row is selected, return null.
        /// </summary>
        /// <returns>Returns the first selected row of the <see cref="DataGridView"/>.</returns>
        public static T SelectedRow<T>(this DataGridView src) where T : class {
            return src.HasSingleSelectedRow() ? ((T)src.SelectedRows[0].DataBoundItem) : null;
        }

        public static T[] SelectedRows<T>(this DataGridView src) where T : class {
            if (!src.HasSelectedRows())
                return null;
            List<T> list = new List<T>();
            foreach (DataGridViewRow row in src.SelectedRows)
                list.Add((T)row.DataBoundItem);
            return list.ToArray();
        }

        /// <summary>
        /// Returns true if <see cref="DataGridView"/> has one or more rows selected.
        /// </summary>
        /// <returns>Returns true if <see cref="DataGridView"/> has one or more rows selected.</returns>
        public static bool HasSelectedRows(this DataGridView src) {
            return src.SelectedRows.Count > 0;
        }

        public static bool HasSingleSelectedRow(this DataGridView src) {
            return src.SelectedRows.Count == 1;
        }

        public static void SelectRows<T>(this DataGridView src, Func<T, bool> predicate, bool deselectOnFail = true) {
            foreach (DataGridViewRow row in src.Rows) {
                T item = (T)row.DataBoundItem;

                if (predicate(item)) {
                    row.Selected = true;

                } else if (deselectOnFail) {
                    row.Selected = false;

                }
            }
        }

        public static void PreloadTabs(this TabControl src) {
            bool state = src.Visible;
            src.Visible = true;
            {
                int index = src.SelectedIndex;
                for (int i = 0; i < src.TabCount; i++)
                    src.SelectedIndex = i;
                src.SelectedIndex = index;
            }
            src.Visible = state;
        }

        public static string SelectFolder(string title, string initialDirectory = null) {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog(title)) {
                dialog.IsFolderPicker = true;
                dialog.InitialDirectory = initialDirectory;
                dialog.Multiselect = false;
                dialog.EnsurePathExists = true;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    return dialog.FileName;
            }
            return null;
        }

        public static string SelectFile(IWin32Window owner, string title, string filter, string initialDirectory = null, bool checkIfExists = true) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.CheckFileExists = checkIfExists;
                dialog.CheckPathExists = checkIfExists;
                dialog.Multiselect = false;
                dialog.Filter = filter;
                dialog.Title = title;
                dialog.InitialDirectory = initialDirectory;

                if (dialog.ShowDialog(owner) == DialogResult.OK)
                    return dialog.FileName;
            }
            return null;
        }

    }
}
