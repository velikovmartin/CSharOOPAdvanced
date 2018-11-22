namespace Logger
{
    using Appenders;
    using Appenders.Contracts;
    using Layouts;
    using Layouts.Contracts;
    using Loggers.Contracts;
    using Loggers;
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

        }
    }
}
