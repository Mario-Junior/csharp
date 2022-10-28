using Microsoft.EntityFrameworkCore;
namespace MigrationsStudy;

public class ProductContext : DbContext
{
  public DbSet<Product> Products { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=products;User=SA;Password=123@SQLServer;");
  }
}
