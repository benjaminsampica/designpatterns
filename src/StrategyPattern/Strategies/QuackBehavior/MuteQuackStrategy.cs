namespace StrategyPattern.Strategies.QuackBehavior
{
    public class MuteQuackStrategy : IQuackBehaviorStrategy
    {
        public string Quack()
        {
            return "I don't quack.";
        }
    }
}
