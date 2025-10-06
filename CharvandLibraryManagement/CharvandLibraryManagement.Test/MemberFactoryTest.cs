using CharvandLibraryManagement.Infrastructure.Events;
using CharvandLibraryManagement.Infrastructure.Exceptions;
using CharvandLibraryManagement.Infrastructure.Factories;

namespace CharvandLibraryManagement.Test;

public class MemberFactoryTest
{
    private readonly MemberFactory _memberFactory;

    public MemberFactoryTest()
    {
        _memberFactory = new MemberFactory();
    }

    //[Fact]
    //public void CreateMember_NullOrEmptyFirstName_NullFirstNameExceptionMustBeThrown()
    //{
    //    //Arrange
    //    var factory = new MemberFactory();
    //    var firstName = "";
    //    var lastName = "Aryan";
    //    var memberShipDate = DateTime.Now;

    //    //Act And Assert
    //    Assert.Throws<NullFirstNameException>(() => factory.CreateMember(firstName, lastName, memberShipDate));
    //}

    //[Fact]
    //public void MemberCreated_WithProperInputs_RaiseMemberCreatedInput()
    //{
    //    //Arrange
    //    var firstName = "";
    //    var lastName = "Aryan";
    //    var memberShipDate = DateTime.Now;
    //    var isVip = false;

    //    //Act And Assert
    //    Assert.Raises<MemberCreatedEventArgs>(
    //            handler => _memberFactory.MemberCreated += handler,
    //            handler => _memberFactory.MemberCreated -= handler,
    //            () => { _memberFactory.CreateMember(firstName, lastName, memberShipDate, isVip); });
    //}
}
