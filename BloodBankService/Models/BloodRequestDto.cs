using System.ComponentModel.DataAnnotations;

namespace BloodBank.API.Models
{
    public class BloodRequestDto
    {
        [Key]
        private int Id { get; set; }
        [Required]
        private String RequestorName { get; set; }
        [Required]
        private String RequestorEmail { get; set; }
        [Required]
        private int Units { get; set; }
        [Required]
        private String City { get; set; }
        [Required]
        private String Town { get; set; }
        [Required]
        [MaxLength(200)]
        private String Reason { get; set; }
        [Required]
        private int SearchDuration { get; set; }
    }
}
