var instance = new NamesWriter();

instance.WriteName("Tryber");

instance.QuizTrybe();

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

  public void QuizTrybe ()
  {
    int? quizNumber = 7;

    try
    {

      if (quizNumber == null)
      {
        throw new NullReferenceException("Número de quiz inválido");
      }

      Console.WriteLine(string.Concat("Você está no quiz número ", quizNumber));
                  
    }
    catch (NullReferenceException ex)
    {
      Console.WriteLine(ex.Message);     
    }
    finally
    {
      Console.WriteLine("Aqui é o finally!");
    }
  }
}
