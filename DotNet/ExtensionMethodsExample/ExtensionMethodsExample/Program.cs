using ExtensionMethodsExample;

var myPizza = new Pizza();

myPizza
    .AddTopping<Cheese>()
    .AddTopping<Salami>()
    .AddTopping<Cheese>()
    .ConfigureDelivery(p =>
    {
        p.Address = "123 C# Street, SoftUni City";
        Console.WriteLine("setting up delivery details...");
    });

myPizza.ShowToppings();
      