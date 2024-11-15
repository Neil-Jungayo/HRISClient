using Microsoft.EntityFrameworkCore;

namespace HRISClient.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
