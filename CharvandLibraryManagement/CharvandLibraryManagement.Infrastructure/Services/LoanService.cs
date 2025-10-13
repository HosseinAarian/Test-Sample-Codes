using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;
using CharvandLibraryManagement.Infrastructure.Services.Contracts;

namespace CharvandLibraryManagement.Infrastructure.Services;

public class LoanService : ILoanServices
{
    private readonly ILoanRepository repository;
    private readonly IBookRepository bookRepository;
    private readonly IMemberRepository memberRepository;

    public LoanService(ILoanRepository repository,
                       IBookRepository bookRepository,
                       IMemberRepository memberRepository)
    {
        this.repository = repository;
        this.bookRepository = bookRepository;
        this.memberRepository = memberRepository;
    }

    public void LoanBook(StandardBooks book, Member member)
    {
        var loan = new Loan
        {
            BookId = book.Id,
            MemberId = member.Id,
            LoanDate = DateTime.Now,
            IsExclusiveLoan = false,
            ReturnDate = DateTime.Now.AddDays(7),
        };

        repository.AddLoan(loan);
        book.AvailableCopies--;
        bookRepository.UpdateBook(book);
    }

    public bool canLoanBook(Member member)
    {
        if (memberRepository.HasOverdueLoans(member.Id))
        {
            return false;
        }
        return true;
    }
}
