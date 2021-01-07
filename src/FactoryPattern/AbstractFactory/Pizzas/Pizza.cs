using FactoryPattern.AbstractFactory.Ingredients.Bases;
using System;

namespace FactoryPattern.AbstractFactory.Pizzas
{
    internal abstract class Pizza
    {
        internal Dough Dough;
        internal Sauce Sauce;
        internal Vegetable[] Vegetables;
        internal Cheese Cheese;
        internal Pepperoni Pepperoni;
        internal Clams Clams;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza");
        }
    }
}