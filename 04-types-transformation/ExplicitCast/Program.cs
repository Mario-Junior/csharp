namespace ExplicitCast;

public class Program
{
    public static void Main()
    {        
        long someLongNumber = 516144564564654;
        int intNumber = (int) someLongNumber;

        Console.WriteLine("Print 1 = " + intNumber);

        long someLongNumber2 = 1212;
        int intNumber2 = Convert.ToInt32(someLongNumber2);

        Console.WriteLine("Print 2 = " + intNumber2);
    }
}
