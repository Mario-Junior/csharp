namespace Polygon;

public class Polygon
{
  public static void Main() {}
  public static string IdentifyPolygon(int sideCount)
  {
    var name = string.Empty;

    switch (sideCount)
    {
      case < 3:
        name = "Não é um polígono!";
        break;
      case 3:
        name = "Triângulo";
        break;
      case 4:
        name = "Retângulo";
        break;
      case 5:
        name = "Pentágono";
        break;
      default:
        name = "Polígono de outro tipo";
        break;
    }
    return name;
  }
}
