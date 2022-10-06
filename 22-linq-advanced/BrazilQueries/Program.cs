namespace BrazilQueries;

public class Program
{
  public static void Main()
  {
    State[] states = State.CreateStates();
    foreach (var state in states)
    {
      Console.WriteLine(state.Name);
    }
  }
}
