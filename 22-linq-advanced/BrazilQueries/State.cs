namespace BrazilQueries;

public class State
{
  public string Name { get; set; } = "";
  public string Abbreviation { get; set; } = "";
  public string Region { get; set; } = "";
  public string States { get; set; } = "";

  public static State[] CreateStates()
  {
    State[] states = {
        new State { Name="Acre", Abbreviation="AC", Region="Norte" },
        new State { Name="Alagoas", Abbreviation="AL", Region="Nordeste" },
        new State { Name="Pará", Abbreviation="PA", Region="Norte" },
        new State { Name="Paraíba", Abbreviation="PB", Region="Nordeste" },
    };

    return states;
  }
}
