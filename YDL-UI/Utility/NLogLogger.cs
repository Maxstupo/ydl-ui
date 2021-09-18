namespace Maxstupo.YdlUi.Utility {
    using NLog;
    using System;

    /// <summary>
    /// An NLog logging implementation for Stylet logging.
    /// </summary>
    public sealed class NLogLogger : Stylet.Logging.ILogger {

        private readonly ILogger logger;

        public NLogLogger(string name) {
            logger = LogManager.GetLogger(name);
        }

        public void Error(Exception exception, string message = null) {
            logger.Error(exception, message);
        }

        public void Info(string format, params object[] args) {
            logger.Debug(format, args);
        }

        public void Warn(string format, params object[] args) {
            logger.Warn(format, args);
        }

    }

}