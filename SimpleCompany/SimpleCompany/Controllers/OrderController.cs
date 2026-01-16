using Microsoft.AspNetCore.Mvc;
using SimpleCompany.Context.Services;

namespace SimpleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderServices _orderServices;

        public OrderController(OrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderServices.GetOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            return Ok(_orderServices.GetOrder(id));
        }
    }
}
