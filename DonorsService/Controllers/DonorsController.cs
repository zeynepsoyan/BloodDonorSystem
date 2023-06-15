using AutoMapper;
using Donors.API.Data;
using Donors.API.Models;
using Donors.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DonorsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonorsController : ControllerBase
    {
        private readonly IDonorAccess _access;
        private readonly IMapper _mapper;
        private readonly ILogger<DonorsController> _logger;

        public DonorsController(IDonorAccess access, IMapper mapper, ILogger<DonorsController> logger)
        {
            _access = access;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DonorReadDto>> GetDonors() 
        {
            Console.WriteLine("-> Getting donors...");

            var donors = _access.GetAllDonors();

            return Ok(_mapper.Map<IEnumerable<DonorReadDto>>(donors));
        }

        [HttpGet("{id}", Name = "GetDonorById")]
        public ActionResult<DonorReadDto> GetDonorById(int id) 
        {
            var donor = _access.GetDonorById(id);

            if ( donor != null) 
            {
                return Ok(_mapper.Map<DonorReadDto>(donor));
            }

                return NotFound();
        }

        [HttpPost]
        public ActionResult<DonorReadDto> CreateDonor(DonorCreateDto donorCreateDto) 
        {
            var donorModel = _mapper.Map<Donor>(donorCreateDto);
            _access.CreateDonor(donorModel);
            _access.SaveChanges();

            var donorReadDto = _mapper.Map<DonorReadDto>(donorModel);

            return CreatedAtRoute(nameof(GetDonorById), new {Id=donorReadDto.Id}, donorReadDto);
        }

    }
}