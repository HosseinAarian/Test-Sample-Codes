using CharvandLibraryManagement.Domain.Entities;

namespace CharvandLibraryManagement.Infrastructure.Factories;

public class Bookfactory
{
    public Book CreateBook(string title,
                           string author,
                           DateTime publishDate,
                           int availableCopies,
                           bool isExclusive = false,
                           string genre = null,
                           int maximumDays = 0)
    {
        if (isExclusive)
        {
            return new ExclusiveBooks
            {
                Title = title,
                Author = author,
                PublishDate = publishDate,
                AvailableCopies = availableCopies,
                MaximumLoanDays = maximumDays
            };
        }
        return new StandardBooks
        {
            Title = title,
            Author = author,
            PublishDate = publishDate,
            AvailableCopies = availableCopies,
            Genre = genre
        };
    }
}
