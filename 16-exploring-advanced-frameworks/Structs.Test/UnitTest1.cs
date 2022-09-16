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
}
