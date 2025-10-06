using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Domain.Repositories;

namespace CharvandLibraryManagement.Test.Fakes;

public class FakeBookRepository : IBookRepository
{
    private readonly List<StandardBooks> _books;
    public FakeBookRepository()
    {
        _books = new List<StandardBooks>
        {
            new StandardBooks { Id =1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.AddYears(-1) },
            new StandardBooks { Id =2, Title = "Book_B", Author = "Author_B", AvailableCopies = 0, PublishDate = DateTime.Now.AddYears(-1) },
        };
    }
    public IEnumerable<StandardBooks> GetAllBooks()
    {
        return _books;
    }

    public void AddBook(StandardBooks books)
    {
        _books.Add(books);
    }

    public async Task<IEnumerable<StandardBooks>> GetAllBooksAsync()
    {
        await Task.Delay(10);
        return _books;
    }

    public StandardBooks GetById(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public void UpdateBook(StandardBooks books)
    {
        var existingBook = GetById(books.Id);

        if (existingBook != null)
        {
            existingBook.Title = books.Title;
            existingBook.Author = books.Author;
            existingBook.AvailableCopies = books.AvailableCopies;
            existingBook.PublishDate = books.PublishDate;
        }
    }
}
