namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : BeverageComponent
    {
        public abstract override string GetDescription();
    }
}
