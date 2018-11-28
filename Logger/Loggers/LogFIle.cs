using System.Linq;

namespace Logger.Loggers
{
    using Contracts;
    using System;

    public class LogFile : ILogFIle
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
