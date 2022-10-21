using Microsoft.EntityFrameworkCore;

namespace Library;

public class DatabaseContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=master;User=SA;Password=123@SQLServer");
  }
}
