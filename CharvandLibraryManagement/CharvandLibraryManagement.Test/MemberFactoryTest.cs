using CharvandLibraryManagement.Infrastructure.Exceptions;
using CharvandLibraryManagement.Infrastructure.Factories;

namespace CharvandLibraryManagement.Test;

public class MemberFactoryTest
{
    [Fact]
    public void CreateMember_NullOrEmptyFirstName_NullFirstNameExceptionMustBeThrown()
    {
        //Arrange
        var factory = new MemberFactory();
        var firstName = "";
        var lastName = "Aryan";
        var memberShipDate = DateTime.Now;

        //Act And Assert
        Assert.Throws<NullFirstNameException>(()=> factory.CreateMember(firstName, lastName, memberShipDate));
    }
}
