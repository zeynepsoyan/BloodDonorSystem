using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models.Dtos
{
    public class BloodDonationDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(2)]
        public string BloodType { get; set; }
        [Required]
        public int Units { get; set; }
        [Required]
        public string DonorName { get; set; }
        [Required]
        public DateOnly DonationDate { get; set; }
    }
}
