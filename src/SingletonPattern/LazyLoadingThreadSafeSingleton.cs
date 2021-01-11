using System;

namespace SingletonPattern
{
    public class LazyLoadingThreadSafeSingleton
    {
        private static readonly Lazy<LazyLoadingThreadSafeSingleton> _singleton = new Lazy<LazyLoadingThreadSafeSingleton>(() => new LazyLoadingThreadSafeSingleton());

        private LazyLoadingThreadSafeSingleton() { }

        public static LazyLoadingThreadSafeSingleton GetInstance()
            => _singleton.Value;
    }
}
