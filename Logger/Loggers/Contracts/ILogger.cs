using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Loggers.Contracts
{
    public interface ILogger
    {
        void Error(string v1, string v2);
        void Info(string v1, string v2);
    }
}
