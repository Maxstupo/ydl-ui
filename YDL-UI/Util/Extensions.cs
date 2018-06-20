using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Util {
    public class ControlListenGroup {
        public delegate void OnChange();
        public event OnChange OnChanged;

        private ControlListenGroup() { }

        public void Trigger() {
            OnChanged?.Invoke();
        }

        public void Listen(params CheckBox[] radios) {
            foreach (CheckBox r in radios)
                r.Listen(this);
        }

        public void Listen(params NumericUpDown[] nuds) {
            foreach (NumericUpDown r in nuds)
                r.Listen(this);
        }

        public void Listen(params RadioButton[] radios) {
            foreach (RadioButton r in radios)
                r.Listen(this);
        }

        public static ControlListenGroup New() {
            return new ControlListenGroup();
        }

    }

    public static class Extensions {
        public static ToolStripMenuItem CheckboxMode(this ToolStripMenuItem src) {
            src.Click += (s, e) => {
                if (s is ToolStripMenuItem tsmi)
                    tsmi.Checked = !tsmi.Checked;
            };
            return src;
        }

        #region Listen

        public static TextBox Listen(this TextBox src, ControlListenGroup listen) {
            if (listen != null) src.TextChanged += (s, e) => listen.Trigger();
            return src;
        }

        public static CheckBox Listen(this CheckBox src, ControlListenGroup listen) {
            if (listen != null) src.CheckedChanged += (s, e) => listen.Trigger();
            return src;
        }

        public static RadioButton Listen(this RadioButton src, ControlListenGroup listen) {
            if (listen != null) src.CheckedChanged += (s, e) => listen.Trigger();
            return src;
        }

        public static DataGridView Listen(this DataGridView src, ControlListenGroup listen) {
            if (listen != null) {
                src.RowsAdded += (s, e) => listen.Trigger();
                src.RowsRemoved += (s, e) => listen.Trigger();
                src.CellValueChanged += (s, e) => listen.Trigger();
            }
            return src;
        }

        public static NumericUpDown Listen(this NumericUpDown src, ControlListenGroup listen) {
            if (listen != null) src.ValueChanged += (s, e) => listen.Trigger();
            return src;
        }

        public static DateTimePicker Listen(this DateTimePicker src, ControlListenGroup listen) {
            if (listen != null) src.ValueChanged += (s, e) => listen.Trigger();
            return src;
        }

        public static ComboBox Listen(this ComboBox src, ControlListenGroup listen, Action action = null) {
            if (listen != null) src.SelectionChangeCommitted += (s, e) => listen.Trigger();
            action?.Invoke();
            return src;
        }

        #endregion

        #region BindValue

        public static TextBox BindValueTo(this TextBox src, Action<string> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.GetValue(enabled));

            src.TextChanged += (s, e) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();
            evt();

            src.Listen(clg);
            enabled?.Listen(clg);

            return src;
        }

        public static DataGridView BindValueTo(this DataGridView src, Action<DataGridViewRowCollection> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.Rows);

            src.RowsAdded += (s, e) => evt();
            src.RowsRemoved += (s, e) => evt();
            src.CellValueChanged += (s, e) => evt();

            if (enabled != null)
                enabled.CheckedChanged += (s, e) => evt();
            evt();
            src.Listen(clg);
            enabled?.Listen(clg);
            return src;
        }

        public static CheckBox BindValueTo(this CheckBox src, Action<bool> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            src.CheckedChanged += (s, e) => action(src.Checked);
            action(src.Checked);
            src.Listen(clg);
            enabled?.Listen(clg);
            return src;
        }

        public static RadioButton BindValueTo(this RadioButton src, Action<bool> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.Checked);

            src.CheckedChanged += (s, e) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();
            evt();

            src.Listen(clg);
            enabled?.Listen(clg);
            return src;
        }

        public static ComboBox BindValueTo(this ComboBox src, Action<object> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.GetValue(enabled));

            src.SelectionChangeCommitted += (e, s) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();

            evt();

            src.Listen(clg);
            enabled?.Listen(clg);

            return src;
        }

        public static NumericUpDown BindValueTo(this NumericUpDown src, Action<float?> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.GetValueFloat(enabled));

            src.ValueChanged += (e, s) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();

            evt();

            src.Listen(clg);
            enabled?.Listen(clg);

            return src;
        }

        public static NumericUpDown BindValueTo(this NumericUpDown src, Action<float?> action, RadioButton enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.GetValueFloat(enabled));

            src.ValueChanged += (e, s) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();

            evt();

            src.Listen(clg);
            enabled?.Listen(clg);

            return src;
        }

        public static DateTimePicker BindValueTo(this DateTimePicker src, Action<DateTime?> action, CheckBox enabled = null, ControlListenGroup clg = null) {
            void evt() => action(src.GetValue(enabled));
            src.ValueChanged += (s, e) => evt();
            if (enabled != null)
                enabled.CheckedChanged += (e, s) => evt();

            evt();
            src.Listen(clg);
            enabled?.Listen(clg);
            return src;
        }

        #endregion
        
        public static bool IsTextValid(this TextBox src, CheckBox enable) {
            if (enable != null && !enable.Checked)
                return false;
            return !string.IsNullOrWhiteSpace(src.Text);
        }

        public static string GetValue(this TextBox src, CheckBox enable) {
            return src.IsTextValid(enable) ? src.Text : null;
        }

        public static object GetValue(this ComboBox src, CheckBox enable) {
            if (enable != null && !enable.Checked)
                return null;
            return src.SelectedValue;
        }

        public static DateTime? GetValue(this DateTimePicker src, CheckBox enable) {
            if (enable != null && !enable.Checked)
                return null;
            return src.Value;
        }

        public static bool IsTextValid(this TextBox src, RadioButton enable) {
            if (enable != null && !enable.Checked)
                return false;
            return !string.IsNullOrWhiteSpace(src.Text);
        }
     
        public static T Get<T>(this T[] src, int index) {
            if (index < 0 || index >= src.Length)
                return default(T);
            return src[index];
        }

        public static int? GetValueInt(this NumericUpDown src, CheckBox enable = null) {
            if (enable != null && !enable.Checked)
                return null;
            return src.ValueToInt32();
        }

        public static float? GetValueFloat(this NumericUpDown src, CheckBox enable = null) {
            if (enable != null && !enable.Checked)
                return null;
            return (float)src.Value;
        }

        public static float? GetValueFloat(this NumericUpDown src, RadioButton enable = null) {
            if (enable != null && !enable.Checked)
                return null;
            return (float)src.Value;
        }

        public static int ValueToInt32(this NumericUpDown src) {
            return Decimal.ToInt32(src.Value);
        }

        public static string GetText(this TextBox src, RadioButton enabled = null) {
            return src.IsTextValid(enabled) ? src.Text : null;
        }

        public static string GetText(this TextBox src, CheckBox enabled = null) {
            return src.IsTextValid(enabled) ? src.Text : null;
        }

        public static bool IsValidUrl(this TextBox src) {
            return Utils.IsValidUrl(src.Text);
        }

        public static bool ExistsFile(this TextBox src) {
            return File.Exists(src.Text);
        }

        public static bool ExistsDirectory(this TextBox src) {
            return Directory.Exists(src.Text);
        }

        public static T BindEnableTo<T>(this T src, RadioButton cb) where T : Control {
            cb.CheckedChanged += (sender, e) => {
                src.Enabled = cb.Checked;
            };
            src.Enabled = cb.Checked;
            return src;
        }

        public static T BindEnableTo<T>(this T src, CheckBox cb) where T : Control {
            cb.CheckedChanged += (sender, e) => {
                src.Enabled = cb.Checked;
            };
            src.Enabled = cb.Checked;
            return src;
        }


        public static T BindEnableTo<T>(this T src, Func<CheckBox[], bool> callback, params CheckBox[] cb) where T : Control {
            cb.ToList().ForEach(c => {
                c.CheckedChanged += (sender, e) => {
                    src.Enabled = callback(cb);
                };
                src.Enabled = callback(cb);
            });
            return src;
        }
    }

}
