# Singleton Pattern

An extremely simple design pattern that is used to instantiate one and _only_ one instance of something.
Really common for storing application configurations, loggers, etc.

C#'s `Lazy<T>` library makes the issue of thread-safe, lazy-loading singletons even more trivial than they were before.
