using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Context.Services;

namespace SimpleCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerServices _service;

        public CustomerController(CustomerServices service) { _service = service; }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            return Ok(_service.GetCustomer(id));
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_service.GetCustomers());
        }
    }
}
