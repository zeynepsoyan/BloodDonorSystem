using BloodBank.API.Models;

namespace BloodBank.API.Data
{
    public interface IBloodRequestAccess
    {
        bool SaveChanges();
        IEnumerable<BloodRequest> GetAllBloodRequests();
        BloodRequest GetBloodRequestById(int id);
        IEnumerable<BloodRequest> GetBloodRequestByRequestorName(String requestorName);
        void CreateBloodRequest(BloodRequest bloodRequest);
    }
}
