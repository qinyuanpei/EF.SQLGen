using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging.Internal;
using Microsoft.Extensions.Logging.Abstractions;


namespace SQLGen
{
    public class SQLGenLogger : ILogger
    {
        private readonly string categoryName;
        public SQLGenLogger(string categoryName) => this.categoryName = categoryName;

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var command = state as Microsoft.Extensions.Logging.Internal.FormattedLogValues;
            Console.WriteLine(state);
        }
    }

    public class SQLGenLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            if(categoryName  == "Microsoft.EntityFrameworkCore.Database.Command")
                return new SQLGenLogger(categoryName);
            return NullLogger.Instance;
        }


        public void Dispose()
        {

        }
    }
}
