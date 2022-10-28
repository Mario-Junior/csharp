using Microsoft.EntityFrameworkCore;
namespace MigrationsStudy;

public class ProductContext : DbContext
{
  public DbSet<Product> Products { get; set; }
}
