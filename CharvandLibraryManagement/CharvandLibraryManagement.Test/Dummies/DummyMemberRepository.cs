using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;

namespace CharvandLibraryManagement.Test.Dummies;

public class DummyMemberRepository : IMemberRepository
{
    public Member GetMemberById(int memberId)
    {
        throw new NotImplementedException();
    }

    public bool HasOverdueLoans(int memberId)
    {
        throw new NotImplementedException();
    }
}
