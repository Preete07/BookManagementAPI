using BookManagements.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookManagements.Models;
using BookManagements.Models.Entities;
using Microsoft.VisualBasic;

namespace BookManagements.Controllers
{
    // localhost:xxxx/api/books
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {           
            return Ok(dbContext.Bookss.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetBookById(Guid id)
        { 
            var book = dbContext.Bookss.Find(id);
            if (book is null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook(AddBookDto addBookDto) 
        {
            var bookEntity = new Books()
            {
                Title = addBookDto.Title,
                Author = addBookDto.Author,
                Year = addBookDto.Year
            };


            dbContext.Bookss.Add(bookEntity);
            dbContext.SaveChanges();
       
            return Ok(bookEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateBook(Guid id, UpdateBookDto updateBookDto)
        {
            var book = dbContext.Bookss.Find(id);
             
            if (book is null)
            {
                return NotFound();
            }

            book.Title = updateBookDto.Title;
            book.Author = updateBookDto.Author;
            book.Year = updateBookDto.Year;

            dbContext.SaveChanges();

            return Ok(book);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteBook(Guid id)
        {
            var book = dbContext.Bookss.Find(id);
            if (book is null)
            {
                return NotFound();
            }
            dbContext.Bookss.Remove(book);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
