using Microsoft.AspNetCore.Mvc;
using Notes.Contracts;
using Notes.DataAccess;
using Notes.Models;

namespace Notes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : Controller
    {
        private readonly NotesDbContext _dbContext;

        public NotesController(NotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateNoteRequest request )
        {
            var note = new Note(request.Title,request.Description);

            _dbContext.AddAsync(note); 
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
