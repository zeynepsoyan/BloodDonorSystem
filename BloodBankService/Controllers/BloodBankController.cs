using AutoMapper;
using BloodBank.API.Data;
using BloodBank.API.Models;
using BloodBank.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BloodBankController : ControllerBase
    {
        private readonly IBloodRequestAccess _access;
        private readonly IMapper _mapper;
        private readonly ILogger<BloodBankController> _logger;

        public BloodBankController(IBloodRequestAccess access, IMapper mapper, ILogger<BloodBankController> logger)
        {
            _access = access;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BloodRequestReadDto>> GetBloods()
        {
            Console.WriteLine("-> Getting blood requests...");

            var bloodRequests = _access.GetAllBloodRequests();

            return Ok(_mapper.Map<IEnumerable<BloodRequestReadDto>>(bloodRequests));
        }

        [HttpGet("{id}", Name = "GetBloodRequestById")]
        public ActionResult<BloodRequestReadDto> GetBloodRequestById(int id)
        {
            var bloodRequest = _access.GetBloodRequestById(id);

            if (bloodRequest != null)
            {
                return Ok(_mapper.Map<BloodRequestReadDto>(bloodRequest));
            }

            return NotFound();
        }

        [HttpGet("{name}", Name = "GetBloodRequestsByRequestorName")]
        public ActionResult<IEnumerable<BloodRequestReadDto>> GetBloodRequestByRequestorName(String name)
        {
            var bloodRequests = _access.GetBloodRequestByRequestorName(name);

            if (bloodRequests != null)
            {
                return Ok(_mapper.Map<IEnumerable<BloodRequestReadDto>>(bloodRequests));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<BloodRequestReadDto> CreateDonor(BloodRequestCreateDto bloodRequestCreateDto)
        {
            var bloodRequestModel = _mapper.Map<BloodRequest>(bloodRequestCreateDto);
            _access.CreateBloodRequest(bloodRequestModel);

            var donorReadDto = _mapper.Map<BloodRequestReadDto>(bloodRequestModel);

            return CreatedAtRoute(nameof(GetBloodRequestById), new { Id = donorReadDto.Id }, donorReadDto);
        }
    }
}
