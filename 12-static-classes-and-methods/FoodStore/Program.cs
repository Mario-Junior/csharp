namespace FoodStore;

class Program
{
  static void Main()
  {
    Restaurant myRestaurant = new("Churrascaria Trybe", "Tryber");

    Bakery myBakery = Bakery.ConvertFromRestaurant(myRestaurant, "Confeitaria Trybe");

    Console.WriteLine(myRestaurant.Name);
    Console.WriteLine(myBakery.Name);
  }
}
