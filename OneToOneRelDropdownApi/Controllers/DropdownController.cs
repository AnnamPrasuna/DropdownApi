using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToOneRelDropdownApi.Data;
using OneToOneRelDropdownApi.Models;

namespace OneToOneRelDropdownApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        private readonly EmpAddContext _context;
        public DropdownController(EmpAddContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Addresss>> GetAddressDropdown()
        {
            var employees = _context.Employees
            .Include(e => e.Address.City) // Include associated address
            .ToList();
            return Ok(employees);
        }

        //// GET: api/employee/cities
        //[HttpGet("cities")]
        //public ActionResult<IEnumerable<string>> GetAllEmployeeCities()
        //{
        //    var employeeCities = _context.Employees
        //        .Join(_context.Address,
        //            e => e.AddressId,
        //            a => a.AddressId,
        //            (e, a) => new { e, a })
        //        .Select(x => x.a.City)
        //        .ToList();

        //    return Ok(employeeCities);
        //}
        public ActionResult<IEnumerable<string>> GetUniqueCitiesForEmployees()
        {
            var uniqueCities = _context.Employees
                .Join(
                    _context.Address, // Join with Addresses table
                    e => e.AddressId,   // Join condition on Employee's AddressId
                    a => a.AddressId,   // Join condition on Address's AddressId
                    (e, a) => a.City    // Select the City from the joined result
                )
                .Distinct() // Get distinct cities
                .ToList();
            return Ok(uniqueCities);
        }
    }
}
