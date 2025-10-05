using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Exceptions;

namespace CharvandLibraryManagement.Infrastructure.Factories;

public class MemberFactory
{
    public Member CreateMember(string firstName, string lastName, DateTime membershipDate, bool isVip = false)
    {
        if(string.IsNullOrWhiteSpace(firstName))
            throw new NullFirstNameException();

        throw new NotFiniteNumberException();
    }
}
