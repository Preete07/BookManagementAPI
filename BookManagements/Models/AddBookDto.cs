namespace BookManagements.Models
{
    public class AddBookDto
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public decimal Year { get; set; }
    }
}
