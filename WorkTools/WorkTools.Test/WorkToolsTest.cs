namespace WorkTools.Test;

using WorkTools;

public class WorkToolsTest
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro")]
    [InlineData(new int[] {1, 1, 1}, 1, 3)]
    [InlineData(new int[] {1, 2, 1}, 1, 2)]
    [InlineData(new int[] {1, 2, 3}, 1, 1)]
    public void TestCountOf(int[] entNumbers, int value, int countExpected)
    {
        var count = NumbersTools.CountOf(entNumbers, value);
        
        count.Should().Be(countExpected);
    }
}
