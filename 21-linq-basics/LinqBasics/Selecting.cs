namespace LinqBasics;
using System;
using System.Linq;

// Em toda consulta, o select sempre irá indicar o tipo de dado que será retornado.

// Essa cláusula é usada para criar uma saída dos elementos da fonte de dados na qual estamos trabalhando
// e essa saída pode não ser necessariamente um tipo vindo da nossa fonte de dados, mas sim um elemento transformado.

// Quando o select é usado para transformar um elemento, dizemos que ele está realizando uma projeção sobre nossa fonte de dados.

public class Selecting
{
  public static void Words()
  {
    string[] words = { "owner", "report", "warm", "scramble", "party" };

    var objWords = from word in words
      select new { word, length = word.Length };

    foreach (var obj in objWords)
    {
      Console.WriteLine(obj);
    }
  }
}
