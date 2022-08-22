namespace Triangle.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um triângulo")]
    [InlineData(2, 2, 2, "Triângulo Equilátero")]
    [InlineData(5, 6, 6, "Triângulo Isósceles")]
    [InlineData(6, 2, 6, "Triângulo Isósceles")]
    [InlineData(6, 6, 2, "Triângulo Isósceles")]
    [InlineData(1, 2, 3, "Triângulo Escaleno")]
    public void TestIdentifyTriangle(double xSide, double ySide, double zSide, string name)
    {
        var resultName = Triangle.IdentifyTriangle(xSide, ySide, zSide);

        resultName.Should().Be(name);
    }
}
