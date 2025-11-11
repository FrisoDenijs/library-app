using library.api.DTOs;

namespace library.api.Interfaces
{
    public interface IBookService
    {
        public BookDto Create(BookDto dto);
        public BookDto Read(string Id);
        public BookDto Update(BookDto dto);
        public void Delete(string Id);
    }
}
