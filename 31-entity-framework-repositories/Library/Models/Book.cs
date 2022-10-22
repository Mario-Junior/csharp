using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class Book
{
  [Key]
  public int BookId { get; set; }
  public string? Title { get; set; }
  public string? Description { get; set; }
  public string? Genre { get; set; }
  public int Year { get; set; }
  public int Pages { get; set; }
  public int? AuthorId { get; set; }
  [ForeignKey("AuthorId")]
  public Author? Author { get; set; }
  public int? PublisherId { get; set; }
  [ForeignKey("PublisherId")]
  public Publisher? Publisher { get; set; }
}
