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
        private readonly IBloodDonationAccess _bloodDonationAccess;
        private readonly IMapper _mapper;
        private readonly ILogger<BloodsController> _logger;

        public BloodsController(IBloodService service, IDonorAccess donorAccess, IBloodDonationAccess bloodDonationAccess ,IMapper mapper, ILogger<BloodsController> logger)
        {
            _donorAccess = donorAccess;
            _bloodDonationAccess = bloodDonationAccess;
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

        [HttpGet("donations")]
        public ActionResult<IEnumerable<BloodDonationReadDto>> GetBloodDonations()
        {
            Console.WriteLine("-> Getting blood donations...");

            var bloodDonations = _bloodDonationAccess.GetAllBloodDonations();

            return Ok(_mapper.Map<IEnumerable<BloodDonationReadDto>>(bloodDonations));
        }

        [HttpGet("donations/{donationId}", Name = "GetBloodDonationById")]
        public ActionResult<BloodDonationReadDto> GetBloodDonationById(int id)
        {
            var bloodDonation = _bloodDonationAccess.GetBloodDonationById(id);

            if (bloodDonation != null)
            {
                return Ok(_mapper.Map<BloodDonationReadDto>(bloodDonation));
            }

            return NotFound();
        }

        [HttpGet("donations/{donorId}", Name = "GetBloodDonationsByDonorId")]
        public ActionResult<IEnumerable<BloodDonationReadDto>> GetBloodDonationsByDonorId(int donorId)
        {
            var bloodDonations = _bloodDonationAccess.GetBloodByDonorId(donorId);

            if (bloodDonations != null)
            {
                return Ok(_mapper.Map<IEnumerable<BloodDonationReadDto>>(bloodDonations));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<BloodReadDto> AddBlood(BloodDonationCreateDto bloodDonationCreateDto)
        {
            var bloodDonation = _mapper.Map<BloodDonation>(bloodDonationCreateDto);
            _bloodDonationAccess.CreateBloodDonation(bloodDonation);

            var donor = _donorAccess.GetDonorById(bloodDonation.donorId);
            var bloodCreateDto = new BloodCreateDto()
            {
                City = donor.City,
                Town = donor.Town,
                BloodType = donor.BloodType,
                Units = bloodDonation.Units
            };
            var bloodModel = _mapper.Map<Blood>(bloodCreateDto);
            _service.AddBlood(bloodModel);

            var bloodReadDto = _mapper.Map<BloodReadDto>(bloodModel);

            return CreatedAtRoute(nameof(GetBloodById), new { bloodReadDto.Id }, bloodReadDto);

        }
    }
}
