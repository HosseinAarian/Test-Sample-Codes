namespace CharvandLibraryManagement.Domain.Entities;

public class Member
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public DateTime MemberShipDate { get; set; }
	public bool ExclusiveAccess { get; set; }
	public decimal DiscountRate { get; set; }

	public override string ToString()
	{
		return $"{FirstName} {LastName}";
	}
}
