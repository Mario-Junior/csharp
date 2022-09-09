using Factory;

class Program
{
  public static void Main()
  {
    Bakery bakery = new();
    var bread1 = bakery.FabricateBread(250);

    Console.WriteLine(bread1.Weight + "gr"); // Saída esperada: 250gr
    Console.WriteLine(bread1.Type); // Saída esperada: White

    var cake1 = bakery.FabricateChocolateCake("Large");

    Console.WriteLine(cake1.Size); // Saída esperada: Large
    Console.WriteLine(cake1.Flavour); // Saída esperada: Chocolate

    cake1.Flavour = "Strawberry";
    Console.WriteLine(cake1.Flavour); // Saída esperada: Strawberry

    bread1.Type = "Barley"; // Saída esperada: Unhandled exception. System.ArgumentException: Invalid bread type
  }
}
