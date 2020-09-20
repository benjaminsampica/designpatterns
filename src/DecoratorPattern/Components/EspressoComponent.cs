namespace DecoratorPattern.Components
{
    public class EspressoComponent : BeverageComponent
    {
        public EspressoComponent()
        {
            Description = "Espresso";
        }

        public override decimal Cost() => .99m;
    }
}
