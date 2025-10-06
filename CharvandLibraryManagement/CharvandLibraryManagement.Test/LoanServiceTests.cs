using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Services;
using CharvandLibraryManagement.Test.Dummies;
using CharvandLibraryManagement.Test.Fakes;

namespace CharvandLibraryManagement.Test;

public class LoanServiceTests
{
    [Fact]
    public void LoanBook_ShouldAddLoan_WhenBookIsAvailable()
    {
        //Arrange
        var dummyMember = DummyMember.Create();
        var fakeLoanRepository = new FakeLoanRepository();
        var fakeBookRepository = new FakeBookRepository();
        var loanService = new LoanService(fakeLoanRepository, fakeBookRepository);
        var book = new StandardBooks
        {
            Id = 1,
            Title = "Book A",
            Author = "Author A",
            PublishDate = DateTime.Now.AddYears(-2),
            AvailableCopies = 5
        };

        //Act
        loanService.LoanBook(book, dummyMember);

        //Assert
        var loans = fakeLoanRepository.GetAll();
        Assert.Single(loans);
    }

    [Fact]
    public void LoanBook_ShouldDecreaseAvailableCopiesOfInputBook_WhenBookIsAvailable()
    {
        //Arrange
        var dummyMember = DummyMember.Create();
        var fakeLoanRepository = new FakeLoanRepository();
        var fakeBookRepository = new FakeBookRepository();
        var loanService = new LoanService(fakeLoanRepository, fakeBookRepository);
        var book = new StandardBooks
        {
            Id = 1,
            Title = "Book A",
            Author = "Author A",
            PublishDate = DateTime.Now.AddYears(-2),
            AvailableCopies = 5
        };

        //Act
        loanService.LoanBook(book, dummyMember);

        //Assert
        var loans = fakeLoanRepository.GetAll();
        Assert.Equal(4, book.AvailableCopies);
    }
}
