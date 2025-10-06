using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;
using CharvandLibraryManagement.Infrastructure.Services.Contracts;

namespace CharvandLibraryManagement.Infrastructure.Services;

public class LoanService : ILoanServices
{
    private readonly ILoanRepository repository;
    private readonly IBookRepository bookRepository;

    public LoanService(ILoanRepository repository,
                       IBookRepository bookRepository)
    {
        this.repository = repository;
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
}
