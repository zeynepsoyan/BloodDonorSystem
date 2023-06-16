﻿namespace BloodBank.API.Models.Dtos
{
    public class BloodRequestCreateDto
    {
        public String RequestorName { get; set; }
        public String RequestorEmail { get; set; }
        public String BloodType { get; set; }
        public int Units { get; set; }
        public String City { get; set; }
        public String Town { get; set; }
        public String Reason { get; set; }
        public int SearchDuration { get; set; }
    }
}
