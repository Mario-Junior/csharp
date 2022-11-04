using System.ComponentModel.DataAnnotations;

namespace Auth.Models;

public class User
{
  [Key]
  public int Id { get; set; }
  public string Name { get; set; }
  public string Password { get; set; }
}
