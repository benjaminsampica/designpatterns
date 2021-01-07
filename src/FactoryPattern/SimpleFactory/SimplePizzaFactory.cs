using System;

namespace FactoryPattern.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new CheesePizza();
                case "Pepperoni":
                    return new PepperoniPizza();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
