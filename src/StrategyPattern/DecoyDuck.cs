using StrategyPattern.Strategies.FlyBehavior;
using StrategyPattern.Strategies.QuackBehavior;

namespace StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavior(new NoFlyStrategy());
            SetQuackBehavior(new MuteQuackStrategy());
        }

        public override string Display()
        {
            return "I am a decoy.";
        }
    }
}
