var instance = new NamesWriter();

instance.WriteName("Tryber");

instance.WriteName(null);

public class NamesWriter
{

  // public static void Main() {}

  public void WriteName(string name)
  {
    try
    {
      if (name == null)
      {
        throw new ArgumentNullException(name, "Nome não pode ser um valor nulo.");
      }

      Console.WriteLine(string.Concat("Seu nome é: ", name));
    }
    catch (ArgumentNullException exc)
    {
      Console.WriteLine(exc.Message);
      throw exc;
    }
  }
}
