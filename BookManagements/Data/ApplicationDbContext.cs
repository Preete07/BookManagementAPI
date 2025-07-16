using Microsoft.EntityFrameworkCore;
using BookManagements.Models.Entities;
namespace BookManagements.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Books> Bookss { get; set; }
    }
}
