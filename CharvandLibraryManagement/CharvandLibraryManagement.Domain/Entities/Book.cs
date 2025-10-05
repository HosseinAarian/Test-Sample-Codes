using System.ComponentModel.DataAnnotations.Schema;

namespace CharvandLibraryManagement.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublishDate { get; set; }
    public int AvailableCopies { get; set; }
    [NotMapped]
    public bool IsAvailable { get { return AvailableCopies > 0 ? true : false; } }
}
