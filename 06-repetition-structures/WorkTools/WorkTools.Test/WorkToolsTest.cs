namespace WorkTools.Test;

using WorkTools;

public class WorkToolsTest
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro.")]
    [InlineData(new int[] {1, 1, 1}, 1, 3)]
    [InlineData(new int[] {1, 2, 1}, 1, 2)]
    [InlineData(new int[] {1, 2, 3}, 1, 1)]
    public void TestCountOf(int[] entNumbers, int value, int countExpected)
    {
        var count = NumbersTools.CountOf(entNumbers, value);
        
        count.Should().Be(countExpected);
    }

    [Theory(DisplayName = "Deve localizar a posição do número no array vetor.")]
    [InlineData(new int[] {5, 6, 7}, 5, 0)]
    [InlineData(new int[] {8, 9, 10}, 9, 1)]
    [InlineData(new int[] {11, 12, 13}, 13, 2)]
    [InlineData(new int[] {11, 12, 13, 13}, 13, 2)]
    [InlineData(new int[] {11, 12, 13}, 10, -1)]
    public void TestIndexOf(int[] entNumbers, int value, int positionExpected)
    {
        var position = NumbersTools.IndexOf(entNumbers, value);
        
        position.Should().Be(positionExpected);
    }

    [Theory(DisplayName = "Deve contar a quantidade de números pares.")]
    [InlineData(new int[] {5, 3, 7}, 0)]
    [InlineData(new int[] {11, 9, 10}, 1)]
    [InlineData(new int[] {8, 9, 10}, 2)]
    public void TestCountEvenNumbers(int[] entNumbers, int countExpected)
    {
        var count = NumbersTools.CountEvenNumbers(entNumbers);
        
        count.Should().Be(countExpected);
    }
}
