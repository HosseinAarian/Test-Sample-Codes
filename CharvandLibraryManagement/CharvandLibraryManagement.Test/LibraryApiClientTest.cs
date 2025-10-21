using CharvandLibraryManagement.Domain.Entities;
using CharvandLibraryManagement.Infrastructure.Services;
using CharvandLibraryManagement.Test.MessageHandlers;
using Moq;
using Moq.Protected;
using System.Text.Json;

namespace CharvandLibraryManagement.Test;

public class LibraryApiClientTest
{
    [Fact]
    public async Task GetBookAsync_WhenApiResponseIsSuccessful_ReturnStandardBook()
    {
        //Arrange
        var expectedBook =
             new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.AddYears(-1) };

        var mockHttpMessageHandler = new Mock<HttpMessageHandler>();

        mockHttpMessageHandler.Protected()
            .Setup<Task<HttpResponseMessage>>(
            "SendAsync",
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(JsonSerializer.Serialize
                (new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.Date.AddYears(-1) }))
            });

        var httpClient = new HttpClient(mockHttpMessageHandler.Object);

        var libraryApiClient = new LibraryApiClient(httpClient);

        //Act
        var fetchedBook = await libraryApiClient.GetBookAsync();

        //Assert
        Assert.NotNull(fetchedBook);
        Assert.Equal(expectedBook.Id, fetchedBook.Id);
    }

    [Fact]
    public async Task GetBookAsync_WhenApiResponseIsSuccessful_ReturnStandardBook_WithFakes()
    {
        //Arrange
        var expectedBook =
             new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.AddYears(-1) };

        var httpMessageHandler = new GetBookMessageHandler(new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.AddYears(-1) });

        var httpClient = new HttpClient(httpMessageHandler);

        var libraryApiClient = new LibraryApiClient(httpClient);

        //Act
        var fetchedBook = await libraryApiClient.GetBookAsync();

        //Assert
        Assert.NotNull(fetchedBook);
        Assert.Equal(expectedBook.Id, fetchedBook.Id);
    }
}
