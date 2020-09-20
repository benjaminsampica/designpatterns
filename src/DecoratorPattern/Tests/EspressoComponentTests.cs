using DecoratorPattern.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPattern.Tests
{
    [TestClass]
    public class EspressoComponentTests
    {
        private EspressoComponent _component;

        [TestInitialize]
        public void Initialize()
        {
            _component = new EspressoComponent();
        }

        [TestMethod]
        public void GetDescription_IsEspresso() => Assert.AreEqual("Espresso", _component.GetDescription());

        [TestMethod]
        public void Cost_Is99Cents() => Assert.AreEqual(.99m, _component.Cost());
    }
}
