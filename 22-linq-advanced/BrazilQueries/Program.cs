namespace BrazilQueries;
using System.Linq;
  using System.Collections;

public class Program
{
  public static void Main()
  {
    // State[] states = State.CreateStates();
    // City[] cities = City.CreateCities();

    State[] states = {
        new State { Name="Acre", Abbreviation="AC", Region="Norte" },
        new State { Name="Alagoas", Abbreviation="AL", Region="Nordeste" },
        new State { Name="Pará", Abbreviation="PA", Region="Norte" },
        new State { Name="Paraíba", Abbreviation="PB", Region="Nordeste" },
    };
    
    City[] cities = {
      new City { Name="Belém", StateAbbreviation="PA" },
      new City { Name="Rio Branco", StateAbbreviation="AC" },
      new City { Name="Maceió", StateAbbreviation="AL" },
    };

    var northEastCitiesWithB = 
      // Selecionar todos os estados da região nordeste
      from state in states
      where state.Region == "Nordeste"

      // Incluir cidades na seleção
      from city in cities
      // Selecionar apenas as cidades que fazem parte dos estados selecionados anteriormente
      where city.StateAbbreviation == state.Abbreviation

      // Selecionar apenas as cidades que começam com a letra `B`
      where city.Name.StartsWith("B")

      // Retornar apenas as cidades selecionadas
      select city;
  }
}
