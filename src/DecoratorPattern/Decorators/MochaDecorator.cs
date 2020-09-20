namespace DecoratorPattern.Decorators
{
    public class MochaDecorator : CondimentDecorator
    {
        private readonly BeverageComponent _beverageComponent;

        public MochaDecorator(BeverageComponent beverageComponent)
        {
            _beverageComponent = beverageComponent;
        }

        public override decimal Cost() => _beverageComponent.Cost() + .20m;
        public override string GetDescription() => _beverageComponent.GetDescription() + ", Mocha";
    }
}
