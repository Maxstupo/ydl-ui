namespace Maxstupo.YdlUi.Core.Utility.Exec {
    using System;

    /// <summary>
    /// Represents a implementation that can create executable processes using a specific working directory and a set of arguments.
    /// </summary>
    public interface IExecutableProcessProvider {

        IExecutableProcess CreateExecutableProcess(object arguments, string workingDirectory);

    }

    /// <summary>
    /// Represents an implementation that can start or stop a process, and monitor data output by the process.
    /// </summary>
    public interface IExecutableProcess : IDisposable {

        /// <summary>Invoked when the process exits/dies.</summary>
        EventHandler<int> OnExited { get; set; }

        /// <summary>Invoked when the process outputs data.</summary>
        EventHandler<string> OnReceived { get; set; }

        /// <summary>Invoked when the process outputs data on the error stream.</summary>
        EventHandler<string> OnError { get; set; }

        /// <summary>The command that will or has beeen executed.</summary>
        string Command { get; }

        /// <summary>Start the process.</summary>
        void Start();

        /// <summary>Stop the process.</summary>
        void Stop();

    }

}