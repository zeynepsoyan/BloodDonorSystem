using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBank.API.Models
{
    public class BloodRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String RequestorName { get; set; }
        [Required]
        public String RequestorEmail { get; set; }
        [Required]
        [StringLength(3)]
        public String BloodType { get; set; }
        [Required]
        public int Units { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String Town { get; set; }
        [Required]
        [MaxLength(200)]
        public String Reason { get; set; }
        [Required]
        public int SearchDuration { get; set; }
    }
}
