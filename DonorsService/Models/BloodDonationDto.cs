using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models
{
    public class BloodDonationDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
