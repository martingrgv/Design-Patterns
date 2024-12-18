namespace Singleton.Singletons
{
    public sealed class Logger : ILogger
    {
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        public Logger()
        {
        }

        public static Logger Instance => instance.Value;

        public void Log(string message)
        {
            Console.WriteLine("Logging: " + message);
        }
    }
}
