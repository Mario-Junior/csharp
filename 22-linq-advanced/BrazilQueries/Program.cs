namespace BrazilQueries;
using System.Linq;
  using System.Collections;

public class Program
{
  public static void Main()
  {
    State[] states = State.CreateStates();
    City[] cities = City.CreateCities();

// DESCOMENTAR E ENTENDER PORQUE NÃO FUNCIONA!!!
    // var northEastStates = 
    //   from state in states
    //   where state.Region == "Nordeste"
    //   select state;

    // var northEastCities = 
    //   from city in cities
    //   where northEastStates.Contains(city.StateAbbreviation) // ENTENDER porque não funciona!!!
    //   select city;

    // var northEastCitiesWithB = 
    //   from city in northEastCities
    //   where city.Name.StartsWith("B")
    //   select city;

// Múltiplas consultas com LINQ
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
    
    foreach (var city in northEastCitiesWithB) Console.WriteLine(city.Name);
    Console.WriteLine("----------------------------------------------------");

// Cláusulas de uso mais ocasional do LINQ
  // let
    var citiesWithState = 
      from city in cities
      let cityNameWithState = city.Name+"/"+city.StateAbbreviation
      select cityNameWithState;

    foreach (var city in citiesWithState) Console.WriteLine(city);
    Console.WriteLine("----------------------------------------------------");

  // group
    var citiesGroupedByState = 
      from city in cities
      // agrupando cidades por StateAbbreviation
      group city by city.StateAbbreviation;
    
    foreach (var state in citiesGroupedByState)
    {
      Console.WriteLine(state.Key + " contém " + state.Count() + " cidades.");
    }
    Console.WriteLine("----------------------------------------------------");

  // group > into
    var citiesGroupedByStateInto = 
      from city in cities
      group city by city.StateAbbreviation into stateGroup
      where stateGroup.Count() > 1
      select new { State = stateGroup.Key, Count = stateGroup.Count() };

    foreach (var state in citiesGroupedByStateInto) Console.WriteLine(state);
    Console.WriteLine("----------------------------------------------------");

  // join
    var citiesGroupedByStateJoin = 
      from city in cities
      join state in states on city.StateAbbreviation equals state.Abbreviation
      group city by new { state.Name, state.Abbreviation } into stateGroup
      where stateGroup.Count() > 1
      select new { State = stateGroup.Key, Count = stateGroup.Count() };

    foreach (var state in citiesGroupedByStateJoin) Console.WriteLine(state);
    Console.WriteLine("----------------------------------------------------");

  // orderBy
    var citiesGroupedByStateOrderBy = 
      from city in cities
      join state in states on city.StateAbbreviation equals state.Abbreviation
      group city by new { state.Name, state.Abbreviation } into stateGroup
      where stateGroup.Count() >= 1
      orderby stateGroup.Key.Name ascending // Resultados serão ordenados pelo nome do estado em ordem crescente
      select new { State = stateGroup.Key, Count = stateGroup.Count() };

    foreach (var state in citiesGroupedByStateOrderBy) Console.WriteLine(state);
    Console.WriteLine("----------------------------------------------------");
  }
}
