using Donors.API.Models;

namespace Donors.API.Data
{
    public class DonorAccess : IDonorAccess
    {
        private readonly AppDbContext _context;

        public DonorAccess(AppDbContext context)
        {
            _context = context;
        }
        public void CreateDonor(Donor donor)
        {
            if (donor == null)
            {
                throw new ArgumentNullException(nameof(donor));
            }

            _context.Donors.Add(donor);
            SaveChanges();
        }

        public IEnumerable<Donor> GetAllDonors()
        {
            return _context.Donors.ToList();
        }

        public Donor GetDonorById(int id)
        {
            return _context.Donors.FirstOrDefault(d => d.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
