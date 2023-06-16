using BloodBank.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BloodRequest> BloodRequests { get; set; }
    }
}
