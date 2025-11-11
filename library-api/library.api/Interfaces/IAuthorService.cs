using library.api.DTOs;
using System.Runtime.InteropServices;

namespace library.api.Interfaces
{
    public interface IAuthorService
    {
        public AuthorDto Create(AuthorDto dto);
        public AuthorDto Read(string id);
        public AuthorDto Update(AuthorDto dto);
        public void Delete(string id);
    }
}
