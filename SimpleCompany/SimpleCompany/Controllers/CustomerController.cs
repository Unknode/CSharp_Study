using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Services;

namespace SimpleCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerServices _service;

        public CustomerController(CustomerServices service) { _service = service; }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_service.GetCustomers());
        }
    }
}
