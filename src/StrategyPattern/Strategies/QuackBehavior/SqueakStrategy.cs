namespace StrategyPattern.Strategies.QuackBehavior
{
    public class SqueakStrategy : IQuackBehaviorStrategy
    {
        public string Quack()
        {
            return "I squeak.";
        }
    }
}
