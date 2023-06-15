using Donors.API.Models;

namespace Donors.API.Data
{
    public interface IDonorAccess
    {
        bool SaveChanges();
        IEnumerable<Donor> GetAllDonors();
        Donor GetDonorById(int id);
        void CreateDonor(Donor donor);
    }
}
