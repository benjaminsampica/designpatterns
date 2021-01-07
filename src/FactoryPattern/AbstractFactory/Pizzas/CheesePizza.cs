using FactoryPattern.AbstractFactory.Ingredients;

namespace FactoryPattern.AbstractFactory.Pizzas
{
    internal class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Dough = _pizzaIngredientFactory.CreateDough();
            Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Vegetables = _pizzaIngredientFactory.CreateVegetables();
            Clams = _pizzaIngredientFactory.CreateClams();
        }
    }
}
