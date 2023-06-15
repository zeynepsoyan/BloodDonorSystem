namespace Donors.API.Models.Dtos
{
    public class DonorCreateDto
    {
        public String Name { get; set; }
        public String BloodType { get; set; }
        public String City { get; set; }
        public String Town { get; set; }
        public String PhoneNumber { get; set; }
    }
}
