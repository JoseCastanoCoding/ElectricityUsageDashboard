using ElectricityUsageDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityUsageDashboard.Data
{
    public class ReadingsDbContext:DbContext
    {
        public ReadingsDbContext(DbContextOptions<ReadingsDbContext> options) : base(options) 
        {

        }
        public DbSet<Reading> Readings { get; set; }
    }
}
