using DecoratorPattern.Components;
using DecoratorPattern.Decorators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPattern.Tests
{
    [TestClass]
    public class MochaTests
    {
        private MochaDecorator _decorator;

        [TestInitialize]
        public void Initialize()
        {
            _decorator = new MochaDecorator(new EspressoComponent());
        }

        [TestMethod]
        public void GetDescription_IsEspressoCommaMocha() => Assert.AreEqual("Espresso, Mocha", _decorator.GetDescription());

        [TestMethod]
        public void GetCost_Is1Dollar19Cents() => Assert.AreEqual(1.19m, _decorator.Cost());

        [TestMethod]
        public void GetCost_TwoMochas_Is1Dollar39Cents() => Assert.AreEqual(1.39m, new MochaDecorator(new MochaDecorator(new EspressoComponent())).Cost());

        [TestMethod]
        public void GetCost_TwoMochas_IsEspressCommaMochaCommaMocha()
        {
            BeverageComponent espresso = new EspressoComponent();
            espresso = new MochaDecorator(espresso);
            espresso = new MochaDecorator(espresso);

            Assert.AreEqual("Espresso, Mocha, Mocha", espresso.GetDescription());
        }
    }
}
