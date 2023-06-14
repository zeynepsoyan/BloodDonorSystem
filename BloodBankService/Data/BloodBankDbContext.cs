using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Data
{
    public class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext(DbContextOptions options) : base(options) { }
    }
}
