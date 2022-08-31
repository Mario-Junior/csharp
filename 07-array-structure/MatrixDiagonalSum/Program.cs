namespace DiagonalSum;

public class Program
{
  public static void Main()
  {
    int[,] myArray = new int[3, 3]
    {
      {1, 2, 3},
      {4, 5, 6},
      {7, 8, 9},
    };

    Console.WriteLine(myArray.GetLength(1));

    int result = GetDiagonalSum(myArray);

    Console.WriteLine("Diagonal Sum = " + result);
  }

  public static int GetDiagonalSum(int[,] matrix)
  {
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum += matrix[i, i];
    }

    return sum;
  }

  public static int[,] FromArrayToTwoDimArray(int[] array, int lines, int columns)
  {
    int[,] result = new int[lines, columns];
    for (int i = 0; i < array.Length; i++)
    {
      result[i / lines, i % columns] = array[i];
    }
    return result;
  }
}
