using FactoryPattern.AbstractFactory.Ingredients.Bases;
using System;

namespace FactoryPattern.AbstractFactory.Ingredients
{
    class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Vegetable[] CreateVegetables()
        {
            throw new NotImplementedException();
        }
    }
}
