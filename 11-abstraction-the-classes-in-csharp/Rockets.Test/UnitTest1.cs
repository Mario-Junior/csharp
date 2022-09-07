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
}
