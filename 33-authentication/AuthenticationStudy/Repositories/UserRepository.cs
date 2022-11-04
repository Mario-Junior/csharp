using Microsoft.EntityFrameworkCore;
using Auth.Models;

namespace Auth.Repositories;

public class UserRepository
{
  protected readonly DatabaseContext _context;

  public UserRepository(DatabaseContext context)
  {
    _context = context;
  }

  public User Get(string name)
  {
    return _context.Users.Where(u => u.Name == name).FirstOrDefault()!;
  }
}
