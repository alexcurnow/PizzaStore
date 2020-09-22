using System;

namespace PizzaStore
{

    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();

            var pizza = nyStore.orderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.getName()}");
        }
    }
}
