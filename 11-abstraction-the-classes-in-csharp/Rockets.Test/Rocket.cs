namespace Rockets.Test;

class Rocket
{
  public string Name { get; set; } = "Foguete";
  public string Country { get; set; } = "Apátrida";
  public double Speed { get; set; }

  public Rocket() {}

  public Rocket(string name, string country, double speed)
  {
    Name = name;
    Country = country;
    Speed = speed;
  }
}
