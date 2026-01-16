using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Context.Services;

namespace SimpleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private PaymentServices _paymentServices;

        public PaymentController(PaymentServices paymentServices)
        {
            _paymentServices = paymentServices;
        }

        [HttpGet]
        public IActionResult GetPayments()
        {
            return Ok(_paymentServices.GetPayments());
        }

        [HttpGet("{id}")]
        public IActionResult GetPayment(int id)
        {
            return Ok(_paymentServices.GetPayment(id));
        }
    }
}
