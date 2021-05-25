using NLog;

namespace Calculator.Framework.Logger
{
    public static class LoggerUtil
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogInfo(string message)
        {
            logger.Info(message);
        }
    }
}
