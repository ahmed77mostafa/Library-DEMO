using Library_DEMO.DTOs.BookFolder;

namespace Library_DEMO.Repositories.Interfaces
{
    public interface IBookRepo
    {
        public void AddBook(BookDto bookDto);
        public void AddBookAuthor(BookAuthorGenreDto bookDto/*,string name*/);
        public void AddBookAuthorJoining(int bookId, int authorId);
        public List<BookAuthorGenreDto> GetBooks();
        public BookAuthorGenreDto GetBookById(int id);
        public void UpdateBook(int bookId, BookAuthorGenreDto bookDto);
        public void DeleteBook(int bookId);
    }
}
