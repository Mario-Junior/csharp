namespace Library;

class Program
{
  static void Main()
  {
    using (var db = new DatabaseContext())
    {
      db.Database.EnsureCreated();
      BookRepository bookRepository = new(db);

      var books = bookRepository.GetBookList();
      foreach (var book in books)
      {
        Console.WriteLine(
          $"Id: {book.BookId} - Title: {book.Title} - Pages: {book.Pages} - Year: {book.Year}");
      }

      var bookById = bookRepository.GetById(3);
      Console.WriteLine(
          $"Id: {bookById.BookId} - Title: {bookById.Title} - Author: {bookById.Author?.Name} - Publisher: {bookById.Publisher}");
    }
  }
}
