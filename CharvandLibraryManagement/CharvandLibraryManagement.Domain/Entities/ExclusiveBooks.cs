namespace CharvandLibraryManagement.Domain.Entities;

public class ExclusiveBooks : Book
{
    public int MaximumLoanDays { get; set; }
}
