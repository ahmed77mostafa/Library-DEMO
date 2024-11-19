using System.ComponentModel.DataAnnotations;

namespace Library_DEMO.DTOs.AuthorFolder
{
    public class AuthorBookCreditCardDto
    {
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
