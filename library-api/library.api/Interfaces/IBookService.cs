using library.api.DTOs;

namespace library.api.Interfaces
{
    internal interface IBookService
    {
        public BookDto CreateBook(BookDto dto);
        public BookDto GetBook(string Id);
        public BookDto UpdateBook(BookDto dto);
        public void DeleteBook(string Id);

        public IEnumerable<BookDto> GetAllBooks();
    }
}
