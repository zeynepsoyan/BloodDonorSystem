using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models
{
    public class BloodDonation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Units { get; set; }
        [Required]
        public int donorId { get; set; }
        [Required]
        public DateTime DonationDate { get; set; }
    }
}
