namespace Maxstupo.YdlUi.Core.Utility.Exec {
    using System;
    using System.Diagnostics;

    /// <summary>
    /// An executable process that uses System.Diagnostics.Process. The process object will only be
    /// created when calling start and will destroyed when stopping or disposing this executable process.  
    /// </summary>
    public sealed class ExecutableProcess : IExecutableProcess {
        private readonly string path;
        private readonly string arguments;
        private readonly string workingDirectory;

        private Process process;

        public EventHandler<int> OnExited { get; set; }
        public EventHandler<string> OnReceived { get; set; }
        public EventHandler<string> OnError { get; set; }

        public string Command => $"{path} {arguments}";

        /// <summary>
        /// Create a new executable process.
        /// </summary>
        /// <param name="path">The filepath to the executable.</param>
        /// <param name="arguments">The arguments given to the executable.</param>
        /// <param name="workingDirectory">The working directory this process will run in.</param>
        public ExecutableProcess(string path, string arguments, string workingDirectory = null) {
            this.path = path;
            this.arguments = arguments;
            this.workingDirectory = workingDirectory;
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
            OnError?.Invoke(this, e.Data);
        }

        private void Process_Exited(object sender, EventArgs e) {
            OnExited?.Invoke(this, process.ExitCode);
            Dispose();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            OnReceived?.Invoke(this, e.Data);
        }

        public void Start() {
            if (process != null)
                Stop();

            process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            //process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = path;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WorkingDirectory = workingDirectory ?? string.Empty;

            process.EnableRaisingEvents = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.OutputDataReceived += Process_OutputDataReceived;
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.Exited += Process_Exited;

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        public void Stop() {
            try {
                process.Kill();
            } catch (Exception) {
            } finally {
                Dispose();
            }
        }

        public void Dispose() {
            Stop();
            process = null;
        }

    }

}