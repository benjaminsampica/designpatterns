using System;
using System.Collections.Generic;

namespace StrategyPattern.Strategies.QuackBehavior
{
    public class QuackBehaviorStrategyContext
    {
        public Dictionary<StrategyPattern.QuackBehavior, Func<IQuackBehaviorStrategy>> QuackBehaviorStrategies =
            new Dictionary<StrategyPattern.QuackBehavior, Func<IQuackBehaviorStrategy>>();

        public QuackBehaviorStrategyContext()
        {
            QuackBehaviorStrategies.Add(StrategyPattern.QuackBehavior.MuteQuack, () => new MuteQuackStrategy());
            QuackBehaviorStrategies.Add(StrategyPattern.QuackBehavior.NormalQuack, () => new NormalQuackStrategy());
            QuackBehaviorStrategies.Add(StrategyPattern.QuackBehavior.Squeak, () => new SqueakStrategy());
        }
    }
}
