using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern.Weather;

namespace ObserverPattern.Tests
{
    [TestClass]
    public class CurrentConditionsDisplayObserverTests
    {
        [TestMethod]
        public void Display_ReturnsCurrentTemperatureMessage()
        {
            var weatherController = new WeatherObservable();
            var currentConditionsDisplayObserver = new CurrentConditionsDisplayObserver(weatherController);

            weatherController.SetMeasurements(100, 100, 100);

            Assert.AreEqual("The current temperature is 100, the current humidity is 100, the current pressure is 100.", currentConditionsDisplayObserver.Display());
        }
    }
}
