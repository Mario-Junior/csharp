namespace Brazil;

public class Brazil
{
  public State[]? states;
  public City[]? cities;

  public dynamic[] GetNumberOfCitiesForEachState()
  {
    var numberOfCitiesForEachState =
      from state in states
      join city in cities! on state.Abbreviation equals city.StateAbbreviation
      group city by state.Abbreviation into stateGroup
      select new {
          StateAbbreviation = stateGroup.Key,
          NumberOfCities = stateGroup.Count()
      };

    return numberOfCitiesForEachState.ToArray();
  }
}
