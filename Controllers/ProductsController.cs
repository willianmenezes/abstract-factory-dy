using AbstractFactory.Clients;
using AbstractFactory.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("foods")]
        public IActionResult SearchFood([FromQuery] TypeProduct type)
        {
            var productClient = ProductClient.CreateProductClient(type);

            var foods = productClient.SearchFood();

            if (foods.Count == 0)
            {
                return BadRequest();
            }

            return Ok(foods);
        }

        [HttpGet("packings")]
        public IActionResult SearchPacking([FromQuery] TypeProduct type)
        {
            var productClient = ProductClient.CreateProductClient(type);

            var packing = productClient.SearchPacking();

            if (packing.Count == 0)
            {
                return BadRequest();
            }

            return Ok(packing);
        }
    }
}
