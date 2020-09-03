namespace StrategyPattern.Strategies.FlyBehavior
{
    public class FlyWithWingsStrategy : IFlyBehaviorStrategy
    {
        public string Fly()
        {
            return "I fly with wings.";
        }
    }
}
