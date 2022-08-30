namespace Multiply.Test;

public class MultiplyTest
{

    public static int Multiply(int numberOne, int numberTwo)
    {
        return numberOne * numberTwo;
    }

    [Theory(DisplayName = "Teste para a multiplicação de dois números inteiros")]
    [InlineData(2, 6, 12)]
    [InlineData(6, 4, 24)]
    [InlineData(4, 132, 528)]
    [InlineData(999, 0, 0)]
    public void TestMultiplyCalculator(int numberOne, int numberTwo, int resultExpected)
    {
        var calculationResult = Multiply(numberOne, numberTwo);

        calculationResult.Should().Be(resultExpected);
    }
}
