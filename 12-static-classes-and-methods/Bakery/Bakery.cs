namespace Factory;

class Bakery
{
  public Bread FabricateBread(int weight)
  {
    return new Bread
    {
      Weight = weight,
      Type = "White"
    };
  }

  public Cake FabricateChocolateCake(string size)
  {
    return new Cake
    {
      Size = size,
      Flavour = "Chocolate"
    };
  }
}
