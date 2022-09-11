namespace Vehicles;

class Program
{
  static void Main()
  {
    Car newCar = new();
    newCar.TopSpeed = 250;
    newCar.StartEngine();
    Console.Write("By Car "); newCar.Drive(250, 100);

    Motorcycle newMoto = new();
    newMoto.TopSpeed = 200;
    newMoto.StartEngine();
    newMoto.CanDoWheelies = true;
    newMoto.DoWheelie();
    Console.Write("By Moto "); newMoto.Drive(250, 80);
  }
}
