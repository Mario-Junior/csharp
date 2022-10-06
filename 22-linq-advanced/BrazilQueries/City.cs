namespace BrazilQueries;

public class City
{
  public string Name { get; set; } = "";
  public string StateAbbreviation { get; set; } = "";

  public static City[] CreateCities()
  {
    City[] cities = {
      new City { Name="Belém", StateAbbreviation="PA" },
      new City { Name="Rio Branco", StateAbbreviation="AC" },
      new City { Name="Maceió", StateAbbreviation="AL" },
    };

    return cities;
  }
}
