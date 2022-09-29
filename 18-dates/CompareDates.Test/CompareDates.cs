public class DatesCompare
{
  public string CompareDates(DateTime d1, DateTime d2)
  {
      var result = DateTime.Compare(d1, d2);
      if(result < 0)      return "antes";
      else if (result > 0) return "depois";
      else                return "igual";
  }
}
