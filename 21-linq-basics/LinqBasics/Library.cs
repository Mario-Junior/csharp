namespace LinqBasics;
using System;
using System.Linq;

internal class Book
{
  public string? Title { get; set; }
  public int Price { get; set; }
  public int PublishYear { get; set; }

  public static void BookList()
  {
    var books = new List<Book>
    {
      new Book { Title = "The Count of Monte Cristo", Price = 39, PublishYear = 2002 },
      new Book { Title = "Brave new World ", Price = 32, PublishYear = 1932 },
      new Book { Title = "The Hobbit", Price = 35, PublishYear = 2011 },
      new Book { Title = "Pan's Labyrinth: The Labyrinth of the Faun", Price = 25, PublishYear = 2019 },
      new Book { Title = "Throne of Glass", Price = 29, PublishYear = 2013 },
    };

    var booksAfter2000 = from book in books
      where book.Price > 30
      select book.Title;

    foreach (var book in booksAfter2000)
    {
      Console.WriteLine(book);
    }
  }
}
