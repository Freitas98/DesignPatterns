using System;

namespace Factory
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza();
            }else if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
}
