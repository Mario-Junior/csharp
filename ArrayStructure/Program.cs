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
    // Somente instancio o array mais externo neste primeiro passo
    // Repare que apenas o primeiro colchete contém número
    int[][] jaggedArray = new int[4][];

    // Agora preciso instanciar um novo array para cada posição do array mais externo
    jaggedArray[0] = new int[3] {1,2,3};
    jaggedArray[1] = new int[5] {1,2,3,4,5};
    jaggedArray[2] = new int[2] {1,2};
    jaggedArray[3] = new int[4] {1,2,3,4};

    for (int x = 0; x < jaggedArray.Length; x++)
    {
      Console.Write("\n");
      for (int y = 0; y < jaggedArray[x].Length; y++)
      {
        Console.Write("{0} ", jaggedArray[x][y]);
      }
    }
  }
}
