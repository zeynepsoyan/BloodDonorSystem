using System.ComponentModel.DataAnnotations;

namespace Donors.API.Models
{
    public class BloodDonationDto
    {
        [Key]
        private int Id { get; set; }
        [Required]
        [StringLength(2)]
        private String BloodType { get; set; }
        [Required]
        private int Units { get; set; }
        [Required]
        private String DonorName { get; set; }
        [Required]
        private DateOnly DonationDate { get; set; }
    }
}
