namespace ObserverPattern
{
    public interface IWeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
