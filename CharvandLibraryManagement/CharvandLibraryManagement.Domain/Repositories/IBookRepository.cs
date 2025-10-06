using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Domain.Repositories;

public interface IBookRepository
{
    Task<IEnumerable<StandardBooks>> GetAllBooksAsync();
    IEnumerable<StandardBooks> GetAllBooks();
    StandardBooks GetById(int id);
    void AddBook(StandardBooks books);
    void UpdateBook(StandardBooks books);
}
