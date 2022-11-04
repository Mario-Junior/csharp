using Microsoft.EntityFrameworkCore;

namespace Auth.Models;

public class DatabaseContext : DbContext
{
  public DbSet<User> Users { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.EnableSensitiveDataLogging();

    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=video-portal;User=SA;Password=123@SQLServer");
    }
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<User>().HasData(
      new User() { Name = "Testador1", Password = "123,456" },
      new User() { Name = "Testador2", Password = "123,456" }
    );
  }
}
