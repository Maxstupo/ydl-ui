namespace Maxstupo.YdlUi.Utility {

    using System;
    using System.Text;

    public class Logger {
        private static Logger log;
        public static Logger Instance => log ?? (log = new Logger());

        public const int LevelOff = 600;
        public const int LevelSevere = 500;
        public const int LevelError = 400;
        public const int LevelWarn = 300;
        public const int LevelInfo = 200;
        public const int LevelDebug = 100;
        public const int LevelFine = 0;

        public string LabelFine { get; set; } = "FINE";
        public string LabelInfo { get; set; } = "INFO";
        public string LabelDebug { get; set; } = "DEBUG";
        public string LabelWarn { get; set; } = "WARN";
        public string LabelError { get; set; } = "ERROR";
        public string LabelSevere { get; set; } = "SEVERE";



        public ConsoleColor WarnColor { get; set; } = ConsoleColor.DarkYellow;
        public ConsoleColor ErrorColor { get; set; } = ConsoleColor.DarkRed;
        public ConsoleColor SevereColor { get; set; } = ConsoleColor.Red;


        public int Level { get; set; } = 0;

        private ConsoleColor prevForeground, prevBackground;
        private readonly StringBuilder sb = new StringBuilder();

        public void Log(int level, string tag, string category, string message, params object[] objs) {
            if (this.Level > level)
                return;
            sb.Clear();

            sb.Append('[').Append(DateTime.Now.ToLongTimeString()).Append("] ");


            if (!string.IsNullOrWhiteSpace(tag))
                sb.Append('[').Append(tag).Append(']');

            if (!string.IsNullOrWhiteSpace(category)) {
                sb.Append(" [").Append(category).Append("]: ");
            } else {
                sb.Append(": ");
            }

            sb.Append(message);

            Console.WriteLine(sb.ToString(), objs);
        }


        public void Fine(string category, string message, params object[] objs) {
            Log(LevelFine, LabelFine, category, message, objs);
        }

        public void Debug(string category, string message, params object[] objs) {
            Log(LevelDebug, LabelDebug, category, message, objs);
        }

        public void Info(string category, string message, params object[] objs) {
            Log(LevelInfo, LabelInfo, category, message, objs);
        }

        public void Warn(string category, string message, params object[] objs) {
            ApplyColor(WarnColor);
            {
                Log(LevelWarn, LabelWarn, category, message, objs);
            }
            RevertColor();
        }

        public void Error(string category, string message, params object[] objs) {
            ApplyColor(ErrorColor);
            {
                Log(LevelError, LabelError, category, message, objs);
            }
            RevertColor();
        }

        public void Severe(string category, string message, params object[] objs) {
            ApplyColor(SevereColor);
            {
                Log(LevelSevere, LabelSevere, category, message, objs);
            }
            RevertColor();
        }


        public void ApplyColor(ConsoleColor background = ConsoleColor.Black, ConsoleColor foreground = ConsoleColor.White) {
            prevBackground = Console.BackgroundColor;
            prevForeground = Console.ForegroundColor;
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }

        public void RevertColor() {
            Console.BackgroundColor = prevBackground;
            Console.ForegroundColor = prevForeground;
        }

    }

}