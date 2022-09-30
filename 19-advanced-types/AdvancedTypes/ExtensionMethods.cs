namespace advancedTypes;

public static class ExtensionMethods
{
  public static int WordCount1(string str)
  {
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("Extension Methods (ver o arquivo da classe pra entender (sem e com extensão)):");
    var splitted = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
    return splitted.Length;
  }

  public static int WordCount2(this string str)
  {
    var splitted = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
    return splitted.Length;
  }
}
