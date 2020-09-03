using System;
using System.Collections.Generic;

namespace StrategyPattern.Strategies.FlyBehavior
{
    public class FlyBehaviorStrategyContext
    {
        public Dictionary<StrategyPattern.FlyBehavior, Func<IFlyBehaviorStrategy>> FlyBehaviorStrategies =
            new Dictionary<StrategyPattern.FlyBehavior, Func<IFlyBehaviorStrategy>>();

        public FlyBehaviorStrategyContext()
        {
            FlyBehaviorStrategies.Add(StrategyPattern.FlyBehavior.NoFly, () => new NoFlyStrategy());
            FlyBehaviorStrategies.Add(StrategyPattern.FlyBehavior.FlyWithWings, () => new FlyWithWingsStrategy());
        }
    }
}
