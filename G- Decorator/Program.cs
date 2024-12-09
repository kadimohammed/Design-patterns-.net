// Usage
using G__Decorator;

ICoffee myCoffee = new SimpleCoffee();
Console.WriteLine(myCoffee.GetDescription()); // Output: Cafe simple
Console.WriteLine(myCoffee.GetCost());        // Output: 10.0

// Tzid 7lib
myCoffee = new MilkDecorator(myCoffee);
Console.WriteLine(myCoffee.GetDescription()); // Output: Cafe simple, m3a 7lib
Console.WriteLine(myCoffee.GetCost());        // Output: 15.0

// Tzid sukkar
myCoffee = new SugarDecorator(myCoffee);
Console.WriteLine(myCoffee.GetDescription()); // Output: Cafe simple, m3a 7lib, m3a sukkar
Console.WriteLine(myCoffee.GetCost());        // Output: 17.0