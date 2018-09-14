using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging.Abstractions;

namespace SQLGen
{
    public class SQLGenLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //var command = state as DbCommandLogData;
            //if(state is CommandExecuting)
            
            Console.WriteLine(typeof(TState));
        }
    }

    public class SQLGenLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            if(categoryName  == typeof(IRelationalCommandBuilderFactory).FullName)
                return new SQLGenLogger();
            return NullLogger.Instance;
        }


        public void Dispose()
        {

        }
    }
}
