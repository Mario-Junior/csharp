// Coleções de dados em C#
// São elas:
// Arraylist: São matrizes de objetos que aumentam o seu tamanho dinamicamente.
// Hashtable: Coleções de chave-valor organizadas com base no código hash da chave.

List<string> stringList = new List<string>(){ "carro", "casa", "roupa", "avião" };

List<int> intList = new List<int>{ 1, 2, 6, 8, 10, 87, 45 };

List<string> animals = new(){ "cachorro", "gato",  "pássaro", "peixe" };

Console.WriteLine("Animals [0] = " + animals[0]);

List<string> vehicles = new(){ "carro", "moto", "avião" };

foreach (var item in vehicles)
{
    Console.WriteLine("Vehicles = " + item);
}

// Sintaxe para criação de objetos do tipo lista simples (vazios):
List<string> newList1 = new List<string>();
Console.WriteLine(newList1);

// Sintaxe com expressão new simplificada:
List<string> newList2 = new();
Console.WriteLine(newList2);

List<string> brands = new(){ "samsung", "dell", "apple", "HP" };
foreach (var item in brands)
{
    Console.WriteLine("Brands = " + item);
}

// Os métodos mais utilizados com listas são: .Add(), .Remove(), .RemoveAt(), .IndexOf() e .Sort(). Cada um deles nos ajuda a resolver alguns problemas:
// .Add() - Serve para adicionarmos itens da lista.
List<string> cars = new(){ "Fusca" };
cars.ForEach(car => { Console.WriteLine(car); });
cars.Add("Brasília");
cars.ForEach(car => { Console.WriteLine("Add example: " + car); });

// .Remove() - Serve para remover um item específico da lista.
cars.Remove("Fusca");
cars.ForEach(car => { Console.WriteLine("Remove example: " + car); });

// .RemoveAt() - Serve para removermos itens da lista segundo o índice deles.
cars.Add("Fusca"); cars.Add("Ferrari"); cars.Add("Lamborghini");
cars.ForEach(car => { Console.WriteLine(car); });
cars.RemoveAt(0);
cars.ForEach(car => { Console.WriteLine("RemoveAt example: " + car); });

// .IndexOf - Nos retorna o índice de um objeto na lista.
List<int> integers = new List<int>(){ 18, 45, 29, 99 };
integers.ForEach(integer => { Console.WriteLine(integer); });
Console.WriteLine("IndexOf example: " + integers.IndexOf(29));

// .Sort() - Serve para ordenar a nossa lista.
