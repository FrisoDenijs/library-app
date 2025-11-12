using library.api.DTOs;
using library.api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace library.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
        }

        [HttpPost]
        public ActionResult<AuthorDto> Post(AuthorDto dto) {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_authorService.CreateAuthor(dto));
        }

        [HttpGet]
        public ActionResult<AuthorDto> Get(string id)
        {
            return Ok(_authorService.GetAuthor(id));
        }

        [HttpPut]
        public ActionResult<AuthorDto> Put(AuthorDto dto) {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_authorService.UpdateAuthor(dto));
        }

        [HttpDelete]
        public ActionResult Delete(string id) {
            ArgumentNullException.ThrowIfNull(id);
            _authorService.DeleteAuthor(id);
            return Accepted();
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAll() { 
            return Ok(_authorService.GetAllAuthors());
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetAllBooksOfAuthor(string id) {
            ArgumentNullException.ThrowIfNull(id);
            return Ok(_authorService.GetAllBooksOfAuthor(id));
        }   
    }
}
