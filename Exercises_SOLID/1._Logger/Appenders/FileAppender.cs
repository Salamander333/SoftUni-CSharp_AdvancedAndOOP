using _1._Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1._Logger.Appenders
{
    class FileAppender : IAppender
    {
        private const string path = "../../../Log.txt";

        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel)
        {
            this.Layout = layout;
            this.LogFile = logFile;
            this.ReportLevel = reportLevel;
            this.MessagesAppended = 0;
        }

        public ILayout Layout { get; protected set; }

        public ILogFile LogFile { get; protected set; }

        public ReportLevel ReportLevel { get; protected set; }

        public int MessagesAppended { get; protected set; }

        public void Append(string dateTime, string message, ReportLevel reportLevel)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesAppended++;
                string messageToLog = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                this.LogFile.Write(messageToLog);
                File.AppendAllText(path, messageToLog);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                $"Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel}, " +
                $"Messages appended: {this.MessagesAppended}, " +
                $"File size: {this.LogFile.Size}";
        }
    }
}
