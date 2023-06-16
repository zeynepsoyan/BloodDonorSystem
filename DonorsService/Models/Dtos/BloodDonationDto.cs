using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models.Dtos
{
    public class BloodDonationDto
    {
        [Required]
        public int Units { get; set; }
        [Required]
        public int donorId { get; set; }
        [Required]
        public DateTime DonationDate { get; set; }
    }
}
