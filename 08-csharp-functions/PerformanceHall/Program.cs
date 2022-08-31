using System;

namespace PerformanceHall;

public class Age
{
  public void Main()
  {
    var age = CalculateAgeByYear(1982);
    var isOfLegalAge = ValidateComingOfAge(age);
  }
  public int CalculateAgeByYear(int yearOfBitrh)
  {
    return DateTime.Now.Year - yearOfBitrh;
  }

  public bool ValidateComingOfAge(int age)
  {
    return age >= 18;
  }
}
