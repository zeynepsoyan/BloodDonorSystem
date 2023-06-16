using AutoMapper;
using BloodBank.API.Models;
using BloodBank.API.Models.Dtos;

namespace BloodBank.API.Profiles
{
    public class BloodBankProfile : Profile
    {
        public BloodBankProfile() 
        {
            CreateMap<BloodRequestCreateDto, BloodRequest>();
            CreateMap<BloodRequest, BloodRequestReadDto>();
        }
    }
}
