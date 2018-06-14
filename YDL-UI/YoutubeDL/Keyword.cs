using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace Maxstupo.YdlUi.YoutubeDL {

    public class Keyword {
        public string Value { get; set; }
        public string Description { get; set; }
        public bool IsNumeric { get; set; }

        public string Formatted {
            get {
                return string.Format("{0,-25} {2,-10} {1,-30}", Value, Description, IsNumeric ? "numeric" : "string");
            }
        }

        public Keyword() : this(string.Empty, false, string.Empty) { }

        public Keyword(string value, bool isNumeric = false, string description = null) {
            this.Value = value;
            this.IsNumeric = isNumeric;
            this.Description = description;
        }

        public override string ToString() {
            return Value ?? GetType().Name;
        }
    }





}