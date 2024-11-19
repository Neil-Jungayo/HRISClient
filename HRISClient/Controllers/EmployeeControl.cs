using HRISClient.Models;
using HRISClient.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRISClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeControl : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public EmployeeControl(ApplicationDbContext context)
        {
            this.context = context;
        }

        //Displaying Employees in descending order
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return context.Employees.OrderByDescending(c => c.Id).ToList();
        }

        //Finding Employee by its ID
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
