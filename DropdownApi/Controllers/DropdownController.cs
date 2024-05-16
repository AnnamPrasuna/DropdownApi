using DropdownApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DropdownApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        private static readonly List<DropdownItem> _dropdownlist = new List<DropdownItem>()
        {
            new DropdownItem { Id = 1, Name = "Option 1" },
            new DropdownItem { Id = 2, Name = "Option 2" },
            new DropdownItem { Id = 3, Name = "Option 3" }
        };
        [HttpGet]
        public IActionResult GetDropDownListItems()
        {
            return Ok(_dropdownlist);
        }
    }
}
