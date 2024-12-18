// Ensures a class has only one instance and provides a global point of access to it.

using Singleton.Singletons;

ThreadSafeSingleton.Instance.Message();
ThreadSafeLazySingleton.Instance.Message();
Logger.Instance.Log("My message");
