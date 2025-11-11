using library.api.DTOs;
using library.api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace library.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
        }

        [HttpPost]
        public ActionResult<AuthorDto> Post(AuthorDto dto) {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_authorService.Create(dto));
        }

        [HttpGet]
        public ActionResult<AuthorDto> Get(string id)
        {
            return Ok(_authorService.Read(id));
        }

        [HttpPut]
        public ActionResult<AuthorDto> Put(AuthorDto dto) {
            ArgumentNullException.ThrowIfNull(dto);
            return Ok(_authorService.Update(dto));
        }

        [HttpDelete]
        public ActionResult Delete(string id) {
            _authorService.Delete(id);
            return Accepted();
        }
    }
}
