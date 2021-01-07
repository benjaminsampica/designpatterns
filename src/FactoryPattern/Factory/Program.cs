using FactoryPattern.Factory.NyPizza;

namespace FactoryPattern.Factory
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
