using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/v1/b/[controller]")]
    public class BloodRequestController : ControllerBase
    {
        public BloodRequestController() { }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("-> Inbound POST # BloodBank Service");
            
            return Ok("Inbound test from BloodBank Service");
        }
    }
}
