namespace LinqBasics;
using System;
using System.Linq;

// DESCOMENTE para ver os modelos de consulta Declarativas:
// // Consulta completa:
// IEnumerable<string> filteredGames1 = from game in games
//                                         where game.Contains('a')
//                                         select game;

// // Consulta simplificada (usando tipos implícitos):
// var filteredGames2 = from game in games
//                   where game.Contains('a')
//                   select game;

public class Program
{
  static void Main()
  {
    Console.WriteLine("% Declarative Linq query:");
    LinqQueries.DeclarativeLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq query:");
    LinqQueries.LambdaLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq refactored query:");
    LinqQueries.LambdaLinqRefactored();
  }
}
