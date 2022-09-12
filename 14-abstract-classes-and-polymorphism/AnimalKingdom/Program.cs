namespace AnimalKingdom;

public class Program
{
  public static void Main()
  {
    Dog dog = new();
    FeedAnimal(dog);
  }
  public static void FeedAnimal(Animal animal)
  {
    animal.Feed();
  }
}
