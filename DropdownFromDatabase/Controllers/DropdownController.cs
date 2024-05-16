using DropdownFromDatabase.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DropdownFromDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        private readonly TechnologyContext _Context;
        public DropdownController(TechnologyContext Context)
        {
            _Context = Context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Technology>>> GetDropdownItems()
        {
            return await _Context.technologies.ToListAsync();
        }
    }
}
