using _1._Logger.Appenders;
using _1._Logger.Interfaces;
using _1._Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Logger.Facories
{
    static class AppenderFactory
    {
        public static IAppender InitializeAppender(string type, ILayout layout, ReportLevel reportLevel)
        {
            string _type = type.ToLower();

            switch (_type)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout, reportLevel);

                case "fileappender":
                    return new FileAppender(layout, new LogFile(), reportLevel);

                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
