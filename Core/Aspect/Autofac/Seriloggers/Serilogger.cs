using Serilog;
using Serilog.Formatting.Json;

namespace Core.Aspect.Autofac
{
    public class Serilogger : ILogger
    {
        public Serilogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                //   .Enrich.WithExceptionDetails()
                .WriteTo.File(new JsonFormatter(renderMessage: true), "logger\\log.txt",
                    rollingInterval: RollingInterval.Day)
                // .WriteTo.Console(LogEventLevel.Information)
                .CreateLogger();
        }


        public void Info(string logMessage)
        {
            Log.Information(logMessage);
        }

        public void Debug(string logMessage)
        {
            Log.Debug(logMessage);
        }

        public void Warn(string logMessage)
        {
            Log.Warning(logMessage);
        }

        public void Fatal(string logMessage)
        {
            Log.Fatal(logMessage);
        }

        public void Error(string logMessage)
        {
            Log.Error(logMessage);
        }
    }
}