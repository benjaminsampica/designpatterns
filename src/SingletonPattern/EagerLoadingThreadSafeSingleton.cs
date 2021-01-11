namespace SingletonPattern
{
    public class EagerLoadingThreadSafeSingleton
    {
        private static readonly EagerLoadingThreadSafeSingleton _singleton = new EagerLoadingThreadSafeSingleton();

        private EagerLoadingThreadSafeSingleton() { }

        public static EagerLoadingThreadSafeSingleton GetInstance()
        {
            return _singleton;
        }
    }
}
