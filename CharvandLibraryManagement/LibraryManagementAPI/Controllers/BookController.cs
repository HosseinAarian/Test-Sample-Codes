using CharvandLibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        public BookController()
        {

        }

        [HttpGet(Name = "GetBook")]
        public IActionResult GetBook()
        {
            return Ok(new StandardBooks { Id = 1, Title = "Book_A", Author = "Author_A", AvailableCopies = 5, PublishDate = DateTime.Now.AddYears(-1) });
        }
    }
}
