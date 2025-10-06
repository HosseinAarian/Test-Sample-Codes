using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Test.Dummies;

public class DummyMember
{
    public static Member Create()
    {
        return new Member
        {
            Id = 1,
            FirstName = "Dummy",
            LastName = "Member",
            MemberShipDate = DateTime.Now.AddYears(-1),
            ExclusiveAccess = false,
            DiscountRate = 0
        };
    }
}
