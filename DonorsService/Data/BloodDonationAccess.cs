using Donors.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Donors.API.Data
{
    public class BloodDonationAccess : IBloodDonationAccess
    {

        private readonly AppDbContext _context;
        public BloodDonationAccess(AppDbContext context)
        {
            _context = context;
        }

        public void CreateBloodDonation(BloodDonation bloodDonation)
        {
            if (bloodDonation == null)
            {
                throw new ArgumentNullException(nameof(bloodDonation));
            }

            _context.BloodDonations.Add(bloodDonation);
        }

        public IEnumerable<BloodDonation> GetAllBloodDonations()
        {
            return _context.BloodDonations.ToList();
        }

        public IEnumerable<BloodDonation> GetBloodByDonorId(int donorId)
        {
            return _context.BloodDonations.Where(d => d.donorId == donorId).ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
