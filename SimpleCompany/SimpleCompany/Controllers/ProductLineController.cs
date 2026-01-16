using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Context.Services;

namespace SimpleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductLineController : ControllerBase
    {
        private ProductLineServices _productLineServices;

        public ProductLineController(ProductLineServices productLineServices)
        {
            _productLineServices = productLineServices;
        }

        [HttpGet]
        public IActionResult GetProductLines()
        {
            return Ok(_productLineServices.GetProductLines());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductLine(string id)
        {
            return Ok(_productLineServices.GetProductLine(id));
        }
    }
}
