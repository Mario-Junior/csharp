namespace DeliveryApp
{
  public class Commission
  {
    public static void Main() {}
    
    public decimal Calculate(decimal orderPrice)
    {
      try
      {
        return orderPrice * 10 / 100;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        throw;
      }
    }
  }  
}
