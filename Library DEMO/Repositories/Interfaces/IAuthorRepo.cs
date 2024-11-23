using Library_DEMO.DTOs.AuthorFolder;
using Library_DEMO.DTOs.BookFolder;

namespace Library_DEMO.Repositories.Interfaces
{
    public interface IAuthorRepo
    {
        public void AddAuthor(AuthorDto authorDto);
        public void AddAuthorBook(AuthorBookCreditIdentityDto authorDto);
        public void AddAuthorBookJoining(int authorId, int bookId);
        public List<AuthorBookCreditIdentityDto> GetAllAuthorBooks();
        public AuthorBookCreditIdentityDto GetAuthorBooksId(int id);
        public void UpdateAuthorBook(int authorId, AuthorBookCreditIdentityDto authorDto);
        public void DeleteAuthorBook(int authorId);
    }
}
