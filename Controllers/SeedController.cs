using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using NN.Cart.services.interfaces;

namespace NN.Cart.Controllers
{
    [Authorize]
    [RequiredScope("access_as_user")]
    [ApiController]
    [Route("[controller]")]
    public class SeedController : ControllerBase
    {
        private readonly ISeedService _seedService;
        public SeedController(ISeedService seedService)
        {
            _seedService = seedService;
        }
        [HttpGet("SeedProducts")]

        
        public IActionResult SeedProducts()
        {

            //_seedService.SeedProducts();
            return Ok("Access");
        }

        [HttpGet("GetProducts/{Id}")]
        public IActionResult GetProducts(string Id)
        {

            var res =  _seedService.GetProducts();
            return Ok();
        }
    }
}
