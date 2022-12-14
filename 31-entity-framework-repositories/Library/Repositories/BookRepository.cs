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

  public Book Insert(Book book)
  {
    _context.Add(book);
    _context.SaveChanges();
    return book;
  }

  public virtual void Update(Book book)
  {
    _context.Update(book);
    _context.SaveChanges();
  }

  public virtual void Delete(int id)
  {
    // realizo busca na base para encontrar o livro e suas associações, pelo id do livro, que quero excluir
    var book = _context.Books.Include(e => e.Author).Include(e => e.Publisher).Single(p => p.BookId == id);
    _context.Remove(book); // removo o livro (classe mãe)
    _context?.Remove(book.Author); // removo o autor relacionado
    _context?.Remove(book.Publisher); // removo a editora associada
    _context?.SaveChanges(); // ao final, salvo a exclusão, para que se refleta no banco de dados
  }
}
