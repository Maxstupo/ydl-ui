using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.YdlUi.Util {

    public class TempDirectory : TempIO {

        public override bool Exists => Directory.Exists(Path);

        public TempDirectory(string path) : base(path) {
        }

        public bool UnpackFile(string name, byte[] content) {
            string filepath = System.IO.Path.Combine(Path, name);
            if (!File.Exists(filepath)) {
                File.WriteAllBytes(filepath, content);
                return true;
            }
            return false;
        }

        public override bool Delete() {
            if (!Exists)
                return false;
            Directory.Delete(Path, true);
            return true;
        }
    }

    public class TempFile : TempIO {
        public override bool Exists => File.Exists(Path);

        public TempFile(string path) : base(path) {
        }


        public override bool Delete() {
            if (!Exists)
                return false;
            File.Delete(Path);
            return true;
        }
    }

    public abstract class TempIO {

        public string Path { get; }
        public abstract bool Exists { get; }

        private bool deleteOnExit = false;

        public TempIO(string path) {
            this.Path = path;
        }

        public abstract bool Delete();

        public TempIO DeleteOnExit() {
            if (deleteOnExit)
                return this;
            deleteOnExit = true;
            AppDomain.CurrentDomain.ProcessExit += (s, e) => Delete();
            return this;
        }

        public static TempFile CreateTempFile(string path, bool tempName = false) {
            if (tempName)
                path = System.IO.Path.Combine(path, System.IO.Path.GetRandomFileName());

            if (File.Exists(path))
                throw new Exception("File already exists: " + path);

            File.Create(path);

            return new TempFile(path);
        }

        public static TempDirectory CreateTempDirectory() {
            return CreateTempDirectory(System.IO.Path.GetTempPath(), true);
        }

        public static TempDirectory CreateTempDirectory(string path, bool tempName = false) {

            if (tempName)
                path = System.IO.Path.Combine(path, System.IO.Path.GetRandomFileName().Replace(".", ""));

            if (Directory.Exists(path))
                throw new Exception("Directory already exists: " + path);

            Directory.CreateDirectory(path);

            return new TempDirectory(path);
        }

    }
}
