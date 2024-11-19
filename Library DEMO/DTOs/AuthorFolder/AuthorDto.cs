using Library_DEMO.DTOs.BookFolder;
using Library_DEMO.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Library_DEMO.DTOs.AuthorFolder
{
    public class AuthorDto
    {
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public List<AuthorBookDto> Books { get; set; }
    }
}
