using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Donors.API.Models.Dtos
{
    public class BloodDonationReadDto
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public int donorId { get; set; }
        public DateTime DonationDate { get; set; }
    }
}
