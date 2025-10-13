using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;

namespace CharvandLibraryManagement.Test.Dummies;

public class DummyBookRepository : IBookRepository
{
	public void AddBook(StandardBooks books)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<StandardBooks> GetAllBooks()
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<StandardBooks>> GetAllBooksAsync()
	{
		throw new NotImplementedException();
	}

	public StandardBooks GetById(int id)
	{
		throw new NotImplementedException();
	}

	public void UpdateBook(StandardBooks books)
	{
		throw new NotImplementedException();
	}
}
