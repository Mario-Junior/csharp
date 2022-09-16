namespace Structs;

public struct Point
{
  public int x;
  public int y;

  public Point(int xArgument, int yArgument)
  {
    x = xArgument;
    y = yArgument;
  }

  // Método que recebe um outro valor do tipo Point e calcula a distância entre os dois pontos no plano cartesiano (X,Y)
  public double Distance(Point other)
  {
    return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));
  }
}
