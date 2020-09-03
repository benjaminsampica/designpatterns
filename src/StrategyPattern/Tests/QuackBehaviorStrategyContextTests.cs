using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.Strategies.QuackBehavior;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class QuackBehaviorStrategyContextTests
    {
        private QuackBehaviorStrategyContext _quackBehaviorStrategyContext;

        [TestInitialize]
        public void Initialize() => _quackBehaviorStrategyContext = new QuackBehaviorStrategyContext();

        [TestMethod]
        public void QuackBehaviorStrategies_NormalQuack_ReturnsNormalQuackStrategy() =>
            Assert.AreEqual(typeof(NormalQuackStrategy), _quackBehaviorStrategyContext.QuackBehaviorStrategies[QuackBehavior.NormalQuack]().GetType());

        [TestMethod]
        public void QuackBehaviorStrategies_MuteQuack_ReturnsMuteQuackStrategy() =>
            Assert.AreEqual(typeof(MuteQuackStrategy), _quackBehaviorStrategyContext.QuackBehaviorStrategies[QuackBehavior.MuteQuack]().GetType());

        [TestMethod]
        public void QuackBehaviorStrategies_Squeak_ReturnsSqueakStrategy() =>
            Assert.AreEqual(typeof(SqueakStrategy), _quackBehaviorStrategyContext.QuackBehaviorStrategies[QuackBehavior.Squeak]().GetType());
    }
}
