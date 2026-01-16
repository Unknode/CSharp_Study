using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Context.Services;

namespace SimpleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private OfficeServices _officeServices;

        public OfficeController(OfficeServices officeServices)
        {
            _officeServices = officeServices;
        }

        [HttpGet]
        public IActionResult GetOffices()
        {
            return Ok(_officeServices.GetOffices());
        }

        [HttpGet("{id}")]
        public IActionResult GetOffice(string id)
        {
            return Ok(_officeServices.GetOffice(id));
        }
    }
}
