using FactoryPattern.AbstractFactory.Pizzas;

namespace FactoryPattern.AbstractFactory.Stores
{
    internal abstract class PizzaStore
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

        protected abstract Pizza CreatePizza(string type);
    }
}
