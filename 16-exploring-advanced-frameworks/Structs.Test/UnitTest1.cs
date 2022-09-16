namespace Structs.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve criar corretamente a estrutura Point")]
    [InlineData(10, 20)]
    public void TestCreatePoint(int xEntry, int yEntry)
    {
        Point point = new(xEntry, yEntry);

        point.x.Should().Be(xEntry);
        point.y.Should().Be(yEntry);
    }

    [Theory(DisplayName = "Deve calcular a distância corretamente com base no método")]
    [InlineData(10, 20, 10, 20, 0.0)]
    [InlineData(0, 0, 0, 20, 20.0)]
    public void TestDistanceReturnCorrect(int xEntry, int yEntry, int xOtherEntry, int yOtherEntry, double expectedResult)
    {
        Point point = new(xEntry, yEntry);
        Point otherPoint = new(xOtherEntry, yOtherEntry);

        double distance = point.Distance(otherPoint);

        distance.Should().Be(expectedResult);
    }
}
