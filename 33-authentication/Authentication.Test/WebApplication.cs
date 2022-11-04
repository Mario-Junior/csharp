using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Auth.Models;

namespace Authentication.Test;
public class WebApplication<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
{
  protected override void ConfigureWebHost(IWebHostBuilder builder)
  {
    builder.ConfigureServices(services =>
    {
      var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<DatabaseContext>));
      if (descriptor != null)
        services.Remove(descriptor);
      services.AddEntityFrameworkInMemoryDatabase().AddDbContext<DatabaseContext>(options =>
          {
            options.UseInMemoryDatabase("InMemoryAuthTest");
          });
      var sp = services.BuildServiceProvider();
      var scope = sp.CreateScope();
      var appContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
      appContext.Database.EnsureCreated();
    });
  }
}
