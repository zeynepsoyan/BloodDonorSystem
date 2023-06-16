using Donors.API.Models;

namespace Donors.API.Data
{
    public interface IBloodDonationAccess
    {
        bool SaveChanges();
        IEnumerable<BloodDonation> GetAllBloodDonations();
        IEnumerable<BloodDonation> GetBloodByDonorId(int donorId);
        void CreateBloodDonation(BloodDonation bloodDonation);
    }
}
