using System.ComponentModel.DataAnnotations;

namespace Staff.API.Models
{
    public class BloodBank
    {
        [Key]
        private int Id { get; set; }
        [Required]
        private String Password { get; set; }
        [Required]
        private String BloodBankName { get; set; }
    }
}
