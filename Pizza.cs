using System;
using System.Collections.Generic;

namespace PizzaStore
{
    public abstract class Pizza
    {
        public string Name;
        public string Dough;
        public string Sauce;
        public List<string> Toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return Name;
        }
    }
}