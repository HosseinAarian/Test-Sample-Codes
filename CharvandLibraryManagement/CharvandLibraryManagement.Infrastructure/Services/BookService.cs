using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;
using CharvandLibraryManagement.Infrastructure.Services.Contracts;

namespace CharvandLibraryManagement.Infrastructure.Services;

public class BookService : IBookServices
{
	private readonly IBookRepository _repository;

	public BookService(IBookRepository repository)
	{
		_repository = repository;
	}

	public IEnumerable<StandardBooks> GetAvailableBooks()
	{
		return _repository.GetAllBooks().Where(x => x.IsAvailable);
	}

	public void LoanBook(int bookId)
	{
		throw new NotImplementedException();
	}
}
