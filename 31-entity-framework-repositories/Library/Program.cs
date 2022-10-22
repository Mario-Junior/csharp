namespace Library;

class Program
{
  static void Main()
  {
    using (var db = new DatabaseContext())
    {
      db.Database.EnsureCreated();
    }
  }
}
