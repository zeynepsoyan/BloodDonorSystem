using Microsoft.AspNetCore.Mvc;

namespace DonorsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonorsController : ControllerBase
    {
        private readonly ILogger<DonorsController> _logger;

        public DonorsController(ILogger<DonorsController> logger)
        {
            _logger = logger;
        }

    }
}