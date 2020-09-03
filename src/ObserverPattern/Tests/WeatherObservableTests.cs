using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern.Weather;

namespace ObserverPattern.Tests
{
    [TestClass]
    public class WeatherObservableTests
    {
        private WeatherObservable _weatherController;
        private WeatherObserver _weatherObserver;

        [TestInitialize]
        public void Initialize()
        {
            _weatherController = new WeatherObservable();
            _weatherObserver = new CurrentConditionsDisplayObserver(_weatherController);
        } 

        [TestMethod]
        public void AddObserver_ObserverIsAdded() => Assert.AreEqual(1, _weatherController.GetObservers().Count);

        [TestMethod]
        public void RemoveObserver_ObserverIsRemoved()
        {
            _weatherController.RemoveObserver(_weatherObserver);
            Assert.AreEqual(0, _weatherController.GetObservers().Count);
        }

        [TestMethod]
        public void SetMeasurements_ObserverHasNewTemperature()
        {
            const int temperature = 100;
            _weatherController.SetMeasurements(temperature, 0, 0);
            Assert.AreEqual(temperature, _weatherObserver.GetTemperature());
        }

        [TestMethod]
        public void SetMeasurements_ObserverHasNewHumidity()
        {
            const int humidity = 100;
            _weatherController.SetMeasurements(0, humidity, 0);
            Assert.AreEqual(humidity, _weatherObserver.GetHumidity());
        }

        [TestMethod]
        public void SetMeasurements_ObserverHasNewPressure()
        {
            const int pressure = 100;
            _weatherController.SetMeasurements(0, 0, pressure);
            Assert.AreEqual(pressure, _weatherObserver.GetPressure());
        }
    }
}
