namespace BrazilQueries;

public class Program
{
  public static void Main()
  {
    State[] states = State.CreateStates();
    City[] cities = City.CreateCities();

    foreach (var state in states) Console.WriteLine(state.Name);
    foreach (var city in cities) Console.WriteLine(city.Name);
  }
}
