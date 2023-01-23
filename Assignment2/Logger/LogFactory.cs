namespace Logger
{
    
  
    public class LogFactory
    {
        private string LogFilePath { get; set; }
        public BaseLogger CreateLogger(string className)
        {
            if (!string.IsNullOrEmpty(LogFilePath))
            {
                BaseLogger baseLogger = new FileLogger(LogFilePath);
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
           LogFilePath = logFilePath;
        }
        
    }
   
}
