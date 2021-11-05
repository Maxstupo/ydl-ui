namespace Maxstupo.YdlUi.Core.Utility.Exec {
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    public class ErrorDataException : Exception {

        public ErrorDataException(string message) : base(message) { }

    }


    /// <summary>
    /// An executable process that uses System.Diagnostics.Process. The process object will only be
    /// created when calling start and will destroyed when stopping or disposing this executable process.  
    /// </summary>
    public sealed class ExecutableProcess : IExecutableProcess {

        private static readonly NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string path;
        private readonly string arguments;
        private readonly string workingDirectory;

        private Process process;

        public EventHandler<int> OnExited { get; set; }
        public EventHandler<string> OnReceived { get; set; }
        public EventHandler<string> OnError { get; set; }

        public string Command => $"{path} {arguments}";

        private TaskCompletionSource<string> tcs, tcsStart;


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

        private void Setup() {
            Logger.Debug("Setup...");

            process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            //process.StartInfo.Verb = "runas";
            process.StartInfo.FileName = path;
            process.StartInfo.Arguments = arguments;
            if (workingDirectory != null)
                process.StartInfo.WorkingDirectory = workingDirectory;

            process.EnableRaisingEvents = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Exited += Process_Exited;
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            string data = e.Data;

            if (!string.IsNullOrWhiteSpace(data)) {

                if (tcs != null)
                    tcs.TrySetResult(data);

                OnReceived?.Invoke(this, data);
            }

        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
            string data = e.Data;

            if (!string.IsNullOrWhiteSpace(data)) {
                Logger.Warn("Query failed, process received error data - {data}", data);

                if (tcs != null)
                    tcs.TrySetException(new ErrorDataException(data));

                OnError?.Invoke(this, data);
            }

        }

        private async void Process_Exited(object sender, EventArgs e) {
            Logger.Debug("Process exited.");
            OnExited?.Invoke(this, process.ExitCode);
            await StopAsync();
        }

        public async Task StartAsync(CancellationToken ct) {
            if (process != null)
                await StopAsync();
                       
            tcsStart = new TaskCompletionSource<string>();

            Logger.Info("Start...");
            using (ct.Register(async () => { // If the CancellationToken was canceled, set result to null and stop the process.
                Logger.Info("Process was cancelled!");
                await StopAsync();
                tcsStart.TrySetResult(null);
            })) {
                Setup();

                Logger.Info("Start...");

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await tcsStart.Task;
            }
        
        }

        public async Task<string> QueryAsync(CancellationToken ct) {
            if (process != null)
                await StopAsync();

            tcs = new TaskCompletionSource<string>();

            using (ct.Register(async () => { // If the CancellationToken was canceled, set result to null and stop the process.
                Logger.Info("Query process was cancelled!");
                await StopAsync();
                tcs.TrySetResult(null);
            })) {

                Setup();

                Logger.Info("Start query...");

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                return await tcs.Task;
            }

        }

        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task StopAsync() {
            await semaphore.WaitAsync(); // Use semaphore since StopAsync is called from multiple threads/events.
            Logger.Info("Stop...");

            try {
                if (process != null && !process.HasExited) {
                    process.Kill();
                    Logger.Debug("Killed process...");
                }
            } finally {

                if (process != null) {
                    Logger.Debug("Disposing...");
                    process.Dispose();
                }

                process = null;

                semaphore.Release();

                tcsStart?.TrySetResult(null);
            }

        }

    }

}