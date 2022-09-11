namespace Car.Test;

public class CarTest
{
    [Fact]
    public void ShouldBeAbleToConvertTopSpeed()
    {
        Car car = new() { TopSpeed = 100 };

        car.TopSpeed.Should().Be(100);
        car.TopSpeedMph.Should().BeApproximately(62.13, 0.1);
    }

    [Fact]
    public void HasKphToMphStaticMethod()
    {
        Car.KphToMph(100).Should().BeApproximately(62.13, 0.1);
    }
}
