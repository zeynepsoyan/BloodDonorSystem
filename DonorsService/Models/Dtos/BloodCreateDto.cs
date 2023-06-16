using System.ComponentModel.DataAnnotations;

namespace Donors.API.Models.Dtos
{
    public class BloodCreateDto
    {
        public String City { get; set; }
        public String Town { get; set; }
        public String BloodType { get; set; }
        public int Units { get; set; }
    }
}