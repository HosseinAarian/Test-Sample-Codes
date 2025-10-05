namespace CharvandLibraryManagement.Infrastructure.Exceptions;

public class NullFirstNameException : Exception
{
    public NullFirstNameException() : base("First Name Could Not Be Null Or Empty...") { }
}
