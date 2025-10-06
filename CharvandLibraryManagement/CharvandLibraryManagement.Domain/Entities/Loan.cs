using System.ComponentModel.DataAnnotations.Schema;

namespace CharvandLibraryManagement.Domain.Entities;

public class Loan
{
    public int Id { get; set; }
	public int BookId { get; set; }
	public int MemberId { get; set; }
	public DateTime LoanDate { get; set; }
	public DateTime? ReturnDate { get; set; }
    public bool IsExclusiveLoan { get; set; }
    [NotMapped]
	public int LoanDurationDays { get => ReturnDate.Value.Subtract(LoanDate).Days; }
}
