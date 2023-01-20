using System;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string LogFilePath { get; set; }

        public FileLogger(){}
        public FileLogger(string logFilePath)
        {
            LogFilePath = logFilePath;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            string logMessage = DateTime.Now.ToString() + " " + ClassName + " " + logLevel + ": " + message + "\n";
            if(File.Exists(LogFilePath))
            {
                StreamWriter streamWriter = File.AppendText(LogFilePath);
                streamWriter.Write(logMessage);
                streamWriter.Close();
                
            }
            else
            {
                StreamWriter streamWriter = File.CreateText(LogFilePath);
                streamWriter.Write(logMessage);
                streamWriter.Close();
            }
        }
        
    }
}