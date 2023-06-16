using AutoMapper;
using Donors.API.Models.Dtos;
using Donors.API.Models;

namespace Donors.API.Profiles
{
    public class BloodsProfile : Profile
    {
        public BloodsProfile()
        {
            CreateMap<BloodCreateDto, Blood>();
            CreateMap<Blood, BloodReadDto>();
        }
    }
}
