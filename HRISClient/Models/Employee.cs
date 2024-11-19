using Microsoft.EntityFrameworkCore;

namespace HRISClient.Models
{
    //Ensuring that the Company Email is unique
    [Index("CompanyEmail", IsUnique = true)]
    public class Employee
    {
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Gender { get; set; } = "";
        public string CompanyEmail { get; set; } = "";
        public string Phone { get; set; } = "";
        public string BirthPlace { get; set; } = "";
        public string Address { get; set; } = "";
        public string Religion { get; set; } = "";
        public string MaritalStatus { get; set; } = "";
        public string Position { get; set; } = "";
        public string OrganizationUnit { get; set; } = "";
        public DateTime? JoinDate { get; set; } 
        public DateTime? BirthDate { get; set; }
        public string JobStatus { get; set; } = "";
        public string Grade { get; set; } = "";
        public string CostCenter { get; set; } = "";
        public string EmployeeStatus { get; set; } = "";
        public string TaxStatus { get; set; } = "";
        public decimal? BaseSalary { get; set; } 
        public DateTime? EmplymentDate { get; set; }
        public DateTime? PermanentDate {  get; set; }

    } 
}
