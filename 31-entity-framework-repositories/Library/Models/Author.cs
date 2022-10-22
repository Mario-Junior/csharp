using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class Author
{
  [Key]
  public int AuthorId { get; set; }
  public string Name { get; set; }
  public string? Email { get; set; }
  [InverseProperty("Author")]
  public ICollection<Book>? Books { get; set; }
}
