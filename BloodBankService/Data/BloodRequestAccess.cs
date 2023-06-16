using BloodBank.API.Models;

namespace BloodBank.API.Data
{
    public class BloodRequestAccess : IBloodRequestAccess
    {
        private readonly AppDbContext _context;
        public BloodRequestAccess(AppDbContext context)
        {
            _context = context;
        }
        public void CreateBloodRequest(BloodRequest bloodRequest)
        {
            if (bloodRequest == null)
            {
                throw new ArgumentNullException(nameof(bloodRequest));
            }

            _context.BloodRequests.Add(bloodRequest);
        }

        public IEnumerable<BloodRequest> GetAllBloodRequests()
        {
            return _context.BloodRequests.ToList();
        }

        public BloodRequest GetBloodRequestById(int id)
        {
            return _context.BloodRequests.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<BloodRequest> GetBloodRequestByRequestorName(string requestorName)
        {
            return _context.BloodRequests.Where(d => d.RequestorName == requestorName).ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
