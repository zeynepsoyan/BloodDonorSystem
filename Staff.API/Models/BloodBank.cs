using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff.API.Models
{
    public class BloodBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int Id { get; set; }
        [Required]
        private String Password { get; set; }
        [Required]
        private String BloodBankName { get; set; }
    }
}
