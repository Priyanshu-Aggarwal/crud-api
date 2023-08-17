using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api_Project.DTO;
using Web_Api_Project.Models;

namespace Web_Api_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController: ControllerBase
    {

        private readonly ApplicationDBContext dbContext;
        private readonly IMapper mapper;
        public BookController(ApplicationDBContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }


        // Fetch All Books
        [HttpGet("")]
        public async Task<List<BookDTO>> GetBooks()
        {
            return await dbContext.Books
                .ProjectTo<BookDTO>(mapper.ConfigurationProvider)
                .ToListAsync();
        }

        // Add Book Corresponding to Author ID
        [HttpPost("insert/{authorId}")]
        public async Task<ActionResult> AddBook(Book book, int authorId)
        {
           
            book.AuthorID = authorId;
            dbContext.Add(book);
            await dbContext.SaveChangesAsync();
            return new OkObjectResult(mapper.Map<BookDTO>(book));
        }

        // Fetch Book By ID
        [HttpGet("{bookId}")]
        public async Task<ActionResult> GetBookById(int bookId)
        {
            Book book = await dbContext.Books.FindAsync(bookId);

            if(book is null) { return new NotFoundResult(); }
           
            return new OkObjectResult(mapper.Map<BookDTO>(book));

        }

        // Add Multiple Books with corresponding Author ID
        [HttpPost("author/{authorId}")]
        public async Task<ActionResult> AddMultipleRecords(Book[] book, int authorId)
        {
            foreach(Book b in book){ b.AuthorID = authorId; }

            dbContext.AddRange(book);
            await dbContext.SaveChangesAsync();
            return  new OkObjectResult("Data Inserted..");
        }

        // Update Book by ID
        [HttpPut("{bookId}")]
        public async Task<ActionResult> updateBookById(int bookId, Book book)
        {
            Book res = dbContext.Books.Find(bookId);
            if(res is null)
            {
                return new NotFoundResult();
            }

            res.Title = book.Title;
            res.Description = book.Description;
     
            await dbContext.SaveChangesAsync();
            return new OkObjectResult("Data Updated");
        }

        // Delete Book by Id
        [HttpDelete("{bookId}")]
        public async Task<ActionResult> deleteBook(int bookId)
        {

            var book = dbContext.Books.Find(bookId);
            if(book is null)
            {
                return new NotFoundResult();
            }
            dbContext.Remove(book);
            await dbContext.SaveChangesAsync();
            return new OkObjectResult("Data Deleted..");
        }    
        
    }
}
