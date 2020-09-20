namespace DecoratorPattern
{
    public abstract class BeverageComponent
    {
        protected string Description = "Unknown beverage";

        public virtual string GetDescription() => Description;

        public abstract decimal Cost();
    }
}
