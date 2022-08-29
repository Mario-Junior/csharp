class Program
{
  public static void Main()
  {
    int[,] myArray = new int[2, 3]
    {
      {1, 2 ,3},
      {4, 5, 6},
    };

    Console.WriteLine(myArray.GetLength(0));
  }

  // public static int GetDiagonalSum(int[,] matrix)
  // {
  //   int sum = 0;

  // }
}
