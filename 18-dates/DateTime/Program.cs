public class DataUtil
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        Console.WriteLine(date.ToString());

        var dataType = DateTime.Now;
        Console.WriteLine(dataType.GetType());

        Console.WriteLine(getTimeNow());

        var dateOnly = date.Date;
        Console.WriteLine(dateOnly.ToString().Split(" ")[0]);

        var dayOnly = date.Day;
        Console.WriteLine(dayOnly.ToString());

        var monthOnly = date.Month;
        Console.WriteLine(monthOnly.ToString());

        var yearOnly = date.Year;
        Console.WriteLine(yearOnly.ToString());

        // De forma similar, existem as propriedades .Hour, .Minute, .Second, .Millisecond e .DayOfWeek
        // que retornam os componentes de Hora, Minuto, Segundo, Milissegundo e Dia da semana, respectivamente

        // .Add(TimeSpan value)
        var today = DateTime.Now;
        var duration = new TimeSpan(36, 0, 0, 0);
        var answer = today.Add(duration);

        Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
        Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
    }

    public static string getTimeNow()
    {
        return "O momento de tempo atual é " +DateTime.Now;
    }
}
