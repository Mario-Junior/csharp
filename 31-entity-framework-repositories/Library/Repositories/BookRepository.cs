using Microsoft.EntityFrameworkCore;

namespace Library;

public class BookRepository
{
  protected readonly DatabaseContext _context;
  public BookRepository(DatabaseContext context)
  {
    _context = context;
  }

  public List<Book> GetBookList()
  {
    var query = _context.Books.ToList();

    return query;
  }
}
