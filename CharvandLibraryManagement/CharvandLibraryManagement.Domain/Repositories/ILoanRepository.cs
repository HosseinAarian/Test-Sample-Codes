using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Domain.Repositories;

public interface ILoanRepository
{
    void AddLoan(Loan loan);
    IEnumerable<Loan> GetAll();
}
