# Observer Pattern
<hr>

- Defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.
- Model-View-Controller (MVC) is a flavor of the observer pattern - models serve as observables and views serve as observers.
- The `System` namespace has `IObservable<>` and `IObserver<>` already ready for use, with the downside of extending them can be more work overall if flexibility is needed.