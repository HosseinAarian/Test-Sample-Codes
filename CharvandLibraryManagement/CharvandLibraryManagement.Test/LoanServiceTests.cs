using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Services;
using CharvandLibraryManagement.Test.Dummies;
using CharvandLibraryManagement.Test.Fakes;
using CharvandLibraryManagement.Test.Stubs;

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
        var dummyMemberRepository = new DummyMemberRepository();
        var loanService = new LoanService(fakeLoanRepository, fakeBookRepository, dummyMemberRepository);
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
        var dummyMemberRepository = new DummyMemberRepository();
        var loanService = new LoanService(fakeLoanRepository, fakeBookRepository, dummyMemberRepository);
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

    public void CanLoanBook_MemberHasOverdueLoans_ShouldReturnFalse()
    {
        //Arrange
        var dummyBookRepository = new DummyBookRepository();
        var dummyLoanRepository = new DummyLoanRepository();
        var stubMemberRepository = new StubMemberRepository(new Dictionary<int, bool>
        {
            { 1, true },
        });

        var loanService = new LoanService(dummyLoanRepository, dummyBookRepository, stubMemberRepository);
        var member = new Member { Id = 1, FirstName = "Hossein", LastName = "Aryan" };

        //Act
        var result = loanService.canLoanBook(member);

        //Assert
        Assert.False(result);
    }

    public void CanLoanBook_MemberHasOverdueLoans_ShouldReturnTrue()
    {
        //Arrange
        var dummyBookRepository = new DummyBookRepository();
        var dummyLoanRepository = new DummyLoanRepository();
        var stubMemberRepository = new StubMemberRepository(new Dictionary<int, bool>
        {
            { 1, false },
        });

        var loanService = new LoanService(dummyLoanRepository, dummyBookRepository, stubMemberRepository);
        var member = new Member { Id = 1, FirstName = "Hossein", LastName = "Aryan" };

        //Act
        var result = loanService.canLoanBook(member);

        //Assert
        Assert.True(result);
    }
}
