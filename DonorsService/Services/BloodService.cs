using Donors.API.Data;
using Donors.API.Models;

namespace Donors.API.Services
{
    public class BloodService : IBloodService
    {
        private readonly IBloodAccess _access;

        public BloodService (IBloodAccess access)
        {
            _access = access;
        }

        public bool AddBlood(Blood blood)
        {
            if (blood == null) 
            {
                throw new ArgumentNullException(nameof(blood));
            }

            var existingBlood = _access.GetBloodByCityAndTownAndBloodType(blood.City, blood.Town, blood.BloodType);

            if (existingBlood != null)
            {
                _access.UpdateBloodById(existingBlood.Id, true, existingBlood.Units);
            } 
            else
            {
                _access.CreateBlood(blood);
            }

            return _access.SaveChanges();
        }

        public IEnumerable<Blood> GetAllBloods()
        {
            return _access.GetAllBloods();
        }

        public Blood GetBloodById(int id)
        {
           return _access.GetBloodById(id);
        }

        public bool SaveChanges()
        {
            return _access.SaveChanges();
        }
    }
}
