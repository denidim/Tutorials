using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample
{
    internal static class PizzaExtensions
    {
        public static Pizza AddTopping<T>(this Pizza pizza) where T : new()
        {
            var topping = new T();

            string toppingName = topping.GetType().Name;

            pizza.Toppings.Add(toppingName);

            Console.WriteLine($"Added {toppingName} to the pizza!");

            return pizza;
        }
    }
}
