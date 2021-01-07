using FactoryPattern.AbstractFactory.Stores;

namespace FactoryPattern.AbstractFactory
{
    public class Program
    {
        public void Main(string[] args)
        {
            var nyPizzaStore = new NyPizzaStore();

            var nyCheesePizza = nyPizzaStore.OrderPizza("Cheese");
        }
    }
}
