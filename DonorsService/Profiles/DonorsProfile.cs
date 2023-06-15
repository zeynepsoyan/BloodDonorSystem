using AutoMapper;
using Donors.API.Models;
using Donors.API.Models.Dtos;

namespace Donors.API.Profiles
{
    public class DonorsProfile : Profile
    {
        public DonorsProfile() 
        {
            CreateMap<DonorCreateDto, Donor>();
            CreateMap<Donor, DonorReadDto>();
        }
    }
}
