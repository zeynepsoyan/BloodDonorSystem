using Donors.API.Models;

namespace Donors.API.Data
{
    public interface IBloodAccess
    {
        bool SaveChanges();
        IEnumerable<Blood> GetAllBloods();
        Blood GetBloodById(int id);
        Blood GetBloodByCityAndTownAndBloodType(String city, String town, String bloodType);
        // If donation 1, then add units; if 0, then substract units
        void UpdateBloodById(int id, bool donation, int units);
        void CreateBlood(Blood blood);
    }
}
