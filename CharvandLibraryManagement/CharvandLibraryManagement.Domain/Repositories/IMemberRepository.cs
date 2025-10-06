using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Domain.Repositories;

public interface IMemberRepository
{
    Member GetMemberById();
}
