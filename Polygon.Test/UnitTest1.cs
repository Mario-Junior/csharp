namespace Polygon.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um polígono")]
    [InlineData(2, "Não é um polígono!")]
    [InlineData(3, "Triângulo")]
    [InlineData(4, "Retângulo")]
    [InlineData(5, "Pentágono")]
    [InlineData(6, "Polígono de outro tipo")]
    public void TestIdentifyPolygon(int sideCount, string name)
    {
        var resultName = Polygon.IdentifyPolygon(sideCount);

        resultName.Should().Be(name);
    }
}
