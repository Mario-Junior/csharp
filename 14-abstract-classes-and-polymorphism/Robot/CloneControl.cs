namespace RobotFactory;

public class CloneControl
{
  public object[] Clones { get; set; } = new object[0];

  public void CreateClone(ICloneable cloneable)
  {
    var newArray = new object[Clones.Length + 1];
    Array.Copy(Clones, newArray, Clones.Length);
    newArray[Clones.Length] = cloneable.Clone();
    Clones = newArray;
  }
}
