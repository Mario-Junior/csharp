namespace RocketFactory;

public class Rocket
{
  public int _fuel;
  readonly int _maxFuel = 5000;

  public int FuelAsPercentage
  {
    get { return _fuel * 100 / _maxFuel; }
    set
    {
      if (value < 0 || value > 100)
        throw new ArgumentOutOfRangeException("Value", "Fuel percentage must be between 0 and 100%");

        _fuel = (value * _maxFuel) / 100;
    }
  }
}
