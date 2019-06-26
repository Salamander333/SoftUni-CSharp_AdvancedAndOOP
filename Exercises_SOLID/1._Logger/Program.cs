using System;
using _1._Logger.Loggers;
using _1._Logger.Appenders;
using _1._Logger.Layouts;
using System.Collections.Generic;
using _1._Logger.Interfaces;
using _1._Logger.Facories;

namespace _1._Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAppender> appenders = new List<IAppender>();
            List<string> messages = new List<string>();

            int appendersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appendersCount; i++)
            {
                var input = Console.ReadLine().Split();
                var appenderType = input[0];
                var layoutType = input[1];
                var reportLevel = ReportLevel.INFO;
                try
                {
                    Enum.TryParse(input[2], out reportLevel);

                }
                catch (Exception){}

                var layout = LayoutFactory.InitializeLayout(layoutType);
                var appender = AppenderFactory.InitializeAppender(appenderType, layout, reportLevel);
                appenders.Add(appender);
            }

            while (true)
            {
                var message = Console.ReadLine();
                if (message == "END")
                {
                    foreach (var m in messages)
                    {
                        foreach (var appender in appenders)
                        {
                            var messageInfo = m.Split("|");
                            Enum.TryParse(messageInfo[0], out ReportLevel messageReportLevel);
                            var messageDateTime = messageInfo[1];
                            var messageString = messageInfo[2];
                            appender.Append(messageDateTime, messageString, messageReportLevel);
                        }
                    }

                    Console.WriteLine("Logger info");
                    foreach (var appender in appenders)
                    {
                        Console.WriteLine(appender.ToString());
                    }
                    return;
                }

                messages.Add(message);
            }

        }
    }
}
