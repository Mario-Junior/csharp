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
  }
}
