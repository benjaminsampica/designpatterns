using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class MallardDuckTests
    {
        private Duck _mallardDuck;

        [TestInitialize]
        public void Initialize()
        {
            _mallardDuck = new MallardDuck();
        }

        [TestMethod]
        public void Display_ReturnsIAmAMallard() => Assert.AreEqual(_mallardDuck.Display(), "I am a mallard.");

        [TestMethod]
        public void PerformFly_ReturnsIFlyWithWings() => Assert.AreEqual(_mallardDuck.PerformFly(), "I fly with wings.");

        [TestMethod]
        public void PerformQuack_ReturnsNormalQuack() => Assert.AreEqual(_mallardDuck.PerformQuack(), "I quack.");

        [TestMethod]
        public void Swim_ReturnsAllDucksSwimEvenDecoys() => Assert.AreEqual(_mallardDuck.Swim(), "All ducks swim, even decoys.");
    }
}
