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

    [Theory(DisplayName = "Deve retornar o primeiro evento")]
    [InlineData(01, 10, 2022, "sábado, 1 de outubro de 2022")]
    [InlineData(23, 01, 1997, "quinta-feira, 23 de janeiro de 1997")]
    [InlineData(12, 12, 2030, "quinta-feira, 12 de dezembro de 2030")]
    [InlineData(23, 07, 2001, "segunda-feira, 23 de julho de 2001")]
    [InlineData(02, 12, 2010, "quinta-feira, 2 de dezembro de 2010")]
    public void TestNextEventFirstEvent(int year, int month, int day, string expected)
    {
        Schedule instance = new();
        instance.nextEvents[0] = new DateTime(day, month, year);
        var result = instance.NextEvent();

        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve adcionar o evento para o array de agenda")]
    [InlineData(30)]
    [InlineData(1)]
    [InlineData(60)]
    [InlineData(90)]
    [InlineData(365)]
    public void TestAddEvent(int days)
    {
        Schedule instance = new();
        var expected = DateTime.Now.AddDays(days);
        instance.nextEvents[0].Date.Should().Be(new DateTime().Date);
        instance.AddEventAtDays(days);
        instance.nextEvents[0].Date.Should().Be(expected.Date);
    }
}
