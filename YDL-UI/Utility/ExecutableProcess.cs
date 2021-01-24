namespace Maxstupo.YdlUi.Utility {

    using System;
    using System.Diagnostics;

    public class ExecutableProcess : IDisposable {
        private readonly string path;
        private readonly string arguments;

        private readonly Process process;

        public EventHandler<int> OnExited { get; set; }
        public EventHandler<string> OnReceived { get; set; }
        public EventHandler<string> OnError { get; set; }

        public string Command => $"{path} {arguments}";

        public ExecutableProcess(string path, string arguments, string workingDirectory = null) {
            this.path = path;
            this.arguments = arguments;

            process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = path;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WorkingDirectory = workingDirectory ?? string.Empty;


            process.EnableRaisingEvents = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;


            process.OutputDataReceived += Process_OutputDataReceived;
            process.Exited += Process_Exited;
            process.ErrorDataReceived += Process_ErrorDataReceived;

        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
            OnError?.Invoke(this, e.Data);
            Console.WriteLine("ERR >> " + e.Data);
        }

        public void WaitForExit() {
            process.WaitForExit();
        }

        private void Process_Exited(object sender, EventArgs e) {
            OnExited?.Invoke(this, process.ExitCode);
            Dispose();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            OnReceived?.Invoke(this, e.Data);
        }

        public void Start() {
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
            process.Dispose();
        }

    }

}