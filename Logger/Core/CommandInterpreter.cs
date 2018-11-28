using System;
using System.Collections.Generic;
using System.Text;
using Logger.Appenders.Contracts;
using Logger.Appenders.Factory;
using Logger.Appenders.Factory.Contracts;
using Logger.Core.Contracts;
using Logger.Layouts.Contracts;
using Logger.Layouts.Factory;
using Logger.Loggers.Enums;

namespace Logger.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private LayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2], true);
            }

            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            IAppender appender = this.appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;

            this.appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0], true);
            string dataTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dataTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
