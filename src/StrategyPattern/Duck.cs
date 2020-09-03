using StrategyPattern.Strategies.FlyBehavior;
using StrategyPattern.Strategies.QuackBehavior;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehaviorStrategy _flyBehaviorStrategy;
        private IQuackBehaviorStrategy _quackBehaviorStrategy;

        public abstract string Display();

        public string Swim()
        {
            return "All ducks swim, even decoys.";
        }

        public string PerformQuack()
        {
            return _quackBehaviorStrategy.Quack();
        }

        public string PerformFly()
        {
            return _flyBehaviorStrategy.Fly();
        }

        public void SetQuackBehavior(IQuackBehaviorStrategy quackBehavior)
        {
            _quackBehaviorStrategy = quackBehavior;
        }

        public void SetFlyBehavior(IFlyBehaviorStrategy flyBehavior)
        {
            _flyBehaviorStrategy = flyBehavior;
        }
    }
}
