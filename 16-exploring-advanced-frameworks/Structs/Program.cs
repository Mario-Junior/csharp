Coordinate someLocation = new(-19.922072, -43.939879);
Console.WriteLine("Latitude: " + someLocation.Latitude);
Console.WriteLine("Longitude: " + someLocation.Longitude);

Coordinate anotherLocation = new();
Console.WriteLine("Latitude: " + anotherLocation.Latitude);
Console.WriteLine("Longitude: " + anotherLocation.Longitude);

struct Point
{
  double x;
  double y;
}

struct Coordinate
{
  public double Latitude;
  public double Longitude;

  public Coordinate(double latitude, double longitude)
  {
    Latitude = latitude;
    Longitude = longitude;
  }
}
