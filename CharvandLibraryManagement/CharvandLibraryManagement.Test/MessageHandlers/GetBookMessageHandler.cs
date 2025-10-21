
using CharvandLibraryManagement.Domain.Entities;
using System.Text.Json;

namespace CharvandLibraryManagement.Test.MessageHandlers;

public class GetBookMessageHandler(StandardBooks standardBooks) : HttpMessageHandler
{
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
        return Task.FromResult(new HttpResponseMessage
        {
            StatusCode = System.Net.HttpStatusCode.OK,
            Content = new StringContent(JsonSerializer.Serialize
                (new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.Date.AddYears(-1) }))
        });

	}
}
