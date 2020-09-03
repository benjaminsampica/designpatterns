namespace ObserverPattern.Weather
{
    public class TemperatureDisplayObserver : WeatherObserver
    {
        public TemperatureDisplayObserver(IWeatherObservable weatherObservable) : base(weatherObservable)
        {
        }

        public string Display()
        {
            return $"The current temperature is {GetTemperature()}.";
        }
    }
}
