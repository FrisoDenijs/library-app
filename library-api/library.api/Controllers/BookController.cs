using library.api.DTOs;
using library.api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace library.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        [HttpPost]
        public ActionResult<BookDto> Post(BookDto dto)
        {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_bookService.Create(dto));
        }

        [HttpGet]
        public ActionResult<BookDto> Get(string id)
        {
            return Ok(_bookService.Read(id));
        }

        [HttpPut]
        public ActionResult<BookDto> Put(BookDto dto)
        {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_bookService.Update(dto));
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            _bookService.Delete(id);
            return Accepted();
        }
    }
}
