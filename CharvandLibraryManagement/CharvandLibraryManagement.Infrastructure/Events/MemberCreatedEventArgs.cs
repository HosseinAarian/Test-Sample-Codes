using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Infrastructure.Events;

public class MemberCreatedEventArgs : EventArgs
{
    public Member Member { get; set; }

    public MemberCreatedEventArgs(Member member)
    {
        Member = member;
    }
}
