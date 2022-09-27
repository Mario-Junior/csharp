namespace Strings;

public class StringLesson
{
  public string ConcatName (string name, string lastName)
  {
    return string.Concat(name, lastName);
  }

  public int IndexOfWord (string word, string letter) 
  {
    return word.IndexOf(letter);
  }

  public string CreateExpirationAlertEmailBody (string name, int daysToExpire)
  {
    return $"Olá, {name}! Faltam apenas {daysToExpire} dias para seu plano expirar.";
  }
}
