using Library_DEMO.Data;
using Library_DEMO.DTOs.CreditCardFolder;
using Library_DEMO.Models;
using Library_DEMO.Repositories.Interfaces;

namespace Library_DEMO.Repositories.Implementations
{
    public class CreditCardRepo : ICreditCardRepo
    {
        private readonly AppDbContext _context;

        public CreditCardRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCreditCard(CreditCardAuthorDto creditCardDto)
        {
            CreditCard creditCard = new CreditCard
            {
                Name = creditCardDto.Name,
                Type = creditCardDto.Type,
            };
            _context.CreditCards.Add(creditCard);
            _context.SaveChanges();
        }

        public void AddCreditCardAuthor(CreditCardDto creditCardDto)
        {
            CreditCard creditCard = new CreditCard
            {
                Name = creditCardDto.Name,
                Type = creditCardDto.Type,
                Author = new Author
                {
                    Name = creditCardDto.Author.Name,
                    Email = creditCardDto.Author.Email,
                    PhoneNumber = creditCardDto.Author.PhoneNumber,
                    Books = creditCardDto.Author.Books.Select(i => new Book
                    {
                        Title = i.Title,
                        PublishedDate = i.PublishedDate,
                    }).ToList()
                }
            };
            _context.CreditCards.Add(creditCard);
            _context.SaveChanges();
        }

        public void AddCreditCardAuthorJoining(int creditCardId, int authorId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCreditCard(int id)
        {
            throw new NotImplementedException();
        }

        public CreditCardDto GetCreditCardById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CreditCardDto> GetCreditCards()
        {
            throw new NotImplementedException();
        }

        public void UpdateCreditCard(int id, CreditCardDto creditCardDto)
        {
            throw new NotImplementedException();
        }
    }
}
