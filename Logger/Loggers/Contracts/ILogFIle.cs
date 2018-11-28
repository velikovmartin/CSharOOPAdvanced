namespace Logger.Loggers.Contracts
{
    public interface ILogFIle
    {
        void Write(string message);

        int Size { get; }
    }
}
