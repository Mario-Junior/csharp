namespace Rockets.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // expressão new em forma simplificada!
        Rocket trybeRocket = new();

        trybeRocket.Should().NotBeNull();
        trybeRocket.Should().BeOfType<Rocket>();
    }

    [Fact]
    public void Test2()
    {
        // expressão new em forma simplificada!
        Rocket trybeRocket = new("Trybe I", "Brasil", 100000);

        trybeRocket.Name.Should().Be("Trybe I");
        trybeRocket.Country.Should().Be("Brasil");
        trybeRocket.Speed.Should().Be(100000);
    }
}
