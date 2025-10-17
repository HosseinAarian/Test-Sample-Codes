namespace CharvandLibraryManagement.Infrastructure.Exceptions;

public class BookIsNotAvailableException : Exception
{
    public BookIsNotAvailableException() : base("Book Is Not Available...") { }
}
