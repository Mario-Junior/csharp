namespace genericList;

public class AnonymousTypes
{
  public static void AnonymousTypesExample()
  {
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("AnonymousTypes:");
    Console.WriteLine("Exemplo: var myAnonymousType = new { Amount = 42, Message = 'Olá',  Value = 3.95};");
    var myAnonymousType = new { Amount = 42, Message = "Olá",  Value = 3.95};

    Console.WriteLine("Console: " + myAnonymousType.Amount);
    Console.WriteLine("Console: " + myAnonymousType.Message);
    Console.WriteLine("Console: " + myAnonymousType.Value);
  }
}
