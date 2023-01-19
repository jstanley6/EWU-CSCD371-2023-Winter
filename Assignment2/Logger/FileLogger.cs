using System;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string LogFilePath { get; set; }

        public FileLogger(string logFilePath)
        {
            LogFilePath = logFilePath;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            File.AppendAllText(LogFilePath, $"{DateTime.Now:HH:m:s zzz} " 
                                             + $"{nameof(ClassName)} {logLevel}: " +
                                             $"{message} {Environment.NewLine}");
        }
        
    }
}