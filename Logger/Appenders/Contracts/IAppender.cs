using Logger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders.Contracts
{
    public interface IAppender
    {
        void Append(string dateTime, ReportLevel errorLevel, string message);

        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get; }
    }
}
