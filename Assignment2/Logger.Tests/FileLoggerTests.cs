using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void CreatesFileAndLogsMessage_Test()
        {
            string path = "test.txt";
            FileLogger fileLogger = new FileLogger()
            {
                LogFilePath = path,
                ClassName = nameof(FileLoggerTests)

            };
            fileLogger.Log(LogLevel.Warning, "Test Message");
            string expected = $"{DateTime.Now} {nameof(FileLoggerTests)} {LogLevel.Warning}: Test Message\n";
            string actual = File.ReadAllText(path);
            File.Delete(path);
            Assert.AreEqual(expected, actual);
        }

    }
}
