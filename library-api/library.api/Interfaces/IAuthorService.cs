using library.api.DTOs;
using System.Runtime.InteropServices;

namespace library.api.Interfaces
{
    internal interface IAuthorService
    {
        public AuthorDto CreateAuthor(AuthorDto dto);
        public AuthorDto GetAuthor(string id);
        public AuthorDto UpdateAuthor(AuthorDto dto);
        public void DeleteAuthor(string id);

        public IEnumerable<AuthorDto> GetAllAuthors();
        public IEnumerable<BookDto> GetAllBooksOfAuthor(string authorId);
    }
}
