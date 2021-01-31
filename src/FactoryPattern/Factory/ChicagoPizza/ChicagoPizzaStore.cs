using System;

namespace FactoryPattern.Factory.ChicagoPizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new ChicagoCheesePizza();
                case "Pepperoni":
                    return new ChicagoPepperoniPizza();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
