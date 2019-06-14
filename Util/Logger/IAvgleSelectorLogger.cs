namespace Util.Logger
{
    public interface IAvgleSelectorLogger
    {
        void LogInformation(string message);
        void LogError(string exceptionMessage);
    }
}