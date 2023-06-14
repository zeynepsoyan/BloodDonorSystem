namespace Donors.API.Models
{
    public class BloodDonationDto
    {
        private int Id { get; set; }
        private String BloodType { get; set; }
        private int Units { get; set; }
        private String DonorName { get; set; }
        private DateOnly DonationDate { get; set; }
    }
}
