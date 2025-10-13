using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Infrastructure.Services.Contracts;

public interface ILoanServices
{
    void LoanBook(StandardBooks book, Member member);
    bool canLoanBook(Member member);
}
