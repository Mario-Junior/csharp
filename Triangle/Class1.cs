namespace Triangle;
public class Triangle
{
  public static string IdentifyTriangle(double xSide, double ySide, double zSide)
  {       
    var name = "";

    if(xSide == ySide && xSide == zSide)
    {
      name = "Triângulo Equilátero";
    }
    else if((xSide == ySide) || (xSide == zSide) || (ySide == zSide))
    {
      name = "Triângulo Isósceles";
    }
    else
    {
      name = "Triângulo Escaleno";
    }
    return name;
  }
}
