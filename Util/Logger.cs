using System;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Util
{
    public class Logger
    {
        public enum LogLevel
        {
            Trace,
            Debug,
            Info,
            Warning,
            Error,
        }

        public static Logger GetLogger() => new Logger();

        public void Log(LogLevel logLevel, string message)
        {
#if DEBUG
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} [{logLevel}] {message}");
#endif
        }

        public void Trace(string message) => Log(LogLevel.Trace, message);
        public void Debug(string message) => Log(LogLevel.Debug, message);
        public void Info(string message) => Log(LogLevel.Info, message);
        public void Warning(string message) => Log(LogLevel.Warning, message);
        public void Error(string message) => Log(LogLevel.Error, message);
    }
}
