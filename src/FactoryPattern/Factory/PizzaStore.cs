﻿namespace FactoryPattern.Factory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // The factory exists in each type of store that is subclassed.
        protected abstract Pizza CreatePizza(string type);
    }
}
