using NLog;

namespace Util.Logger
{
    public class AvgleSelectorLogger : IAvgleSelectorLogger
    {
        private readonly NLog.Logger _logger;
        private const string LoggerName = "AvgleSelector";

        public AvgleSelectorLogger(NLog.Logger logger)
        {
            _logger = LogManager.GetLogger(LoggerName);
        }

        public void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public void LogError(string exceptionMessage)
        {
            _logger.Error(exceptionMessage);
        }
    }

    public interface IAvgleSelectorLogger
    {
        void LogInformation(string message);
        void LogError(string exceptionMessage);
    }
}