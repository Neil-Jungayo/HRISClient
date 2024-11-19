using HRISClient.Models;
using Microsoft.EntityFrameworkCore;

namespace HRISClient.Services
{

    //We created ApplicationDbContext to allows us to connect to the Database
    //After creating, we extend it to the identity dbcontext
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        //This will create the table in the database
        public DbSet<Employee> Employees { get; set; }
    }
}
