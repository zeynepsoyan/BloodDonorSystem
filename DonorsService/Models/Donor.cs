using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models
{
    public class Donor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int Id { get; set; }
        [Required]
        private String Name { get; set; }
        [Required]
        [StringLength(2)]
        private String BloodType { get; set; }
        [Required]
        private String City { get; set;}
        [Required]
        private String Town { get; set; }
        [Required]
        private String PhoneNumber { get; set; }
    }
}
