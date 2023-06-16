using Donors.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Donors.API.Data
{
    public class BloodAccess : IBloodAccess
    {
        private readonly AppDbContext _context;

        public BloodAccess(AppDbContext context)
        {
            _context = context;
        }

        public void CreateBlood(Blood blood)
        {
            if (blood == null)
            {
                throw new ArgumentNullException(nameof(blood));
            }

            _context.Bloods.Add(blood);
        }

        public IEnumerable<Blood> GetAllBloods()
        {
            return _context.Bloods.ToList();
        }

        public Blood GetBloodByCityAndTownAndBloodType(String city, String town, String bloodType)
        {
            return _context.Bloods.FirstOrDefault(b => b.City == city && b.Town == town && b.BloodType == bloodType);
        }

        public Blood GetBloodById(int id)
        {
            return _context.Bloods.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBloodById(int id, bool donation, int units)
        {
            var blood = _context.Bloods.FirstOrDefault(b => b.Id == id);
            if (blood != null)
            {
                if (donation)
                {
                    // add blood
                    blood.Units += units;
                }
                else
                {
                    if (blood.Units - units < 0)
                    {
                        throw new Exception("Not enough blood in the bank");
                    }
                    else
                    {
                        // get blood
                        blood.Units -= units;
                    }
                }
            }
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
