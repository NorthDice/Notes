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
        public async Task<IActionResult> Create([FromBody]CreateNoteRequest request,CancellationToken ct )
        {
            var note = new Note(request.Title,request.Description);

            await _dbContext.Notes.AddAsync(note, ct);
            
            await _dbContext.SaveChangesAsync(ct);
            
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetNotesRequest request)
        {


            return Ok();
        }
    }
}
