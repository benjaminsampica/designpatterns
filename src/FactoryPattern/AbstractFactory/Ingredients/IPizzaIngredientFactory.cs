using FactoryPattern.AbstractFactory.Ingredients.Bases;

namespace FactoryPattern.AbstractFactory.Ingredients
{
    internal interface IPizzaIngredientFactory
    {
        Cheese CreateCheese();
        Clams CreateClams();
        Dough CreateDough();
        Pepperoni CreatePepperoni();
        Sauce CreateSauce();
        Vegetable[] CreateVegetables();
    }
}
