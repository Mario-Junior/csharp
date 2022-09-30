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

    AnonymousTypes.AnonymousTypesExample();

    var message = "Olá, Mundo!";
    var words1 = ExtensionMethods.WordCount1(message);
    Console.WriteLine("Console com método SEM extensão: " + words1);
    
    var words2 = message.WordCount2();
    Console.WriteLine("Console com método COM extensão: " + words2);
  }
}
