﻿using System;
using System.Collections.Generic;
using System.Text;
using Logger.Appenders.Contracts;
using Logger.Appenders.Factory.Contracts;
using Logger.Layouts.Contracts;
using Logger.Loggers;

namespace Logger.Appenders.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid Appender Type!");

            }
        }
    }
}
