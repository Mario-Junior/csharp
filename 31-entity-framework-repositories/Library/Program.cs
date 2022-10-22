namespace Library;

class Program
{
  static void Main()
  {
    DatabaseContext context = new();
    BookRepository bookRepository = new(context);
    
    context.Database.EnsureCreated();

    var books = bookRepository.GetBookList();
    foreach (var book in books)
    {
      Console.WriteLine(
        $"Id: {book.BookId} - Title: {book.Title} - Pages: {book.Pages} - Year: {book.Year}");
    }

    var newBook = new Book{
      Title = "The Divine Comedy",
      Description = "A journey through the infinite torment of Hell",
      Year = 2013,
      Pages = 811,
      Genre = "Drama",
      Author = new Author{
        Name = "Dante Alighieri",
        Email = "mail@mail.com"
      },
      Publisher = new Publisher{
        Name = "Paradise Publisher"
      }
    };

    bookRepository.Insert(newBook);

    var bookById = bookRepository.GetById(3);
    Console.WriteLine(
        $"Id: {bookById.BookId} - Title: {bookById.Title} - Author: {bookById.Author?.Name} - Publisher: {bookById.Publisher?.Name}");

    var bookToUpdate = bookRepository.GetById(3);
    bookToUpdate.Publisher!.Name = "Publisky";
    bookRepository.Update(bookToUpdate);

    Console.WriteLine(
        $"Id: {bookById.BookId} - Title: {bookById.Title} - Author: {bookById.Author?.Name} - Publisher: {bookById.Publisher?.Name}");

    bookRepository.Delete(3);

    var booksUpdated = bookRepository.GetBookList();
    foreach (var book in booksUpdated)
    {
      Console.WriteLine(
        $"Id: {book.BookId} - Title: {book.Title} - Pages: {book.Pages} - Year: {book.Year}");
    }    
  }
}
