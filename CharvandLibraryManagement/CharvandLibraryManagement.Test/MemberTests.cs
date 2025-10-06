using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Test;

public class MemberTests(ITestOutputHelper outputHelper)
{
    [Fact]
    public void MemberToString_FirstNameAndLastNameAreGiven_FullNameShouldBeReturn()
    {
        //Arrange
        var member = new Member
        {
            Id = 1,
            FirstName = "Hosein",
            LastName = "Aryan",
            MemberShipDate = DateTime.Now
        };

        //Act
        var fullName = member.ToString();

        //Assert
        Assert.Equal("Hosein Aryan", fullName);
    }

    [Fact]
    public void MemberToString_FirstNameAndLastNameAreGiven_FullNameShouldStartsWithFirstName()
    {
        //Arrange
        var member = new Member
        {
            Id = 1,
            FirstName = "Hosein",
            LastName = "Aryan",
            MemberShipDate = DateTime.Now
        };

        //Act
        var fullName = member.ToString();
        outputHelper.WriteLine(fullName);

        //Assert
        Assert.StartsWith("Hosein", fullName);
    }

    [Fact]
    public void MemberToString_FirstNameAndLastNameAreGiven_FullNameShouldEndWithLastName()
    {
        //Arrange
        var member = new Member
        {
            Id = 1,
            FirstName = "Hosein",
            LastName = "Aryan",
            MemberShipDate = DateTime.Now
        };

        //Act
        var fullName = member.ToString();

        //Assert
        Assert.EndsWith("Aryan", fullName);
    }
}
