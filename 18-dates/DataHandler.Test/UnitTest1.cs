namespace DataHandler.Test;
using DateHandler;

public class DateHandlerTest
{
    [Theory(DisplayName = "Deve retornar string de não há eventos")]
    [InlineData("Não há eventos marcados")]
    public void TestNextEventWithoutEvents(string expected)
    {
        Schedule instance = new();
        var result = instance.NextEvent();

        result.Should().Be(expected);
    }
}
