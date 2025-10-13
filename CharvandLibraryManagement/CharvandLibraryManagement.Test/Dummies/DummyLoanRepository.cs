using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;

namespace CharvandLibraryManagement.Test.Dummies;

public class DummyLoanRepository : ILoanRepository
{
	public void AddLoan(Loan loan)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<Loan> GetAll()
	{
		throw new NotImplementedException();
	}
}
