using System;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Serilog;

namespace Core.Aspect.Autofac.Logging
{
    public class LogAspect : MethotInterceptor
    {
        private readonly Serilogger _logger = new Serilogger();

        protected override void OnBefore(IInvocation invocation)
        {
            var log = new LoggerConfiguration()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Console.WriteLine("Ben sonuc öncesi log alıyorum");
            _logger.Info("Fatal log onBefore");
        }

        protected override void OnAfter(IInvocation invocation)
        {
            invocation.Proceed();
            Console.WriteLine("İşlem bitti log tutuyorum.", invocation.Method.Name);
            _logger.Info("Fatal log onBefore");
        }
    }
}