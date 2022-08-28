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
Console.WriteLine("myArrayInit length = " + myArrayInit.Length);
foreach (var number in myArrayInit)
{
  Console.WriteLine(number);
}

myArrayInit = new int[10];
Console.WriteLine("myArrayInit length = " + myArrayInit.Length);

// Arrays multidimensionais
PlayingWithArrays.commonMultiDimensionalArray();
PlayingWithArrays.jaggedMultiDimensionalArray();

class PlayingWithArrays
{
  public static void commonMultiDimensionalArray()
  {
    int[,] commonMultiDimensionalArray = new int[3, 3] {{1,2,3}, {1,2,3}, {1,2,3}};
    for (int i = 0; i < commonMultiDimensionalArray.GetLength(0); i++)
    {
      for (int j = 0; j < commonMultiDimensionalArray.GetLength(1); j++)
      {
        Console.Write("{0} ", commonMultiDimensionalArray[i, j]);
      }
      Console.WriteLine();
    }
  }

  public static void jaggedMultiDimensionalArray()
  {
    int[,] jaggedMultiDimensionalArray = new int[3, 3] {{1,2,3}, {1,2,3}, {1,2,3}};
    for (int i = 0; i < jaggedMultiDimensionalArray.GetLength(0); i++)
    {
      for (int j = 0; j < jaggedMultiDimensionalArray.GetLength(1); j++)
      {
        Console.Write("{0} ", jaggedMultiDimensionalArray[i, j]);
      }
      Console.WriteLine();
    }
  }
}
