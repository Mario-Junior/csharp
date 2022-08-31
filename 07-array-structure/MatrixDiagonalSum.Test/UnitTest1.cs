using DiagonalSum;

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

    [Theory(DisplayName = "2- Imprime todos os elementos de um Array com elementos diferentes")]
    [InlineData(new int[] { 1, 2, 3, 4 }, "Minha string")]
    public void TestArrayInlineData2(int[] intArrayEntry, string stringEntry)
    {
        for (int i = 0; i < intArrayEntry.Length; i++)
        {
            Console.WriteLine(intArrayEntry[i]);
        }
        Console.WriteLine(stringEntry);
    }

    // Como não posso criar arrays multidimensionais com o InlineData para os testes, uso funções de suporte para, a partir de um array de uma só dimensão, fazer os testes funcionarem
    // Posso identar o código de forma que fique mais simples visualizar que o array multidimensional que será criado é originado do Array de apenas uma dimensão

    [Theory(DisplayName = "3- Testa Arrays quadrados (de 2 dimensões)")]
    [InlineData(new int[]
    // O Array continua tendo apenas uma dimensão, mas foi identado para facilitar a visualização
    {
        1, 2, 3,
        4, 5, 6,
        7, 8, 9,
    }, 3, 15)]
    [InlineData(new int[]
    {
        1,  2,  3,  4,
        5,  6,  7,  8,
        9,  10, 11, 12,
        13, 14, 15, 16
    }, 4, 34)]
    public void TestGetDiagonalSum(int[] intArrayEntry, int entryLines, int expectedResult)
    {
        int[,] multiDimArray = Program.FromArrayToTwoDimArray(intArrayEntry, entryLines, entryLines);
        // Agora multiDimArray é um array multidimensional criado a partir dos dados passados como InlineData

        // Passo o array de 2 dimensões criado e comparo com o resultado esperado
        Program.GetDiagonalSum(multiDimArray).Should().Be(expectedResult);
    }
}
