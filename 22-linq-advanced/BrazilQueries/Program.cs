﻿namespace BrazilQueries;
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
  }
}
