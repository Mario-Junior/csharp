namespace Car.Test;

public class Car
{
  double _topSpeedKph;
  public double TopSpeed
  {
    get { return _topSpeedKph; }
    set { _topSpeedKph = value; }
  }

  public static double KphToMph(double kph)
  {
    return kph / 1.61;
  }

  public double TopSpeedMph
  {
    get { return KphToMph(_topSpeedKph); }
  }
}
