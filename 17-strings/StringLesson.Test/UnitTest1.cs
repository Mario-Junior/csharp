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
}
