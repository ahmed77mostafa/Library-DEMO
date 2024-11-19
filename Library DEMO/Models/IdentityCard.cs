namespace Library_DEMO.Models
{
    public class IdentityCard
    {
        public int Id { get; set; }
        public string ExpireDate { get; set; }
        public Author Author { get; set; }
        public int AuthorId {  get; set; }
    }
}
