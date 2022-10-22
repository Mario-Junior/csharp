using Microsoft.EntityFrameworkCore;

namespace Library;

public class BookRepository
{
  protected readonly DbContext _context;
  public BookRepository(DbContext context)
  {
    _context = context;
  }
}
