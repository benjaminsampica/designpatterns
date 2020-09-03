using StrategyPattern.Strategies.FlyBehavior;
using StrategyPattern.Strategies.QuackBehavior;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWingsStrategy());
            SetQuackBehavior(new NormalQuackStrategy());
        }

        public override string Display()
        {
            return "I am a mallard.";
        }
    }
}
