namespace TrybeNamesWriter.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Teste de exceção para nome com valor nulo passado como parâmetro.")]
    [InlineData("Ariel")]
    [InlineData("Drica")]
    [InlineData("Duda")]
    [InlineData(null)]
    public void TestWriteNameException(string name)
    {
        var namesWriter = new NamesWriter();

        Action act = () => namesWriter.WriteName(name);

        act.Should().Throw<ArgumentNullException>();
    }
}
