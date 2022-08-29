namespace MatrixDiagonalSum.Test;

public class TestMatrixDiagonalSum
{
    [Theory(DisplayName = "Imprime todos os elementos de um Array")]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    public void TestArrayInlineData(int[] intArrayEntry)
    {
        for (int i = 0; i < intArrayEntry.Length; i++)
        {
            Console.WriteLine(intArrayEntry[i]);
        }
    }
}
