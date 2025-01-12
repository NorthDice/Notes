using Microsoft.AspNetCore.Mvc;

namespace Notes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Create(string title, string description)
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
