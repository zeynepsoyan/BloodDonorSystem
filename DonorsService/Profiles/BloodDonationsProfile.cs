using AutoMapper;
using Donors.API.Models.Dtos;
using Donors.API.Models;

namespace Donors.API.Profiles
{
    public class BloodDonationsProfile : Profile
    {
        public BloodDonationsProfile()
        {
            CreateMap<BloodDonationCreateDto, BloodDonation>();
            CreateMap<BloodDonation, BloodDonationReadDto>();
        }
    }
}
