class Program
{
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
  }
}
