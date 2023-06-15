using Donors.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Donors.API.Data
{
    public class DonorDbContext : DbContext
    {
        public DonorDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Blood> Bloods { get; set; }
    }
}
