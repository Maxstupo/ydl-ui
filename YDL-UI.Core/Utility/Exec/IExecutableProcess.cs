namespace Maxstupo.YdlUi.Core.Utility.Exec {
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a implementation that can create executable processes using a specific working directory and a set of arguments.
    /// </summary>
    public interface IExecutableProcessProvider {

        IExecutableProcess CreateExecutableProcess(object arguments);

    }

    /// <summary>
    /// Represents an implementation that can start or stop a process, and monitor data output by the process.
    /// </summary>
    public interface IExecutableProcess {

        /// <summary>Invoked when the process exits/dies.</summary>
        EventHandler<int> OnExited { get; set; }

        /// <summary>Invoked when the process outputs data.</summary>
        EventHandler<string> OnReceived { get; set; }

        /// <summary>Invoked when the process outputs data on the error stream.</summary>
        EventHandler<string> OnError { get; set; }

        /// <summary>The command that will or has beeen executed.</summary>
        string Command { get; }

        /// <summary>Start the process.</summary>
        Task StartAsync(CancellationToken ct);

        Task<string> QueryAsync(CancellationToken ct);


        /// <summary>Stop the process.</summary>
        Task StopAsync();

    }

}