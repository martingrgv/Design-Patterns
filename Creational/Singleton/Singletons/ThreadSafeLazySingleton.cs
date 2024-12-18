namespace Singleton.Singletons
{
    public sealed class ThreadSafeLazySingleton
    {
        private static readonly Lazy<ThreadSafeLazySingleton> instance = new Lazy<ThreadSafeLazySingleton>(() => new ThreadSafeLazySingleton());

        public ThreadSafeLazySingleton()
        {
        }

        public static ThreadSafeLazySingleton Instance => instance.Value;

        public void Message()
        {
            Console.WriteLine("Thread-Safe Lazy Singleton!");
        }
    }
}
