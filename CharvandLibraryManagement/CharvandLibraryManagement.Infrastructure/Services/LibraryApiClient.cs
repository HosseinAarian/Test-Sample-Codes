using CharvandLibraryManagement.Domain.Entities;
using System.Text.Json;

namespace CharvandLibraryManagement.Infrastructure.Services;

public class LibraryApiClient(HttpClient httpClient)
{
    public async Task<StandardBooks> GetBookAsync()
    {
        var response = await httpClient.GetAsync("https://localhost:7251/Book/GetBook");
        if (response.IsSuccessStatusCode)
        {
            throw new Exception("Failed To Fetch Book");
        }
        var content = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<StandardBooks>(content);
    }
}
