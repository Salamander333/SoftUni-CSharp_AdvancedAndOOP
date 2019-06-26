using System;
using System.Collections.Generic;
using System.Text;
using _1._Logger.Interfaces;

namespace _1._Logger.Appenders
{
    class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
            this.MessagesAppended = 0;
        }

        public ILayout Layout { get ; protected set ; }

        public ReportLevel ReportLevel { get; protected set; }

        public int MessagesAppended { get; protected set; }

        public void Append(string dateTime, string message, ReportLevel reportLevel)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesAppended++;
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                $"Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel}, " +
                $"Messages appended: {this.MessagesAppended}";
        }
    }
}
