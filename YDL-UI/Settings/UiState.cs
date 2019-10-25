using Maxstupo.YdlUi.Controls;
using Maxstupo.YdlUi.Forms;
using Maxstupo.YdlUi.Forms.Tab;
using Maxstupo.YdlUi.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Settings {

    /// <summary>
    /// A class containing a key-value pair, representing a serialized value of a <see cref="Control"/>.
    /// </summary>
    public class ControlState {
        /// <summary>
        /// The key used to identify a <see cref="Control"/>.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The serialized value of the <see cref="Control"/>.
        /// </summary>
        public string Value { get; set; }

        // Used for JSON Serialization.
        public ControlState() { }

        /// <summary>
        /// Create a new <see cref="ControlState"/> with copied values of another.
        /// </summary>
        public ControlState(ControlState copy) : this(copy.Key, copy.Value) {
        }

        public ControlState(string key, string value) {
            this.Key = key;
            this.Value = value;
        }

        public ControlState Copy() {
            return new ControlState(this);
        }

    }

    public class UiState {

        protected Dictionary<Type, Func<Control, string>> Serializers { get; private set; } = new Dictionary<Type, Func<Control, string>>();
        protected Dictionary<Type, Action<Control, string>> Deserializers { get; private set; } = new Dictionary<Type, Action<Control, string>>();


        private readonly Type[] WhitelistedTypes = {
          typeof(TextBox),
          typeof(RadioButton),
          typeof(CheckBox),
          typeof(NumericUpDown),
          typeof(DateTimePicker),
          typeof(ComboBox),
          typeof(DataGridView),
          typeof(KeywordTextBox)
        };

        public UiState() {
            DefaultSerializers();
            DefaultDeserializer();
        }

        public virtual UiState DefaultSerializers() {
            Serializers.Clear();
            Serializers.Add(typeof(TextBox), control => control.Text);
            Serializers.Add(typeof(KeywordTextBox), control => ((KeywordTextBox)control).Text);
            Serializers.Add(typeof(RadioButton), control => ((RadioButton)control).Checked.ToString());
            Serializers.Add(typeof(CheckBox), control => ((CheckBox)control).Checked.ToString());
            Serializers.Add(typeof(NumericUpDown), control => ((NumericUpDown)control).Value.ToString());
            Serializers.Add(typeof(DateTimePicker), control => ((DateTimePicker)control).Value.ToString());
            Serializers.Add(typeof(ComboBox), control => {
                ComboBox cbx = (ComboBox)control;

                //   if (cbx.Items.Count == 0) // No items in combobox, dont serialize selected item, as we don't know the item type.
                //        return null;

                return cbx.SelectedIndex.ToString();
            });
            Serializers.Add(typeof(DataGridView), control => {
                StringBuilder sb = new StringBuilder();

                DataGridView dgv = (DataGridView)control;
                foreach (DataGridViewRow row in dgv.Rows) {
                    if (row.IsNewRow)
                        continue;
                    foreach (DataGridViewCell cell in row.Cells) {

                        string value = cell.Value?.ToString();
                        if (cell.OwningColumn.GetType() != typeof(DataGridViewTextBoxColumn))
                            value = null;

                        sb.Append(value).Append(',');
                    }

                    if (row.Cells.Count > 0)
                        sb.Remove(sb.Length - 1, 1);
                    sb.Append('|');
                }
                if (dgv.Rows.Count > 0 && sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            });
            return this;
        }

        public virtual UiState DefaultDeserializer() {
            Deserializers.Clear();
            Deserializers.Add(typeof(TextBox), (c, val) => c.Text = val);
            Deserializers.Add(typeof(KeywordTextBox), (c, val) => ((KeywordTextBox)c).Text = val);
            Deserializers.Add(typeof(CheckBox), (c, val) => ((CheckBox)c).Checked = (val == bool.TrueString)); // TODO: Use bool.TryParse
            Deserializers.Add(typeof(RadioButton), (c, val) => ((RadioButton)c).Checked = (val == bool.TrueString)); // TODO: Use bool.TryParse
            Deserializers.Add(typeof(NumericUpDown), (c, val) => {
                if (decimal.TryParse(val, out decimal result))
                    ((NumericUpDown)c).Value = result;
            });
            Deserializers.Add(typeof(DateTimePicker), (c, val) => {
                if (DateTime.TryParse(val, out DateTime result))
                    ((DateTimePicker)c).Value = result;
            });

            Deserializers.Add(typeof(ComboBox), (c, val) => {
                ComboBox cbx = (ComboBox)c;
                try {
                    cbx.SelectedIndex = int.Parse(val);
                } catch (Exception e) {
                    Console.WriteLine(e);
                }
            });

            Deserializers.Add(typeof(DataGridView), (c, val) => {
                DataGridView dgv = (DataGridView)c;

                string[] rows = val.Split('|');
                for (int i = 0; i < rows.Length; i++) {
                    string row = rows[i];
                    string[] cells = row.Split(',');

                    if (dgv.Rows.Count <= i + 1) dgv.Rows.Add();
                    DataGridViewRow dgvRow = dgv.Rows[i];


                    for (int j = 0; j < cells.Length; j++) {
                        string cell = cells[j];

                        DataGridViewCell dgvCell = dgvRow.Cells.Count >= j ? dgvRow.Cells[j] : null;
                        if (dgvRow == null) return;

                        dgvCell.Value = cell;
                    }
                }
            });
            return this;
        }

        public List<ControlState> CreateFrom(Control rootControl, params string[] blacklist) {
            if (rootControl == null)
                throw new ArgumentNullException(nameof(rootControl));

            List<ControlState> states = new List<ControlState>();

            foreach (KeyControl keyControl in GetAll(rootControl, WhitelistedTypes)) {

                string key = keyControl.Key;

                if (string.IsNullOrWhiteSpace(key) || blacklist.Contains(key))
                    continue;

                if (Serializers.TryGetValue(keyControl.Control.GetType(), out Func<Control, string> func)) {
                    string value = func(keyControl.Control);
                    if (value == null)
                        continue;
                    states.Add(new ControlState(key, value));

                } else {
                    Logger.Instance.Warn(nameof(UiState), $"Failed to find serializer for {keyControl.Control.GetType()}! Ignoring...");
                }

            }

            SortStates(states);

            return states;
        }

        public UiState Apply(Control rootControl, List<ControlState> states, params string[] blacklist) {
            if (states.Count == 0)
                return this;
            if (rootControl == null)
                throw new ArgumentNullException(nameof(rootControl));


            List<KeyControl> controls = GetAll(rootControl, WhitelistedTypes);

            foreach (ControlState state in states) {
                if (blacklist.Contains(state.Key))
                    continue;

                KeyControl keyControl = controls.Find(c => c.Key == state.Key);

                if (keyControl == null) {
                    Logger.Instance.Warn(nameof(UiState), $"Failed to find control with key: {state.Key}");
                    continue;
                }

                Control control = keyControl.Control;


                if (Deserializers.TryGetValue(control.GetType(), out Action<Control, string> action)) {
                    action(control, state.Value);
                } else {
                    Logger.Instance.Warn(nameof(UiState), $"{control.GetType().Name} has no deserializer! Ignoring...");
                }
            }

            return this;
        }

        protected virtual void SortStates(List<ControlState> states) {
            states.Sort((a, b) => {

                bool av = (a.Value == "True" || a.Value == "False");
                bool bv = (b.Value == "True" || b.Value == "False");

                return (!av && bv) ? 1 : (av && !bv) ? -1 : 0;
            });

            // XXX: Move logic dependant on YDL-UI out of UiState
            int idx = states.FindIndex(cs => cs.Key.Contains("cbBasicMode"));
            ControlState state = states[idx];
            states.RemoveAt(idx);
            states.Insert(0, state);
        }

        protected virtual string GetKey(Control control) {
            return control.Name;
        }

        public List<KeyControl> GetAll(Control control, Type[] whitelist, string path = null, List<KeyControl> controls = null) {
            if (controls == null)
                controls = new List<KeyControl>();
            else
                path = path == null ? GetKey(control) : $"{path}.{GetKey(control)}";


            if (whitelist.Contains(control.GetType())) {
                if (control.Tag is string tag) {
                    if (!tag.StartsWith("!"))
                        controls.Add(new KeyControl(path, control));
                } else {
                    controls.Add(new KeyControl(path, control));
                }
            }

            foreach (Control child in control.Controls)
                controls = GetAll(child, whitelist, path, controls);

            return controls;
        }

    }

    public class KeyControl {
        public string Key { get; set; }
        public Control Control { get; }

        public KeyControl(string key, Control control) {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Control = control ?? throw new ArgumentNullException(nameof(control));
        }
    }
}
