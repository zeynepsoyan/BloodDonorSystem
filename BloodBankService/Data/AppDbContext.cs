using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
