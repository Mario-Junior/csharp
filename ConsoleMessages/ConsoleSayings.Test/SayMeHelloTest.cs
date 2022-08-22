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

    [Theory(DisplayName = "Deve imprimir as linhas de acordo com o nome passado como parâmetro.")]
    [InlineData("Rahel", "Hey, Hello Rahel", "Can I call u Rahelzita(o)?")]
    [InlineData("Marina", "Hey, Hello Marina", "Can I call u Marinazita(o)?")]
    [InlineData("Luiz", "Hey, Hello Luiz", "Can I call u Luizzita(o)?")]
    [InlineData("Arthur", "Hey, Hello Arthur", "Can I call u Arthurzita(o)?")]
    [InlineData("Livia", "Hey, Hello Livia", "Can I call u Liviazita(o)?")]
    public void TestHelloHarder(string entry, string expected1call, string expected2call)
    {
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);
            SayMeHello.HelloHarder(entry);
            var phrases = stringWriter.ToString().Trim().Split("\n");
            phrases[0].Should().Be(expected1call);
            phrases[1].Should().Be(expected2call);
        }
    }
}
