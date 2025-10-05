using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Test;

public class LoanTest
{
    [Fact]
    public void LoanDurationGetter_LoanIsClosed_DurationMustBeCalcutedCorrectly()
    {
        //Arrange
        var Loan = new Loan
        {
            Id = 1,
            BookId = 1,
            MemberId = 1,
            LoanDate = DateTime.Now.AddDays(-5),
            ReturnDate = DateTime.Now,
        };

        //Act
        var duration = Loan.LoanDurationDays;

        //Assert
        Assert.Equal(5, duration);
    }
}
