//Criando o array
int[] myFirstArray1;

//instanciando array: 
//array = new tipo[tamanhoDoArray];
myFirstArray1 = new int[5];
Console.WriteLine(myFirstArray1);

// inicializando e instanciando o array de forma simplificada
int[] myFirstArray2 = new int[5];
Console.WriteLine(myFirstArray2);

// inicializando array com valores pré-definidos
int[] myFirstArray3 = new int[] {1, 2, 3, 4, 5};
Console.WriteLine(myFirstArray3);

int[] myFirstArray4 = {1, 2, 3, 4, 5};
Console.WriteLine(myFirstArray4);

string[] myFirstStringArray1 = new string[] {"Vamo", "que", "vamo", "!"};
Console.WriteLine(myFirstStringArray1);

string[] myFirstStringArray2 = {"Vamo", "que", "vamo", "!"};
foreach (var word in myFirstStringArray2)
{
  Console.WriteLine(word);
}

// // DESCOMENTE para verificar o resultado dessa parte do estudo
// int[] myArray = new int[4] {6, 9, 5, 8};

// Console.WriteLine(myArray[4]);
// // Saída: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

// Console.WriteLine("Chegou Aqui!?");
// // Essa linha não será executada

// Um Array em C# é imutável, ou seja, assim que a instância de um Array é criada, o seu tamanho não pode ser alterado.
// Porém ele pode ser instanciado novamente usando um valor diferente com uma nova atribuição =.
int[] myArrayInit = {1, 2, 3, 4};
foreach (var number in myArrayInit)
{
  Console.WriteLine(number);
}
