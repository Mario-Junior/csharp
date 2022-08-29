namespace MatrixDiagonalSum.Test;

public class TestMatrixDiagonalSum
{
    [Theory(DisplayName = "1- Imprime todos os elementos de um Array de elementos iguais")]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    public void TestArrayInlineData1(int[] intArrayEntry)
    {
        for (int i = 0; i < intArrayEntry.Length; i++)
        {
            Console.WriteLine(intArrayEntry[i]);
        }
    }

    [Theory(DisplayName = "1- Imprime todos os elementos de um Array com elementos diferentes")]
    [InlineData(new int[] { 1, 2, 3, 4 }, "Minha string")]
    public void TestArrayInlineData2(int[] intArrayEntry, string stringEntry)
    {
        for (int i = 0; i < intArrayEntry.Length; i++)
        {
            Console.WriteLine(intArrayEntry[i]);
        }
        Console.WriteLine(stringEntry);
    }
}
