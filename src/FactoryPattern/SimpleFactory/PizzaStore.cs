namespace FactoryPattern.SimpleFactory
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var simplePizzaFactory = new SimplePizzaFactory();
            
            var pizza = simplePizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
