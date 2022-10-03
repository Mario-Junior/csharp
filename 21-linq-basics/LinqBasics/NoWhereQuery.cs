namespace LinqBasics;
using System;
using System.Linq;
// Assim como no SQL, no LINQ posso omitir a cláusula WHERE em casos em que quero retornar toda a coleção disponível em minha fonte de dados

public class NoWhereQuery
{
  public static void Greetings()
  {
    string[] greetings = { "Hello World", "Hello LINQ", "Hello Trybe" };
    var items =
      from greeting in greetings
      select greeting;
    foreach (var item in items)
      Console.WriteLine(item);

    var countItems = 
      (from greeting in greetings
      select greeting).Count();
    
    Console.WriteLine("Contagem de itens em 'greetings' = " + countItems);
  }
}
