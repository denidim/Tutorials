using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample
{
    internal class Pizza
    {
        public List<string> Toppings { get; set; } = new List<string>();
        public string Address { get; set; } = "Pickup"; // Default
        public void ShowToppings() 
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Your Pizza has: {string.Join(", ", Toppings)}");
        } 
    }
}
