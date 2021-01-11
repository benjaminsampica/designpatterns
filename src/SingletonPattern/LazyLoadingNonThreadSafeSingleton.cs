namespace SingletonPattern
{
    public class LazyLoadingNonThreadSafeSingleton
    {
        private static LazyLoadingNonThreadSafeSingleton _singleton;

        private LazyLoadingNonThreadSafeSingleton() { }

        public static LazyLoadingNonThreadSafeSingleton GetInstance()
        {
            if(_singleton == null)
            {
                _singleton = new LazyLoadingNonThreadSafeSingleton();
            }

            return _singleton;
        }
    }
}
