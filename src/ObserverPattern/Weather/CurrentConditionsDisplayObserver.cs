namespace ObserverPattern.Weather
{
    public class CurrentConditionsDisplayObserver : WeatherObserver
    {
        public CurrentConditionsDisplayObserver(IWeatherObservable weatherObservable) : base(weatherObservable)
        {
        }

        public string Display()
        {
            return $"The current temperature is {GetTemperature()}, the current humidity is {GetHumidity()}, the current pressure is {GetPressure()}.";
        }
    }
}
