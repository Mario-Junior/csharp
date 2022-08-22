using ConsoleSayings;

namespace ConsoleSayings.Test;

public class SayMeHelloTest
{
    [Theory(DisplayName = "Deve imprimir a saudação de acordo com o nome passado como parâmetro.")]
    [InlineData("Rahel", "Hey, Hello Rahel")]
    [InlineData("Marina", "Hey, Hello Marina")]
    [InlineData("Luiz", "Hey, Hello Luiz")]
    [InlineData("Arthur", "Hey, Hello Arthur")]
    [InlineData("Livia", "Hey, Hello Livia")]
    public void TestHello(string entry, string expected)
    {
        // DESCOMENTAR para verificar o erro
        // var greeting = SayMeHello.Hello(entry);
        // // Não consigo testar dessa forma, pois o método Hello é 'void' e não retorna nada
        // greeting.Should().Be(expected);

        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);
            SayMeHello.Hello(entry);
            var greeting = stringWriter.ToString().Trim();
            greeting.Should().Be(expected);
        }
    }
}
