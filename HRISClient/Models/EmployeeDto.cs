using System.ComponentModel.DataAnnotations;

namespace HRISClient.Models
{
    public class EmployeeDto
    {
        [Required]
        public int EmployeeNo { get; set; }

        [Required]
        public string EmployeeName { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string MiddleName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        [Required]
        public string Gender { get; set; } = "";

        [Required]
        public string CompanyEmail { get; set; } = "";

        [Required]
        public string Phone {  get; set; } = "";

        [Required]
        public string BirthPlace { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";

        [Required]
        public string Religion { get; set; } = "";

        [Required]
        public string MaritalStatus { get; set; } = "";

        [Required]
        public string Position { get; set; } = "";

        [Required]
        public string OrganizationalUnit { get; set; } = "";

        [Required]
        public DateTime? JoinDate { get; set; }

        [Required]
        public DateTime? BirthDate { get; set; }

        [Required]
        public string JobStatus { get; set; } = "";

        [Required]
        public string Grade { get; set; } = "";

        [Required]
        public string CostCenter { get; set; } = "";

        [Required]
        public string EmployeeStatus { get; set; } = "";

        [Required]
        public string TaxStatus { get; set; } = "";

        [Required]
        public double BaseSalary { get; set; }

        [Required]
        public DateTime? EmploymentDate { get; set; }
        
        [Required]
        public DateTime? PermanentDate { get; set; }
    }
}
