using Donors.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Donors.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<BloodDonation> BloodDonations { get; set; }
    }
}
