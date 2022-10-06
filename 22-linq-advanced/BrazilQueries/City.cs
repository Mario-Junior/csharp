namespace BrazilQueries;

public class City
{
  public string Name { get; set; } = "";
  public string StateAbbreviation { get; set; } = "";

  public static City[] CreateCities()
  {
    City[] cities = {
      new City { Name="Baía Formosa", StateAbbreviation="RN" },
      new City { Name="Belém", StateAbbreviation="PA" },
      new City { Name="Boa Viagem", StateAbbreviation="CE" },
      new City { Name="Maceió", StateAbbreviation="AL" },
      new City { Name="Rio Branco", StateAbbreviation="AC" },
    };

    return cities;
  }
}
