namespace LinqBasics;
using System;
using System.Linq;

internal class Artist
{
  public string? Name { get; set; }
  public int Listeners { get; set; }

  public static void TopListeners()
  {
  List<Artist> artists = new()
  {
    new Artist { Name = "Raul Seixas", Listeners = 50000 },
    new Artist { Name = "Mozart", Listeners = 15000 },
    new Artist { Name = "Elvis Presley", Listeners = 25000 },
    new Artist { Name = "Bob Dylan", Listeners = 30000 },
    new Artist { Name = "Guns N' Roses", Listeners = 40000 },
  };
    var topListeners = from artist in artists
                  where artist.Listeners > 30000
                  select artist.Name;

    foreach (string name in topListeners)
    {
      Console.WriteLine(name);
    }
  }
}
