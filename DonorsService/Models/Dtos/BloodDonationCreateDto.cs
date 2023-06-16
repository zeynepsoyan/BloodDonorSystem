namespace Donors.API.Models.Dtos
{
    public class BloodDonationCreateDto
    {
        public int Units { get; set; }
        public int donorId { get; set; }
        public DateTime DonationDate { get; set; }
    }
}
