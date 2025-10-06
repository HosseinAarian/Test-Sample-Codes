using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Infrastructure.Services.Contracts;

public interface IBookServices
{
    IEnumerable<StandardBooks> GetAvailableBooks();
    void LoanBook(int bookId);
}
