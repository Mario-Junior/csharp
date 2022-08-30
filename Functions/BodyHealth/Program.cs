var instance = new BodyHealth();
var bmi = instance.CalculateBMI(82, 1.78);
instance.CalculateAgeByYear(1982);

Console.WriteLine(bmi);

class BodyHealth
{
  public double CalculateBMI(int weight, double height)
  {
    return weight / (height * height);
  }

  public void CalculateAgeByYear(int yearOfBirth) 
  {     
    Console.WriteLine(DateTime.Now.Year - yearOfBirth);
  }
}
