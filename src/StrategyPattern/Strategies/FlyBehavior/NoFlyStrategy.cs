namespace StrategyPattern.Strategies.FlyBehavior
{
    public class NoFlyStrategy : IFlyBehaviorStrategy
    {
        public string Fly()
        {
            return "I don't fly.";
        }
    }
}
