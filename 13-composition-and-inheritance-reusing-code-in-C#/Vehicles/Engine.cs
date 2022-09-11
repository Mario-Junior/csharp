namespace Vehicles;

class Engine
{
  public int Horsepower { get; set; }
  public int Torque { get; set; }
  public int Capacity { get; set; }
  public bool IsStarted { get; set; }

  public void Start()
  {
    if (IsStarted)
      Console.WriteLine("The engine is alredy started!");
    else IsStarted = true;
  }

  public void Stop()
  {
    if (!IsStarted)
      Console.WriteLine("The engine is alredy stopped!");
    else IsStarted = false;
  }
}
