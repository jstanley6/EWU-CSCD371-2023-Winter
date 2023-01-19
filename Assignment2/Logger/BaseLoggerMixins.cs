using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger baseLogger, string message, params object[] messageArgs)
        {
            if (baseLogger is null)
            {
                throw new ArgumentException("The BaseLogger can not be null.");

            }

            message = String.Format(message, messageArgs);
            baseLogger.Log(LogLevel.Error, message);
        }

        public static void Warning(this BaseLogger baseLogger, string message, params object[] messageArgs)
        {
            if (baseLogger is null)
            {
                throw new ArgumentException("The BaseLogger can not be null.");

            }

            message = String.Format(message, messageArgs);
            baseLogger.Log(LogLevel.Warning, message);

        }

        public static void Information(this BaseLogger baseLogger, string message, params object[] messageArgs)
        {
            if (baseLogger is null)
            {
                throw new ArgumentException("The BaseLogger can not be null.");

            }

            message = String.Format(message, messageArgs);
            baseLogger.Log(LogLevel.Information, message);
        }
        
        public static void Debug(this BaseLogger baseLogger, string message, params object[] messageArgs)
        {
            if (baseLogger is null)
            {
                throw new ArgumentException("The BaseLogger can not be null.");

            }

            message = String.Format(message, messageArgs);
            baseLogger.Log(LogLevel.Debug, message);
        }
    }
}
