using AutoMapper;
using Donors.API.Data;
using Donors.API.Models;
using Donors.API.Models.Dtos;
using Donors.API.Services;
using DonorsService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Donors.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BloodsController : ControllerBase
    {
        private readonly IBloodService _service;
        private readonly IDonorAccess _donorAccess;
        private readonly IMapper _mapper;
        private readonly ILogger<BloodsController> _logger;

        public BloodsController(IBloodService service, IDonorAccess donorAccess, IMapper mapper, ILogger<BloodsController> logger)
        {
            _donorAccess = donorAccess;
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BloodReadDto>> GetBloods()
        {
            Console.WriteLine("-> Getting bloods...");

            var bloods = _service.GetAllBloods();

            return Ok(_mapper.Map<IEnumerable<BloodReadDto>>(bloods));
        }

        [HttpGet("{id}", Name = "GetBloodById")]
        public ActionResult<BloodReadDto> GetBloodById(int id)
        {
            var blood = _service.GetBloodById(id);

            if (blood != null)
            {
                return Ok(_mapper.Map<BloodReadDto>(blood));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<BloodReadDto> AddBlood(BloodDonationDto bloodDonationDto)
        {
            var donor = _donorAccess.GetDonorById(bloodDonationDto.donorId);
            var bloodCreateDto = new BloodCreateDto()
            {
                City = donor.City,
                Town = donor.Town,
                BloodType = donor.BloodType,
                Units = bloodDonationDto.Units
            };
            var bloodModel = _mapper.Map<Blood>(bloodCreateDto);
            _service.AddBlood(bloodModel);

            var bloodReadDto = _mapper.Map<BloodReadDto>(bloodModel);

            return CreatedAtRoute(nameof(GetBloodById), new { Id = bloodReadDto.Id }, bloodReadDto);

        }
    }
}
