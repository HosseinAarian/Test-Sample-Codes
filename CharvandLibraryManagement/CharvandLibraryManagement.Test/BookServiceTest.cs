using CharvandLibraryManagement.Infrastructure.Services;
using CharvandLibraryManagement.Test.Fakes;

namespace CharvandLibraryManagement.Test;

public class BookServiceTest
{
    [Fact]
    public void GetAvailableBooks_ShouldReturnOnlyAvailableBooks()
    {
        //Arrange
        var fakeRepository = new FakeBookRepository();
        var bookService = new BookService(fakeRepository);

        //Act
        var availableBooks = bookService.GetAvailableBooks();

        //Assert
        Assert.NotEmpty(availableBooks);
        Assert.All(availableBooks, book => Assert.True(book.IsAvailable));
    }
}
