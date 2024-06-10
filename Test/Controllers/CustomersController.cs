using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Context;
using Test.Model;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerDto>> GetCustomerWithApplicationsAndRules()
        {
            var customers = await _context.Customers
                .Include(c => c.CustomerApplications)
                .ThenInclude(ca => ca.Application)
                .ThenInclude(a => a.Roles)
                .ToListAsync();

            var customerDtos = customers.Select(c => new CustomerDto
            {
                Name = c.Name,
                Applications = c.CustomerApplications.Select(ca => new ApplicationDto
                {
                    Name = ca.Application.Name,
                    Roles = ca.Application.Roles.Select(r => r.Description).ToList()
                }).ToList()
            }).ToList();

            return Ok(customerDtos);
        }
    }

}
