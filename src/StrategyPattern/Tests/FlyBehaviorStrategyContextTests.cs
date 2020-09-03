using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.Strategies.FlyBehavior;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class FlyBehaviorStrategyContextTests
    {
        private FlyBehaviorStrategyContext _flyBehaviorStrategyContext;

        [TestInitialize]
        public void Initialize() => _flyBehaviorStrategyContext = new FlyBehaviorStrategyContext();

        [TestMethod]
        public void FlyBehaviorStrategies_NoFly_ReturnsNoFlyStrategy() =>
            Assert.AreEqual(typeof(NoFlyStrategy), _flyBehaviorStrategyContext.FlyBehaviorStrategies[FlyBehavior.NoFly]().GetType());

        [TestMethod]
        public void FlyBehaviorStrategies_FlyWithWings_ReturnsFlyWithWingsStrategy() =>
            Assert.AreEqual(typeof(FlyWithWingsStrategy), _flyBehaviorStrategyContext.FlyBehaviorStrategies[FlyBehavior.FlyWithWings]().GetType());
    }
}
