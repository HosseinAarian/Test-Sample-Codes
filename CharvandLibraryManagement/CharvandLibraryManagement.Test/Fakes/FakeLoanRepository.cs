using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;

namespace CharvandLibraryManagement.Test.Fakes;

public class FakeLoanRepository : ILoanRepository
{
    private readonly List<Loan> _loans;

    public FakeLoanRepository()
    {
        _loans = new List<Loan>();
    }

    public void AddLoan(Loan loan)
    {
        _loans.Add(loan);
    }

	public IEnumerable<Loan> GetAll()
	{
		return _loans;
	}
}
