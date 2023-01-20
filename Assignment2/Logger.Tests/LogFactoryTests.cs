using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_FileLoggerReturnsNull()
        {
            LogFactory logFactory = new LogFactory();
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));
            Assert.IsNull(fileLogger);
        }

        public void CreateLogger_ReturnsFileLogger()
        {
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger("testFile.txt");
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));
            Assert.IsNotNull(fileLogger);
        }
        
    }
}
