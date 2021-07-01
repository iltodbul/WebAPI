using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Contracts;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            this._booksService = booksService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = this._booksService.GetAllBooks();
            return Ok(books);

        }

        [HttpGet("{name}")]
        public IActionResult GetBookByName(string name)
        {
            var books = this._booksService.GetBooksByName(name);

            if (books.Count == 0)
            {
                return NoContent();
            }

            return Ok(books);
        }
    }
}
