using Donors.API.Models.Dtos;

namespace Donors.API.SyncDataServices
{
    public interface IBloodBankDataClient
    {
        Task BloodRequest(BloodReadDto blood);
    }
}
