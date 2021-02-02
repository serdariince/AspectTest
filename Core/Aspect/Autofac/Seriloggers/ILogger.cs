namespace Core.Aspect
{
    public interface ILogger
    {
        void Info(string logMessage);
        void Debug(string logMessage);
        void Warn(string logMessage);
        void Fatal(string logMessage);
        void Error(string logMessage);
    }
}