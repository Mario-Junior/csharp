namespace RobotFactory;

class Program
{
  static void Main()
  {
    CloneControl control = new();
    Robot robot = new()
    {
      ProcessingPower = 50,
      BatteryCapacity = 100
    };

    control.CreateClone(robot);
    Console.WriteLine(robot.BatteryCapacity);
    control.CreateClone(robot);
    control.CreateClone(robot);

    // Como conseguir acessar os itens dos objetos dentro do Array?
    // verificar na monitoria!
    foreach (var item in control.Clones)
    {
      Console.WriteLine(item);
    }
  }
}
