﻿namespace Maxstupo.YdlUi.Utility {

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Windows.Forms;
    using ByteSizeLib;
    using Microsoft.WindowsAPICodePack.Dialogs;

    public static class GuiUtil {

        #region Control Value Getters

        /// <summary>
        /// Returns a <see cref="ByteSize"/> value of the <see cref="NumericUpDown"/>, or <paramref name="defaultValue"/> if the <see cref="NumericUpDown"/> is disabled.
        /// </summary>
        /// <param name="cbxUnit">The filesize unit to convert.</param>
        /// <param name="defaultValue">The value to return if the <paramref name="cbxUnit"/> doesn't have a selected value, or the <see cref="NumericUpDown"/> is disabled.</param>
        /// <returns>A <see cref="ByteSize"/> value or <paramref name="defaultValue"/>.</returns>
        public static ByteSize? GetUnitValue(this NumericUpDown src, ComboBox cbxUnit, ByteSize? defaultValue = null) {
            if (cbxUnit.SelectedValue == null) return defaultValue;

            return src.Enabled && cbxUnit.Enabled ? (ByteSize?) Util.From((double) src.Value, (FilesizeUnit) cbxUnit.SelectedValue) : defaultValue;
        }

        /// <summary>
        /// Binds two <see cref="NumericUpDown"/> controls together to create a range selector.</code>
        /// </summary>
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

        /// <summary>
        /// Returns the <see cref="ComboBox"/> selected value, or the <paramref name="defaultValue"/> if the control is disabled.
        /// </summary>
        /// <param name="defaultValue">The value to return if the control is disabled.</param>
        /// <returns>The <see cref="ComboBox"/> selected value, or the <paramref name="defaultValue"/> if the control is disabled.</returns>
        public static T GetSelectedValue<T>(this ComboBox src, T defaultValue = default) {
            return src.Enabled ? (T) src.SelectedValue : defaultValue;
        }

        /// <summary>
        /// Returns the <see cref="NumericUpDown"/> value, or the <paramref name="defaultValue"/> if the control is disabled.
        /// </summary>
        /// <param name="defaultValue">The value to return if the control is disabled.</param>
        /// <returns>The <see cref="NumericUpDown"/> value, or the <paramref name="defaultValue"/> if the control is disabled.</returns>
        public static decimal? GetValue(this NumericUpDown src, decimal? defaultValue = null) {
            return src.Enabled ? src.Value : defaultValue;
        }

        /// <summary>
        /// Returns the <see cref="TextBox"/> text, or the <paramref name="defaultValue"/> if the control is disabled or the text is whitespace only.
        /// </summary>
        /// <param name="defaultValue">The value to return if the control is disabled or text is whitespace.</param>
        /// <returns>The <see cref="TextBox"/> text, or the <paramref name="defaultValue"/> if the control is disabled or the text is whitespace only.</returns>
        public static string GetText(this TextBox src, string defaultValue = null) {
            return src.Enabled && !string.IsNullOrWhiteSpace(src.Text) ? src.Text : defaultValue;
        }

        /// <summary>
        /// Returns the <see cref="DateTime"/> value, or the <paramref name="defaultValue"/> if the control is disabled.
        /// </summary>
        /// <param name="defaultValue">The value to return if the control is disabled.</param>
        /// <returns>The <see cref="DateTime"/> value, or the <paramref name="defaultValue"/> if the control is disabled.</returns>
        public static DateTime? GetValue(this DateTimePicker src, DateTime? defaultValue = null) {
            return src.Enabled ? src.Value : defaultValue;
        }

        #endregion


        #region Binding Helpers

        private static void SwitchBool(object s, ConvertEventArgs ee) {
            ee.Value = !((bool) ee.Value);
        }

        public static Binding Invert(this Binding src) {
            src.Format += SwitchBool;
            src.Parse += SwitchBool;
            return src;
        }

        /// <summary>
        /// Binds <see cref="Control.Enabled"/> to the provided predicate. The predicate is passed the text of the textbox, it's called whenever the text changes.
        /// </summary>
        public static void BindEnabledTo(this Control control, TextBox textBox, Func<string, bool> predicate) {
            void textChanged(object sender, EventArgs e) {
                control.Enabled = predicate((sender as TextBox).Text);
            };
            textBox.TextChanged += textChanged;
            textChanged(textBox, null);
        }

        /// <summary>
        /// Binds <see cref="Control.Enabled"/> to the <see cref="CheckBox.Checked"/> property.
        /// </summary>
        /// <returns>The <see cref="Binding"/> that was created.</returns>
        public static Binding BindEnabledTo(this Control control, CheckBox checkBox) {
            return control.DataBindings.Add(nameof(control.Enabled), checkBox, nameof(checkBox.Checked), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Binds <see cref="Control.Enabled"/> to the <see cref="RadioButton.Checked"/> property.
        /// </summary>
        /// <returns>The <see cref="Binding"/> that was created.</returns>
        public static Binding BindEnabledTo(this Control control, RadioButton radioButton) {
            return control.DataBindings.Add(nameof(control.Enabled), radioButton, nameof(radioButton.Checked), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Binds <see cref="TextBox.ReadOnly"/> to the <see cref="CheckBox.Checked"/> property.
        /// </summary>
        /// <returns>The <see cref="Binding"/> that was created.</returns>
        public static Binding BindReadonlyTo(this TextBox control, CheckBox checkbox) {
            return control.DataBindings.Add(nameof(control.ReadOnly), checkbox, nameof(checkbox.Checked), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion

        /// <summary>
        /// Call the given <paramref name="action"/> on all <see cref="Control"/> descendants of the type <typeparamref name="T"/>. 
        /// </summary>
        /// <param name="action">The action to be executed.</param>
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
            src.OpenCellLinkOnClick(uri => Process.Start(application, uri.AbsoluteUri));
        }

        /// <summary>
        /// Registers a new event handler that will select the row on right click.
        /// </summary>
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

                    string urlLink = (cell.Value as string).Trim();

                    if (!urlLink.StartsWith("https://www.youtube.com"))
                        urlLink = string.Format("https://www.youtube.com/watch?v={0}", urlLink);

                    if (action != null) {
                        action(new Uri(urlLink));
                    } else {
                        Process.Start(urlLink);
                    }
                }
            };
        }

        /// <summary>
        /// Returns the selected row of the <see cref="DataGridView"/>. If more than one row is selected, return null.
        /// </summary>
        /// <returns>Returns the first selected row of the <see cref="DataGridView"/>.</returns>
        public static T SelectedRow<T>(this DataGridView src) where T : class {
            return src.HasSingleSelectedRow() ? ((T) src.SelectedRows[0].DataBoundItem) : null;
        }

        /// <summary>
        /// Returns the selected rows of the <see cref="DataGridView"/>. If zero rows are selected, return null.
        /// </summary>
        /// <returns>Returns the selected rows or null if none are selected.</returns>
        public static T[] SelectedRows<T>(this DataGridView src) where T : class {
            if (!src.HasSelectedRows())
                return null;
            List<T> list = new List<T>();
            foreach (DataGridViewRow row in src.SelectedRows)
                list.Add((T) row.DataBoundItem);
            return list.ToArray();
        }

        /// <summary>
        /// Returns true if <see cref="DataGridView"/> has one or more rows selected.
        /// </summary>
        /// <returns>Returns true if <see cref="DataGridView"/> has one or more rows selected.</returns>
        public static bool HasSelectedRows(this DataGridView src) {
            return src.SelectedRows.Count > 0;
        }

        /// <summary>
        /// Returns true if <see cref="DataGridView"/> has <strong>one</strong> selected row.
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static bool HasSingleSelectedRow(this DataGridView src) {
            return src.SelectedRows.Count == 1;
        }

        /// <summary>
        /// Select any row of the <see cref="DataGridView"/> if the predicate returns true.
        /// </summary>
        /// <param name="predicate">The predicate to test each row item with, return true to select row.</param>
        /// <param name="deselectOnFail">If true and the predicate returns false the row will be unselected.</param>
        public static void SelectRows<T>(this DataGridView src, Func<T, bool> predicate, bool deselectOnFail = true) {
            foreach (DataGridViewRow row in src.Rows) {
                T item = (T) row.DataBoundItem;

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

        /// <summary>
        /// Opens a select folder dialog with no multiselect and filepath validation enabled.
        /// </summary>
        /// <param name="form">The form that will own the modal dialog.</param>
        /// <param name="title">The title of the dialog.</param>
        /// <param name="initialDirectory">The initial directory that the dialog will display.</param>
        /// <returns>The selected filepath or null if cancel was selected.</returns>
        public static string SelectFolder(Form form, string title, string initialDirectory = null, bool useWinformsFolderPicker = false) {
            if (!useWinformsFolderPicker) {
                using (CommonOpenFileDialog dialog = new CommonOpenFileDialog(title)) {
                    dialog.IsFolderPicker = true;
                    dialog.InitialDirectory = initialDirectory;
                    dialog.Multiselect = false;
                    dialog.EnsurePathExists = true;

                    if (dialog.ShowDialog(form.Handle) == CommonFileDialogResult.Ok)
                        return dialog.FileName;
                }
            } else {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
                    dialog.Description = title;
                    dialog.ShowNewFolderButton = true;
                    dialog.SelectedPath = initialDirectory;

                    if (dialog.ShowDialog(form) == DialogResult.OK)
                        return dialog.SelectedPath;
                }
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