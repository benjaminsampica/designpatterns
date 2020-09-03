using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern.Weather;

namespace ObserverPattern.Tests
{
    [TestClass]
    public class TemperatureDisplayObserverTests
    {
        [TestMethod]
        public void Display_ReturnsCurrentTemperatureMessage()
        {
            var weatherController = new WeatherObservable();
            var temperatureDisplayObserver  = new TemperatureDisplayObserver(weatherController);

            weatherController.SetMeasurements(100, 0, 0);

            Assert.AreEqual("The current temperature is 100.", temperatureDisplayObserver.Display());
        }
    }
}
