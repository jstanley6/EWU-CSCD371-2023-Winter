namespace Logger
{
    
  
    public class LogFactory
    {
        private string _logFilePath { get; set; }
        public BaseLogger CreateLogger(string className)
        {
            if (!string.IsNullOrEmpty(_logFilePath) && _logFilePath != null)
            {
                BaseLogger baseLogger = new FileLogger(_logFilePath);
                baseLogger.ClassName = className;
                return baseLogger;

            }
            else
            {
                return null;
            }
        }

        public void ConfigureFileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
        }
        
    }
   
}
