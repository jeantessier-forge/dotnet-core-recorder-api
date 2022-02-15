using Microsoft.AspNetCore.Mvc;
using RecorderApi.Data;
using RecorderApi.Models;

namespace RecorderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecorderApiController : ControllerBase
    {
        private readonly RecorderApiContext _context;

        public RecorderApiController(RecorderApiContext context)
        {
            _context = context;
        }
        
        // GET: api/RecorderApi
        [HttpGet]
        public async Task<ActionResult<int>> GetRecordCount()
        {
            return _context.Records.Count();
        }
        
        // POST: api/TodoItems
        [HttpPost]
        public async Task<IActionResult> PostRecord(string? name)
        {
            var record = new Record
            {
                Name = name,
                RecordedAt = DateTime.Now
            };
            
            _context.Records.Add(record);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }    
}
