using StrategyPattern.Strategies.FlyBehavior;
using StrategyPattern.Strategies.QuackBehavior;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetQuackBehavior(new SqueakStrategy());
            SetFlyBehavior(new NoFlyStrategy());
        }

        public override string Display()
        {
            return "I am a rubber duck.";
        }
    }
}
