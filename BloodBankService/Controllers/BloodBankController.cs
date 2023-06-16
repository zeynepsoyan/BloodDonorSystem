using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/v1/b/[controller]")]
    public class BloodBankController : ControllerBase
    {
        public BloodBankController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("-> Inbound POST # BloodBank Service");

            return Ok("Inbound test from BloodBank Service");
        }
    }
}
