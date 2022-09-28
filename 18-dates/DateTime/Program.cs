public class DataUtil
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        Console.WriteLine(date.ToString());

        var dataType = DateTime.Now;
        Console.WriteLine(dataType.GetType());

        Console.WriteLine(getTimeNow());
    }

    public static string getTimeNow()
    {
        return "O momento de tempo atual é " +DateTime.Now;
    }
}
