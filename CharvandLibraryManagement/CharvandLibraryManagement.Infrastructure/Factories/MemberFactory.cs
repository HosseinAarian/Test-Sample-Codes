using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Events;
using CharvandLibraryManagement.Infrastructure.Exceptions;

namespace CharvandLibraryManagement.Infrastructure.Factories;

public class MemberFactory
{
    public Member CreateMember(string firstName, string lastName, DateTime membershipDate, bool isVip = false)
    {
        //OnMemberCreated(new MemberCreatedEventArgs(mem));
        if (string.IsNullOrWhiteSpace(firstName))
            throw new NullFirstNameException();

        throw new NotFiniteNumberException();
    }

    public event EventHandler<MemberCreatedEventArgs> MemberCreated;

    private void OnMemberCreated(MemberCreatedEventArgs e)
    {
        MemberCreated?.Invoke(null, e);
    }
}
