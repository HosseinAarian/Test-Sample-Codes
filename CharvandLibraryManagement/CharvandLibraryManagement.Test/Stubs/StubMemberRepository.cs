using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;
using CharvandLibraryManagement.Test.Dummies;

namespace CharvandLibraryManagement.Test.Stubs;

public class StubMemberRepository : IMemberRepository
{
    private readonly Dictionary<int, bool> _overdueLoans;

    public StubMemberRepository(Dictionary<int, bool> overdueLoans)
    {
        _overdueLoans = overdueLoans;
    }

    public Member GetMemberById(int memberId)
    {
        return DummyMember.Create();
    }

    public bool HasOverdueLoans(int memberId)
    {
        return _overdueLoans.ContainsKey(memberId) && _overdueLoans[memberId];
    }
}
