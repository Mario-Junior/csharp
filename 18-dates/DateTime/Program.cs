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

        // .Add(TimeSpan value) => O valor pode ser positivo ou negativo
        var today = DateTime.Now;
        var duration_pos = new TimeSpan(36, 0, 0, 0);
        var duration_neg = new TimeSpan(-36, 0, 0, 0);
        var answer_pos = today.Add(duration_pos);
        var answer_neg = today.Add(duration_neg);

        Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
        Console.WriteLine("Daqui a 36 dias será "+answer_pos.Day +"/" +answer_pos.Month +" - " +answer_pos.DayOfWeek);
        Console.WriteLine("36 dias atrás era "+answer_neg.Day +"/" +answer_neg.Month +" - " +answer_neg.DayOfWeek);

        // .Compare(DateTime t1, DateTime t2)
        DateTime date1 = new DateTime(2010, 9, 1, 5, 0, 0);
        DateTime date2 = new DateTime(2022, 8, 10, 12, 0, 0);

        int result = DateTime.Compare(date1, date2);
        string relationship;

        if (result < 0) relationship = "é anterior à";
        else if (result == 0) relationship = "è o mesmo que";
        else relationship = "è posterior à";

        Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

        // Usando o método .ToString() com 'override' (sobrecarga) = .ToString(string? format)
        Console.WriteLine(new DateTime(2008, 6, 15, 21, 15, 07).ToString("R"));
    }

    public static string getTimeNow()
    {
        return "O momento de tempo atual é " +DateTime.Now;
    }
}
