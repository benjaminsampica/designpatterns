using System;

namespace FactoryPattern.Factory.NyPizza
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new NyCheesePizza();
                case "Pepperoni":
                    return new NyPepperoniPizza();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
