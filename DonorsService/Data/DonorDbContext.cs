using Microsoft.EntityFrameworkCore;

namespace Donors.API.Data
{
    public class DonorDbContext : DbContext
    {
        public DonorDbContext(DbContextOptions options) : base(options) { }
    }
}
