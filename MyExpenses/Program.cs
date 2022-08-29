class Program
{
  // Função para transformar um Array de uma única dimensão (uma única linha), em duas dimensões (vide Console.WriteLine ao final do arquivo, na função Main):
  public static int[,] FromArrayToTwoDimArray(int[] array, int lines, int columns)
  {
    Console.WriteLine("\n" + "** Transformando Array de única dimensão em duas dimensões **");
    int[,] result = new int[lines, columns];
    for (int i = 0; i < array.Length; i++)
    {
      result[i / lines, i % columns] = array[i];
    }
    return result;
  }

  private static int GetNumberOfExpenses() {
    string? numberOfExpenses = Console.ReadLine();
    int numberConverted = Convert.ToInt32(numberOfExpenses);
    return numberConverted;
  }

  private static int GetExpenseCostFromUser() {
    Console.WriteLine("Entre o valor da despesa: ");
    string? valueOfExpense = Console.ReadLine();
    int valueConverted = Convert.ToInt32(valueOfExpense);
    return valueConverted;
  }

  static void Main()
  {
    int[] expensesCost;
    Console.WriteLine("Entre com o número de despesas: ");
    int numberOfExpenses = GetNumberOfExpenses();

    expensesCost = new int[numberOfExpenses];

    for (int i = 0; i < numberOfExpenses; i++)
    {
      expensesCost[i] = GetExpenseCostFromUser();
    }

    int totalExpenses = 0;

    for (int i = 0; i < numberOfExpenses; i++)
    {
      totalExpenses += expensesCost[i];
    }

    Console.WriteLine("O total das despesas é: " + totalExpenses);

    // Console.WriteLine da função de transforamação de Array de uma para duas dimensões:
    var newArr = FromArrayToTwoDimArray(new int[9], 3, 3);
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
      for (int j = 0; j < newArr.GetLength(1); j++)
      {
        Console.Write("{0} ", newArr[i, j]);
      }
      Console.WriteLine();
    }
  }
}
