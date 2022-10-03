namespace LinqBasics;
using System;
using System.Linq;
// LINQ permite uma consulta em qualquer coleção que implemente a interface IEnumerable<T>
// seja um array, uma lista, um XML ou uma fonte de dados remota, como uma tabela no SQL.

// Para a execução dessa consulta, a cláusula from é a única obrigatória quando usamos LINQ.

// Na consulta a uma fonte de dados é permitida a presença de apenas uma cláusula from, pois ela determina qual fonte será usada.

public class FruitBasket
{
  public static void FruitLoops()
  {

    string[] fruits = { "Banana", "Orange", "Apple", "Mango", "Grape" };

    var ordenedFruits = from fruitName
      in fruits
      orderby fruitName
      orderby fruitName.Length
      select fruitName;

    foreach (var fruit in ordenedFruits)
    {
      Console.WriteLine(fruit);
    }
  }
}
