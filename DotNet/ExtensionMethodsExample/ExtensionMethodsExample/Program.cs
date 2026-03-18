using ExtensionMethodsExample;

var myPizza = new Pizza();

myPizza
    .AddTopping<Cheese>()
    .AddTopping<Salami>()
    .AddTopping<Cheese>();

myPizza.ShowToppings();
      