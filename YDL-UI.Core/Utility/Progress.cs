namespace Maxstupo.YdlUi.Core.Utility {
    using System;
    using ByteSizeLib;

    public struct Progress : IEquatable<Progress> {

        public int Value { get; }

        public int Maximum { get;  }

        public float Percent => (float) Value / Maximum;

        public Progress(int value, int maximum) {
            Value = value;
            Maximum = maximum;
        }

        public override bool Equals(object obj) {
            return obj is Progress progress && Equals(progress);
        }

        public bool Equals(Progress other) {
            return this.Value == other.Value &&
                   this.Maximum == other.Maximum;
        }

        public override int GetHashCode() {
            int hashCode = 1864270363;
            hashCode = hashCode * -1521134295 + this.Value.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Maximum.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Progress left, Progress right) {
            return left.Equals(right);
        }

        public static bool operator !=(Progress left, Progress right) {
            return !(left == right);
        }

    }

    public struct DownloadStatistics {
        public int Value { get;  }

        public int Maximum { get; }

        public ByteSize Size { get; }

        public ByteSize Speed { get;  }

        public TimeSpan Eta { get;  }

        public float Percent => (float) Value / Maximum;

        public DownloadStatistics(int value, int maximum, ByteSize size, ByteSize speed, TimeSpan eta) {
            this.Value = value;
            this.Maximum = maximum;
            this.Size = size;
            this.Speed = speed;
            this.Eta = eta;
        }
    }


}