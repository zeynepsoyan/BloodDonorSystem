using Donors.API.Models;

namespace Donors.API.Data
{
    public interface IBloodDonationAccess
    {
        bool SaveChanges();
        IEnumerable<BloodDonation> GetAllBloodDonations();
        BloodDonation GetBloodDonationById(int id);
        IEnumerable<BloodDonation> GetBloodByDonorId(int donorId);
        void CreateBloodDonation(BloodDonation bloodDonation);
    }
}
