using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class RubberDuckTests
    {
        private Duck _rubberDuck;

        [TestInitialize]
        public void Initialize()
        {
            _rubberDuck = new RubberDuck();
        }

        [TestMethod]
        public void Display_ReturnsIAmADecoy() => Assert.AreEqual(_rubberDuck.Display(), "I am a rubber duck.");

        [TestMethod]
        public void PerformFly_ReturnsIDontFly() => Assert.AreEqual(_rubberDuck.PerformFly(), "I don't fly.");

        [TestMethod]
        public void PerformQuack_ReturnsIDontQuack() => Assert.AreEqual(_rubberDuck.PerformQuack(), "I squeak.");

        [TestMethod]
        public void Swim_ReturnsAllDucksSwimEvenDecoys() => Assert.AreEqual(_rubberDuck.Swim(), "All ducks swim, even decoys.");
    }
}
