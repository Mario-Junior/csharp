﻿namespace LinqBasics;
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
    DeclarativeLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq query:");
    LambdaLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq refactored query:");
    LambdaLinqRefactored();
  }
  static void DeclarativeLinq()
  {
    string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"};

    var filteredGames = from game in games
                  where game.Contains('a')
                  select game;

    foreach (string game in filteredGames)
    {
      Console.WriteLine(game);
    }
  }

  static void LambdaLinq()
  {
    string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"};

    IEnumerable<string> filteredGames = System.Linq.Enumerable.Where(games, n => n.Contains('a'));

    foreach (string game in filteredGames)
    {
      Console.WriteLine(game);
    }
  }

  static void LambdaLinqRefactored()
  {
    string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"};

    var filteredGames = games.Where(n => n.Contains('a'));

    foreach (string game in filteredGames)
    {
      Console.WriteLine(game);
    }
  }
}
