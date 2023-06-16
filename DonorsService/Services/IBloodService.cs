using Donors.API.Models;

namespace Donors.API.Services
{
    public interface IBloodService
    {
        bool SaveChanges();
        IEnumerable<Blood> GetAllBloods();
        Blood GetBloodById(int id);
        bool AddBlood(Blood blood);
    }
}
