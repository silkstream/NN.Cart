using Microsoft.AspNetCore.Mvc;
using NN.Cart.services.interfaces;

namespace NN.Cart.Controllers
{
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
            _seedService.SeedProducts();

            return Ok();
        }

        [HttpGet("GetProducts/{Id}")]
        public IActionResult GetProducts(string Id)
        {

            var res =  _seedService.GetProducts();
            return Ok();
        }
    }
}
