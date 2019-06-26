using System;
using System.Collections.Generic;
using System.Text;
using _1._Logger.Interfaces;
using _1._Logger.Appenders;

namespace _1._Logger.Loggers
{
    class Logger : ILogger
    {
        public Logger(IAppender consoleAppender)
        {
            this.ConsoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.ConsoleAppender = consoleAppender;
            this.FileAppender = fileAppender;
        }

        public IAppender ConsoleAppender { get; protected set; }

        public IAppender FileAppender { get; protected set; }

        public void Info(string dateTime, string message)
        {
            this.AppendMessage(dateTime, message, ReportLevel.INFO);
        }

        public void Warning(string dateTime, string message)
        {
            this.AppendMessage(dateTime, message, ReportLevel.WARNING);
        }

        public void Error(string dateTime, string message)
        {
            this.AppendMessage(dateTime, message, ReportLevel.ERROR);
        }

        public void Critical(string dateTime, string message)
        {
            this.AppendMessage(dateTime, message, ReportLevel.CRITICAL);
        }

        public void Fatal(string dateTime, string message)
        {
            this.AppendMessage(dateTime, message, ReportLevel.FATAL);
        }

        private void AppendMessage(string dateTime, string message, ReportLevel reportLevel)
        {
            this.ConsoleAppender?.Append(dateTime, message, reportLevel);
            this.FileAppender?.Append(dateTime, message, reportLevel);
        }
    }
}
