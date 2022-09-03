namespace MathSystem.Test;

public class TestMathSystem
{
    [Theory(DisplayName = "Teste para lançamento de exceção em divisão entre dois números inteiros")]
    [InlineData(2022, 0)]
    [InlineData(5, 4)]
    [InlineData(6, 0)]
    [InlineData(12, 2)]
    public void TestDivideNumbersException(int numberOne, int numberTwo)
    {
        MathOperations mathOperations = new MathOperations();

        Action act = () => mathOperations.DivideNumbers(numberOne, numberTwo);

        act.Should().Throw<DivideByZeroException>().WithMessage("Não pode dividir um número por zero!");
    }
}
