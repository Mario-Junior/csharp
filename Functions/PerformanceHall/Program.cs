using System;

namespace AgeNamespace;

class PerformanceHall
{
  public static void Main()
  {
    var age = CalculateAgeByYear(1982);
    var isOfLegalAge = ValidateComingOfAge(age);
  }
  public static int CalculateAgeByYear(int yearOfBitrh)
  {
    return DateTime.Now.Year - yearOfBitrh;
  }

  public static bool ValidateComingOfAge(int age)
  {
    return age >= 18;
  }
}
