using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Test;

public class BookTest
{
    [Fact]
    //Test Method Naming
    //[MethodName]_[Scenario]_[ExpectedResult]
    public void BookIsAvailableGetter_WithNonZeroAvailableCopies_IsAvailableMustBBeTrue()
    {
        //Arrange
        var book = new Book
        {
            Id = 1,
            Author = "chukpulanic",
            AvailableCopies = 2,
            PublishDate = DateTime.Now,
            Title = "FightClub"
        };
        //Act

        //Assert
        Assert.True(book.IsAvailable);
    }

    [Fact]
    public void BookIsAvailableGetter_WithZeroAvailableCopies_IsAvailableMustBBeFalse()
    {
        //Arrange
        var book = new Book
        {
            Id = 1,
            Author = "chukpulanic",
            AvailableCopies = 0,
            PublishDate = DateTime.Now,
            Title = "FightClub"
        };
        //Act

        //Assert
        Assert.False(book.IsAvailable);
    }
}
