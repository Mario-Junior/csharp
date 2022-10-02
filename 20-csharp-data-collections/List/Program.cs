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
