using Library_DEMO.Data;
using Library_DEMO.DTOs.AuthorFolder;
using Library_DEMO.DTOs.BookFolder;
using Library_DEMO.Models;
using Library_DEMO.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library_DEMO.Repositories.Implementations
{
    public class BookRepo : IBookRepo
    {
        private readonly AppDbContext _context;

        public BookRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookAuthorGenreDto bookDto)
        {
            Book book = new Book
            {
                Title = bookDto.Title,
                PublishedDate = bookDto.PublishedDate,
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void AddBookAuthor(BookDto bookDto)
        {
            Book book = new Book
            {
                Title = bookDto.Title,
                PublishedDate = bookDto.PublishedDate,
                Authors = bookDto.Authors.Select(i => new Author
                {
                    Name = i.Name,
                    Email = i.Email,
                    PhoneNumber = i.PhoneNumber,
                }).ToList()
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void AddBookAuthorJoining(int bookId, int authorId)
        {
            var book = _context.Books.Include(i => i.Authors).FirstOrDefault(i => i.Id == bookId);
            var author = _context.Authors.FirstOrDefault(i => i.Id == authorId);

            book.Authors.Add(author);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.Books.FirstOrDefault(i => i.Id == bookId);
            if(book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public BookDto GetBookById(int id)
        {
            var book = _context.Books
                .Include(i => i.Authors)
                .FirstOrDefault(i => i.Id == id);

            if(book != null)
            {
                BookDto bookDto = new BookDto
                {
                    Title = book.Title,
                    PublishedDate = book.PublishedDate,
                    Authors = book.Authors.Select(i => new AuthorBookCreditCardDto
                    {
                        Name = i.Name,
                        Email = i.Email,
                        PhoneNumber = i.PhoneNumber,
                    }).ToList()
                };
                return bookDto;
            }
            return null;
        }

        public List<BookDto> GetBooks()
        {
            var result = _context.Books
                .Include(i => i.Authors)
                .Select(i => new BookDto
                {
                    Title = i.Title,
                    PublishedDate = i.PublishedDate,
                    Authors = i.Authors.Select(i => new AuthorBookCreditCardDto
                    {
                        Name = i.Name,
                        Email = i.Email,
                        PhoneNumber = i.PhoneNumber,
                    }).ToList()
                }).ToList();
            return result;
        }

        public void UpdateBook(int bookId, BookDto bookDto)
        {
            var book = _context.Books
                .Include(i => i.Authors)
                .FirstOrDefault(i => i.Id == bookId);

            if(book != null)
            {
                book.Title = bookDto.Title;
                book.PublishedDate = bookDto.PublishedDate;
                book.Authors = bookDto.Authors.Select(i => new Author
                {
                    Name = i.Name,
                    Email = i.Email,
                    PhoneNumber = i.PhoneNumber
                }).ToList();

                _context.Books.Update(book);
                _context.SaveChanges();
            }
        }
    }
}
