using Maxstupo.YdlUi.YoutubeDL.Model;
using System;
using System.Diagnostics;
using System.Text;

namespace Maxstupo.YdlUi.YoutubeDL {

    [Flags]
    public enum ProcType : byte {
        None = 0,
        Error = 1,
        DataReceived = 2,
        Exited = 4
    }

    public delegate bool ProcessCallback(string data, ProcType type);

    public class YdlApi {

        public string Executable { get; set; }
        public YdlArguments Arguments { get; private set; } = new YdlArguments();

        private readonly YdlArgumentSerializer ydlArgumentSerializer = new YdlArgumentSerializer();

        public YdlApi(string executable) {
            this.Executable = executable;
        }

        public string BuildArgumentString() {
            return ydlArgumentSerializer.Serialize(Arguments, true);
        }

        public bool Execute(string workingDirectory = null) {
            string arguments = BuildArgumentString();
            return DoExecute(arguments, workingDirectory);
        }

        public bool Execute(ProcessCallback callback, string workingDirectory = null) {
            string arguments = BuildArgumentString();
            return DoExecute(arguments, workingDirectory, callback);
        }

        public bool ExecuteWithTempArguments(YdlArguments tempArgs, ProcessCallback callback, string workingDirectory = null) {
            YdlArguments savedArgs = Arguments;
            Arguments = tempArgs;

            bool result = Execute(callback, workingDirectory);

            Arguments = savedArgs;
            return result;
        }

        private bool DoExecute(string arguments, string workingDirectory, ProcessCallback callback = null) {
            if (string.IsNullOrWhiteSpace(Executable))
                return false;

            StringBuilder sb = new StringBuilder();

            bool disabledData = false;

            Process proc = new Process();
            proc.StartInfo.FileName = Executable;

            if (!string.IsNullOrWhiteSpace(arguments))
                proc.StartInfo.Arguments = arguments;

            proc.StartInfo.CreateNoWindow = callback != null;
            proc.StartInfo.Verb = "runas";

            proc.StartInfo.RedirectStandardOutput = callback != null;
            proc.StartInfo.RedirectStandardInput = callback != null;
            proc.StartInfo.RedirectStandardError = callback != null;

            proc.StartInfo.UseShellExecute = callback == null;
            if (!string.IsNullOrWhiteSpace(workingDirectory))
                proc.StartInfo.WorkingDirectory = workingDirectory;

            proc.EnableRaisingEvents = callback != null;

            if (callback != null) {
                proc.OutputDataReceived += (sender, e) => {
                    if (string.IsNullOrEmpty(e.Data))
                        return;

                    sb.Append(e.Data).Append('\n');

                    if (!disabledData && callback(e.Data, ProcType.DataReceived))
                        disabledData = true;
                };

                proc.Exited += (sender, e) => {

                    proc.Dispose();

                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);

                    callback(sb.ToString(), ProcType.Exited);
                };

                proc.ErrorDataReceived += (sender, e) => {
                    callback(e.Data, ProcType.Error);
                };

            }
            proc.Start();
            if (callback != null) {
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
            }
            return true;
        }

        public bool IsCompatibleVersion(string version) {
            return YdlArguments.Version == version;
        }

    }

}
