namespace ConsoleSayings;

public class SayMeHello
{
  public static void Main() {}

  public static void Hello(string name)
  {
    Console.WriteLine($"Hey, Hello {name}");
  }

  public static void HelloHarder(string name)
  {
    Console.WriteLine($"Hey, Hello {name}");
    Console.WriteLine($"Can I call u {name}zita(o)?");
    Console.WriteLine($"No?");
    Console.WriteLine($"Ok?");
  }

  public static void HelloSayYourName()
  {
    Console.WriteLine("Hey, please say me your name:");

    var userName = Console.ReadLine();

    Console.WriteLine($"Ok, Hello {userName}!");
  }
}
