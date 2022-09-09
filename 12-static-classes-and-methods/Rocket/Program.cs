using RocketFactory;

class Program
{
  public static void Main(string[] args)
  {
    Rocket rocket1 = new();
    rocket1.FuelAsPercentage = 10;
    Console.WriteLine(rocket1.FuelAsPercentage); // Saída esperada: 10 %
    Console.WriteLine(rocket1._fuel); // Saída esperada: 500 L

    rocket1.FuelAsPercentage = 101; // Saída esperada: Unhandled exception. System.ArgumentOutOfRangeException: Fuel percentage must be between 0 and 100% (Parameter 'Value')
    Console.WriteLine(rocket1.FuelAsPercentage);
    Console.WriteLine(rocket1._fuel);
  }
}
