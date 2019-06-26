using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Logger.Interfaces
{
    interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; }

        int MessagesAppended { get; }

        void Append(string dateTime, string message, ReportLevel reportLevel);
    }
}
