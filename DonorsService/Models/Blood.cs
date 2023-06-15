using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donors.API.Models
{
    public class Blood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String Town { get; set; }
        [Required]
        [StringLength(2)]
        public String BloodType { get; set; }
        [Required]
        public int Units { get; set; }
    }
}
