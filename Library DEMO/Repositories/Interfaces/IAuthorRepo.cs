using Library_DEMO.DTOs.AuthorFolder;
using Library_DEMO.DTOs.BookFolder;

namespace Library_DEMO.Repositories.Interfaces
{
    public interface IAuthorRepo
    {
        public void AddAuthor(AuthorDto authorDto);
        public void AddAuthorBook(AuthorCreditIdentityDto authorDto);
        public void AddAuthorBookJoining(int authorId, int bookId);
        public List<AuthorCreditIdentityDto> GetAllAuthorBooks();
        public AuthorCreditIdentityDto GetAuthorBooksId(int id);
        public void UpdateAuthorBook(int authorId, AuthorCreditIdentityDto authorDto);
        public void DeleteAuthorBook(int authorId);
    }
}
