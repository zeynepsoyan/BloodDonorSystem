namespace BloodBank.API.Models
{
    public class BloodRequestDto
    {
        private int Id { get; set; }
        private String RequestorName { get; set; }
        private String RequestorEmail { get; set; }
        private int Units { get; set; }
        private String City { get; set; }
        private String Town { get; set; }
        private String Reason { get; set; }
        private int SearchDuration { get; set; }
    }
}
