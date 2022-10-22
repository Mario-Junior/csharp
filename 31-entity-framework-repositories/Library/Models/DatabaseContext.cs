using Microsoft.EntityFrameworkCore;

namespace Library;

public class DatabaseContext : DbContext
{
  public DbSet<Book> Books { get; set; }

  // Para acessar somente a classe mãe Book e, a partir dela, fazer as consultas nas classes agregadas!
  // public DbSet<Publisher> Publisher { get; set; }

  // public DbSet<Author> Author { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=library;User=SA;Password=123@SQLServer");
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Book>()
      .HasOne(b => b.Author) // Explicita que a entidade Book tem uma referência a Author
      .WithMany(a => a.Books) // Define a relação como um Author para muitos Book
      .HasForeignKey(b => b.AuthorId); // Define como chave estrangeira a variável AuthorId

    modelBuilder.Entity<Book>()
      .HasOne(b => b.Publisher)// Explicita que a entidade Book tem uma referência a Publisher
      .WithMany(p => p.Books) // Define a relação como um Publisher para muitos Book
      .HasForeignKey(b => b.PublisherId); // Define como chave estrangeira a variável PublisherId

    modelBuilder.Entity<Book>().HasData(
      new Book() { BookId = 1, Title = "The Hobbit", Pages = 550, Year = 2011 },
      new Book() { BookId = 2, Title = "Brave new World", Pages = 325, Year = 1932 }
    );

    modelBuilder.Entity<Author>().HasData(
      new Author() { AuthorId = 1, Name = "Nome de teste" }
    );

    modelBuilder.Entity<Publisher>().HasData(
      new Publisher() { PublisherId = 1, Name = "Nome de teste" }
    );
  }
}
