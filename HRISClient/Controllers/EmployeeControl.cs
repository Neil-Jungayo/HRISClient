using HRISClient.Models;
using HRISClient.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Threading.Tasks;

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

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            var otherEmployee = context.Employees.FirstOrDefault(c => c.CompanyEmail == employeeDto.CompanyEmail);
            if (otherEmployee != null)
            {
                ModelState.AddModelError("CompanyEmail", "The Company Email is already used");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }

            var employee = new Employee
            {
                EmployeeNo = employeeDto.EmployeeNo,
                EmployeeName = employeeDto.EmployeeName,
                FirstName = employeeDto.FirstName,
                MiddleName = employeeDto.MiddleName,
                LastName = employeeDto.LastName,
                Gender = employeeDto.Gender,
                CompanyEmail = employeeDto.CompanyEmail,
                Phone = employeeDto.Phone,
                BirthPlace = employeeDto.BirthPlace,
                Address = employeeDto.Address,
                Religion = employeeDto.Religion,
                MaritalStatus = employeeDto.MaritalStatus,
                Position = employeeDto.Position,
                OrganizationUnit = employeeDto.OrganizationalUnit,
                JoinDate = employeeDto.JoinDate,
                BirthDate = employeeDto.BirthDate,
                JobStatus = employeeDto.JobStatus,
                Grade = employeeDto.Grade,
                CostCenter  = employeeDto.CostCenter,
                EmployeeStatus = employeeDto.EmployeeStatus,
                TaxStatus = employeeDto.TaxStatus,
                BaseSalary = employeeDto.BaseSalary,
                EmploymentDate  = employeeDto.EmploymentDate,
                PermanentDate = employeeDto.PermanentDate,
            };

            context.Employees.Add(employee);
            context.SaveChanges();

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult EditEmployee(int id, EmployeeDto employeeDto)
        {
            var otherEmployee = context.Employees.FirstOrDefault(c => c.CompanyEmail == employeeDto.CompanyEmail);
            if (otherEmployee != null)
            {
                ModelState.AddModelError("CompanyEmail", "The Company Email is already used");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }

            var employee = context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            //Update the details
            employee.EmployeeNo = employeeDto.EmployeeNo;
            employee.EmployeeName = employeeDto.EmployeeName;
            employee.FirstName = employeeDto.FirstName;
            employee.MiddleName = employeeDto.MiddleName;
            employee.LastName = employeeDto.LastName;
            employee.Gender = employeeDto.Gender;
            employee.CompanyEmail = employeeDto.CompanyEmail;
            employee.Phone = employeeDto.Phone;
            employee.BirthPlace = employeeDto.BirthPlace;
            employee.Address = employeeDto.Address;
            employee.Religion = employeeDto.Religion;
            employee.MaritalStatus = employeeDto.MaritalStatus;
            employee.Position = employeeDto.Position;
            employee.OrganizationUnit = employeeDto.OrganizationalUnit;
            employee.JoinDate = employeeDto.JoinDate;
            employee.BirthDate = employeeDto.BirthDate;
            employee.JobStatus = employeeDto.JobStatus;
            employee.Grade = employeeDto.Grade;
            employee.CostCenter = employeeDto.CostCenter;
            employee.EmployeeStatus = employeeDto.EmployeeStatus;
            employee.TaxStatus = employeeDto.TaxStatus;
            employee.BaseSalary = employeeDto.BaseSalary;
            employee.EmploymentDate = employeeDto.EmploymentDate;
            employee.PermanentDate = employeeDto.PermanentDate;

            context.SaveChanges();

            return Ok(employee);
        }
    }
}
