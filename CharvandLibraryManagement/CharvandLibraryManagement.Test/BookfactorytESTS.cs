using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Factories;

namespace CharvandLibraryManagement.Test;

public class BookfactorytESTS
{
    private readonly Bookfactory _bookfactory;
    public BookfactorytESTS()
    {
        _bookfactory = new Bookfactory();
    }

    [Fact]
    public void CreateBook_IsExclusiveIsTrue_ReturnTypeMustBeExclusiveBook()
    {
        //Arrange 
        var title = "Title";
        var author = "Author";
        var publishDate = DateTime.Now;
        var availableCopies = 1;
        var isExclusive = true;
        var MaximumLoanDays = 30;

        //Act 
        var book =
            _bookfactory.CreateBook(title,
            author,
            publishDate,
            availableCopies,
            isExclusive,
            maximumDays: MaximumLoanDays);

        //Assert
        Assert.IsType<ExclusiveBooks>(book);
    }

    [Fact]
    public void CreateBook_IsExclusiveIsFalse_ReturnTypeMustBeStandardBook()
    {
        //Arrange 
        var title = "Title";
        var author = "Author";
        var publishDate = DateTime.Now;
        var availableCopies = 1;
        var isExclusive = false;
        var genre = "action";

        //Act 
        var book =
            _bookfactory.CreateBook(title,
            author,
            publishDate,
            availableCopies,
            isExclusive,
            genre);

        //Assert
        Assert.IsType<StandardBooks>(book);
        Assert.IsAssignableFrom<Book>(book);
    }
}
