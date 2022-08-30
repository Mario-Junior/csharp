var instance = new BodyHealth();
var bmi = instance.CalculateBMI(82, 1.78);

Console.WriteLine(bmi);

class BodyHealth
{
  public double CalculateBMI(int weight, double height)
  {
    return weight / (height * height);
  }
}
