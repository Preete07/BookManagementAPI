namespace BookManagements.Models.Entities
{
    public class Books
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public decimal Year { get; set; }
    }
}
