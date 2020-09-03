namespace StrategyPattern.Strategies.QuackBehavior
{
    public class NormalQuackStrategy : IQuackBehaviorStrategy
    {
        public string Quack()
        {
            return "I quack.";
        }
    }
}
