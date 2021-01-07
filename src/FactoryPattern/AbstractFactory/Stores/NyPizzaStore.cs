using FactoryPattern.AbstractFactory.Ingredients;
using FactoryPattern.AbstractFactory.Pizzas;
using System;

namespace FactoryPattern.AbstractFactory.Stores
{
    internal class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var ingredientFactory = new NyPizzaIngredientFactory();

            switch (type)
            {
                case "Cheese":
                    return new CheesePizza(ingredientFactory);
                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
