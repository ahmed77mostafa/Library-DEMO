using Library_DEMO.Models;
using System.ComponentModel.DataAnnotations;

namespace Library_DEMO.DTOs.BookFolder
{
    public class BookDto
    {
        [Required]
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<BookAuthorDto> Authors { get; set; }
    }
}
