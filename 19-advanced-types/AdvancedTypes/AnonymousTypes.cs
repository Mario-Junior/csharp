namespace advancedTypes;

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

// classe criada para fins didáticos em tipos genéricos e testes
public class SomeClass
{
  public static object[] getAllContacts()
  {
    // Cria consulta ao BD...
    return new[]
    {
        new{name = "John", number = "1111-1111"},
        new{name = "Steve", number = "2222-2222"},
        new{name = "Clara", number = "3333-3333"},
        new{name = "Ana", number = "4444-4444"}
    };
  }
}
