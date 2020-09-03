namespace ObserverPattern
{
    public abstract class WeatherObserver : IWeatherObserver
    {

        private float _temperature;
        private float _humidity;
        private float _pressure;

        protected WeatherObserver(IWeatherObservable weatherObservable)
        {
            weatherObservable.AddObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
