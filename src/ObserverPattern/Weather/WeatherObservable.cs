using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Weather
{
    public class WeatherObservable : IWeatherObservable
    {
        private readonly List<IWeatherObserver> _observers = new List<IWeatherObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void AddObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            if (_observers.Any(o => o == observer))
            {
                _observers.Remove(observer);
            }
        }

        public void SetChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            SetChanged();
        }

        public List<IWeatherObserver> GetObservers()
        {
            return _observers;
        }
    }
}
