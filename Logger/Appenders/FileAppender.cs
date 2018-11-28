using System;

namespace Logger.Appenders
{
    using Layouts.Contracts;
    using Loggers.Enums;
    using Loggers.Contracts;
    using System.IO;

    public class FileAppender : Appender
    {
        private const string Path = "../.././log.txt";

        private readonly ILogFIle logFile;

        public FileAppender(ILayout layout, ILogFIle logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                this.logFile.Write(content);
                File.AppendAllText(Path, content);
            }
        }

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}, File size: {this.logFile.Size}";
        }
    }
}
