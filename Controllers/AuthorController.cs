
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api_Project.DTO;
using Web_Api_Project.Models;
using Web_Api_Project.Pagination;

namespace Web_Api_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController: ControllerBase
    {
        private readonly ApplicationDBContext dbContext;
        private readonly IMapper mapper;

        public AuthorController(ApplicationDBContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        // Fetch All Authors using Pagination
        [HttpGet("")]
        public List<AuthorDTO> GetAllAuthors([FromQuery] int page, [FromQuery] int recordToTake)
        {
            return dbContext.Authors
                .ProjectTo<AuthorDTO>(mapper.ConfigurationProvider)         // New Method
                .Paginate(page, recordToTake)
                .ToList();

        }

        // Fetch Author By ID
        [HttpGet("{id}")]
        public ActionResult<AuthorDTO> GetAuthorById(int id)
        {
            Author author = dbContext.Authors
                .Include("Books")
                .FirstOrDefault(a => a.Id == id);
            
            if(author is null)
            {
                return new NotFoundResult(); 
            }
            return mapper.Map<AuthorDTO>(author);
        }

        // Fetch Author using AutoMapper
        [HttpGet("data")]
        public AuthorDTO GetAuthorWithAutoMapper(int id)
        {
            var res = dbContext.Authors.Select(m => new AuthorDTO
            {
                Id = m.Id,
                Name = m.Name,
                bookDTOs = mapper.Map<List<BookDTO>>(m.Books.OrderByDescending(g => g.Id))          // OrderBy Used
            }).First(m => m.Id == 1);

            return res;
        }

        // Add Author
        [HttpPost("add")]
        public async Task<ActionResult> AddAuthor(Author author)
        {
            author.CreatedAt = DateTime.Now;
            dbContext.Add(author);
            await dbContext.SaveChangesAsync();
            return new OkObjectResult("Auther Inserted Successfully");
        }

        // Delete Author
        [HttpDelete("{authorId}")]
        public async Task<ActionResult> DeleteAuthor(int authorId)
        {

            var author = dbContext.Authors.Find(authorId);
            if (author is null)
            {
                return new NotFoundResult();
            }
            dbContext.Remove(author);
            await dbContext.SaveChangesAsync();
            return new OkObjectResult("Data Deleted..");
        }


    }
}
