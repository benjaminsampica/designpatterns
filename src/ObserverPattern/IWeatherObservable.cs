namespace ObserverPattern
{
    public interface IWeatherObservable
    {
        void AddObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
        void SetChanged();
    }
}
