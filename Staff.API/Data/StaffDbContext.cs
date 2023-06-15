using Staff.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Staff.API.Data
{
    public class StaffDbContext : DbContext
    {
        public StaffDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BloodBank> BloodBanks { get; set; }
    }
}
