using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class DecoyDuckTests
    {
        private Duck _decoyDuck;

        [TestInitialize]
        public void Initialize()
        {
            _decoyDuck = new DecoyDuck();
        }

        [TestMethod]
        public void Display_ReturnsIAmADecoy() => Assert.AreEqual(_decoyDuck.Display(), "I am a decoy.");

        [TestMethod]
        public void PerformFly_ReturnsIDontFly() => Assert.AreEqual(_decoyDuck.PerformFly(), "I don't fly.");

        [TestMethod]
        public void PerformQuack_ReturnsIDontQuack() => Assert.AreEqual(_decoyDuck.PerformQuack(), "I don't quack.");

        [TestMethod]
        public void Swim_ReturnsAllDucksSwimEvenDecoys() => Assert.AreEqual(_decoyDuck.Swim(), "All ducks swim, even decoys.");
    }
}
