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
    return _context.Books.ToList();
  }

  public Book GetById(int id)
  {
    return _context.Books.Where(e => e.BookId == id).Include(e => e.Author).Include(e => e.Publisher).First();
  }
}
