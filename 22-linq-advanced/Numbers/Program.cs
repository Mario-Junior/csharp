// Os métodos de uma coleção

// Base de dados é um array de inteiros
int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

// numQuery é do tipo IEnumerable<int>
// Selecionando apenas os números pares da coleção.
var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

// Count():
// Método para qualquer tipo de consulta e coleções.
// Retorna o número de elementos da consulta ou lista que implementa a Interface IEnumerable
Console.WriteLine("$ Método .Count:");
Console.WriteLine("int[] numbers.Count() = " + numbers.Count());
Console.WriteLine("numQuery.Count() = " + numQuery.Count());
Console.WriteLine("------------------------------------------------------------------------");
