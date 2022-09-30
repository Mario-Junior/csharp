namespace genericList;

public class Program
{
  public static void Main(string[] args)
  {
    GenericList<string> listString = new();
    listString.Add("Olá");
    listString.Add("Hello");
    listString.Add("Hola");
    listString.Add("Hallo");

    listString.Print();

    // AnonymousTypes:
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("AnonymousTypes:");
    Console.WriteLine("Exemplo: var myAnonymousType = new { Amount = 42, Message = 'Olá',  Value = 3.95};");
    var myAnonymousType = new { Amount = 42, Message = "Olá",  Value = 3.95};

    Console.WriteLine("Console: " + myAnonymousType.Amount);
    Console.WriteLine("Console: " + myAnonymousType.Message);
    Console.WriteLine("Console: " + myAnonymousType.Value);
  }
}
