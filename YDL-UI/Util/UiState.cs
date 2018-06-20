using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Maxstupo.YdlUi.Util.UiStore {

    public class SerializedValue {
        public string Value { get; }
        public Type Type { get; }

        public SerializedValue(string value, Type type = null) {
            Value = value;
            Type = type;
        }
    }

    public class UiState : IEnumerable<ControlState> {
        private List<ControlState> states = new List<ControlState>();

        private Control rootControl;
        private Type[] whitelist;

        public Dictionary<Type, Func<Control, SerializedValue>> Serializers { get; private set; } = new Dictionary<Type, Func<Control, SerializedValue>>();
        public Dictionary<Type, Action<Control, SerializedValue>> Deserializers { get; private set; } = new Dictionary<Type, Action<Control, SerializedValue>>();

        public UiState(UiState copy) {
            this.Serializers = new Dictionary<Type, Func<Control, SerializedValue>>(copy.Serializers);
            this.Deserializers = new Dictionary<Type, Action<Control, SerializedValue>>(copy.Deserializers);
            this.states = new List<ControlState>(copy.states);
            this.rootControl = copy.rootControl;
            this.whitelist = copy.whitelist;
        }

        public UiState(Control rootControl = null, params Type[] whitelist) {
            DefaultSerializers();
            DefaultDeserializer();

            if (rootControl != null)
                CreateFrom(rootControl, whitelist);
        }

        public UiState Clear() {
            states.Clear();
            rootControl = null;
            whitelist = null;
            return this;
        }

        public UiState DefaultSerializers() {
            Serializers.Clear();
            Serializers.Add(typeof(TextBox), control => new SerializedValue(control.Text));
            Serializers.Add(typeof(RadioButton), control => new SerializedValue(((RadioButton)control).Checked.ToString()));
            Serializers.Add(typeof(CheckBox), control => new SerializedValue(((CheckBox)control).Checked.ToString()));
            Serializers.Add(typeof(NumericUpDown), control => new SerializedValue(((NumericUpDown)control).Value.ToString()));
            Serializers.Add(typeof(DateTimePicker), control => new SerializedValue(((DateTimePicker)control).Value.ToString()));
            Serializers.Add(typeof(ComboBox), control => {
                ComboBox cbx = (ComboBox)control;
                if (cbx.Items.Count == 0) // No items in combobox, dont serialize selected item, as we don't know the item type.
                    return null;

                Type itemType = cbx.Items[0].GetType();
                return new SerializedValue(cbx.SelectedItem?.ToString(), itemType);
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
                return new SerializedValue(sb.ToString());
            });
            return this;
        }

        public UiState DefaultDeserializer() {
            Deserializers.Clear();
            Deserializers.Add(typeof(TextBox), (c, val) => c.Text = val.Value);
            Deserializers.Add(typeof(CheckBox), (c, val) => ((CheckBox)c).Checked = (val.Value == bool.TrueString)); // TODO: Use bool.TryParse
            Deserializers.Add(typeof(RadioButton), (c, val) => ((RadioButton)c).Checked = (val.Value == bool.TrueString)); // TODO: Use bool.TryParse
            Deserializers.Add(typeof(NumericUpDown), (c, val) => {
                if (decimal.TryParse(val.Value, out decimal result))
                    ((NumericUpDown)c).Value = result;
            });
            Deserializers.Add(typeof(DateTimePicker), (c, val) => {
                if (DateTime.TryParse(val.Value, out DateTime result))
                    ((DateTimePicker)c).Value = result;
            });

            Deserializers.Add(typeof(ComboBox), (c, val) => {
                ComboBox cbx = (ComboBox)c;

                if (val.Type == null) // If we dont know the item type, dont try and set the selected item for the combobox.
                    return;

                if (val.Type.IsEnum) {
                    Array items = Enum.GetValues(val.Type);
                    foreach (var item in items) {
                        if (item.ToString() == val.Value) {
                            cbx.SelectedItem = item;
                            break;
                        }
                    }
                } else if (val.Type == typeof(string)) {
                    cbx.SelectedItem = val.Value;
                }
            });

            // NOTE: DataGridView 
            Deserializers.Add(typeof(DataGridView), (c, val) => {
                DataGridView dgv = (DataGridView)c;

                string[] rows = val.Value.Split('|');
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

        public UiState CreateFrom(Control rootControl, params Type[] whitelist) {
            this.rootControl = rootControl ?? throw new ArgumentNullException("The rootControl can't be null!");
            this.whitelist = whitelist;

            states.Clear();

            foreach (Control control in GetAll(rootControl, whitelist)) {

                string key = GetKey(control);

                if (string.IsNullOrWhiteSpace(key))
                    continue;

                if (Serializers.TryGetValue(control.GetType(), out Func<Control, SerializedValue> func)) {
                    SerializedValue value = func(control);
                    if (value == null)
                        continue;
                    states.Add(new ControlState(this, key, value));
                } else {
                    Console.WriteLine("[WARN] [UiState]: Failed to find a serializer for " + control.GetType().ToString() + "! Ignoring...");
                }

            }
            return this;
        }

        public UiState Apply(Control rootControl = null, params Type[] whitelist) {
            Control rtControl = rootControl ?? this.rootControl ?? throw new ArgumentNullException("No root control specified! Applying control state aborted!");
            Type[] whitelistedControls = (whitelist == null || whitelist.Length == 0) ? this.whitelist : whitelist;

            List<Control> controls = GetAll(rtControl, whitelistedControls).ToList();

            foreach (ControlState state in states) {

                Control control = controls.Find(c => GetKey(c) == state.Key);

                if (control == null) {
                    Console.WriteLine("[WARN] [UiState]: Failed to find control with key: " + state.Key);
                    continue;
                }

                if (Deserializers.TryGetValue(control.GetType(), out Action<Control, SerializedValue> action)) {
                    action(control, state.Value);
                } else {
                    Console.WriteLine("[WARN] [UiState]: " + control.GetType().Name + " has no deserializer! Ignoring...");
                }
            }

            return this;
        }


        protected virtual string GetKey(Control control) {
            string tagSuffix = string.Empty;

            if (control.Tag != null)
                tagSuffix = "_" + control.Tag.ToString();

            return control.Name + tagSuffix;
        }

        public UiState Save(string file) {
            if (string.IsNullOrWhiteSpace(file))
                throw new ArgumentNullException("The given filepath is null!");

            using (XmlWriter sw = XmlWriter.Create(file, new XmlWriterSettings() { Indent = true })) {
                sw.WriteStartDocument();
                {
                    sw.WriteStartElement("UiState");
                    {
                        foreach (ControlState state in states)
                            state.Write(sw);
                    }
                    sw.WriteEndElement();
                }
                sw.WriteEndDocument();
            }
            return this;
        }

        public static UiState LoadFromFile(string file) {
            return new UiState().Load(file);
        }

        public UiState Load(string file) {
            if (string.IsNullOrWhiteSpace(file) || !File.Exists(file))
                throw new ArgumentException("The specified filepath is null or doesn't exist!");

            states.Clear();

            using (XmlReader sr = XmlReader.Create(file)) {
                sr.MoveToContent();
                while (sr.Read()) {
                    if (sr.NodeType == XmlNodeType.Element && sr.Name == "Control") {
                        string key = sr.GetAttribute("key");
                        string value = sr.GetAttribute("value");
                        string typeStr = sr.GetAttribute("type") ?? null;

                        Type type = null;
                        if (typeStr != null)
                            type = Type.GetType(typeStr);

                        states.Add(new ControlState(this, key, new SerializedValue(value, type)));
                    }
                }

            }
            return this;
        }

        public UiState Copy() {
            return new UiState(this);
        }

        public static IEnumerable<Control> GetAll(Control control, params Type[] whitelist) {
            IEnumerable<Control> controls = control.Controls.Cast<Control>();
            return controls.SelectMany(c => GetAll(c)).Concat(controls).Where(c => {
                if (whitelist == null || whitelist.Length == 0)
                    return true;
                return whitelist.Contains(c.GetType());
            });
        }

        public IEnumerator<ControlState> GetEnumerator() {
            return states.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return states.GetEnumerator();
        }
    }

    public class ControlState {
        public UiState State { get; }

        public string Key { get; }
        public SerializedValue Value { get; }

        public ControlState(UiState state, string key, SerializedValue value) {
            this.State = state;
            this.Key = key;
            this.Value = value;
        }

        public void Write(XmlWriter w) {
            if (w == null) return;

            w.WriteStartElement("Control");
            {
                w.WriteAttributeString("key", Key);
                w.WriteAttributeString("value", Value.Value);
                if (Value.Type != null)
                    w.WriteAttributeString("type", Value.Type.ToString());
            }
            w.WriteEndElement();
        }
    }

}