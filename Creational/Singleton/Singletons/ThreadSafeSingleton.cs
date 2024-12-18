namespace Singleton.Singletons
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? instance;
        private static readonly object _lock = new object();

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        public void Message()
        {
            Console.WriteLine("Thread-Safe Singleton!");
        }
    }
}
