namespace LinqBasics;
using System;
using System.Linq;

public class Program
{
  static void Main()
  {
    Console.WriteLine("% Declarative Linq query:");
    LinqExpressions.DeclarativeLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq query:");
    LinqExpressions.LambdaLinq();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Lambda Linq refactored query:");
    LinqExpressions.LambdaLinqRefactored();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% Linq Basic query - TopListeners:");
    Artist.TopListeners();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("% No WHERE query:");
    NoWhereQuery.Greetings();
  }
}
