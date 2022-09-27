namespace Strings.Test;

public class UnitTest1
{    
    [Theory(DisplayName = "Teste da função Concat para concatenar nome")]
    [InlineData("Andrea ", "Santos", "Andrea Santos")]
    [InlineData("Alex ", "Silva", "Alex Silva")]
    public void TestConcatNameSuccess(string name, string lastName, string resultExpected)
    {
        var result = new StringLesson().ConcatName(name, lastName);
        result.Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste da função IndexOf para captar index de determinado caracter em uma palavra")]
    [InlineData("csharp", "h", 2)]
    [InlineData("trybe", "b", 3)]
    public void TestIndexOfWordSuccess(string word, string letter, int resultExpected)
    {
        var result = new StringLesson().IndexOfWord(word, letter);
        result.Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste da função CreateExpirationAlertEmailBody")]
    [InlineData("Luiz", 3, "Olá, Luiz! Faltam apenas 3 dias para seu plano expirar.")]
    [InlineData("Larissa", 6, "Olá, Larissa! Faltam apenas 6 dias para seu plano expirar.")]
    [InlineData("Cris", 12, "Olá, Cris! Faltam apenas 12 dias para seu plano expirar.")]
    public void TestCreateExpirationAlertEmailBodySuccess(string name, int daysToExpire, string resultExpected)
    {
        var result = new StringLesson().CreateExpirationAlertEmailBody(name, daysToExpire);
        result.Should().Be(resultExpected);
    }
}
